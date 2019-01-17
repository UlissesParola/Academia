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
			_controleVisitante = new ControleVisitante();

		}

		private void UCVisitantes_Load(object sender, EventArgs e)
		{
			CriarListView();

			PreencherListView(_controleVisitante.Visitantes);
		}

		private void PreencherListView(List<Visitante> lista)
		{
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

				//listView1.View = View.Details;
				//listView1.GridLines = true;
				//listView1.FullRowSelect = true;
				////Add column header
				//listView1.Columns.Add("ProductName", 100);
				//listView1.Columns.Add("Price", 70);
				//listView1.Columns.Add("Quantity", 70);

				////Add items in the listview
				//string[] arr = new string[4];
				//ListViewItem itm;
				////Add first item
				//arr[0] = "product_1";
				//arr[1] = "100";
				//arr[2] = "10";
				//itm = new ListViewItem(arr);
				//listView1.Items.Add(itm);

				////Add second item
				//arr[0] = "product_2";
				//arr[1] = "200";
				//arr[2] = "20";
				//itm = new ListViewItem(arr);
				//listView1.Items.Add(itm);
			}
		}

		private void CriarListView()
		{

			ColumnHeader cabecalhoNome = new ColumnHeader();
			cabecalhoNome.Text = "NOME";
			cabecalhoNome.TextAlign = HorizontalAlignment.Center;
			cabecalhoNome.Width = 265;

			ColumnHeader cabecalhoDataVisita = new ColumnHeader();
			cabecalhoDataVisita.Text = "VISITA";
			cabecalhoDataVisita.TextAlign = HorizontalAlignment.Center;
			cabecalhoDataVisita.Width = 140;

			ColumnHeader cabecalhoProximoContato = new ColumnHeader();
			cabecalhoProximoContato.Text = "CONTATO";
			cabecalhoProximoContato.TextAlign = HorizontalAlignment.Center;
			cabecalhoProximoContato.Width = 140;

			lvwVisitantes.Columns.Add(cabecalhoNome);
			lvwVisitantes.Columns.Add(cabecalhoDataVisita);
			lvwVisitantes.Columns.Add(cabecalhoProximoContato);

			lvwVisitantes.Columns[0].ListView.Font = new Font(lvwVisitantes.Columns[0].ListView.Font, FontStyle.Bold);
			lvwVisitantes.Columns[1].ListView.Font = new Font(lvwVisitantes.Columns[1].ListView.Font, FontStyle.Bold);
			lvwVisitantes.Columns[2].ListView.Font = new Font(lvwVisitantes.Columns[2].ListView.Font, FontStyle.Bold);

		}
	}
}
