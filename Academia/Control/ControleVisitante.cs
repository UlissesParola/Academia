using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Model;
using Microsoft.EntityFrameworkCore;

namespace Academia.Control
{
	class ControleVisitante
	{
		public List<Visitante> Visitantes { get; set; }

		public ControleVisitante()
		{
			AtualizarListaVisitantes();
		}

		public void AdicionarNovoVisitante(String nome, DateTime dataVisita, DateTime proximoContato, String email, String telefone1, String telefone2, String informacoes)
		{
			if (!String.IsNullOrEmpty(nome) && (!String.IsNullOrEmpty(email) ||
				!String.IsNullOrEmpty(telefone1) || !String.IsNullOrEmpty(telefone2)))
			{
				Visitante novoVisitante = new Visitante();
				Contato novoContato = new Contato();

				novoVisitante.Nome = nome;
				novoVisitante.DataVisita = dataVisita;
				novoVisitante.ProximoContato = proximoContato;
				novoContato.Email = email;
				novoContato.Telefone1 = telefone1;
				novoContato.Telefone2 = telefone2;
				novoVisitante.Contato = novoContato;
				novoVisitante.Informacoes = informacoes;

				using (AcademiaDbContext context = new AcademiaDbContext())
				{
					context.Visitantes.Add(novoVisitante);
					context.SaveChanges();
					AtualizarListaVisitantes();
				}
			}
			else
			{
				throw (new ArgumentException("Nome ou Contato em branco"));
			}
			
		}

		public void AtualizarVisitante(int Id, String nome, DateTime dataVisita, DateTime proximoContato, String email, String telefone1, String telefone2, String informacoes)
		{
			if (!String.IsNullOrEmpty(nome) && (!String.IsNullOrEmpty(email) ||
				!String.IsNullOrEmpty(telefone1) || !String.IsNullOrEmpty(telefone2)))
			{
				using (AcademiaDbContext context = new AcademiaDbContext())
				{
					Visitante visitanteParaSerAtualizado = context.Visitantes.Include("Contato").Where(v => v.Id == Id).First();
					visitanteParaSerAtualizado.Nome = nome;
					visitanteParaSerAtualizado.DataVisita = dataVisita;
					visitanteParaSerAtualizado.ProximoContato = proximoContato;
					visitanteParaSerAtualizado.Contato.Email = email;
					visitanteParaSerAtualizado.Contato.Telefone1 = telefone1;
					visitanteParaSerAtualizado.Contato.Telefone2 = telefone2;
					visitanteParaSerAtualizado.Informacoes = informacoes;
					context.SaveChanges();
					AtualizarListaVisitantes();
				}
			}
			else
			{
				throw (new ArgumentException("Nome ou Contato em branco"));
			}
		}

		public void DeletarVisitante(Visitante visitante)
		{
			using (AcademiaDbContext context = new AcademiaDbContext())
			{
				if (visitante != null)
				{
					Visitante visitanteParaSerDeletado = context.Visitantes.Include("Contato").Where(v => v.Id == visitante.Id).First();
					context.Contatos.Remove(visitanteParaSerDeletado.Contato);
					context.Visitantes.Remove(visitanteParaSerDeletado);
					context.SaveChanges();
					AtualizarListaVisitantes();
				}
				else
				{
					throw new ArgumentNullException("Nenhum visitante selecionado.");
				}
			}
		}

		public void AtualizarListaVisitantes()
		{
			using (AcademiaDbContext context = new AcademiaDbContext())
			{
				Visitantes = context.Visitantes.Include("Contato").OrderBy(v => v.DataVisita).ToList();
			}
		}

		public void PesquisaVisitantePorNome(string nome)
		{
			List<Visitante> ListaFiltrada = new List<Visitante>();
			if (String.IsNullOrEmpty(nome.Trim()))
			{
				AtualizarListaVisitantes();
			}
			else
			{

				foreach (var visitante in Visitantes)
				{
					if (visitante.Nome.ToLower().Contains(nome.ToLower()))
					{
						ListaFiltrada.Add(visitante);
					}
				}

				Visitantes = ListaFiltrada; ;
			}

		}	

		public void OrdenarVisitantesPorNome()
		{
			Visitantes = Visitantes.OrderBy(v => v.Nome).ToList();
		}

		public void OrdenarVisitantesPorDataDeVisita()
		{ 
			Visitantes = Visitantes.OrderBy(v => v.DataVisita).ToList();
		}

		public void OrdenarVisitantesPorDataProximoContato()
		{
			Visitantes = Visitantes.OrderBy(v => v.ProximoContato).ToList();
		}
	}
}
