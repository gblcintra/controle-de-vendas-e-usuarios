namespace LES_17_I_M {
    partial class frmendereco {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmendereco));
            this.tbcendereco = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvendereco = new System.Windows.Forms.DataGridView();
            this.ENDCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbobairros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtendnome = new System.Windows.Forms.TextBox();
            this.txtendcep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcendereco.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcendereco
            // 
            this.tbcendereco.Controls.Add(this.tabPage1);
            this.tbcendereco.Controls.Add(this.tabPage2);
            this.tbcendereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcendereco.Location = new System.Drawing.Point(0, 0);
            this.tbcendereco.Name = "tbcendereco";
            this.tbcendereco.SelectedIndex = 0;
            this.tbcendereco.Size = new System.Drawing.Size(384, 362);
            this.tbcendereco.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvendereco);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvendereco
            // 
            this.dgvendereco.AllowUserToAddRows = false;
            this.dgvendereco.AllowUserToDeleteRows = false;
            this.dgvendereco.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvendereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvendereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ENDCEP,
            this.ENDENDE,
            this.BAINOME});
            this.dgvendereco.Location = new System.Drawing.Point(8, 6);
            this.dgvendereco.MultiSelect = false;
            this.dgvendereco.Name = "dgvendereco";
            this.dgvendereco.ReadOnly = true;
            this.dgvendereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvendereco.Size = new System.Drawing.Size(360, 318);
            this.dgvendereco.TabIndex = 0;
            this.dgvendereco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvendereco_CellDoubleClick);
            // 
            // ENDCEP
            // 
            this.ENDCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ENDCEP.DataPropertyName = "ENDCEP";
            this.ENDCEP.HeaderText = "CEP";
            this.ENDCEP.Name = "ENDCEP";
            this.ENDCEP.ReadOnly = true;
            this.ENDCEP.Width = 55;
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
            // BAINOME
            // 
            this.BAINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BAINOME.DataPropertyName = "BAINOME";
            this.BAINOME.HeaderText = "Bairro";
            this.BAINOME.Name = "BAINOME";
            this.BAINOME.ReadOnly = true;
            this.BAINOME.Width = 68;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbobairros);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtendnome);
            this.tabPage2.Controls.Add(this.txtendcep);
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
            // cbobairros
            // 
            this.cbobairros.FormattingEnabled = true;
            this.cbobairros.Location = new System.Drawing.Point(120, 152);
            this.cbobairros.MaxDropDownItems = 100;
            this.cbobairros.Name = "cbobairros";
            this.cbobairros.Size = new System.Drawing.Size(121, 25);
            this.cbobairros.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código Bairro:";
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
            // txtendnome
            // 
            this.txtendnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendnome.Location = new System.Drawing.Point(93, 97);
            this.txtendnome.Name = "txtendnome";
            this.txtendnome.Size = new System.Drawing.Size(250, 25);
            this.txtendnome.TabIndex = 3;
            // 
            // txtendcep
            // 
            this.txtendcep.Location = new System.Drawing.Point(93, 41);
            this.txtendcep.Name = "txtendcep";
            this.txtendcep.Size = new System.Drawing.Size(142, 25);
            this.txtendcep.TabIndex = 2;
            this.txtendcep.Leave += new System.EventHandler(this.txtendcep_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // frmendereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcendereco);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmendereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Endereços";
            this.Load += new System.EventHandler(this.frmendereco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmendereco_KeyDown);
            this.tbcendereco.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcendereco;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvendereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtendnome;
        private System.Windows.Forms.TextBox txtendcep;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbobairros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDENDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAINOME;
    }
}