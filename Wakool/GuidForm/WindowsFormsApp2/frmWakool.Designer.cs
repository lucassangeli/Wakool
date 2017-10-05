namespace WinFormsApp
{
    partial class frmWakool
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWakool));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlBottonLeftBar = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCadastrarConsultar = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMinButton = new System.Windows.Forms.Panel();
            this.pnlCloseButton = new System.Windows.Forms.Panel();
            this.pnlSaidaProduto = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlVendaClienteNome = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgMotar = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLeftBar.SuspendLayout();
            this.pnlBottonLeftBar.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlSaidaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.Black;
            this.pnlLeftBar.Controls.Add(this.statusStrip1);
            this.pnlLeftBar.Controls.Add(this.panelMenu);
            this.pnlLeftBar.Controls.Add(this.pnlBottonLeftBar);
            this.pnlLeftBar.Controls.Add(this.panel3);
            this.pnlLeftBar.Controls.Add(this.lblCadastrarConsultar);
            this.pnlLeftBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 42);
            this.pnlLeftBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftBar.MinimumSize = new System.Drawing.Size(80, 20);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(274, 468);
            this.pnlLeftBar.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(274, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Location = new System.Drawing.Point(8, 38);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(260, 369);
            this.panelMenu.TabIndex = 23;
            // 
            // pnlBottonLeftBar
            // 
            this.pnlBottonLeftBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottonLeftBar.Controls.Add(this.lblDateTime);
            this.pnlBottonLeftBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottonLeftBar.Location = new System.Drawing.Point(0, 411);
            this.pnlBottonLeftBar.Name = "pnlBottonLeftBar";
            this.pnlBottonLeftBar.Size = new System.Drawing.Size(274, 43);
            this.pnlBottonLeftBar.TabIndex = 20;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(-30, 17);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateTime.MinimumSize = new System.Drawing.Size(298, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(298, 19);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "<hora>";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 454);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 14);
            this.panel3.TabIndex = 22;
            // 
            // lblCadastrarConsultar
            // 
            this.lblCadastrarConsultar.AutoSize = true;
            this.lblCadastrarConsultar.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastrarConsultar.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCadastrarConsultar.Location = new System.Drawing.Point(12, 2);
            this.lblCadastrarConsultar.Name = "lblCadastrarConsultar";
            this.lblCadastrarConsultar.Size = new System.Drawing.Size(52, 24);
            this.lblCadastrarConsultar.TabIndex = 2;
            this.lblCadastrarConsultar.Text = "Menu";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Black;
            this.pnlTopBar.Controls.Add(this.panel2);
            this.pnlTopBar.Controls.Add(this.pnlMinButton);
            this.pnlTopBar.Controls.Add(this.pnlCloseButton);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1248, 42);
            this.pnlTopBar.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 33);
            this.panel2.TabIndex = 133;
            // 
            // pnlMinButton
            // 
            this.pnlMinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMinButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlMinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMinButton.BackgroundImage")));
            this.pnlMinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMinButton.Location = new System.Drawing.Point(1180, 7);
            this.pnlMinButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMinButton.Name = "pnlMinButton";
            this.pnlMinButton.Size = new System.Drawing.Size(26, 26);
            this.pnlMinButton.TabIndex = 1;
            this.pnlMinButton.Click += new System.EventHandler(this.pnlMinButton_Click);
            // 
            // pnlCloseButton
            // 
            this.pnlCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlCloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCloseButton.BackgroundImage")));
            this.pnlCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCloseButton.Location = new System.Drawing.Point(1213, 7);
            this.pnlCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCloseButton.Name = "pnlCloseButton";
            this.pnlCloseButton.Size = new System.Drawing.Size(26, 26);
            this.pnlCloseButton.TabIndex = 2;
            this.pnlCloseButton.Click += new System.EventHandler(this.pnlCloseButton_Click);
            // 
            // pnlSaidaProduto
            // 
            this.pnlSaidaProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSaidaProduto.BackgroundImage")));
            this.pnlSaidaProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSaidaProduto.Controls.Add(this.splitContainer1);
            this.pnlSaidaProduto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSaidaProduto.Location = new System.Drawing.Point(274, 42);
            this.pnlSaidaProduto.Name = "pnlSaidaProduto";
            this.pnlSaidaProduto.Size = new System.Drawing.Size(974, 468);
            this.pnlSaidaProduto.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.pnlVendaClienteNome);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.lbTitulo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(974, 468);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 138;
            this.splitContainer1.Visible = false;
            // 
            // pnlVendaClienteNome
            // 
            this.pnlVendaClienteNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlVendaClienteNome.Location = new System.Drawing.Point(355, 9);
            this.pnlVendaClienteNome.MaximumSize = new System.Drawing.Size(500, 1);
            this.pnlVendaClienteNome.Name = "pnlVendaClienteNome";
            this.pnlVendaClienteNome.Size = new System.Drawing.Size(169, 1);
            this.pnlVendaClienteNome.TabIndex = 6;
            this.pnlVendaClienteNome.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(-2, 33);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelEdit);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer2.Size = new System.Drawing.Size(975, 246);
            this.splitContainer2.SplitterDistance = 192;
            this.splitContainer2.TabIndex = 143;
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.AutoScroll = true;
            this.panelEdit.AutoSize = true;
            this.panelEdit.BackColor = System.Drawing.Color.White;
            this.panelEdit.Location = new System.Drawing.Point(3, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(972, 186);
            this.panelEdit.TabIndex = 136;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(427, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 47);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.limpTela_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(283, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 47);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.sav_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(353, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 47);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.delet_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTitulo.Location = new System.Drawing.Point(4, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(109, 24);
            this.lbTitulo.TabIndex = 142;
            this.lbTitulo.Text = "Cadastro de  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.lbLista);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Location = new System.Drawing.Point(8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 65);
            this.panel1.TabIndex = 141;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPDF.BackgroundImage")));
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.ForeColor = System.Drawing.Color.Transparent;
            this.btnPDF.Location = new System.Drawing.Point(867, 14);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(74, 48);
            this.btnPDF.TabIndex = 136;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbLista.Location = new System.Drawing.Point(-4, 5);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(110, 24);
            this.lbLista.TabIndex = 127;
            this.lbLista.Text = "Listagem de  ";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcel.Location = new System.Drawing.Point(797, 14);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(64, 48);
            this.btnExcel.TabIndex = 135;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dtgMotar);
            this.panel4.Location = new System.Drawing.Point(3, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 121);
            this.panel4.TabIndex = 140;
            // 
            // dtgMotar
            // 
            this.dtgMotar.AllowUserToAddRows = false;
            this.dtgMotar.AllowUserToDeleteRows = false;
            this.dtgMotar.AllowUserToOrderColumns = true;
            this.dtgMotar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMotar.BackgroundColor = System.Drawing.Color.White;
            this.dtgMotar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMotar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgMotar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMotar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgMotar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgMotar.GridColor = System.Drawing.Color.Black;
            this.dtgMotar.Location = new System.Drawing.Point(5, 34);
            this.dtgMotar.Name = "dtgMotar";
            this.dtgMotar.ReadOnly = true;
            this.dtgMotar.RowHeadersVisible = false;
            this.dtgMotar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMotar.Size = new System.Drawing.Size(924, 75);
            this.dtgMotar.TabIndex = 140;
            this.dtgMotar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMotar_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmWakool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1248, 510);
            this.Controls.Add(this.pnlSaidaProduto);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWakool";
            this.Text = "Wakool.NET";
            this.Load += new System.EventHandler(this.frmWakool_Load);
            this.pnlLeftBar.ResumeLayout(false);
            this.pnlLeftBar.PerformLayout();
            this.pnlBottonLeftBar.ResumeLayout(false);
            this.pnlBottonLeftBar.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlSaidaProduto.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Panel pnlBottonLeftBar;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlMinButton;
        private System.Windows.Forms.Panel pnlCloseButton;
        private System.Windows.Forms.Panel pnlSaidaProduto;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCadastrarConsultar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lbLista;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgMotar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlVendaClienteNome;
    }
}

