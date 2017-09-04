namespace LES_17_I_M
{
    partial class frmcbo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcbo));
            this.tbccbo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvcbo = new System.Windows.Forms.DataGridView();
            this.CBOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Voltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtcbonome = new System.Windows.Forms.TextBox();
            this.txtcbocodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbccbo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbccbo
            // 
            this.tbccbo.Controls.Add(this.tabPage1);
            this.tbccbo.Controls.Add(this.tabPage2);
            this.tbccbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbccbo.Location = new System.Drawing.Point(0, 0);
            this.tbccbo.Name = "tbccbo";
            this.tbccbo.SelectedIndex = 0;
            this.tbccbo.Size = new System.Drawing.Size(384, 362);
            this.tbccbo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvcbo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
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
            this.dgvcbo.Location = new System.Drawing.Point(8, 6);
            this.dgvcbo.MultiSelect = false;
            this.dgvcbo.Name = "dgvcbo";
            this.dgvcbo.ReadOnly = true;
            this.dgvcbo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcbo.Size = new System.Drawing.Size(360, 318);
            this.dgvcbo.TabIndex = 0;
            this.dgvcbo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcbo_CellDoubleClick);
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
            this.tabPage2.Controls.Add(this.Voltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtcbonome);
            this.tabPage2.Controls.Add(this.txtcbocodi);
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
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(293, 301);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 24);
            this.Voltar.TabIndex = 7;
            this.Voltar.Text = "&Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
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
            // txtcbonome
            // 
            this.txtcbonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcbonome.Location = new System.Drawing.Point(93, 97);
            this.txtcbonome.Name = "txtcbonome";
            this.txtcbonome.Size = new System.Drawing.Size(275, 25);
            this.txtcbonome.TabIndex = 3;
            // 
            // txtcbocodi
            // 
            this.txtcbocodi.Location = new System.Drawing.Point(93, 41);
            this.txtcbocodi.Name = "txtcbocodi";
            this.txtcbocodi.Size = new System.Drawing.Size(100, 25);
            this.txtcbocodi.TabIndex = 2;
            this.txtcbocodi.Leave += new System.EventHandler(this.txtcbocodi_Leave);
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
            // frmcbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbccbo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcbo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de CBO\'s";
            this.Load += new System.EventHandler(this.frmcbo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcbo_KeyDown);
            this.tbccbo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbccbo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvcbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcbonome;
        private System.Windows.Forms.TextBox txtcbocodi;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOME;
    }
}