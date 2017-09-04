namespace LES_17_I_M
{
    partial class frmramo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmramo));
            this.tbcramo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvramo = new System.Windows.Forms.DataGridView();
            this.RAMCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.rtxtramobs = new System.Windows.Forms.RichTextBox();
            this.txtramnome = new System.Windows.Forms.TextBox();
            this.txtramcodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcramo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvramo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcramo
            // 
            this.tbcramo.Controls.Add(this.tabPage1);
            this.tbcramo.Controls.Add(this.tabPage2);
            this.tbcramo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcramo.Location = new System.Drawing.Point(0, 0);
            this.tbcramo.Name = "tbcramo";
            this.tbcramo.SelectedIndex = 0;
            this.tbcramo.Size = new System.Drawing.Size(384, 362);
            this.tbcramo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvramo);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvramo
            // 
            this.dgvramo.AllowUserToAddRows = false;
            this.dgvramo.AllowUserToDeleteRows = false;
            this.dgvramo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvramo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvramo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RAMCODI,
            this.RAMNOME,
            this.RAMOBS});
            this.dgvramo.Location = new System.Drawing.Point(6, 6);
            this.dgvramo.MultiSelect = false;
            this.dgvramo.Name = "dgvramo";
            this.dgvramo.ReadOnly = true;
            this.dgvramo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvramo.Size = new System.Drawing.Size(364, 318);
            this.dgvramo.TabIndex = 0;
            this.dgvramo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvramo_CellDoubleClick);
            // 
            // RAMCODI
            // 
            this.RAMCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAMCODI.DataPropertyName = "RAMCODI";
            this.RAMCODI.HeaderText = "Código";
            this.RAMCODI.Name = "RAMCODI";
            this.RAMCODI.ReadOnly = true;
            this.RAMCODI.Width = 76;
            // 
            // RAMNOME
            // 
            this.RAMNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAMNOME.DataPropertyName = "RAMNOME";
            this.RAMNOME.HeaderText = "Nome";
            this.RAMNOME.Name = "RAMNOME";
            this.RAMNOME.ReadOnly = true;
            this.RAMNOME.Width = 69;
            // 
            // RAMOBS
            // 
            this.RAMOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAMOBS.DataPropertyName = "RAMOBS";
            this.RAMOBS.HeaderText = "Observação";
            this.RAMOBS.Name = "RAMOBS";
            this.RAMOBS.ReadOnly = true;
            this.RAMOBS.Width = 103;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.rtxtramobs);
            this.tabPage2.Controls.Add(this.txtramnome);
            this.tabPage2.Controls.Add(this.txtramcodi);
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
            // rtxtramobs
            // 
            this.rtxtramobs.Location = new System.Drawing.Point(93, 103);
            this.rtxtramobs.Name = "rtxtramobs";
            this.rtxtramobs.Size = new System.Drawing.Size(275, 178);
            this.rtxtramobs.TabIndex = 5;
            this.rtxtramobs.Text = "";
            // 
            // txtramnome
            // 
            this.txtramnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtramnome.Location = new System.Drawing.Point(93, 72);
            this.txtramnome.Name = "txtramnome";
            this.txtramnome.Size = new System.Drawing.Size(100, 25);
            this.txtramnome.TabIndex = 4;
            // 
            // txtramcodi
            // 
            this.txtramcodi.Location = new System.Drawing.Point(93, 41);
            this.txtramcodi.Name = "txtramcodi";
            this.txtramcodi.Size = new System.Drawing.Size(100, 25);
            this.txtramcodi.TabIndex = 3;
            this.txtramcodi.Leave += new System.EventHandler(this.txtramcodi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 75);
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
            // frmramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcramo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção do Ramo";
            this.Load += new System.EventHandler(this.frmramo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmramo_KeyDown);
            this.tbcramo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvramo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcramo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvramo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMOBS;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.RichTextBox rtxtramobs;
        private System.Windows.Forms.TextBox txtramnome;
        private System.Windows.Forms.TextBox txtramcodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}