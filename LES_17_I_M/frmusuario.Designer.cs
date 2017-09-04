namespace LES_17_I_M {
    partial class frmusuario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusuario));
            this.tbcusuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.USUNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUNIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUDATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkmostrac = new System.Windows.Forms.CheckBox();
            this.btnvoltarc = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncadastro = new System.Windows.Forms.Button();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtfuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btndesbloc = new System.Windows.Forms.Button();
            this.btnsalvalt = new System.Windows.Forms.Button();
            this.rbcomum = new System.Windows.Forms.RadioButton();
            this.rbvendedor = new System.Windows.Forms.RadioButton();
            this.rbdados = new System.Windows.Forms.RadioButton();
            this.rbfolha = new System.Windows.Forms.RadioButton();
            this.rbvendas = new System.Windows.Forms.RadioButton();
            this.rbgerdados = new System.Windows.Forms.RadioButton();
            this.rbgerfolha = new System.Windows.Forms.RadioButton();
            this.rbgervendas = new System.Windows.Forms.RadioButton();
            this.rbgergeral = new System.Windows.Forms.RadioButton();
            this.cbousuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkmostram = new System.Windows.Forms.CheckBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtnovarepete = new System.Windows.Forms.TextBox();
            this.txtnova = new System.Windows.Forms.TextBox();
            this.txtantiga = new System.Windows.Forms.TextBox();
            this.cboperfil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcusuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcusuario
            // 
            this.tbcusuario.Controls.Add(this.tabPage1);
            this.tbcusuario.Controls.Add(this.tabPage2);
            this.tbcusuario.Controls.Add(this.tabPage3);
            this.tbcusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcusuario.Location = new System.Drawing.Point(0, 0);
            this.tbcusuario.Name = "tbcusuario";
            this.tbcusuario.SelectedIndex = 0;
            this.tbcusuario.Size = new System.Drawing.Size(584, 462);
            this.tbcusuario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvusuario
            // 
            this.dgvusuario.AllowUserToAddRows = false;
            this.dgvusuario.AllowUserToDeleteRows = false;
            this.dgvusuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUNOME,
            this.FUNNOME,
            this.USUNIVEL,
            this.USUDATA,
            this.USUQTDE});
            this.dgvusuario.Location = new System.Drawing.Point(6, 6);
            this.dgvusuario.MultiSelect = false;
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.ReadOnly = true;
            this.dgvusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusuario.Size = new System.Drawing.Size(562, 418);
            this.dgvusuario.TabIndex = 0;
            // 
            // USUNOME
            // 
            this.USUNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USUNOME.DataPropertyName = "USUNOME";
            this.USUNOME.HeaderText = "Nome Login";
            this.USUNOME.Name = "USUNOME";
            this.USUNOME.ReadOnly = true;
            this.USUNOME.Width = 105;
            // 
            // FUNNOME
            // 
            this.FUNNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FUNNOME.DataPropertyName = "FUNNOME";
            this.FUNNOME.HeaderText = "Funcionario";
            this.FUNNOME.Name = "FUNNOME";
            this.FUNNOME.ReadOnly = true;
            // 
            // USUNIVEL
            // 
            this.USUNIVEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USUNIVEL.DataPropertyName = "USUNIVEL";
            this.USUNIVEL.HeaderText = "Nível de Permissão";
            this.USUNIVEL.Name = "USUNIVEL";
            this.USUNIVEL.ReadOnly = true;
            this.USUNIVEL.Width = 145;
            // 
            // USUDATA
            // 
            this.USUDATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USUDATA.DataPropertyName = "USUDATA";
            this.USUDATA.HeaderText = "Ultima Modificação de Senha";
            this.USUDATA.Name = "USUDATA";
            this.USUDATA.ReadOnly = true;
            this.USUDATA.Width = 204;
            // 
            // USUQTDE
            // 
            this.USUQTDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USUQTDE.DataPropertyName = "USUQTDE";
            this.USUQTDE.HeaderText = "Quantia de Logins Disponivel";
            this.USUQTDE.Name = "USUQTDE";
            this.USUQTDE.ReadOnly = true;
            this.USUQTDE.Width = 203;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkmostrac);
            this.tabPage2.Controls.Add(this.btnvoltarc);
            this.tabPage2.Controls.Add(this.btnlimpar);
            this.tabPage2.Controls.Add(this.btncadastro);
            this.tabPage2.Controls.Add(this.txtpass2);
            this.tabPage2.Controls.Add(this.txtpass);
            this.tabPage2.Controls.Add(this.txtlogin);
            this.tabPage2.Controls.Add(this.txtfuncionario);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkmostrac
            // 
            this.chkmostrac.AutoSize = true;
            this.chkmostrac.Location = new System.Drawing.Point(218, 122);
            this.chkmostrac.Name = "chkmostrac";
            this.chkmostrac.Size = new System.Drawing.Size(74, 21);
            this.chkmostrac.TabIndex = 11;
            this.chkmostrac.Text = "Mostrar";
            this.chkmostrac.UseVisualStyleBackColor = true;
            this.chkmostrac.CheckedChanged += new System.EventHandler(this.chkmostrac_CheckedChanged);
            // 
            // btnvoltarc
            // 
            this.btnvoltarc.Location = new System.Drawing.Point(493, 400);
            this.btnvoltarc.Name = "btnvoltarc";
            this.btnvoltarc.Size = new System.Drawing.Size(75, 24);
            this.btnvoltarc.TabIndex = 10;
            this.btnvoltarc.Text = "&Voltar";
            this.btnvoltarc.UseVisualStyleBackColor = true;
            this.btnvoltarc.Click += new System.EventHandler(this.btnvoltarc_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(168, 400);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 24);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(11, 400);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(75, 24);
            this.btncadastro.TabIndex = 8;
            this.btncadastro.Text = "&Cadastrar";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(112, 164);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.PasswordChar = '*';
            this.txtpass2.Size = new System.Drawing.Size(100, 25);
            this.txtpass2.TabIndex = 7;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(112, 123);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 25);
            this.txtpass.TabIndex = 6;
            // 
            // txtlogin
            // 
            this.txtlogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlogin.Location = new System.Drawing.Point(112, 74);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(278, 25);
            this.txtlogin.TabIndex = 5;
            // 
            // txtfuncionario
            // 
            this.txtfuncionario.Location = new System.Drawing.Point(112, 23);
            this.txtfuncionario.Name = "txtfuncionario";
            this.txtfuncionario.ReadOnly = true;
            this.txtfuncionario.Size = new System.Drawing.Size(283, 25);
            this.txtfuncionario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repita a Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Login:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(576, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manutenção";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnapagar);
            this.groupBox2.Controls.Add(this.btndesbloc);
            this.groupBox2.Controls.Add(this.btnsalvalt);
            this.groupBox2.Controls.Add(this.rbcomum);
            this.groupBox2.Controls.Add(this.rbvendedor);
            this.groupBox2.Controls.Add(this.rbdados);
            this.groupBox2.Controls.Add(this.rbfolha);
            this.groupBox2.Controls.Add(this.rbvendas);
            this.groupBox2.Controls.Add(this.rbgerdados);
            this.groupBox2.Controls.Add(this.rbgerfolha);
            this.groupBox2.Controls.Add(this.rbgervendas);
            this.groupBox2.Controls.Add(this.rbgergeral);
            this.groupBox2.Controls.Add(this.cbousuario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(8, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manutenção Usuarios";
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(82, 58);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(100, 68);
            this.btnapagar.TabIndex = 2;
            this.btnapagar.Text = "&Apagar Usuario";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Visible = false;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btndesbloc
            // 
            this.btndesbloc.Location = new System.Drawing.Point(85, 132);
            this.btndesbloc.Name = "btndesbloc";
            this.btndesbloc.Size = new System.Drawing.Size(97, 62);
            this.btndesbloc.TabIndex = 3;
            this.btndesbloc.Text = "Desbloquear User";
            this.btndesbloc.UseVisualStyleBackColor = true;
            this.btndesbloc.Visible = false;
            this.btndesbloc.Click += new System.EventHandler(this.btndesbloc_Click);
            // 
            // btnsalvalt
            // 
            this.btnsalvalt.Location = new System.Drawing.Point(426, 160);
            this.btnsalvalt.Name = "btnsalvalt";
            this.btnsalvalt.Size = new System.Drawing.Size(128, 24);
            this.btnsalvalt.TabIndex = 13;
            this.btnsalvalt.Text = "Salvar &Alterações";
            this.btnsalvalt.UseVisualStyleBackColor = true;
            this.btnsalvalt.Visible = false;
            this.btnsalvalt.Click += new System.EventHandler(this.btnsalvalt_Click);
            // 
            // rbcomum
            // 
            this.rbcomum.AutoSize = true;
            this.rbcomum.Location = new System.Drawing.Point(447, 119);
            this.rbcomum.Name = "rbcomum";
            this.rbcomum.Size = new System.Drawing.Size(71, 21);
            this.rbcomum.TabIndex = 12;
            this.rbcomum.TabStop = true;
            this.rbcomum.Text = "Comum";
            this.rbcomum.UseVisualStyleBackColor = true;
            this.rbcomum.Visible = false;
            // 
            // rbvendedor
            // 
            this.rbvendedor.AutoSize = true;
            this.rbvendedor.Location = new System.Drawing.Point(340, 119);
            this.rbvendedor.Name = "rbvendedor";
            this.rbvendedor.Size = new System.Drawing.Size(83, 21);
            this.rbvendedor.TabIndex = 11;
            this.rbvendedor.TabStop = true;
            this.rbvendedor.Text = "Vendedor";
            this.rbvendedor.UseVisualStyleBackColor = true;
            this.rbvendedor.Visible = false;
            // 
            // rbdados
            // 
            this.rbdados.AutoSize = true;
            this.rbdados.Location = new System.Drawing.Point(233, 119);
            this.rbdados.Name = "rbdados";
            this.rbdados.Size = new System.Drawing.Size(57, 21);
            this.rbdados.TabIndex = 10;
            this.rbdados.TabStop = true;
            this.rbdados.Text = "Caixa";
            this.rbdados.UseVisualStyleBackColor = true;
            this.rbdados.Visible = false;
            // 
            // rbfolha
            // 
            this.rbfolha.AutoSize = true;
            this.rbfolha.Location = new System.Drawing.Point(447, 74);
            this.rbfolha.Name = "rbfolha";
            this.rbfolha.Size = new System.Drawing.Size(133, 21);
            this.rbfolha.TabIndex = 9;
            this.rbfolha.TabStop = true;
            this.rbfolha.Text = "Auxiliar de Vendas";
            this.rbfolha.UseVisualStyleBackColor = true;
            this.rbfolha.Visible = false;
            // 
            // rbvendas
            // 
            this.rbvendas.AutoSize = true;
            this.rbvendas.Location = new System.Drawing.Point(340, 74);
            this.rbvendas.Name = "rbvendas";
            this.rbvendas.Size = new System.Drawing.Size(68, 21);
            this.rbvendas.TabIndex = 8;
            this.rbvendas.TabStop = true;
            this.rbvendas.Text = "Auxiliar";
            this.rbvendas.UseVisualStyleBackColor = true;
            this.rbvendas.Visible = false;
            // 
            // rbgerdados
            // 
            this.rbgerdados.AutoSize = true;
            this.rbgerdados.Location = new System.Drawing.Point(233, 74);
            this.rbgerdados.Name = "rbgerdados";
            this.rbgerdados.Size = new System.Drawing.Size(89, 21);
            this.rbgerdados.TabIndex = 7;
            this.rbgerdados.TabStop = true;
            this.rbgerdados.Text = "Verificador";
            this.rbgerdados.UseVisualStyleBackColor = true;
            this.rbgerdados.Visible = false;
            // 
            // rbgerfolha
            // 
            this.rbgerfolha.AutoSize = true;
            this.rbgerfolha.Location = new System.Drawing.Point(447, 29);
            this.rbgerfolha.Name = "rbgerfolha";
            this.rbgerfolha.Size = new System.Drawing.Size(100, 21);
            this.rbgerfolha.TabIndex = 6;
            this.rbgerfolha.TabStop = true;
            this.rbgerfolha.Text = "Vice Gerente";
            this.rbgerfolha.UseVisualStyleBackColor = true;
            this.rbgerfolha.Visible = false;
            // 
            // rbgervendas
            // 
            this.rbgervendas.AutoSize = true;
            this.rbgervendas.Location = new System.Drawing.Point(340, 29);
            this.rbgervendas.Name = "rbgervendas";
            this.rbgervendas.Size = new System.Drawing.Size(72, 21);
            this.rbgervendas.TabIndex = 5;
            this.rbgervendas.TabStop = true;
            this.rbgervendas.Text = "Gerente";
            this.rbgervendas.UseVisualStyleBackColor = true;
            this.rbgervendas.Visible = false;
            // 
            // rbgergeral
            // 
            this.rbgergeral.AutoSize = true;
            this.rbgergeral.Location = new System.Drawing.Point(233, 29);
            this.rbgergeral.Name = "rbgergeral";
            this.rbgergeral.Size = new System.Drawing.Size(59, 21);
            this.rbgergeral.TabIndex = 4;
            this.rbgergeral.TabStop = true;
            this.rbgergeral.Text = "Chefe";
            this.rbgergeral.UseVisualStyleBackColor = true;
            this.rbgergeral.Visible = false;
            // 
            // cbousuario
            // 
            this.cbousuario.FormattingEnabled = true;
            this.cbousuario.Location = new System.Drawing.Point(68, 28);
            this.cbousuario.MaxDropDownItems = 100;
            this.cbousuario.Name = "cbousuario";
            this.cbousuario.Size = new System.Drawing.Size(144, 25);
            this.cbousuario.TabIndex = 1;
            this.cbousuario.SelectionChangeCommitted += new System.EventHandler(this.cbousuario_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkmostram);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.txtnovarepete);
            this.groupBox1.Controls.Add(this.txtnova);
            this.groupBox1.Controls.Add(this.txtantiga);
            this.groupBox1.Controls.Add(this.cboperfil);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manutenção Perfil";
            // 
            // chkmostram
            // 
            this.chkmostram.AutoSize = true;
            this.chkmostram.Location = new System.Drawing.Point(473, 31);
            this.chkmostram.Name = "chkmostram";
            this.chkmostram.Size = new System.Drawing.Size(74, 21);
            this.chkmostram.TabIndex = 6;
            this.chkmostram.Text = "Mostrar";
            this.chkmostram.UseVisualStyleBackColor = true;
            this.chkmostram.CheckedChanged += new System.EventHandler(this.chkmostram_CheckedChanged);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(203, 164);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(119, 24);
            this.btnsalvar.TabIndex = 10;
            this.btnsalvar.Text = "&Salvar Alterações";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtnovarepete
            // 
            this.txtnovarepete.Location = new System.Drawing.Point(380, 93);
            this.txtnovarepete.Name = "txtnovarepete";
            this.txtnovarepete.PasswordChar = '*';
            this.txtnovarepete.Size = new System.Drawing.Size(100, 25);
            this.txtnovarepete.TabIndex = 8;
            // 
            // txtnova
            // 
            this.txtnova.Location = new System.Drawing.Point(112, 98);
            this.txtnova.Name = "txtnova";
            this.txtnova.PasswordChar = '*';
            this.txtnova.Size = new System.Drawing.Size(100, 25);
            this.txtnova.TabIndex = 7;
            // 
            // txtantiga
            // 
            this.txtantiga.Location = new System.Drawing.Point(371, 28);
            this.txtantiga.Name = "txtantiga";
            this.txtantiga.PasswordChar = '*';
            this.txtantiga.Size = new System.Drawing.Size(100, 25);
            this.txtantiga.TabIndex = 5;
            // 
            // cboperfil
            // 
            this.cboperfil.FormattingEnabled = true;
            this.cboperfil.Location = new System.Drawing.Point(65, 28);
            this.cboperfil.MaxDropDownItems = 100;
            this.cboperfil.Name = "cboperfil";
            this.cboperfil.Size = new System.Drawing.Size(147, 25);
            this.cboperfil.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Senha Antiga:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Repetir Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nova Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Perfil:";
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tbcusuario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmusuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmusuario_KeyDown);
            this.tbcusuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcusuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtfuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltarc;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUNIVEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUDATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUQTDE;
        private System.Windows.Forms.CheckBox chkmostrac;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtnovarepete;
        private System.Windows.Forms.TextBox txtnova;
        private System.Windows.Forms.TextBox txtantiga;
        private System.Windows.Forms.ComboBox cboperfil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbousuario;
        private System.Windows.Forms.CheckBox chkmostram;
        private System.Windows.Forms.RadioButton rbcomum;
        private System.Windows.Forms.RadioButton rbvendedor;
        private System.Windows.Forms.RadioButton rbdados;
        private System.Windows.Forms.RadioButton rbfolha;
        private System.Windows.Forms.RadioButton rbvendas;
        private System.Windows.Forms.RadioButton rbgerdados;
        private System.Windows.Forms.RadioButton rbgerfolha;
        private System.Windows.Forms.RadioButton rbgervendas;
        private System.Windows.Forms.RadioButton rbgergeral;
        private System.Windows.Forms.Button btndesbloc;
        private System.Windows.Forms.Button btnsalvalt;
        private System.Windows.Forms.Button btnapagar;
    }
}