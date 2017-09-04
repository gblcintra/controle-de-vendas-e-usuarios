namespace LES_17_I_M {
    partial class frmbairro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbairro));
            this.tbcbairro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvbairro = new System.Windows.Forms.DataGridView();
            this.BAICODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbomuni = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtbainome = new System.Windows.Forms.TextBox();
            this.txtbaicodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcbairro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcbairro
            // 
            this.tbcbairro.Controls.Add(this.tabPage1);
            this.tbcbairro.Controls.Add(this.tabPage2);
            this.tbcbairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcbairro.Location = new System.Drawing.Point(0, 0);
            this.tbcbairro.Name = "tbcbairro";
            this.tbcbairro.SelectedIndex = 0;
            this.tbcbairro.Size = new System.Drawing.Size(384, 362);
            this.tbcbairro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvbairro);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvbairro
            // 
            this.dgvbairro.AllowUserToAddRows = false;
            this.dgvbairro.AllowUserToDeleteRows = false;
            this.dgvbairro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvbairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BAICODI,
            this.BAINOME,
            this.MUNNOME});
            this.dgvbairro.Location = new System.Drawing.Point(8, 6);
            this.dgvbairro.MultiSelect = false;
            this.dgvbairro.Name = "dgvbairro";
            this.dgvbairro.ReadOnly = true;
            this.dgvbairro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbairro.Size = new System.Drawing.Size(360, 318);
            this.dgvbairro.TabIndex = 0;
            this.dgvbairro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbairro_CellDoubleClick);
            // 
            // BAICODI
            // 
            this.BAICODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BAICODI.DataPropertyName = "BAICODI";
            this.BAICODI.HeaderText = "Código";
            this.BAICODI.Name = "BAICODI";
            this.BAICODI.ReadOnly = true;
            this.BAICODI.Width = 76;
            // 
            // BAINOME
            // 
            this.BAINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BAINOME.DataPropertyName = "BAINOME";
            this.BAINOME.HeaderText = "Nome";
            this.BAINOME.Name = "BAINOME";
            this.BAINOME.ReadOnly = true;
            this.BAINOME.Width = 69;
            // 
            // MUNNOME
            // 
            this.MUNNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MUNNOME.DataPropertyName = "MUNNOME";
            this.MUNNOME.HeaderText = "Municipio";
            this.MUNNOME.Name = "MUNNOME";
            this.MUNNOME.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbomuni);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtbainome);
            this.tabPage2.Controls.Add(this.txtbaicodi);
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
            // cbomuni
            // 
            this.cbomuni.FormattingEnabled = true;
            this.cbomuni.Location = new System.Drawing.Point(154, 153);
            this.cbomuni.MaxDropDownItems = 100;
            this.cbomuni.Name = "cbomuni";
            this.cbomuni.Size = new System.Drawing.Size(121, 25);
            this.cbomuni.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código Município:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Enabled = false;
            this.btnexcluir.Location = new System.Drawing.Point(202, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Enabled = false;
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 6;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(8, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 5;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtbainome
            // 
            this.txtbainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbainome.Location = new System.Drawing.Point(93, 97);
            this.txtbainome.Name = "txtbainome";
            this.txtbainome.Size = new System.Drawing.Size(250, 25);
            this.txtbainome.TabIndex = 3;
            // 
            // txtbaicodi
            // 
            this.txtbaicodi.Location = new System.Drawing.Point(93, 41);
            this.txtbaicodi.Name = "txtbaicodi";
            this.txtbaicodi.Size = new System.Drawing.Size(50, 25);
            this.txtbaicodi.TabIndex = 2;
            this.txtbaicodi.Leave += new System.EventHandler(this.txtbaicodi_Leave);
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
            // frmbairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcbairro);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Bairros";
            this.Load += new System.EventHandler(this.frmbairro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmbairro_KeyDown);
            this.tbcbairro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcbairro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvbairro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbaicodi;
        private System.Windows.Forms.TextBox txtbainome;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbomuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAICODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNNOME;
    }
}