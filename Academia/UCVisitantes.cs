using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Control;
using Academia.Model;

namespace Academia
{
	public partial class UCVisitantes : UserControl
	{
		private ControleVisitante _controleVisitante;
		private Visitante _visitanteAtual;

		public UCVisitantes()
		{
			InitializeComponent();
			

		}

		private void UCVisitantes_Load(object sender, EventArgs e)
		{
			CriarListView();

			if (!DesignMode)
			{
				_controleVisitante = new ControleVisitante();
				PreencherListView(_controleVisitante.Visitantes);
			}

		}

		private void PreencherListView(List<Visitante> lista)
		{
			lvwVisitantes.Items.Clear();
			for (int i = 0; i < lista.Count; i++)
			{
				string[] linha = new string[3];
				linha[0] = lista[i].Nome;
				linha[1] = lista[i].DataVisita.ToShortDateString();
				linha[2] = lista[i].ProximoContato.ToShortDateString();

				ListViewItem item = new ListViewItem(linha);
				
				// setando a font do item para que não seja em negrito. 
				item.Font = new Font(lvwVisitantes.Columns[0].ListView.Font, FontStyle.Regular);

				lvwVisitantes.Items.Add(item);
			}
		}

		private void CriarListView()
		{
			lvwVisitantes.View = View.Details;
			lvwVisitantes.GridLines = true;
			lvwVisitantes.FullRowSelect = true;

			ColumnHeader cabecalhoNome = new ColumnHeader();
			cabecalhoNome.Name = "Nome";
			cabecalhoNome.Text = "NOME";
			cabecalhoNome.TextAlign = HorizontalAlignment.Center;
			cabecalhoNome.Width = 265;

			ColumnHeader cabecalhoDataVisita = new ColumnHeader();
			cabecalhoDataVisita.Name = "DataVisita";
			cabecalhoDataVisita.Text = "VISITA";
			cabecalhoDataVisita.TextAlign = HorizontalAlignment.Center;
			cabecalhoDataVisita.Width = 140;

			ColumnHeader cabecalhoProximoContato = new ColumnHeader();
			cabecalhoProximoContato.Name = "ProximoContato";
			cabecalhoProximoContato.Text = "CONTATO";
			cabecalhoProximoContato.TextAlign = HorizontalAlignment.Center;
			cabecalhoProximoContato.Width = 140;

			lvwVisitantes.Columns.Add(cabecalhoNome);
			lvwVisitantes.Columns.Add(cabecalhoDataVisita);
			lvwVisitantes.Columns.Add(cabecalhoProximoContato);

			// colocando a fonte do listview em negrito
			lvwVisitantes.Columns[0].ListView.Font = new Font(lvwVisitantes.Columns[0].ListView.Font, FontStyle.Bold);
			lvwVisitantes.Columns[1].ListView.Font = new Font(lvwVisitantes.Columns[1].ListView.Font, FontStyle.Bold);
			lvwVisitantes.Columns[2].ListView.Font = new Font(lvwVisitantes.Columns[2].ListView.Font, FontStyle.Bold);

		}

		private void PreencheFormularioVisitante(int index)
		{
			_visitanteAtual = _controleVisitante.Visitantes[index];

			txtNomeVisitante.Text = _visitanteAtual.Nome;
			dtpVisitante.Value = _visitanteAtual.DataVisita;
			dtpProximoContatoVisitante.Value = _visitanteAtual.ProximoContato;
			rtbInformacoesVisitante.Text = _visitanteAtual.Informacoes;

			txtEmailVisitante.Text = _visitanteAtual.Contato.Email;
			txtTelefoneVisitante1.Text = _visitanteAtual.Contato.Telefone1;
			txtTelefoneVisitante2.Text = _visitanteAtual.Contato.Telefone2;
		}

		private void lvwVisitantes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvwVisitantes.SelectedIndices.Count > 0)
			{
				PreencheFormularioVisitante(lvwVisitantes.SelectedIndices[0]);
			}
			
		}

		private void LimparFormularioVisitante()
		{
			txtNomeVisitante.Text = "";
			dtpVisitante.Value = DateTime.Today;
			txtEmailVisitante.Text = "";
			txtTelefoneVisitante1.Text = "";
			txtTelefoneVisitante2.Text = "";
			dtpProximoContatoVisitante.Value = DateTime.Today.AddMonths(1);
			rtbInformacoesVisitante.Text = "";

			txtPesquisarVisitantePorNome.Text = "";

			_visitanteAtual = null;
		}

		private void btnNovoVisitante_Click(object sender, EventArgs e)
		{
			_visitanteAtual = null;
			LimparFormularioVisitante();
			txtNomeVisitante.Focus();
		}

		private void btnCancelarNovoVisitante_Click(object sender, EventArgs e)
		{
			if (_visitanteAtual != null)
			{
				String pergunta = "Tem certeza de que quer deletar " + _visitanteAtual.Nome + "? Ele não poderá ser recuperado depois.";

				DialogResult dialogResult = MessageBox.Show(pergunta, "Deletar Visitante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

				if (dialogResult == DialogResult.Yes)
				{
					try
					{
						_controleVisitante.DeletarVisitante(_visitanteAtual);
						LimparFormularioVisitante();
						PreencherListView(_controleVisitante.Visitantes);
					}
					catch (ArgumentNullException exception)
					{
						MessageBox.Show(exception.Message, "Nenhum Visitante Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnSalvarNovoVisitante_Click(object sender, EventArgs e)
		{
			try
			{
				if (_visitanteAtual == null)
				{
					_controleVisitante.AdicionarNovoVisitante(txtNomeVisitante.Text, dtpVisitante.Value, dtpProximoContatoVisitante.Value, txtEmailVisitante.Text,
					txtTelefoneVisitante1.Text, txtTelefoneVisitante2.Text, rtbInformacoesVisitante.Text);
					PreencherListView(_controleVisitante.Visitantes);
					SelecionarUltimoVisitante();

				}
				else
				{
					String pergunta = "Tem certeza de que quer mudar as informações de " + _visitanteAtual.Nome + "?";

					DialogResult dialogResult = MessageBox.Show(pergunta, "Atualizar Visitante", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (dialogResult == DialogResult.Yes)
					{
						_controleVisitante.AtualizarVisitante(_visitanteAtual.Id, txtNomeVisitante.Text, dtpVisitante.Value, dtpProximoContatoVisitante.Value, txtEmailVisitante.Text,
						txtTelefoneVisitante1.Text, txtTelefoneVisitante2.Text, rtbInformacoesVisitante.Text);
						PreencherListView(_controleVisitante.Visitantes);
					}

				}
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show(exception.Message, "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void SelecionarUltimoVisitante()
		{
			int index = lvwVisitantes.Items.Count - 1;

			if (index > (_controleVisitante.Visitantes.Count -1))
			{
				throw new IndexOutOfRangeException("Visitante não existe na lista");
			}

			lvwVisitantes.Items[index].Selected = true;
			_visitanteAtual = _controleVisitante.Visitantes[index];

			PreencheFormularioVisitante(index);
		}

		private void lvwVisitantes_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			String coluna = lvwVisitantes.Columns[e.Column].Name;
			switch (coluna)
			{
				case "Nome":
					_controleVisitante.OrdenarVisitantesPorNome();
					break;
				case "DataVisita":
					_controleVisitante.OrdenarVisitantesPorDataDeVisita();
					break;
				case "ProximoContato":
					_controleVisitante.OrdenarVisitantesPorDataProximoContato();
					break;
				default:
					_controleVisitante.OrdenarVisitantesPorDataProximoContato();
					break;
			}

			PreencherListView(_controleVisitante.Visitantes);
		}

		private void txtPesquisarVisitantePorNome_TextChanged(object sender, EventArgs e)
		{
			_controleVisitante.PesquisaVisitantePorNome(txtPesquisarVisitantePorNome.Text);
			PreencherListView(_controleVisitante.Visitantes);
		}
	}
}
