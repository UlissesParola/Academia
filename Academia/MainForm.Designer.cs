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
			this.SidebarTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SideBarPanel = new System.Windows.Forms.Panel();
			this.pnlBotaoSelecionado = new System.Windows.Forms.Panel();
			this.btnFinanceiro = new System.Windows.Forms.Button();
			this.btnVisitantes = new System.Windows.Forms.Button();
			this.btnAlunos = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlVisitantes = new System.Windows.Forms.Panel();
			this.pnlAdicionarVisitante = new System.Windows.Forms.Panel();
			this.btnNovoVisitante = new System.Windows.Forms.Button();
			this.dgvVisitantes = new System.Windows.Forms.DataGridView();
			this.dtpProximoContatoVisitante = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.rtbInformacoesVisitante = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnCancelarNovoVisitante = new System.Windows.Forms.Button();
			this.btnSalvarNovoVisitante = new System.Windows.Forms.Button();
			this.txtTelefoneVisitante2 = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefoneVisitante1 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmailVisitante = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpVisitante = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.pnlHome = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pnlFinanceiro = new System.Windows.Forms.Panel();
			this.pnlAlunos = new System.Windows.Forms.Panel();
			this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProximoContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MainTablePanel.SuspendLayout();
			this.SidebarTablePanel.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SideBarPanel.SuspendLayout();
			this.pnlMain.SuspendLayout();
			this.pnlVisitantes.SuspendLayout();
			this.pnlAdicionarVisitante.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
			this.pnlHome.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// MainTablePanel
			// 
			this.MainTablePanel.ColumnCount = 2;
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.MainTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.MainTablePanel.Controls.Add(this.SidebarTablePanel, 0, 0);
			this.MainTablePanel.Controls.Add(this.pnlMain, 1, 0);
			this.MainTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTablePanel.Location = new System.Drawing.Point(0, 0);
			this.MainTablePanel.Margin = new System.Windows.Forms.Padding(0);
			this.MainTablePanel.Name = "MainTablePanel";
			this.MainTablePanel.RowCount = 1;
			this.MainTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTablePanel.Size = new System.Drawing.Size(1262, 673);
			this.MainTablePanel.TabIndex = 0;
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
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.White;
			this.pnlMain.Controls.Add(this.pnlVisitantes);
			this.pnlMain.Controls.Add(this.pnlHome);
			this.pnlMain.Controls.Add(this.pnlFinanceiro);
			this.pnlMain.Controls.Add(this.pnlAlunos);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(189, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1073, 673);
			this.pnlMain.TabIndex = 2;
			// 
			// pnlVisitantes
			// 
			this.pnlVisitantes.BackColor = System.Drawing.Color.White;
			this.pnlVisitantes.Controls.Add(this.pnlAdicionarVisitante);
			this.pnlVisitantes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlVisitantes.Location = new System.Drawing.Point(0, 0);
			this.pnlVisitantes.Margin = new System.Windows.Forms.Padding(0);
			this.pnlVisitantes.Name = "pnlVisitantes";
			this.pnlVisitantes.Size = new System.Drawing.Size(1073, 673);
			this.pnlVisitantes.TabIndex = 2;
			// 
			// pnlAdicionarVisitante
			// 
			this.pnlAdicionarVisitante.BackColor = System.Drawing.Color.White;
			this.pnlAdicionarVisitante.Controls.Add(this.btnNovoVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.dgvVisitantes);
			this.pnlAdicionarVisitante.Controls.Add(this.dtpProximoContatoVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.label10);
			this.pnlAdicionarVisitante.Controls.Add(this.rtbInformacoesVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.label9);
			this.pnlAdicionarVisitante.Controls.Add(this.btnCancelarNovoVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.btnSalvarNovoVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.txtTelefoneVisitante2);
			this.pnlAdicionarVisitante.Controls.Add(this.txtTelefoneVisitante1);
			this.pnlAdicionarVisitante.Controls.Add(this.label5);
			this.pnlAdicionarVisitante.Controls.Add(this.label4);
			this.pnlAdicionarVisitante.Controls.Add(this.txtEmailVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.label3);
			this.pnlAdicionarVisitante.Controls.Add(this.dtpVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.label2);
			this.pnlAdicionarVisitante.Controls.Add(this.label1);
			this.pnlAdicionarVisitante.Controls.Add(this.txtNomeVisitante);
			this.pnlAdicionarVisitante.Controls.Add(this.lblNome);
			this.pnlAdicionarVisitante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAdicionarVisitante.Location = new System.Drawing.Point(0, 0);
			this.pnlAdicionarVisitante.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAdicionarVisitante.Name = "pnlAdicionarVisitante";
			this.pnlAdicionarVisitante.Size = new System.Drawing.Size(1073, 673);
			this.pnlAdicionarVisitante.TabIndex = 1;
			// 
			// btnNovoVisitante
			// 
			this.btnNovoVisitante.BackColor = System.Drawing.Color.White;
			this.btnNovoVisitante.FlatAppearance.BorderSize = 0;
			this.btnNovoVisitante.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnNovoVisitante.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNovoVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovoVisitante.Image = global::Academia.Properties.Resources.icons8_Plus_48px;
			this.btnNovoVisitante.Location = new System.Drawing.Point(807, 580);
			this.btnNovoVisitante.Margin = new System.Windows.Forms.Padding(0);
			this.btnNovoVisitante.Name = "btnNovoVisitante";
			this.btnNovoVisitante.Size = new System.Drawing.Size(60, 60);
			this.btnNovoVisitante.TabIndex = 23;
			this.btnNovoVisitante.UseVisualStyleBackColor = false;
			this.btnNovoVisitante.Click += new System.EventHandler(this.btnNovoVisitante_Click);
			// 
			// dgvVisitantes
			// 
			this.dgvVisitantes.AllowUserToOrderColumns = true;
			this.dgvVisitantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVisitantes.AutoGenerateColumns = false;
			this.dgvVisitantes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvVisitantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataVisitaDataGridViewTextBoxColumn,
            this.ProximoContato,
            this.contatoDataGridViewTextBoxColumn});
			this.dgvVisitantes.DataSource = this.visitanteBindingSource;
			this.dgvVisitantes.Location = new System.Drawing.Point(36, 133);
			this.dgvVisitantes.MultiSelect = false;
			this.dgvVisitantes.Name = "dgvVisitantes";
			this.dgvVisitantes.ReadOnly = true;
			this.dgvVisitantes.RowTemplate.Height = 24;
			this.dgvVisitantes.Size = new System.Drawing.Size(550, 444);
			this.dgvVisitantes.TabIndex = 19;
			this.dgvVisitantes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVisitantes_RowEnter);
			// 
			// dtpProximoContatoVisitante
			// 
			this.dtpProximoContatoVisitante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpProximoContatoVisitante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpProximoContatoVisitante.Location = new System.Drawing.Point(820, 358);
			this.dtpProximoContatoVisitante.Name = "dtpProximoContatoVisitante";
			this.dtpProximoContatoVisitante.Size = new System.Drawing.Size(147, 30);
			this.dtpProximoContatoVisitante.TabIndex = 15;
			this.dtpProximoContatoVisitante.Value = new System.DateTime(2018, 12, 23, 12, 31, 55, 0);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(637, 362);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(177, 22);
			this.label10.TabIndex = 20;
			this.label10.Text = "Falar de novo em:";
			// 
			// rtbInformacoesVisitante
			// 
			this.rtbInformacoesVisitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbInformacoesVisitante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbInformacoesVisitante.Location = new System.Drawing.Point(641, 450);
			this.rtbInformacoesVisitante.Name = "rtbInformacoesVisitante";
			this.rtbInformacoesVisitante.Size = new System.Drawing.Size(393, 127);
			this.rtbInformacoesVisitante.TabIndex = 16;
			this.rtbInformacoesVisitante.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(637, 406);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(129, 22);
			this.label9.TabIndex = 18;
			this.label9.Text = "Informações:";
			// 
			// btnCancelarNovoVisitante
			// 
			this.btnCancelarNovoVisitante.BackColor = System.Drawing.Color.White;
			this.btnCancelarNovoVisitante.FlatAppearance.BorderSize = 0;
			this.btnCancelarNovoVisitante.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnCancelarNovoVisitante.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelarNovoVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarNovoVisitante.Image = global::Academia.Properties.Resources.icons8_Delete_48px;
			this.btnCancelarNovoVisitante.Location = new System.Drawing.Point(971, 580);
			this.btnCancelarNovoVisitante.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancelarNovoVisitante.Name = "btnCancelarNovoVisitante";
			this.btnCancelarNovoVisitante.Size = new System.Drawing.Size(60, 60);
			this.btnCancelarNovoVisitante.TabIndex = 18;
			this.btnCancelarNovoVisitante.UseVisualStyleBackColor = false;
			this.btnCancelarNovoVisitante.Click += new System.EventHandler(this.btnDeletarVisitante_Click);
			// 
			// btnSalvarNovoVisitante
			// 
			this.btnSalvarNovoVisitante.BackColor = System.Drawing.Color.White;
			this.btnSalvarNovoVisitante.FlatAppearance.BorderSize = 0;
			this.btnSalvarNovoVisitante.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnSalvarNovoVisitante.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvarNovoVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvarNovoVisitante.Image = global::Academia.Properties.Resources.icons8_Checkmark_48px;
			this.btnSalvarNovoVisitante.Location = new System.Drawing.Point(889, 580);
			this.btnSalvarNovoVisitante.Margin = new System.Windows.Forms.Padding(0);
			this.btnSalvarNovoVisitante.Name = "btnSalvarNovoVisitante";
			this.btnSalvarNovoVisitante.Size = new System.Drawing.Size(60, 60);
			this.btnSalvarNovoVisitante.TabIndex = 17;
			this.btnSalvarNovoVisitante.UseVisualStyleBackColor = false;
			this.btnSalvarNovoVisitante.Click += new System.EventHandler(this.btnSalvarVisitante_Click);
			// 
			// txtTelefoneVisitante2
			// 
			this.txtTelefoneVisitante2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtTelefoneVisitante2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefoneVisitante2.Location = new System.Drawing.Point(740, 313);
			this.txtTelefoneVisitante2.Mask = "(99) 00000-0000";
			this.txtTelefoneVisitante2.Name = "txtTelefoneVisitante2";
			this.txtTelefoneVisitante2.Size = new System.Drawing.Size(181, 30);
			this.txtTelefoneVisitante2.TabIndex = 14;
			this.txtTelefoneVisitante2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtTelefoneVisitante1
			// 
			this.txtTelefoneVisitante1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.txtTelefoneVisitante1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefoneVisitante1.Location = new System.Drawing.Point(740, 268);
			this.txtTelefoneVisitante1.Mask = "(99) 00000-0000";
			this.txtTelefoneVisitante1.Name = "txtTelefoneVisitante1";
			this.txtTelefoneVisitante1.Size = new System.Drawing.Size(181, 30);
			this.txtTelefoneVisitante1.TabIndex = 13;
			this.txtTelefoneVisitante1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(637, 317);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "Telefone:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(637, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "Telefone:";
			// 
			// txtEmailVisitante
			// 
			this.txtEmailVisitante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmailVisitante.Location = new System.Drawing.Point(740, 223);
			this.txtEmailVisitante.Name = "txtEmailVisitante";
			this.txtEmailVisitante.Size = new System.Drawing.Size(294, 30);
			this.txtEmailVisitante.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(637, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 22);
			this.label3.TabIndex = 7;
			this.label3.Text = "Email:";
			// 
			// dtpVisitante
			// 
			this.dtpVisitante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVisitante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpVisitante.Location = new System.Drawing.Point(789, 178);
			this.dtpVisitante.Name = "dtpVisitante";
			this.dtpVisitante.Size = new System.Drawing.Size(147, 30);
			this.dtpVisitante.TabIndex = 6;
			this.dtpVisitante.Value = new System.DateTime(2018, 12, 23, 0, 0, 0, 0);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(637, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Data da Visita:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(417, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 58);
			this.label1.TabIndex = 4;
			this.label1.Text = "Visitantes";
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitante.Location = new System.Drawing.Point(740, 133);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(294, 30);
			this.txtNomeVisitante.TabIndex = 3;
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(637, 137);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(70, 22);
			this.lblNome.TabIndex = 2;
			this.lblNome.Text = "Nome:";
			// 
			// pnlHome
			// 
			this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
			this.pnlHome.Controls.Add(this.label8);
			this.pnlHome.Controls.Add(this.label7);
			this.pnlHome.Controls.Add(this.label6);
			this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHome.Location = new System.Drawing.Point(0, 0);
			this.pnlHome.Name = "pnlHome";
			this.pnlHome.Size = new System.Drawing.Size(1073, 673);
			this.pnlHome.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(419, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(209, 58);
			this.label8.TabIndex = 2;
			this.label8.Text = "Resumo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(71, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(269, 22);
			this.label7.TabIndex = 1;
			this.label7.Text = "Alunos Matriculados no mês:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(66, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(138, 22);
			this.label6.TabIndex = 0;
			this.label6.Text = "Alunos Ativos:";
			// 
			// pnlFinanceiro
			// 
			this.pnlFinanceiro.BackColor = System.Drawing.Color.NavajoWhite;
			this.pnlFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFinanceiro.Location = new System.Drawing.Point(0, 0);
			this.pnlFinanceiro.Margin = new System.Windows.Forms.Padding(0);
			this.pnlFinanceiro.Name = "pnlFinanceiro";
			this.pnlFinanceiro.Size = new System.Drawing.Size(1073, 673);
			this.pnlFinanceiro.TabIndex = 3;
			// 
			// pnlAlunos
			// 
			this.pnlAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAlunos.Location = new System.Drawing.Point(0, 0);
			this.pnlAlunos.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAlunos.Name = "pnlAlunos";
			this.pnlAlunos.Size = new System.Drawing.Size(1073, 673);
			this.pnlAlunos.TabIndex = 1;
			// 
			// visitanteBindingSource
			// 
			this.visitanteBindingSource.DataSource = typeof(Academia.Model.Visitante);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataVisitaDataGridViewTextBoxColumn
			// 
			this.dataVisitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataVisitaDataGridViewTextBoxColumn.DataPropertyName = "DataVisita";
			this.dataVisitaDataGridViewTextBoxColumn.HeaderText = "Data Visita";
			this.dataVisitaDataGridViewTextBoxColumn.Name = "dataVisitaDataGridViewTextBoxColumn";
			this.dataVisitaDataGridViewTextBoxColumn.ReadOnly = true;
			this.dataVisitaDataGridViewTextBoxColumn.Width = 139;
			// 
			// ProximoContato
			// 
			this.ProximoContato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.ProximoContato.DataPropertyName = "ProximoContato";
			this.ProximoContato.HeaderText = "Proximo Contato";
			this.ProximoContato.Name = "ProximoContato";
			this.ProximoContato.ReadOnly = true;
			this.ProximoContato.Width = 24;
			// 
			// contatoDataGridViewTextBoxColumn
			// 
			this.contatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
			this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
			this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
			this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
			this.contatoDataGridViewTextBoxColumn.Visible = false;
			this.contatoDataGridViewTextBoxColumn.Width = 117;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.MainTablePanel);
			this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "MainForm";
			this.Text = "Taofit";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainTablePanel.ResumeLayout(false);
			this.SidebarTablePanel.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.SideBarPanel.ResumeLayout(false);
			this.pnlMain.ResumeLayout(false);
			this.pnlVisitantes.ResumeLayout(false);
			this.pnlAdicionarVisitante.ResumeLayout(false);
			this.pnlAdicionarVisitante.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
			this.pnlHome.ResumeLayout(false);
			this.pnlHome.PerformLayout();
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
		private System.Windows.Forms.Panel pnlHome;
		private System.Windows.Forms.Panel pnlVisitantes;
		private System.Windows.Forms.Panel pnlFinanceiro;
		private System.Windows.Forms.Panel pnlAlunos;
		private System.Windows.Forms.BindingSource visitanteBindingSource;
		private System.Windows.Forms.Panel pnlAdicionarVisitante;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.DateTimePicker dtpVisitante;
		private System.Windows.Forms.MaskedTextBox txtTelefoneVisitante2;
		private System.Windows.Forms.MaskedTextBox txtTelefoneVisitante1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmailVisitante;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalvarNovoVisitante;
		private System.Windows.Forms.Button btnCancelarNovoVisitante;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox rtbInformacoesVisitante;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtpProximoContatoVisitante;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dgvVisitantes;
		private System.Windows.Forms.Button btnNovoVisitante;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataVisitaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProximoContato;
		private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
	}
}