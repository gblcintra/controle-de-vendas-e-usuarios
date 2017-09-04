namespace LES_17_I_M
{
    partial class frmpais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpais));
            this.tbcpais = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvpais = new System.Windows.Forms.DataGridView();
            this.PAICODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtpainome = new System.Windows.Forms.TextBox();
            this.txtpaicodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcpais.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcpais
            // 
            this.tbcpais.Controls.Add(this.tabPage1);
            this.tbcpais.Controls.Add(this.tabPage2);
            this.tbcpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpais.Location = new System.Drawing.Point(0, 0);
            this.tbcpais.Name = "tbcpais";
            this.tbcpais.SelectedIndex = 0;
            this.tbcpais.Size = new System.Drawing.Size(384, 362);
            this.tbcpais.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvpais);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvpais
            // 
            this.dgvpais.AllowUserToAddRows = false;
            this.dgvpais.AllowUserToDeleteRows = false;
            this.dgvpais.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvpais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PAICODI,
            this.PAINOME});
            this.dgvpais.Location = new System.Drawing.Point(6, 6);
            this.dgvpais.MultiSelect = false;
            this.dgvpais.Name = "dgvpais";
            this.dgvpais.ReadOnly = true;
            this.dgvpais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpais.Size = new System.Drawing.Size(362, 320);
            this.dgvpais.TabIndex = 0;
            this.dgvpais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpais_CellDoubleClick);
            // 
            // PAICODI
            // 
            this.PAICODI.DataPropertyName = "PAICODI";
            this.PAICODI.HeaderText = "Código";
            this.PAICODI.Name = "PAICODI";
            this.PAICODI.ReadOnly = true;
            // 
            // PAINOME
            // 
            this.PAINOME.DataPropertyName = "PAINOME";
            this.PAINOME.HeaderText = "Nome";
            this.PAINOME.Name = "PAINOME";
            this.PAINOME.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtpainome);
            this.tabPage2.Controls.Add(this.txtpaicodi);
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
            // txtpainome
            // 
            this.txtpainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpainome.Location = new System.Drawing.Point(93, 97);
            this.txtpainome.Name = "txtpainome";
            this.txtpainome.Size = new System.Drawing.Size(250, 25);
            this.txtpainome.TabIndex = 3;
            // 
            // txtpaicodi
            // 
            this.txtpaicodi.Location = new System.Drawing.Point(93, 41);
            this.txtpaicodi.Name = "txtpaicodi";
            this.txtpaicodi.Size = new System.Drawing.Size(50, 25);
            this.txtpaicodi.TabIndex = 2;
            this.txtpaicodi.Leave += new System.EventHandler(this.txtpaicodi_Leave);
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
            // frmpais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcpais);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Países";
            this.Load += new System.EventHandler(this.frmpais_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmpais_KeyDown);
            this.tbcpais.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcpais;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvpais;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtpainome;
        private System.Windows.Forms.TextBox txtpaicodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAICODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOME;
    }
}