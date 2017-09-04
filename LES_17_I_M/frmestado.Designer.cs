namespace LES_17_I_M {
    partial class frmestado {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmestado));
            this.tbcestado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvestado = new System.Windows.Forms.DataGridView();
            this.ESTCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbopais = new System.Windows.Forms.ComboBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtesticms = new System.Windows.Forms.TextBox();
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.txtestcodi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcestado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcestado
            // 
            this.tbcestado.Controls.Add(this.tabPage1);
            this.tbcestado.Controls.Add(this.tabPage2);
            this.tbcestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcestado.Location = new System.Drawing.Point(0, 0);
            this.tbcestado.Name = "tbcestado";
            this.tbcestado.SelectedIndex = 0;
            this.tbcestado.Size = new System.Drawing.Size(384, 362);
            this.tbcestado.TabIndex = 0;
            this.tbcestado.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcestado_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvestado);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvestado
            // 
            this.dgvestado.AllowUserToAddRows = false;
            this.dgvestado.AllowUserToDeleteRows = false;
            this.dgvestado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTCODI,
            this.ESTUF,
            this.ESTNOME,
            this.ESTICMS,
            this.PAINOME});
            this.dgvestado.Location = new System.Drawing.Point(8, 6);
            this.dgvestado.MultiSelect = false;
            this.dgvestado.Name = "dgvestado";
            this.dgvestado.ReadOnly = true;
            this.dgvestado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvestado.Size = new System.Drawing.Size(360, 318);
            this.dgvestado.TabIndex = 0;
            this.dgvestado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestado_CellDoubleClick);
            // 
            // ESTCODI
            // 
            this.ESTCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTCODI.DataPropertyName = "ESTCODI";
            this.ESTCODI.HeaderText = "Código";
            this.ESTCODI.Name = "ESTCODI";
            this.ESTCODI.ReadOnly = true;
            this.ESTCODI.Width = 76;
            // 
            // ESTUF
            // 
            this.ESTUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTUF.DataPropertyName = "ESTUF";
            this.ESTUF.HeaderText = "UF";
            this.ESTUF.Name = "ESTUF";
            this.ESTUF.ReadOnly = true;
            this.ESTUF.Width = 48;
            // 
            // ESTNOME
            // 
            this.ESTNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTNOME.DataPropertyName = "ESTNOME";
            this.ESTNOME.HeaderText = "Nome";
            this.ESTNOME.Name = "ESTNOME";
            this.ESTNOME.ReadOnly = true;
            this.ESTNOME.Width = 69;
            // 
            // ESTICMS
            // 
            this.ESTICMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTICMS.DataPropertyName = "ESTICMS";
            this.ESTICMS.HeaderText = "ICMS";
            this.ESTICMS.Name = "ESTICMS";
            this.ESTICMS.ReadOnly = true;
            this.ESTICMS.Width = 63;
            // 
            // PAINOME
            // 
            this.PAINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PAINOME.DataPropertyName = "PAINOME";
            this.PAINOME.HeaderText = "Pais";
            this.PAINOME.Name = "PAINOME";
            this.PAINOME.ReadOnly = true;
            this.PAINOME.Width = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbopais);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtesticms);
            this.tabPage2.Controls.Add(this.txtestnome);
            this.tabPage2.Controls.Add(this.txtestuf);
            this.tabPage2.Controls.Add(this.txtestcodi);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbopais
            // 
            this.cbopais.FormattingEnabled = true;
            this.cbopais.Location = new System.Drawing.Point(93, 201);
            this.cbopais.MaxDropDownItems = 100;
            this.cbopais.Name = "cbopais";
            this.cbopais.Size = new System.Drawing.Size(121, 25);
            this.cbopais.TabIndex = 9;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(202, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 12;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 11;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(8, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 10;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtesticms
            // 
            this.txtesticms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtesticms.Location = new System.Drawing.Point(93, 161);
            this.txtesticms.Name = "txtesticms";
            this.txtesticms.Size = new System.Drawing.Size(100, 25);
            this.txtesticms.TabIndex = 8;
            // 
            // txtestnome
            // 
            this.txtestnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestnome.Location = new System.Drawing.Point(93, 121);
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.Size = new System.Drawing.Size(250, 25);
            this.txtestnome.TabIndex = 7;
            // 
            // txtestuf
            // 
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(93, 79);
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.Size = new System.Drawing.Size(50, 25);
            this.txtestuf.TabIndex = 6;
            // 
            // txtestcodi
            // 
            this.txtestcodi.Location = new System.Drawing.Point(93, 41);
            this.txtestcodi.Name = "txtestcodi";
            this.txtestcodi.Size = new System.Drawing.Size(50, 25);
            this.txtestcodi.TabIndex = 5;
            this.txtestcodi.Leave += new System.EventHandler(this.txtestcodi_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Pais:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ICMS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UF:";
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
            // frmestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcestado);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.Load += new System.EventHandler(this.frmestado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmestado_KeyDown);
            this.tbcestado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcestado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestcodi;
        private System.Windows.Forms.TextBox txtestuf;
        private System.Windows.Forms.TextBox txtestnome;
        private System.Windows.Forms.TextBox txtesticms;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.ComboBox cbopais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOME;
    }
}