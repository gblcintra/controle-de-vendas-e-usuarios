namespace LES_17_I_M {
    partial class frmmunicipio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmunicipio));
            this.tbcmunicipio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvmunicipio = new System.Windows.Forms.DataGridView();
            this.MUNCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboestados = new System.Windows.Forms.ComboBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtmunnome = new System.Windows.Forms.TextBox();
            this.txtmuncodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcmunicipio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcmunicipio
            // 
            this.tbcmunicipio.Controls.Add(this.tabPage1);
            this.tbcmunicipio.Controls.Add(this.tabPage2);
            this.tbcmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcmunicipio.Location = new System.Drawing.Point(0, 0);
            this.tbcmunicipio.Name = "tbcmunicipio";
            this.tbcmunicipio.SelectedIndex = 0;
            this.tbcmunicipio.Size = new System.Drawing.Size(384, 362);
            this.tbcmunicipio.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvmunicipio);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvmunicipio
            // 
            this.dgvmunicipio.AllowUserToAddRows = false;
            this.dgvmunicipio.AllowUserToDeleteRows = false;
            this.dgvmunicipio.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvmunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MUNCODI,
            this.MUNNOME,
            this.ESTNOME});
            this.dgvmunicipio.Location = new System.Drawing.Point(8, 6);
            this.dgvmunicipio.MultiSelect = false;
            this.dgvmunicipio.Name = "dgvmunicipio";
            this.dgvmunicipio.ReadOnly = true;
            this.dgvmunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmunicipio.Size = new System.Drawing.Size(360, 318);
            this.dgvmunicipio.TabIndex = 0;
            this.dgvmunicipio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmunicipio_CellDoubleClick);
            // 
            // MUNCODI
            // 
            this.MUNCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MUNCODI.DataPropertyName = "MUNCODI";
            this.MUNCODI.HeaderText = "Código";
            this.MUNCODI.Name = "MUNCODI";
            this.MUNCODI.ReadOnly = true;
            this.MUNCODI.Width = 76;
            // 
            // MUNNOME
            // 
            this.MUNNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MUNNOME.DataPropertyName = "MUNNOME";
            this.MUNNOME.HeaderText = "Nome";
            this.MUNNOME.Name = "MUNNOME";
            this.MUNNOME.ReadOnly = true;
            this.MUNNOME.Width = 69;
            // 
            // ESTNOME
            // 
            this.ESTNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTNOME.DataPropertyName = "ESTNOME";
            this.ESTNOME.HeaderText = "Estado";
            this.ESTNOME.Name = "ESTNOME";
            this.ESTNOME.ReadOnly = true;
            this.ESTNOME.Width = 73;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboestados);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtmunnome);
            this.tabPage2.Controls.Add(this.txtmuncodi);
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
            // cboestados
            // 
            this.cboestados.FormattingEnabled = true;
            this.cboestados.Location = new System.Drawing.Point(137, 143);
            this.cboestados.MaxDropDownItems = 100;
            this.cboestados.Name = "cboestados";
            this.cboestados.Size = new System.Drawing.Size(121, 25);
            this.cboestados.TabIndex = 5;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(202, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 7;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(8, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 6;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtmunnome
            // 
            this.txtmunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunnome.Location = new System.Drawing.Point(93, 97);
            this.txtmunnome.Name = "txtmunnome";
            this.txtmunnome.Size = new System.Drawing.Size(250, 25);
            this.txtmunnome.TabIndex = 4;
            // 
            // txtmuncodi
            // 
            this.txtmuncodi.Location = new System.Drawing.Point(93, 41);
            this.txtmuncodi.Name = "txtmuncodi";
            this.txtmuncodi.Size = new System.Drawing.Size(87, 25);
            this.txtmuncodi.TabIndex = 3;
            this.txtmuncodi.Leave += new System.EventHandler(this.txtmuncodi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
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
            // frmmunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcmunicipio);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Município";
            this.Load += new System.EventHandler(this.frmmunicipio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmunicipio_KeyDown);
            this.tbcmunicipio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcmunicipio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvmunicipio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmunnome;
        private System.Windows.Forms.TextBox txtmuncodi;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.ComboBox cboestados;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTNOME;
    }
}