namespace LES_17_I_M {
    partial class frmgrupo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgrupo));
            this.tbcgrupo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvgrupo = new System.Windows.Forms.DataGridView();
            this.GRUCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtgrunome = new System.Windows.Forms.TextBox();
            this.txtgrucodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcgrupo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcgrupo
            // 
            this.tbcgrupo.Controls.Add(this.tabPage1);
            this.tbcgrupo.Controls.Add(this.tabPage2);
            this.tbcgrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcgrupo.Location = new System.Drawing.Point(0, 0);
            this.tbcgrupo.Name = "tbcgrupo";
            this.tbcgrupo.SelectedIndex = 0;
            this.tbcgrupo.Size = new System.Drawing.Size(384, 362);
            this.tbcgrupo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvgrupo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvgrupo
            // 
            this.dgvgrupo.AllowUserToAddRows = false;
            this.dgvgrupo.AllowUserToDeleteRows = false;
            this.dgvgrupo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRUCODI,
            this.GRUNOME});
            this.dgvgrupo.Location = new System.Drawing.Point(6, 6);
            this.dgvgrupo.MultiSelect = false;
            this.dgvgrupo.Name = "dgvgrupo";
            this.dgvgrupo.ReadOnly = true;
            this.dgvgrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvgrupo.Size = new System.Drawing.Size(362, 318);
            this.dgvgrupo.TabIndex = 0;
            this.dgvgrupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrupo_CellDoubleClick);
            // 
            // GRUCODI
            // 
            this.GRUCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GRUCODI.DataPropertyName = "GRUCODI";
            this.GRUCODI.HeaderText = "Código";
            this.GRUCODI.Name = "GRUCODI";
            this.GRUCODI.ReadOnly = true;
            this.GRUCODI.Width = 76;
            // 
            // GRUNOME
            // 
            this.GRUNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GRUNOME.DataPropertyName = "GRUNOME";
            this.GRUNOME.HeaderText = "Nome";
            this.GRUNOME.Name = "GRUNOME";
            this.GRUNOME.ReadOnly = true;
            this.GRUNOME.Width = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtgrunome);
            this.tabPage2.Controls.Add(this.txtgrucodi);
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
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(202, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(8, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtgrunome
            // 
            this.txtgrunome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrunome.Location = new System.Drawing.Point(93, 79);
            this.txtgrunome.Name = "txtgrunome";
            this.txtgrunome.Size = new System.Drawing.Size(100, 25);
            this.txtgrunome.TabIndex = 3;
            // 
            // txtgrucodi
            // 
            this.txtgrucodi.Location = new System.Drawing.Point(93, 41);
            this.txtgrucodi.Name = "txtgrucodi";
            this.txtgrucodi.Size = new System.Drawing.Size(100, 25);
            this.txtgrucodi.TabIndex = 2;
            this.txtgrucodi.Leave += new System.EventHandler(this.txtgrucodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
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
            // frmgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcgrupo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Grupo";
            this.Load += new System.EventHandler(this.frmgrupo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmgrupo_KeyDown);
            this.tbcgrupo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcgrupo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvgrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUNOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrunome;
        private System.Windows.Forms.TextBox txtgrucodi;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}