namespace LES_17_I_M
{
    partial class frmfuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncao));
            this.tbcfuncao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvfuncao = new System.Windows.Forms.DataGridView();
            this.FUCCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cbocbo = new System.Windows.Forms.ComboBox();
            this.txtfucnome = new System.Windows.Forms.TextBox();
            this.txtfuccodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcfuncao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcfuncao
            // 
            this.tbcfuncao.Controls.Add(this.tabPage1);
            this.tbcfuncao.Controls.Add(this.tabPage2);
            this.tbcfuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcfuncao.Location = new System.Drawing.Point(0, 0);
            this.tbcfuncao.Name = "tbcfuncao";
            this.tbcfuncao.SelectedIndex = 0;
            this.tbcfuncao.Size = new System.Drawing.Size(384, 362);
            this.tbcfuncao.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfuncao);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvfuncao
            // 
            this.dgvfuncao.AllowUserToAddRows = false;
            this.dgvfuncao.AllowUserToDeleteRows = false;
            this.dgvfuncao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvfuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUCCODI,
            this.FUCNOME,
            this.CBONOME});
            this.dgvfuncao.Location = new System.Drawing.Point(8, 6);
            this.dgvfuncao.MultiSelect = false;
            this.dgvfuncao.Name = "dgvfuncao";
            this.dgvfuncao.ReadOnly = true;
            this.dgvfuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncao.Size = new System.Drawing.Size(360, 318);
            this.dgvfuncao.TabIndex = 0;
            this.dgvfuncao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncao_CellDoubleClick);
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
            // CBONOME
            // 
            this.CBONOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CBONOME.DataPropertyName = "CBONOME";
            this.CBONOME.HeaderText = "CBO";
            this.CBONOME.Name = "CBONOME";
            this.CBONOME.ReadOnly = true;
            this.CBONOME.Width = 58;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cbocbo);
            this.tabPage2.Controls.Add(this.txtfucnome);
            this.tabPage2.Controls.Add(this.txtfuccodi);
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
            // cbocbo
            // 
            this.cbocbo.FormattingEnabled = true;
            this.cbocbo.Location = new System.Drawing.Point(93, 140);
            this.cbocbo.MaxDropDownItems = 100;
            this.cbocbo.Name = "cbocbo";
            this.cbocbo.Size = new System.Drawing.Size(275, 25);
            this.cbocbo.TabIndex = 5;
            // 
            // txtfucnome
            // 
            this.txtfucnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfucnome.Location = new System.Drawing.Point(93, 97);
            this.txtfucnome.Name = "txtfucnome";
            this.txtfucnome.Size = new System.Drawing.Size(275, 25);
            this.txtfucnome.TabIndex = 4;
            // 
            // txtfuccodi
            // 
            this.txtfuccodi.Location = new System.Drawing.Point(93, 41);
            this.txtfuccodi.Name = "txtfuccodi";
            this.txtfuccodi.Size = new System.Drawing.Size(100, 25);
            this.txtfuccodi.TabIndex = 3;
            this.txtfuccodi.Leave += new System.EventHandler(this.txtfuccodi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CBO:";
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
            // frmfuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcfuncao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Funções";
            this.Load += new System.EventHandler(this.frmfuncao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncao_KeyDown);
            this.tbcfuncao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcfuncao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvfuncao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.ComboBox cbocbo;
        private System.Windows.Forms.TextBox txtfucnome;
        private System.Windows.Forms.TextBox txtfuccodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOME;
    }
}