namespace Academia
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.SidebarTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.pnlBotaoSelecionado = new System.Windows.Forms.Panel();
			this.btnFinanceiro = new System.Windows.Forms.Button();
			this.btnVisitantes = new System.Windows.Forms.Button();
			this.btnAlunos = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ucVisitantes1 = new Academia.UCVisitantes();
			this.MainTablePanel.SuspendLayout();
			this.pnlMain.SuspendLayout();
			this.SidebarTablePanel.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SideBarPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTablePanel
			// 
			this.MainTablePanel.ColumnCount = 2;
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.MainTablePanel.Controls.Add(this.pnlMain, 1, 0);
			this.MainTablePanel.Controls.Add(this.SidebarTablePanel, 0, 0);
			this.MainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTablePanel.Location = new System.Drawing.Point(0, 0);
			this.MainTablePanel.Margin = new System.Windows.Forms.Padding(0);
			this.MainTablePanel.Name = "MainTablePanel";
			this.MainTablePanel.RowCount = 1;
			this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTablePanel.Size = new System.Drawing.Size(1262, 673);
			this.MainTablePanel.TabIndex = 0;
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.AutoSize = true;
			this.pnlMain.BackColor = System.Drawing.Color.White;
			this.pnlMain.Controls.Add(this.ucVisitantes1);
			this.pnlMain.Location = new System.Drawing.Point(189, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1073, 673);
			this.pnlMain.TabIndex = 2;
			// 
			// SidebarTablePanel
			// 
			this.SidebarTablePanel.BackColor = System.Drawing.Color.Black;
			this.SidebarTablePanel.ColumnCount = 1;
			this.SidebarTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SidebarTablePanel.Controls.Add(this.pnlLogo, 0, 0);
			this.SidebarTablePanel.Controls.Add(this.SideBarPanel, 0, 1);
			this.SidebarTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SidebarTablePanel.Location = new System.Drawing.Point(0, 0);
			this.SidebarTablePanel.Margin = new System.Windows.Forms.Padding(0);
			this.SidebarTablePanel.Name = "SidebarTablePanel";
			this.SidebarTablePanel.RowCount = 2;
			this.SidebarTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.SidebarTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.SidebarTablePanel.Size = new System.Drawing.Size(189, 673);
			this.SidebarTablePanel.TabIndex = 1;
			// 
			// pnlLogo
			// 
			this.pnlLogo.AutoScroll = true;
			this.pnlLogo.BackColor = System.Drawing.Color.Black;
			this.pnlLogo.Controls.Add(this.pictureBox1);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(189, 100);
			this.pnlLogo.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Academia.Properties.Resources.LogoTaoFit;
			this.pictureBox1.Location = new System.Drawing.Point(38, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(114, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// SideBarPanel
			// 
			this.SideBarPanel.Controls.Add(this.pnlBotaoSelecionado);
			this.SideBarPanel.Controls.Add(this.btnFinanceiro);
			this.SideBarPanel.Controls.Add(this.btnVisitantes);
			this.SideBarPanel.Controls.Add(this.btnAlunos);
			this.SideBarPanel.Controls.Add(this.btnHome);
			this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SideBarPanel.Location = new System.Drawing.Point(0, 100);
			this.SideBarPanel.Margin = new System.Windows.Forms.Padding(0);
			this.SideBarPanel.Name = "SideBarPanel";
			this.SideBarPanel.Size = new System.Drawing.Size(189, 573);
			this.SideBarPanel.TabIndex = 1;
			// 
			// pnlBotaoSelecionado
			// 
			this.pnlBotaoSelecionado.BackColor = System.Drawing.Color.Maroon;
			this.pnlBotaoSelecionado.Location = new System.Drawing.Point(22, 33);
			this.pnlBotaoSelecionado.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBotaoSelecionado.Name = "pnlBotaoSelecionado";
			this.pnlBotaoSelecionado.Size = new System.Drawing.Size(13, 43);
			this.pnlBotaoSelecionado.TabIndex = 4;
			// 
			// btnFinanceiro
			// 
			this.btnFinanceiro.BackColor = System.Drawing.Color.DimGray;
			this.btnFinanceiro.FlatAppearance.BorderSize = 0;
			this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinanceiro.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnFinanceiro.Location = new System.Drawing.Point(35, 246);
			this.btnFinanceiro.Margin = new System.Windows.Forms.Padding(0);
			this.btnFinanceiro.Name = "btnFinanceiro";
			this.btnFinanceiro.Size = new System.Drawing.Size(154, 43);
			this.btnFinanceiro.TabIndex = 3;
			this.btnFinanceiro.Text = "Financeiro";
			this.btnFinanceiro.UseVisualStyleBackColor = false;
			this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
			// 
			// btnVisitantes
			// 
			this.btnVisitantes.BackColor = System.Drawing.Color.DimGray;
			this.btnVisitantes.FlatAppearance.BorderSize = 0;
			this.btnVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVisitantes.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnVisitantes.Location = new System.Drawing.Point(35, 175);
			this.btnVisitantes.Margin = new System.Windows.Forms.Padding(0);
			this.btnVisitantes.Name = "btnVisitantes";
			this.btnVisitantes.Size = new System.Drawing.Size(154, 43);
			this.btnVisitantes.TabIndex = 2;
			this.btnVisitantes.Text = "Visitantes";
			this.btnVisitantes.UseVisualStyleBackColor = false;
			this.btnVisitantes.Click += new System.EventHandler(this.btnVisitantes_Click);
			// 
			// btnAlunos
			// 
			this.btnAlunos.BackColor = System.Drawing.Color.DimGray;
			this.btnAlunos.FlatAppearance.BorderSize = 0;
			this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlunos.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAlunos.Location = new System.Drawing.Point(35, 104);
			this.btnAlunos.Margin = new System.Windows.Forms.Padding(0);
			this.btnAlunos.Name = "btnAlunos";
			this.btnAlunos.Size = new System.Drawing.Size(154, 43);
			this.btnAlunos.TabIndex = 1;
			this.btnAlunos.Text = "Alunos";
			this.btnAlunos.UseVisualStyleBackColor = false;
			this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.DimGray;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnHome.Location = new System.Drawing.Point(35, 33);
			this.btnHome.Margin = new System.Windows.Forms.Padding(0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(154, 43);
			this.btnHome.TabIndex = 0;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// visitanteBindingSource
			// 
			this.visitanteBindingSource.DataSource = typeof(Academia.Model.Visitante);
			// 
			// ucVisitantes1
			// 
			this.ucVisitantes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ucVisitantes1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ucVisitantes1.Location = new System.Drawing.Point(0, 0);
			this.ucVisitantes1.Margin = new System.Windows.Forms.Padding(0);
			this.ucVisitantes1.Name = "ucVisitantes1";
			this.ucVisitantes1.Size = new System.Drawing.Size(1072, 673);
			this.ucVisitantes1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.MainTablePanel);
			this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "MainForm";
			this.Text = "Taofit";
			this.MainTablePanel.ResumeLayout(false);
			this.MainTablePanel.PerformLayout();
			this.pnlMain.ResumeLayout(false);
			this.SidebarTablePanel.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.SideBarPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTablePanel;
		private System.Windows.Forms.TableLayoutPanel SidebarTablePanel;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel SideBarPanel;
		private System.Windows.Forms.Panel pnlBotaoSelecionado;
		private System.Windows.Forms.Button btnFinanceiro;
		private System.Windows.Forms.Button btnVisitantes;
		private System.Windows.Forms.Button btnAlunos;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.BindingSource visitanteBindingSource;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private UCVisitantes ucVisitantes1;
	}
}