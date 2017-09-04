namespace LES_17_I_M {
    partial class frmConsFolha {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsFolha));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvcbo = new System.Windows.Forms.DataGridView();
            this.CBOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvdepto = new System.Windows.Forms.DataGridView();
            this.DEPCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.FUNCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNSALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDTNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCELU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCEL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNNUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPNOMEFUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOMEFUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORNOMEFUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvfuncao = new System.Windows.Forms.DataGridView();
            this.FUCCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOMEFUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.HORCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORMANE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORMANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORTARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORTARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONOMEHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvtipohorario = new System.Windows.Forms.DataGridView();
            this.THOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvcbo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cbo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvcbo
            // 
            this.dgvcbo.AllowUserToAddRows = false;
            this.dgvcbo.AllowUserToDeleteRows = false;
            this.dgvcbo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvcbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBOCODI,
            this.CBONOME});
            this.dgvcbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcbo.Location = new System.Drawing.Point(3, 3);
            this.dgvcbo.Name = "dgvcbo";
            this.dgvcbo.ReadOnly = true;
            this.dgvcbo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcbo.Size = new System.Drawing.Size(720, 426);
            this.dgvcbo.TabIndex = 0;
            this.dgvcbo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcbo_CellContentClick);
            // 
            // CBOCODI
            // 
            this.CBOCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CBOCODI.DataPropertyName = "CBOCODI";
            this.CBOCODI.HeaderText = "Código";
            this.CBOCODI.Name = "CBOCODI";
            this.CBOCODI.ReadOnly = true;
            this.CBOCODI.Width = 76;
            // 
            // CBONOME
            // 
            this.CBONOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CBONOME.DataPropertyName = "CBONOME";
            this.CBONOME.HeaderText = "Nome";
            this.CBONOME.Name = "CBONOME";
            this.CBONOME.ReadOnly = true;
            this.CBONOME.Width = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvdepto);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdepto
            // 
            this.dgvdepto.AllowUserToAddRows = false;
            this.dgvdepto.AllowUserToDeleteRows = false;
            this.dgvdepto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvdepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEPCODI,
            this.DEPNOME});
            this.dgvdepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdepto.Location = new System.Drawing.Point(3, 3);
            this.dgvdepto.Name = "dgvdepto";
            this.dgvdepto.ReadOnly = true;
            this.dgvdepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdepto.Size = new System.Drawing.Size(720, 426);
            this.dgvdepto.TabIndex = 0;
            // 
            // DEPCODI
            // 
            this.DEPCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DEPCODI.DataPropertyName = "DEPCODI";
            this.DEPCODI.HeaderText = "Código";
            this.DEPCODI.Name = "DEPCODI";
            this.DEPCODI.ReadOnly = true;
            this.DEPCODI.Width = 76;
            // 
            // DEPNOME
            // 
            this.DEPNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DEPNOME.DataPropertyName = "DEPNOME";
            this.DEPNOME.HeaderText = "Nome";
            this.DEPNOME.Name = "DEPNOME";
            this.DEPNOME.ReadOnly = true;
            this.DEPNOME.Width = 69;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvfuncionario);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(726, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Funcionario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.AllowUserToAddRows = false;
            this.dgvfuncionario.AllowUserToDeleteRows = false;
            this.dgvfuncionario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUNCODI,
            this.FUNNOME,
            this.FUNSALA,
            this.FUNDTNA,
            this.FUNCPF,
            this.FUNRG,
            this.FUNFONE,
            this.FUNCELU,
            this.FUNCEL1,
            this.FUNNUME,
            this.ENDENDE,
            this.DEPNOMEFUN,
            this.FUCNOMEFUN,
            this.HORNOMEFUN});
            this.dgvfuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfuncionario.Location = new System.Drawing.Point(3, 3);
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.ReadOnly = true;
            this.dgvfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncionario.Size = new System.Drawing.Size(720, 426);
            this.dgvfuncionario.TabIndex = 0;
            // 
            // FUNCODI
            // 
            this.FUNCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNCODI.DataPropertyName = "FUNCODI";
            this.FUNCODI.HeaderText = "Código";
            this.FUNCODI.Name = "FUNCODI";
            this.FUNCODI.ReadOnly = true;
            this.FUNCODI.Width = 76;
            // 
            // FUNNOME
            // 
            this.FUNNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNNOME.DataPropertyName = "FUNNOME";
            this.FUNNOME.HeaderText = "Nome";
            this.FUNNOME.Name = "FUNNOME";
            this.FUNNOME.ReadOnly = true;
            this.FUNNOME.Width = 69;
            // 
            // FUNSALA
            // 
            this.FUNSALA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNSALA.DataPropertyName = "FUNSALA";
            this.FUNSALA.HeaderText = "Salário";
            this.FUNSALA.Name = "FUNSALA";
            this.FUNSALA.ReadOnly = true;
            this.FUNSALA.Width = 73;
            // 
            // FUNDTNA
            // 
            this.FUNDTNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNDTNA.DataPropertyName = "FUNDTNA";
            this.FUNDTNA.HeaderText = "Data Nasc";
            this.FUNDTNA.Name = "FUNDTNA";
            this.FUNDTNA.ReadOnly = true;
            this.FUNDTNA.Width = 93;
            // 
            // FUNCPF
            // 
            this.FUNCPF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNCPF.DataPropertyName = "FUNCPF";
            this.FUNCPF.HeaderText = "CPF";
            this.FUNCPF.Name = "FUNCPF";
            this.FUNCPF.ReadOnly = true;
            this.FUNCPF.Width = 54;
            // 
            // FUNRG
            // 
            this.FUNRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNRG.DataPropertyName = "FUNRG";
            this.FUNRG.HeaderText = "RG";
            this.FUNRG.Name = "FUNRG";
            this.FUNRG.ReadOnly = true;
            this.FUNRG.Width = 50;
            // 
            // FUNFONE
            // 
            this.FUNFONE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNFONE.DataPropertyName = "FUNFONE";
            this.FUNFONE.HeaderText = "Telefone";
            this.FUNFONE.Name = "FUNFONE";
            this.FUNFONE.ReadOnly = true;
            this.FUNFONE.Width = 82;
            // 
            // FUNCELU
            // 
            this.FUNCELU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNCELU.DataPropertyName = "FUNCELU";
            this.FUNCELU.HeaderText = "Celular";
            this.FUNCELU.Name = "FUNCELU";
            this.FUNCELU.ReadOnly = true;
            this.FUNCELU.Width = 73;
            // 
            // FUNCEL1
            // 
            this.FUNCEL1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNCEL1.DataPropertyName = "FUNCEL1";
            this.FUNCEL1.HeaderText = "Celular 2";
            this.FUNCEL1.Name = "FUNCEL1";
            this.FUNCEL1.ReadOnly = true;
            this.FUNCEL1.Width = 84;
            // 
            // FUNNUME
            // 
            this.FUNNUME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNNUME.DataPropertyName = "FUNNUME";
            this.FUNNUME.HeaderText = "Numero";
            this.FUNNUME.Name = "FUNNUME";
            this.FUNNUME.ReadOnly = true;
            this.FUNNUME.Width = 81;
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
            // DEPNOMEFUN
            // 
            this.DEPNOMEFUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DEPNOMEFUN.DataPropertyName = "DEPNOME";
            this.DEPNOMEFUN.HeaderText = "Departamento";
            this.DEPNOMEFUN.Name = "DEPNOMEFUN";
            this.DEPNOMEFUN.ReadOnly = true;
            this.DEPNOMEFUN.Width = 117;
            // 
            // FUCNOMEFUN
            // 
            this.FUCNOMEFUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUCNOMEFUN.DataPropertyName = "FUCNOME";
            this.FUCNOMEFUN.HeaderText = "Função";
            this.FUCNOMEFUN.Name = "FUCNOMEFUN";
            this.FUCNOMEFUN.ReadOnly = true;
            this.FUCNOMEFUN.Width = 74;
            // 
            // HORNOMEFUN
            // 
            this.HORNOMEFUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORNOMEFUN.DataPropertyName = "HORNOME";
            this.HORNOMEFUN.HeaderText = "Horario";
            this.HORNOMEFUN.Name = "HORNOMEFUN";
            this.HORNOMEFUN.ReadOnly = true;
            this.HORNOMEFUN.Width = 78;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvfuncao);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Função";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvfuncao
            // 
            this.dgvfuncao.AllowUserToAddRows = false;
            this.dgvfuncao.AllowUserToDeleteRows = false;
            this.dgvfuncao.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvfuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUCCODI,
            this.FUCNOME,
            this.CBONOMEFUC});
            this.dgvfuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfuncao.Location = new System.Drawing.Point(3, 3);
            this.dgvfuncao.Name = "dgvfuncao";
            this.dgvfuncao.ReadOnly = true;
            this.dgvfuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncao.Size = new System.Drawing.Size(720, 426);
            this.dgvfuncao.TabIndex = 0;
            // 
            // FUCCODI
            // 
            this.FUCCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUCCODI.DataPropertyName = "FUCCODI";
            this.FUCCODI.HeaderText = "Código";
            this.FUCCODI.Name = "FUCCODI";
            this.FUCCODI.ReadOnly = true;
            this.FUCCODI.Width = 76;
            // 
            // FUCNOME
            // 
            this.FUCNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUCNOME.DataPropertyName = "FUCNOME";
            this.FUCNOME.HeaderText = "Nome";
            this.FUCNOME.Name = "FUCNOME";
            this.FUCNOME.ReadOnly = true;
            this.FUCNOME.Width = 69;
            // 
            // CBONOMEFUC
            // 
            this.CBONOMEFUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CBONOMEFUC.DataPropertyName = "CBONOME";
            this.CBONOMEFUC.HeaderText = "CBO";
            this.CBONOMEFUC.Name = "CBONOMEFUC";
            this.CBONOMEFUC.ReadOnly = true;
            this.CBONOMEFUC.Width = 58;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvhorario);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(726, 432);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Horario";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvhorario
            // 
            this.dgvhorario.AllowUserToAddRows = false;
            this.dgvhorario.AllowUserToDeleteRows = false;
            this.dgvhorario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORCODI,
            this.HORNOME,
            this.HORMANE,
            this.HORMANS,
            this.HORTARE,
            this.HORTARS,
            this.THONOMEHOR});
            this.dgvhorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhorario.Location = new System.Drawing.Point(3, 3);
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.ReadOnly = true;
            this.dgvhorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorario.Size = new System.Drawing.Size(720, 426);
            this.dgvhorario.TabIndex = 0;
            // 
            // HORCODI
            // 
            this.HORCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORCODI.DataPropertyName = "HORCODI";
            this.HORCODI.HeaderText = "Código";
            this.HORCODI.Name = "HORCODI";
            this.HORCODI.ReadOnly = true;
            this.HORCODI.Width = 76;
            // 
            // HORNOME
            // 
            this.HORNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORNOME.DataPropertyName = "HORNOME";
            this.HORNOME.HeaderText = "Nome";
            this.HORNOME.Name = "HORNOME";
            this.HORNOME.ReadOnly = true;
            this.HORNOME.Width = 69;
            // 
            // HORMANE
            // 
            this.HORMANE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORMANE.DataPropertyName = "HORMANE";
            this.HORMANE.HeaderText = "Entrada Manhã";
            this.HORMANE.Name = "HORMANE";
            this.HORMANE.ReadOnly = true;
            this.HORMANE.Width = 122;
            // 
            // HORMANS
            // 
            this.HORMANS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORMANS.DataPropertyName = "HORMANS";
            this.HORMANS.HeaderText = "Saida Manhã";
            this.HORMANS.Name = "HORMANS";
            this.HORMANS.ReadOnly = true;
            this.HORMANS.Width = 109;
            // 
            // HORTARE
            // 
            this.HORTARE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORTARE.DataPropertyName = "HORTARE";
            this.HORTARE.HeaderText = "Entrada Tarde";
            this.HORTARE.Name = "HORTARE";
            this.HORTARE.ReadOnly = true;
            this.HORTARE.Width = 115;
            // 
            // HORTARS
            // 
            this.HORTARS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORTARS.DataPropertyName = "HORTARS";
            this.HORTARS.HeaderText = "Saida Tarde";
            this.HORTARS.Name = "HORTARS";
            this.HORTARS.ReadOnly = true;
            this.HORTARS.Width = 102;
            // 
            // THONOMEHOR
            // 
            this.THONOMEHOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.THONOMEHOR.DataPropertyName = "THONOME";
            this.THONOMEHOR.HeaderText = "Tipo Horario";
            this.THONOMEHOR.Name = "THONOMEHOR";
            this.THONOMEHOR.ReadOnly = true;
            this.THONOMEHOR.Width = 108;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvtipohorario);
            this.tabPage6.Location = new System.Drawing.Point(4, 26);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(726, 432);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Tipo Horario";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvtipohorario
            // 
            this.dgvtipohorario.AllowUserToAddRows = false;
            this.dgvtipohorario.AllowUserToDeleteRows = false;
            this.dgvtipohorario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvtipohorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipohorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.THOCODI,
            this.THONOME});
            this.dgvtipohorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtipohorario.Location = new System.Drawing.Point(3, 3);
            this.dgvtipohorario.Name = "dgvtipohorario";
            this.dgvtipohorario.ReadOnly = true;
            this.dgvtipohorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipohorario.Size = new System.Drawing.Size(720, 426);
            this.dgvtipohorario.TabIndex = 0;
            // 
            // THOCODI
            // 
            this.THOCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.THOCODI.DataPropertyName = "THOCODI";
            this.THOCODI.HeaderText = "Código";
            this.THOCODI.Name = "THOCODI";
            this.THOCODI.ReadOnly = true;
            this.THOCODI.Width = 76;
            // 
            // THONOME
            // 
            this.THONOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.THONOME.DataPropertyName = "THONOME";
            this.THONOME.HeaderText = "Nome";
            this.THONOME.Name = "THONOME";
            this.THONOME.ReadOnly = true;
            this.THONOME.Width = 69;
            // 
            // frmConsFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsFolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Folha de Pgto";
            this.Load += new System.EventHandler(this.frmConsFolha_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsFolha_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvcbo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOME;
        private System.Windows.Forms.DataGridView dgvdepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPNOME;
        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNSALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDTNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCELU;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCEL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNNUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDENDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPNOMEFUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOMEFUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORNOMEFUN;
        private System.Windows.Forms.DataGridView dgvfuncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOMEFUC;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORMANE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORMANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORTARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORTARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONOMEHOR;
        private System.Windows.Forms.DataGridView dgvtipohorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONOME;
    }
}