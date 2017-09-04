namespace LES_17_I_M
{
    partial class frmcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcliente));
            this.tbcclientes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.CLICODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIFANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLILIMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIDTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLICNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIINES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIEMAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLICELU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLICEL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLINUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLISTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtclinume = new System.Windows.Forms.TextBox();
            this.cboendereco = new System.Windows.Forms.ComboBox();
            this.cboramo = new System.Windows.Forms.ComboBox();
            this.txtclistat = new System.Windows.Forms.TextBox();
            this.txtclicel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtclicelu = new System.Windows.Forms.MaskedTextBox();
            this.txtclifone = new System.Windows.Forms.MaskedTextBox();
            this.txtcliines = new System.Windows.Forms.TextBox();
            this.txtclicnpj = new System.Windows.Forms.TextBox();
            this.txtcliemai = new System.Windows.Forms.TextBox();
            this.txtclilimi = new System.Windows.Forms.TextBox();
            this.txtclidtin = new System.Windows.Forms.MaskedTextBox();
            this.txtcliapel = new System.Windows.Forms.TextBox();
            this.txtclifant = new System.Windows.Forms.TextBox();
            this.txtclinome = new System.Windows.Forms.TextBox();
            this.txtclicodi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcclientes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcclientes
            // 
            this.tbcclientes.Controls.Add(this.tabPage1);
            this.tbcclientes.Controls.Add(this.tabPage2);
            this.tbcclientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcclientes.Location = new System.Drawing.Point(0, 0);
            this.tbcclientes.Name = "tbcclientes";
            this.tbcclientes.SelectedIndex = 0;
            this.tbcclientes.Size = new System.Drawing.Size(584, 462);
            this.tbcclientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvclientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLICODI,
            this.CLINOME,
            this.CLIFANT,
            this.CLIAPEL,
            this.CLILIMI,
            this.CLIDTIN,
            this.CLICNPJ,
            this.CLIINES,
            this.CLIEMAI,
            this.CLIFONE,
            this.CLICELU,
            this.CLICEL1,
            this.CLINUME,
            this.CLISTAT,
            this.RAMNOME,
            this.ENDENDE});
            this.dgvclientes.Location = new System.Drawing.Point(8, 6);
            this.dgvclientes.MultiSelect = false;
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            this.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclientes.Size = new System.Drawing.Size(560, 418);
            this.dgvclientes.TabIndex = 0;
            this.dgvclientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellDoubleClick);
            // 
            // CLICODI
            // 
            this.CLICODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLICODI.DataPropertyName = "CLICODI";
            this.CLICODI.HeaderText = "Codigo";
            this.CLICODI.Name = "CLICODI";
            this.CLICODI.ReadOnly = true;
            this.CLICODI.Width = 76;
            // 
            // CLINOME
            // 
            this.CLINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLINOME.DataPropertyName = "CLINOME";
            this.CLINOME.HeaderText = "Nome";
            this.CLINOME.Name = "CLINOME";
            this.CLINOME.ReadOnly = true;
            this.CLINOME.Width = 69;
            // 
            // CLIFANT
            // 
            this.CLIFANT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIFANT.DataPropertyName = "CLIFANT";
            this.CLIFANT.HeaderText = "Fantasia";
            this.CLIFANT.Name = "CLIFANT";
            this.CLIFANT.ReadOnly = true;
            this.CLIFANT.Width = 80;
            // 
            // CLIAPEL
            // 
            this.CLIAPEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIAPEL.DataPropertyName = "CLIAPEL";
            this.CLIAPEL.HeaderText = "Apelido";
            this.CLIAPEL.Name = "CLIAPEL";
            this.CLIAPEL.ReadOnly = true;
            this.CLIAPEL.Width = 78;
            // 
            // CLILIMI
            // 
            this.CLILIMI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLILIMI.DataPropertyName = "CLILIMI";
            this.CLILIMI.HeaderText = "Limite";
            this.CLILIMI.Name = "CLILIMI";
            this.CLILIMI.ReadOnly = true;
            this.CLILIMI.Width = 67;
            // 
            // CLIDTIN
            // 
            this.CLIDTIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIDTIN.DataPropertyName = "CLIDTIN";
            this.CLIDTIN.HeaderText = "Primeira Compra";
            this.CLIDTIN.Name = "CLIDTIN";
            this.CLIDTIN.ReadOnly = true;
            this.CLIDTIN.Width = 121;
            // 
            // CLICNPJ
            // 
            this.CLICNPJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLICNPJ.DataPropertyName = "CLICNPJ";
            this.CLICNPJ.HeaderText = "CNPJ";
            this.CLICNPJ.Name = "CLICNPJ";
            this.CLICNPJ.ReadOnly = true;
            this.CLICNPJ.Width = 62;
            // 
            // CLIINES
            // 
            this.CLIINES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIINES.DataPropertyName = "CLIINES";
            this.CLIINES.HeaderText = "Inscrição Estadual";
            this.CLIINES.Name = "CLIINES";
            this.CLIINES.ReadOnly = true;
            this.CLIINES.Width = 125;
            // 
            // CLIEMAI
            // 
            this.CLIEMAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIEMAI.DataPropertyName = "CLIEMAI";
            this.CLIEMAI.HeaderText = "E-mail";
            this.CLIEMAI.Name = "CLIEMAI";
            this.CLIEMAI.ReadOnly = true;
            this.CLIEMAI.Width = 69;
            // 
            // CLIFONE
            // 
            this.CLIFONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLIFONE.DataPropertyName = "CLIFONE";
            this.CLIFONE.HeaderText = "Telefone";
            this.CLIFONE.Name = "CLIFONE";
            this.CLIFONE.ReadOnly = true;
            this.CLIFONE.Width = 82;
            // 
            // CLICELU
            // 
            this.CLICELU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLICELU.DataPropertyName = "CLICELU";
            this.CLICELU.HeaderText = "Celular";
            this.CLICELU.Name = "CLICELU";
            this.CLICELU.ReadOnly = true;
            this.CLICELU.Width = 73;
            // 
            // CLICEL1
            // 
            this.CLICEL1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLICEL1.DataPropertyName = "CLICEL1";
            this.CLICEL1.HeaderText = "Celular 2";
            this.CLICEL1.Name = "CLICEL1";
            this.CLICEL1.ReadOnly = true;
            this.CLICEL1.Width = 78;
            // 
            // CLINUME
            // 
            this.CLINUME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLINUME.DataPropertyName = "CLINUME";
            this.CLINUME.HeaderText = "Numero Casa";
            this.CLINUME.Name = "CLINUME";
            this.CLINUME.ReadOnly = true;
            this.CLINUME.Width = 104;
            // 
            // CLISTAT
            // 
            this.CLISTAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CLISTAT.DataPropertyName = "CLISTAT";
            this.CLISTAT.HeaderText = "Status";
            this.CLISTAT.Name = "CLISTAT";
            this.CLISTAT.ReadOnly = true;
            this.CLISTAT.Width = 68;
            // 
            // RAMNOME
            // 
            this.RAMNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAMNOME.DataPropertyName = "RAMNOME";
            this.RAMNOME.HeaderText = "Ramo";
            this.RAMNOME.Name = "RAMNOME";
            this.RAMNOME.ReadOnly = true;
            this.RAMNOME.Width = 67;
            // 
            // ENDENDE
            // 
            this.ENDENDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ENDENDE.DataPropertyName = "ENDENDE";
            this.ENDENDE.HeaderText = "Endereço";
            this.ENDENDE.Name = "ENDENDE";
            this.ENDENDE.ReadOnly = true;
            this.ENDENDE.Width = 88;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtclinume);
            this.tabPage2.Controls.Add(this.cboendereco);
            this.tabPage2.Controls.Add(this.cboramo);
            this.tabPage2.Controls.Add(this.txtclistat);
            this.tabPage2.Controls.Add(this.txtclicel1);
            this.tabPage2.Controls.Add(this.txtclicelu);
            this.tabPage2.Controls.Add(this.txtclifone);
            this.tabPage2.Controls.Add(this.txtcliines);
            this.tabPage2.Controls.Add(this.txtclicnpj);
            this.tabPage2.Controls.Add(this.txtcliemai);
            this.tabPage2.Controls.Add(this.txtclilimi);
            this.tabPage2.Controls.Add(this.txtclidtin);
            this.tabPage2.Controls.Add(this.txtcliapel);
            this.tabPage2.Controls.Add(this.txtclifant);
            this.tabPage2.Controls.Add(this.txtclinome);
            this.tabPage2.Controls.Add(this.txtclicodi);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(493, 403);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 35;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(348, 403);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 34;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(175, 403);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 33;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(20, 403);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 32;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtclinume
            // 
            this.txtclinume.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclinume.Location = new System.Drawing.Point(326, 365);
            this.txtclinume.Name = "txtclinume";
            this.txtclinume.Size = new System.Drawing.Size(100, 25);
            this.txtclinume.TabIndex = 31;
            // 
            // cboendereco
            // 
            this.cboendereco.FormattingEnabled = true;
            this.cboendereco.Location = new System.Drawing.Point(102, 365);
            this.cboendereco.Name = "cboendereco";
            this.cboendereco.Size = new System.Drawing.Size(152, 25);
            this.cboendereco.TabIndex = 30;
            // 
            // cboramo
            // 
            this.cboramo.FormattingEnabled = true;
            this.cboramo.Location = new System.Drawing.Point(97, 324);
            this.cboramo.Name = "cboramo";
            this.cboramo.Size = new System.Drawing.Size(157, 25);
            this.cboramo.TabIndex = 29;
            // 
            // txtclistat
            // 
            this.txtclistat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclistat.Location = new System.Drawing.Point(416, 286);
            this.txtclistat.Name = "txtclistat";
            this.txtclistat.Size = new System.Drawing.Size(100, 25);
            this.txtclistat.TabIndex = 28;
            // 
            // txtclicel1
            // 
            this.txtclicel1.Location = new System.Drawing.Point(258, 286);
            this.txtclicel1.Mask = "(00)90000-0000";
            this.txtclicel1.Name = "txtclicel1";
            this.txtclicel1.Size = new System.Drawing.Size(100, 25);
            this.txtclicel1.TabIndex = 27;
            // 
            // txtclicelu
            // 
            this.txtclicelu.Location = new System.Drawing.Point(258, 249);
            this.txtclicelu.Mask = "(00)90000-0000";
            this.txtclicelu.Name = "txtclicelu";
            this.txtclicelu.Size = new System.Drawing.Size(100, 25);
            this.txtclicelu.TabIndex = 26;
            // 
            // txtclifone
            // 
            this.txtclifone.Location = new System.Drawing.Point(97, 249);
            this.txtclifone.Mask = "(00)0000-0000";
            this.txtclifone.Name = "txtclifone";
            this.txtclifone.Size = new System.Drawing.Size(100, 25);
            this.txtclifone.TabIndex = 25;
            // 
            // txtcliines
            // 
            this.txtcliines.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliines.Location = new System.Drawing.Point(350, 214);
            this.txtcliines.Name = "txtcliines";
            this.txtcliines.Size = new System.Drawing.Size(88, 25);
            this.txtcliines.TabIndex = 24;
            // 
            // txtclicnpj
            // 
            this.txtclicnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclicnpj.Location = new System.Drawing.Point(89, 214);
            this.txtclicnpj.Name = "txtclicnpj";
            this.txtclicnpj.Size = new System.Drawing.Size(166, 25);
            this.txtclicnpj.TabIndex = 23;
            // 
            // txtcliemai
            // 
            this.txtcliemai.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtcliemai.Location = new System.Drawing.Point(90, 161);
            this.txtcliemai.Name = "txtcliemai";
            this.txtcliemai.Size = new System.Drawing.Size(478, 25);
            this.txtcliemai.TabIndex = 22;
            // 
            // txtclilimi
            // 
            this.txtclilimi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclilimi.Location = new System.Drawing.Point(318, 117);
            this.txtclilimi.Name = "txtclilimi";
            this.txtclilimi.Size = new System.Drawing.Size(120, 25);
            this.txtclilimi.TabIndex = 21;
            // 
            // txtclidtin
            // 
            this.txtclidtin.Location = new System.Drawing.Point(154, 117);
            this.txtclidtin.Mask = "00/00/0000";
            this.txtclidtin.Name = "txtclidtin";
            this.txtclidtin.Size = new System.Drawing.Size(100, 25);
            this.txtclidtin.TabIndex = 20;
            this.txtclidtin.ValidatingType = typeof(System.DateTime);
            // 
            // txtcliapel
            // 
            this.txtcliapel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliapel.Location = new System.Drawing.Point(322, 72);
            this.txtcliapel.Name = "txtcliapel";
            this.txtcliapel.Size = new System.Drawing.Size(246, 25);
            this.txtcliapel.TabIndex = 19;
            // 
            // txtclifant
            // 
            this.txtclifant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclifant.Location = new System.Drawing.Point(102, 72);
            this.txtclifant.Name = "txtclifant";
            this.txtclifant.Size = new System.Drawing.Size(153, 25);
            this.txtclifant.TabIndex = 18;
            // 
            // txtclinome
            // 
            this.txtclinome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclinome.Location = new System.Drawing.Point(258, 32);
            this.txtclinome.Name = "txtclinome";
            this.txtclinome.Size = new System.Drawing.Size(310, 25);
            this.txtclinome.TabIndex = 17;
            // 
            // txtclicodi
            // 
            this.txtclicodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclicodi.Location = new System.Drawing.Point(102, 32);
            this.txtclicodi.Name = "txtclicodi";
            this.txtclicodi.Size = new System.Drawing.Size(100, 25);
            this.txtclicodi.TabIndex = 16;
            this.txtclicodi.Leave += new System.EventHandler(this.txtclicodi_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(203, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Celular:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Apelido:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "CNPJ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fantasia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Primeira Compra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Limite:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Celular2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ramo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ins. Estadual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tbcclientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Clientes";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcliente_KeyDown);
            this.tbcclientes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcclientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclinume;
        private System.Windows.Forms.ComboBox cboendereco;
        private System.Windows.Forms.ComboBox cboramo;
        private System.Windows.Forms.TextBox txtclistat;
        private System.Windows.Forms.MaskedTextBox txtclicel1;
        private System.Windows.Forms.MaskedTextBox txtclicelu;
        private System.Windows.Forms.MaskedTextBox txtclifone;
        private System.Windows.Forms.TextBox txtcliines;
        private System.Windows.Forms.TextBox txtclicnpj;
        private System.Windows.Forms.TextBox txtcliemai;
        private System.Windows.Forms.TextBox txtclilimi;
        private System.Windows.Forms.MaskedTextBox txtclidtin;
        private System.Windows.Forms.TextBox txtcliapel;
        private System.Windows.Forms.TextBox txtclifant;
        private System.Windows.Forms.TextBox txtclinome;
        private System.Windows.Forms.TextBox txtclicodi;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLICODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIFANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIAPEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLILIMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIDTIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLICNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIINES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIEMAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLICELU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLICEL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLINUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLISTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDENDE;
    }
}