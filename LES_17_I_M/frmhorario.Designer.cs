namespace LES_17_I_M
{
    partial class frmhorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhorario));
            this.tbchorario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.HORCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORMANE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORMANS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORTARE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORTARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbotipohora = new System.Windows.Forms.ComboBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txthortars = new System.Windows.Forms.MaskedTextBox();
            this.txthortare = new System.Windows.Forms.MaskedTextBox();
            this.txthormans = new System.Windows.Forms.MaskedTextBox();
            this.txthormane = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthornome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthorcodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbchorario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbchorario
            // 
            this.tbchorario.Controls.Add(this.tabPage1);
            this.tbchorario.Controls.Add(this.tabPage2);
            this.tbchorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbchorario.Location = new System.Drawing.Point(0, 0);
            this.tbchorario.Name = "tbchorario";
            this.tbchorario.SelectedIndex = 0;
            this.tbchorario.Size = new System.Drawing.Size(384, 362);
            this.tbchorario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvhorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvhorario
            // 
            this.dgvhorario.AllowUserToAddRows = false;
            this.dgvhorario.AllowUserToDeleteRows = false;
            this.dgvhorario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORCODI,
            this.HORNOME,
            this.HORMANE,
            this.HORMANS,
            this.HORTARE,
            this.HORTARS,
            this.THONOME});
            this.dgvhorario.Location = new System.Drawing.Point(8, 7);
            this.dgvhorario.MultiSelect = false;
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.ReadOnly = true;
            this.dgvhorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorario.Size = new System.Drawing.Size(360, 318);
            this.dgvhorario.TabIndex = 1;
            this.dgvhorario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhorario_CellDoubleClick);
            // 
            // HORCODI
            // 
            this.HORCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORCODI.DataPropertyName = "HORCODI";
            this.HORCODI.HeaderText = "Código";
            this.HORCODI.Name = "HORCODI";
            this.HORCODI.ReadOnly = true;
            this.HORCODI.Width = 76;
            // 
            // HORNOME
            // 
            this.HORNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORNOME.DataPropertyName = "HORNOME";
            this.HORNOME.HeaderText = "Nome";
            this.HORNOME.Name = "HORNOME";
            this.HORNOME.ReadOnly = true;
            this.HORNOME.Width = 69;
            // 
            // HORMANE
            // 
            this.HORMANE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORMANE.DataPropertyName = "HORMANE";
            this.HORMANE.HeaderText = "Entrada Manhã";
            this.HORMANE.Name = "HORMANE";
            this.HORMANE.ReadOnly = true;
            this.HORMANE.Width = 122;
            // 
            // HORMANS
            // 
            this.HORMANS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORMANS.DataPropertyName = "HORMANS";
            this.HORMANS.HeaderText = "Saida Manhã";
            this.HORMANS.Name = "HORMANS";
            this.HORMANS.ReadOnly = true;
            this.HORMANS.Width = 109;
            // 
            // HORTARE
            // 
            this.HORTARE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORTARE.DataPropertyName = "HORTARE";
            this.HORTARE.HeaderText = "Entrada Tarde";
            this.HORTARE.Name = "HORTARE";
            this.HORTARE.ReadOnly = true;
            this.HORTARE.Width = 115;
            // 
            // HORTARS
            // 
            this.HORTARS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HORTARS.DataPropertyName = "HORTARS";
            this.HORTARS.HeaderText = "Saida Tarde";
            this.HORTARS.Name = "HORTARS";
            this.HORTARS.ReadOnly = true;
            this.HORTARS.Width = 102;
            // 
            // THONOME
            // 
            this.THONOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.THONOME.DataPropertyName = "THONOME";
            this.THONOME.HeaderText = "Tipo Horario";
            this.THONOME.Name = "THONOME";
            this.THONOME.ReadOnly = true;
            this.THONOME.Width = 108;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbotipohora);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txthortars);
            this.tabPage2.Controls.Add(this.txthortare);
            this.tabPage2.Controls.Add(this.txthormans);
            this.tabPage2.Controls.Add(this.txthormane);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txthornome);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txthorcodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbotipohora
            // 
            this.cbotipohora.FormattingEnabled = true;
            this.cbotipohora.Location = new System.Drawing.Point(93, 87);
            this.cbotipohora.MaxDropDownItems = 100;
            this.cbotipohora.Name = "cbotipohora";
            this.cbotipohora.Size = new System.Drawing.Size(184, 25);
            this.cbotipohora.TabIndex = 9;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(293, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(202, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 15;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(8, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 14;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txthortars
            // 
            this.txthortars.Location = new System.Drawing.Point(119, 242);
            this.txthortars.Mask = "00:00";
            this.txthortars.Name = "txthortars";
            this.txthortars.Size = new System.Drawing.Size(100, 25);
            this.txthortars.TabIndex = 13;
            this.txthortars.ValidatingType = typeof(System.DateTime);
            // 
            // txthortare
            // 
            this.txthortare.Location = new System.Drawing.Point(119, 211);
            this.txthortare.Mask = "00:00";
            this.txthortare.Name = "txthortare";
            this.txthortare.Size = new System.Drawing.Size(100, 25);
            this.txthortare.TabIndex = 12;
            this.txthortare.ValidatingType = typeof(System.DateTime);
            // 
            // txthormans
            // 
            this.txthormans.Location = new System.Drawing.Point(119, 176);
            this.txthormans.Mask = "00:00";
            this.txthormans.Name = "txthormans";
            this.txthormans.Size = new System.Drawing.Size(100, 25);
            this.txthormans.TabIndex = 11;
            this.txthormans.ValidatingType = typeof(System.DateTime);
            // 
            // txthormane
            // 
            this.txthormane.Location = new System.Drawing.Point(119, 141);
            this.txthormane.Mask = "00:00";
            this.txthormane.Name = "txthormane";
            this.txthormane.Size = new System.Drawing.Size(100, 25);
            this.txthormane.TabIndex = 10;
            this.txthormane.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Saida (T):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Entrada (T):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saida (M):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entrada (M):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // txthornome
            // 
            this.txthornome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthornome.Location = new System.Drawing.Point(163, 41);
            this.txthornome.Name = "txthornome";
            this.txthornome.Size = new System.Drawing.Size(205, 25);
            this.txthornome.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // txthorcodi
            // 
            this.txthorcodi.Location = new System.Drawing.Point(93, 41);
            this.txthorcodi.Name = "txthorcodi";
            this.txthorcodi.Size = new System.Drawing.Size(45, 25);
            this.txthorcodi.TabIndex = 7;
            this.txthorcodi.Leave += new System.EventHandler(this.txthorcodi_Leave);
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
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbchorario);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Horarios";
            this.Load += new System.EventHandler(this.frmhorario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmhorario_KeyDown);
            this.tbchorario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbchorario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthornome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthorcodi;
        private System.Windows.Forms.MaskedTextBox txthortars;
        private System.Windows.Forms.MaskedTextBox txthortare;
        private System.Windows.Forms.MaskedTextBox txthormans;
        private System.Windows.Forms.MaskedTextBox txthormane;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.ComboBox cbotipohora;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORMANE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORMANS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORTARE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORTARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn THONOME;
    }
}