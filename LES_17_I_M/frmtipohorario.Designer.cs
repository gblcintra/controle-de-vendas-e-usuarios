namespace LES_17_I_M
{
    partial class frmtipohorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtipohorario));
            this.tbctipohorario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvtipohorario = new System.Windows.Forms.DataGridView();
            this.THOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtthonome = new System.Windows.Forms.TextBox();
            this.txtthocodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbctipohorario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctipohorario
            // 
            this.tbctipohorario.Controls.Add(this.tabPage1);
            this.tbctipohorario.Controls.Add(this.tabPage2);
            this.tbctipohorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctipohorario.Location = new System.Drawing.Point(0, 0);
            this.tbctipohorario.Name = "tbctipohorario";
            this.tbctipohorario.SelectedIndex = 0;
            this.tbctipohorario.Size = new System.Drawing.Size(384, 362);
            this.tbctipohorario.TabIndex = 0;
            this.tbctipohorario.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbctipohorario_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtipohorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvtipohorario
            // 
            this.dgvtipohorario.AllowUserToAddRows = false;
            this.dgvtipohorario.AllowUserToDeleteRows = false;
            this.dgvtipohorario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtipohorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipohorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.THOCODI,
            this.THONOME});
            this.dgvtipohorario.Location = new System.Drawing.Point(8, 6);
            this.dgvtipohorario.MultiSelect = false;
            this.dgvtipohorario.Name = "dgvtipohorario";
            this.dgvtipohorario.ReadOnly = true;
            this.dgvtipohorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipohorario.Size = new System.Drawing.Size(360, 318);
            this.dgvtipohorario.TabIndex = 0;
            this.dgvtipohorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtipohorario_CellDoubleClick);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtthonome);
            this.tabPage2.Controls.Add(this.txtthocodi);
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
            // txtthonome
            // 
            this.txtthonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtthonome.Location = new System.Drawing.Point(93, 97);
            this.txtthonome.Name = "txtthonome";
            this.txtthonome.Size = new System.Drawing.Size(100, 25);
            this.txtthonome.TabIndex = 3;
            // 
            // txtthocodi
            // 
            this.txtthocodi.Location = new System.Drawing.Point(93, 41);
            this.txtthocodi.Name = "txtthocodi";
            this.txtthocodi.Size = new System.Drawing.Size(100, 25);
            this.txtthocodi.TabIndex = 2;
            this.txtthocodi.Leave += new System.EventHandler(this.txtthocodi_Leave);
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
            // frmtipohorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbctipohorario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtipohorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Tipo de Horario";
            this.Load += new System.EventHandler(this.frmtipohorario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmtipohorario_KeyDown);
            this.tbctipohorario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctipohorario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvtipohorario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtthonome;
        private System.Windows.Forms.TextBox txtthocodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONOME;
    }
}