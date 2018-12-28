using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Model;

namespace Academia.Control
{
	class ControleVisitante
	{
		public List<Visitante> Visitantes { get; set; }

		public ControleVisitante()
		{
			AtualizarVisitantes();
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
					Visitantes = context.Visitantes.ToList();
				}
			}
			else
			{
				throw (new ArgumentException("Nome ou Contato em branco"));
			}
			
		}

		public void DeletarVisitante(int Id)
		{
			using (AcademiaDbContext context = new AcademiaDbContext())
			{
				Visitante visitante = Visitantes[Id];
				context.Visitantes.Remove(visitante);
				context.SaveChanges();
				Visitantes = context.Visitantes.ToList();
			}
		}

		public void AtualizarVisitantes()
		{
			using (AcademiaDbContext context = new AcademiaDbContext())
			{
				Visitantes = context.Visitantes.Include("Contato").ToList();
			}
		}
	}
}
