using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Control;
using Academia.Model;

namespace Academia
{
	public partial class MainForm : Form
	{
		private ControleVisitante _controleVisitante;
		private Visitante _visitanteAtual;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (_controleVisitante == null)
			{
				_controleVisitante = new ControleVisitante();
			}

			dgvVisitantes.DataSource = _controleVisitante.Visitantes;
		}


		/**Sidebar**/


		private void btnHome_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnHome.Height;
			pnlBotaoSelecionado.Top = btnHome.Top;
			pnlHome.BringToFront();
		}

		private void btnAlunos_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnAlunos.Height;
			pnlBotaoSelecionado.Top = btnAlunos.Top;
			pnlAlunos.BringToFront();
		}

		private void btnVisitantes_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnVisitantes.Height;
			pnlBotaoSelecionado.Top = btnVisitantes.Top;
			pnlVisitantes.BringToFront();
		}

		private void btnFinanceiro_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnFinanceiro.Height;
			pnlBotaoSelecionado.Top = btnFinanceiro.Top;
			pnlFinanceiro.BringToFront();
		}



		//Visitantes

		private void btnSalvarNovoVisitante_Click(object sender, EventArgs e)
		{
			try
			{
				_controleVisitante.AdicionarNovoVisitante(txtNomeVisitante.Text, dtpVisitante.Value, dtpProximoContatoVisitante.Value,txtEmailVisitante.Text,
				txtTelefoneVisitante1.Text, txtTelefoneVisitante2.Text, rtbInformacoesVisitante.Text);
				LimparFormularioVisitante();
				AtualizarDataGridVisitantes();
				
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show(exception.Message, "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}


		private void AtualizarDataGridVisitantes()
		{
			dgvVisitantes.DataSource = _controleVisitante.Visitantes;

			var index = dgvVisitantes.Rows.Count - 1;

			dgvVisitantes.ClearSelection();
			dgvVisitantes.FirstDisplayedScrollingRowIndex = index;
			dgvVisitantes.CurrentCell = dgvVisitantes.Rows[index].Cells[1];

			_visitanteAtual = _controleVisitante.Visitantes[index];

			PreencheFormularioVisitante(index);
		}

		private void btnDeletarVisitante_Click(object sender, EventArgs e)
		{
			try
			{
				_controleVisitante.DeletarVisitante(_visitanteAtual);
				LimparFormularioVisitante();
				AtualizarDataGridVisitantes();
			}
			catch (ArgumentNullException exception)
			{
				MessageBox.Show(exception.Message, "Nenhum Visitante Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

			_visitanteAtual = null;
		}

		private void btnNovoVisitante_Click(object sender, EventArgs e)
		{
			LimparFormularioVisitante();
			txtNomeVisitante.Focus();
		}

		private void DataGridVisitantes_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			PreencheFormularioVisitante(e.RowIndex);
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
	}
}
