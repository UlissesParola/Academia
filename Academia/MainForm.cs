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
		private ControleVisitante controleVisitante;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (controleVisitante == null)
			{
				controleVisitante = new ControleVisitante();
			}

			dgvVisitantes.DataSource = controleVisitante.Visitantes;
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
				controleVisitante.AdicionarNovoVisitante(txtNomeVisitante.Text, dtpVisitante.Value, dtpProximoContatoVisitante.Value,txtEmailVisitante.Text,
				txtTelefoneVisitante1.Text, txtTelefoneVisitante2.Text, rtbInformacoesVisitante.Text);

				AtualizarDataGridVisitantes();
				LimparFormularioVisitante();
			}
			catch (ArgumentException exception)
			{
				MessageBox.Show(exception.Message, "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}


		private void AtualizarDataGridVisitantes()
		{
			dgvVisitantes.DataSource = controleVisitante.Visitantes;

			var index = dgvVisitantes.Rows.Count - 1;

			dgvVisitantes.FirstDisplayedScrollingRowIndex = index;
			dgvVisitantes.Rows[index].Selected = true;
		}

		private void btnCancelarNovoVisitante_Click(object sender, EventArgs e)
		{
			LimparFormularioVisitante();
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
		}

		private void btnNovoVisitante_Click(object sender, EventArgs e)
		{
			LimparFormularioVisitante();
			txtNomeVisitante.Focus();
		}

		private void DataGridVisitantes_RowEnter(object sender, DataGridViewCellEventArgs e)
		{

			//int rowIndex = e.RowIndex;
			Visitante visitante = controleVisitante.Visitantes[e.RowIndex];

			txtNomeVisitante.Text = visitante.Nome;
			dtpVisitante.Value = visitante.DataVisita;
			dtpProximoContatoVisitante.Value = visitante.ProximoContato;
			rtbInformacoesVisitante.Text = "";

			if (visitante.Contato == null)
			{
				txtEmailVisitante.Text = "";
				txtTelefoneVisitante1.Text = "";
				txtTelefoneVisitante2.Text = "";
			}
			else
			{
				txtEmailVisitante.Text = visitante.Contato.Email;
				txtTelefoneVisitante1.Text = visitante.Contato.Telefone1;
				txtTelefoneVisitante2.Text = visitante.Contato.Telefone2;
			}
				
		
		}
	}
}
