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
	/// <summary>
	/// 
	/// </summary>
	public partial class MainForm : Form
	{


		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//this.Controls.OfType<UserControl>();
		}

		/**Sidebar**/


		private void btnHome_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnHome.Height;
			pnlBotaoSelecionado.Top = btnHome.Top;
			//pnlHome.BringToFront();
		}

		private void btnAlunos_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnAlunos.Height;
			pnlBotaoSelecionado.Top = btnAlunos.Top;
			//pnlAlunos.BringToFront();
		}

		private void btnVisitantes_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnVisitantes.Height;
			pnlBotaoSelecionado.Top = btnVisitantes.Top;
			//pnlVisitantes.BringToFront();
		}

		private void btnFinanceiro_Click(object sender, EventArgs e)
		{
			pnlBotaoSelecionado.Height = btnFinanceiro.Height;
			pnlBotaoSelecionado.Top = btnFinanceiro.Top;
			//pnlFinanceiro.BringToFront();
		}


	}
}
