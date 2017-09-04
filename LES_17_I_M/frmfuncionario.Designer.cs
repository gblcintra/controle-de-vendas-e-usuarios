namespace LES_17_I_M
{
    partial class frmfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionario));
            this.tbcFuncionario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.DEPNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbohorario = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbofuncao = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbodepto = new System.Windows.Forms.ComboBox();
            this.txtfunsala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbocep = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfunnume = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtfuncel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtfuncelu = new System.Windows.Forms.MaskedTextBox();
            this.txtfunfone = new System.Windows.Forms.MaskedTextBox();
            this.txtfunrg = new System.Windows.Forms.TextBox();
            this.txtfuncpf = new System.Windows.Forms.TextBox();
            this.txtfundtna = new System.Windows.Forms.MaskedTextBox();
            this.txtfunnome = new System.Windows.Forms.TextBox();
            this.txtfuncodi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcFuncionario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcFuncionario
            // 
            this.tbcFuncionario.Controls.Add(this.tabPage1);
            this.tbcFuncionario.Controls.Add(this.tabPage2);
            this.tbcFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcFuncionario.Location = new System.Drawing.Point(0, 0);
            this.tbcFuncionario.Name = "tbcFuncionario";
            this.tbcFuncionario.SelectedIndex = 0;
            this.tbcFuncionario.Size = new System.Drawing.Size(584, 512);
            this.tbcFuncionario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfuncionario);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.AllowUserToAddRows = false;
            this.dgvfuncionario.AllowUserToDeleteRows = false;
            this.dgvfuncionario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.DEPNOME,
            this.FUCNOME,
            this.HORNOME});
            this.dgvfuncionario.Location = new System.Drawing.Point(6, 6);
            this.dgvfuncionario.MultiSelect = false;
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.ReadOnly = true;
            this.dgvfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncionario.Size = new System.Drawing.Size(562, 468);
            this.dgvfuncionario.TabIndex = 0;
            this.dgvfuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionario_CellDoubleClick);
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
            this.FUNDTNA.HeaderText = "Dt Nascimento";
            this.FUNDTNA.Name = "FUNDTNA";
            this.FUNDTNA.ReadOnly = true;
            this.FUNDTNA.Width = 119;
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
            this.FUNNUME.HeaderText = "Nº Funcionario";
            this.FUNNUME.Name = "FUNNUME";
            this.FUNNUME.ReadOnly = true;
            this.FUNNUME.Width = 120;
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
            // DEPNOME
            // 
            this.DEPNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DEPNOME.DataPropertyName = "DEPNOME";
            this.DEPNOME.HeaderText = "Departamento";
            this.DEPNOME.Name = "DEPNOME";
            this.DEPNOME.ReadOnly = true;
            this.DEPNOME.Width = 117;
            // 
            // FUCNOME
            // 
            this.FUCNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUCNOME.DataPropertyName = "FUCNOME";
            this.FUCNOME.HeaderText = "Função";
            this.FUCNOME.Name = "FUCNOME";
            this.FUCNOME.ReadOnly = true;
            this.FUCNOME.Width = 74;
            // 
            // HORNOME
            // 
            this.HORNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORNOME.DataPropertyName = "HORNOME";
            this.HORNOME.HeaderText = "Horario";
            this.HORNOME.Name = "HORNOME";
            this.HORNOME.ReadOnly = true;
            this.HORNOME.Width = 78;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtfuncel1);
            this.tabPage2.Controls.Add(this.txtfuncelu);
            this.tabPage2.Controls.Add(this.txtfunfone);
            this.tabPage2.Controls.Add(this.txtfunrg);
            this.tabPage2.Controls.Add(this.txtfuncpf);
            this.tabPage2.Controls.Add(this.txtfundtna);
            this.tabPage2.Controls.Add(this.txtfunnome);
            this.tabPage2.Controls.Add(this.txtfuncodi);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbohorario);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cbofuncao);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbodepto);
            this.groupBox2.Controls.Add(this.txtfunsala);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 149);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro Empresa";
            // 
            // cbohorario
            // 
            this.cbohorario.FormattingEnabled = true;
            this.cbohorario.Location = new System.Drawing.Point(110, 83);
            this.cbohorario.MaxDropDownItems = 100;
            this.cbohorario.Name = "cbohorario";
            this.cbohorario.Size = new System.Drawing.Size(159, 25);
            this.cbohorario.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 17);
            this.label18.TabIndex = 26;
            this.label18.Text = "Horario:";
            // 
            // cbofuncao
            // 
            this.cbofuncao.FormattingEnabled = true;
            this.cbofuncao.Location = new System.Drawing.Point(110, 50);
            this.cbofuncao.MaxDropDownItems = 100;
            this.cbofuncao.Name = "cbofuncao";
            this.cbofuncao.Size = new System.Drawing.Size(248, 25);
            this.cbofuncao.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Função:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Departamento:";
            // 
            // cbodepto
            // 
            this.cbodepto.FormattingEnabled = true;
            this.cbodepto.Location = new System.Drawing.Point(110, 18);
            this.cbodepto.MaxDropDownItems = 100;
            this.cbodepto.Name = "cbodepto";
            this.cbodepto.Size = new System.Drawing.Size(159, 25);
            this.cbodepto.TabIndex = 24;
            // 
            // txtfunsala
            // 
            this.txtfunsala.Location = new System.Drawing.Point(110, 114);
            this.txtfunsala.Name = "txtfunsala";
            this.txtfunsala.Size = new System.Drawing.Size(159, 25);
            this.txtfunsala.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbocep);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtfunnume);
            this.groupBox1.Location = new System.Drawing.Point(20, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Rua:";
            // 
            // cbocep
            // 
            this.cbocep.FormattingEnabled = true;
            this.cbocep.Location = new System.Drawing.Point(61, 26);
            this.cbocep.MaxDropDownItems = 100;
            this.cbocep.Name = "cbocep";
            this.cbocep.Size = new System.Drawing.Size(131, 25);
            this.cbocep.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nº Casa:";
            // 
            // txtfunnume
            // 
            this.txtfunnume.Location = new System.Drawing.Point(258, 26);
            this.txtfunnume.Name = "txtfunnume";
            this.txtfunnume.Size = new System.Drawing.Size(83, 25);
            this.txtfunnume.TabIndex = 22;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(487, 450);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 31;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(348, 450);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 30;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(175, 450);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 29;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(20, 450);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 28;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtfuncel1
            // 
            this.txtfuncel1.Location = new System.Drawing.Point(452, 159);
            this.txtfuncel1.Mask = "(00)00000-0009";
            this.txtfuncel1.Name = "txtfuncel1";
            this.txtfuncel1.Size = new System.Drawing.Size(116, 25);
            this.txtfuncel1.TabIndex = 19;
            // 
            // txtfuncelu
            // 
            this.txtfuncelu.Location = new System.Drawing.Point(256, 159);
            this.txtfuncelu.Mask = "(00)00000-0009";
            this.txtfuncelu.Name = "txtfuncelu";
            this.txtfuncelu.Size = new System.Drawing.Size(122, 25);
            this.txtfuncelu.TabIndex = 18;
            // 
            // txtfunfone
            // 
            this.txtfunfone.Location = new System.Drawing.Point(81, 159);
            this.txtfunfone.Mask = "(00)0000-0000";
            this.txtfunfone.Name = "txtfunfone";
            this.txtfunfone.Size = new System.Drawing.Size(112, 25);
            this.txtfunfone.TabIndex = 17;
            // 
            // txtfunrg
            // 
            this.txtfunrg.Location = new System.Drawing.Point(429, 118);
            this.txtfunrg.Name = "txtfunrg";
            this.txtfunrg.Size = new System.Drawing.Size(139, 25);
            this.txtfunrg.TabIndex = 16;
            // 
            // txtfuncpf
            // 
            this.txtfuncpf.Location = new System.Drawing.Point(256, 118);
            this.txtfuncpf.Name = "txtfuncpf";
            this.txtfuncpf.Size = new System.Drawing.Size(133, 25);
            this.txtfuncpf.TabIndex = 15;
            // 
            // txtfundtna
            // 
            this.txtfundtna.Location = new System.Drawing.Point(134, 118);
            this.txtfundtna.Mask = "00/00/0000";
            this.txtfundtna.Name = "txtfundtna";
            this.txtfundtna.Size = new System.Drawing.Size(78, 25);
            this.txtfundtna.TabIndex = 14;
            this.txtfundtna.ValidatingType = typeof(System.DateTime);
            // 
            // txtfunnome
            // 
            this.txtfunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnome.Location = new System.Drawing.Point(93, 79);
            this.txtfunnome.Name = "txtfunnome";
            this.txtfunnome.Size = new System.Drawing.Size(477, 25);
            this.txtfunnome.TabIndex = 13;
            // 
            // txtfuncodi
            // 
            this.txtfuncodi.Location = new System.Drawing.Point(93, 41);
            this.txtfuncodi.Name = "txtfuncodi";
            this.txtfuncodi.Size = new System.Drawing.Size(73, 25);
            this.txtfuncodi.TabIndex = 12;
            this.txtfuncodi.Leave += new System.EventHandler(this.txtfuncodi_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Celular 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.tbcFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Funcionarios";
            this.Load += new System.EventHandler(this.frmfuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncionario_KeyDown);
            this.tbcFuncionario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFuncionario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtfuncel1;
        private System.Windows.Forms.MaskedTextBox txtfuncelu;
        private System.Windows.Forms.MaskedTextBox txtfunfone;
        private System.Windows.Forms.TextBox txtfunrg;
        private System.Windows.Forms.TextBox txtfuncpf;
        private System.Windows.Forms.TextBox txtfunnome;
        private System.Windows.Forms.TextBox txtfuncodi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtfunsala;
        private System.Windows.Forms.ComboBox cbodepto;
        private System.Windows.Forms.ComboBox cbocep;
        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.MaskedTextBox txtfundtna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbofuncao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbohorario;
        private System.Windows.Forms.TextBox txtfunnume;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORNOME;
    }
}