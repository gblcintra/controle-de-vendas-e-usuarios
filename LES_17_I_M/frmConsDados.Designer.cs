namespace LES_17_I_M {
    partial class frmConsDados {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsDados));
            this.tbcConsDados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvbairro = new System.Windows.Forms.DataGridView();
            this.BAICODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNNOMEBAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvendereco = new System.Windows.Forms.DataGridView();
            this.ENDCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAINOMEEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvestado = new System.Windows.Forms.DataGridView();
            this.ESTCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOMEEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvmunicipio = new System.Windows.Forms.DataGridView();
            this.MUNCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTNOMEMUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvpais = new System.Windows.Forms.DataGridView();
            this.PAICODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcConsDados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcConsDados
            // 
            this.tbcConsDados.Controls.Add(this.tabPage1);
            this.tbcConsDados.Controls.Add(this.tabPage2);
            this.tbcConsDados.Controls.Add(this.tabPage3);
            this.tbcConsDados.Controls.Add(this.tabPage4);
            this.tbcConsDados.Controls.Add(this.tabPage5);
            this.tbcConsDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcConsDados.Location = new System.Drawing.Point(0, 0);
            this.tbcConsDados.Name = "tbcConsDados";
            this.tbcConsDados.SelectedIndex = 0;
            this.tbcConsDados.Size = new System.Drawing.Size(734, 462);
            this.tbcConsDados.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvbairro);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bairro";
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
            this.MUNNOMEBAI});
            this.dgvbairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbairro.Location = new System.Drawing.Point(3, 3);
            this.dgvbairro.Name = "dgvbairro";
            this.dgvbairro.ReadOnly = true;
            this.dgvbairro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbairro.Size = new System.Drawing.Size(720, 426);
            this.dgvbairro.TabIndex = 0;
            this.dgvbairro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbairro_CellContentClick);
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
            // MUNNOMEBAI
            // 
            this.MUNNOMEBAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MUNNOMEBAI.DataPropertyName = "MUNNOME";
            this.MUNNOMEBAI.HeaderText = "Municipio";
            this.MUNNOMEBAI.Name = "MUNNOMEBAI";
            this.MUNNOMEBAI.ReadOnly = true;
            this.MUNNOMEBAI.Width = 90;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvendereco);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereço";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvendereco
            // 
            this.dgvendereco.AllowUserToAddRows = false;
            this.dgvendereco.AllowUserToDeleteRows = false;
            this.dgvendereco.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvendereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvendereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ENDCEP,
            this.ENDENDE,
            this.BAINOMEEND});
            this.dgvendereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvendereco.Location = new System.Drawing.Point(3, 3);
            this.dgvendereco.Name = "dgvendereco";
            this.dgvendereco.ReadOnly = true;
            this.dgvendereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvendereco.Size = new System.Drawing.Size(720, 426);
            this.dgvendereco.TabIndex = 0;
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
            // BAINOMEEND
            // 
            this.BAINOMEEND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BAINOMEEND.DataPropertyName = "BAINOME";
            this.BAINOMEEND.HeaderText = "Bairro";
            this.BAINOMEEND.Name = "BAINOMEEND";
            this.BAINOMEEND.ReadOnly = true;
            this.BAINOMEEND.Width = 68;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvestado);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(726, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvestado
            // 
            this.dgvestado.AllowUserToAddRows = false;
            this.dgvestado.AllowUserToDeleteRows = false;
            this.dgvestado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTCODI,
            this.ESTUF,
            this.ESTNOME,
            this.ESTICMS,
            this.PAINOMEEST});
            this.dgvestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvestado.Location = new System.Drawing.Point(3, 3);
            this.dgvestado.Name = "dgvestado";
            this.dgvestado.ReadOnly = true;
            this.dgvestado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvestado.Size = new System.Drawing.Size(720, 426);
            this.dgvestado.TabIndex = 0;
            this.dgvestado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestado_CellContentClick);
            // 
            // ESTCODI
            // 
            this.ESTCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTCODI.DataPropertyName = "ESTCODI";
            this.ESTCODI.HeaderText = "Código";
            this.ESTCODI.Name = "ESTCODI";
            this.ESTCODI.ReadOnly = true;
            this.ESTCODI.Width = 76;
            // 
            // ESTUF
            // 
            this.ESTUF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTUF.DataPropertyName = "ESTUF";
            this.ESTUF.HeaderText = "UF";
            this.ESTUF.Name = "ESTUF";
            this.ESTUF.ReadOnly = true;
            this.ESTUF.Width = 48;
            // 
            // ESTNOME
            // 
            this.ESTNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTNOME.DataPropertyName = "ESTNOME";
            this.ESTNOME.HeaderText = "Nome";
            this.ESTNOME.Name = "ESTNOME";
            this.ESTNOME.ReadOnly = true;
            this.ESTNOME.Width = 69;
            // 
            // ESTICMS
            // 
            this.ESTICMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTICMS.DataPropertyName = "ESTICMS";
            this.ESTICMS.HeaderText = "IMCS";
            this.ESTICMS.Name = "ESTICMS";
            this.ESTICMS.ReadOnly = true;
            this.ESTICMS.Width = 63;
            // 
            // PAINOMEEST
            // 
            this.PAINOMEEST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PAINOMEEST.DataPropertyName = "PAINOME";
            this.PAINOMEEST.HeaderText = "Pais";
            this.PAINOMEEST.Name = "PAINOMEEST";
            this.PAINOMEEST.ReadOnly = true;
            this.PAINOMEEST.Width = 56;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvmunicipio);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(726, 432);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Municipío";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvmunicipio
            // 
            this.dgvmunicipio.AllowUserToAddRows = false;
            this.dgvmunicipio.AllowUserToDeleteRows = false;
            this.dgvmunicipio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvmunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MUNCODI,
            this.MUNNOME,
            this.ESTNOMEMUN});
            this.dgvmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmunicipio.Location = new System.Drawing.Point(3, 3);
            this.dgvmunicipio.Name = "dgvmunicipio";
            this.dgvmunicipio.ReadOnly = true;
            this.dgvmunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmunicipio.Size = new System.Drawing.Size(720, 426);
            this.dgvmunicipio.TabIndex = 0;
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
            // ESTNOMEMUN
            // 
            this.ESTNOMEMUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ESTNOMEMUN.DataPropertyName = "ESTNOME";
            this.ESTNOMEMUN.HeaderText = "Estado";
            this.ESTNOMEMUN.Name = "ESTNOMEMUN";
            this.ESTNOMEMUN.ReadOnly = true;
            this.ESTNOMEMUN.Width = 73;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvpais);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(726, 432);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pais";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvpais
            // 
            this.dgvpais.AllowUserToAddRows = false;
            this.dgvpais.AllowUserToDeleteRows = false;
            this.dgvpais.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvpais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PAICODI,
            this.PAINOME});
            this.dgvpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpais.Location = new System.Drawing.Point(3, 3);
            this.dgvpais.Name = "dgvpais";
            this.dgvpais.ReadOnly = true;
            this.dgvpais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpais.Size = new System.Drawing.Size(720, 426);
            this.dgvpais.TabIndex = 0;
            this.dgvpais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpais_CellContentClick);
            // 
            // PAICODI
            // 
            this.PAICODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PAICODI.DataPropertyName = "PAICODI";
            this.PAICODI.HeaderText = "Código";
            this.PAICODI.Name = "PAICODI";
            this.PAICODI.ReadOnly = true;
            this.PAICODI.Width = 76;
            // 
            // PAINOME
            // 
            this.PAINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PAINOME.DataPropertyName = "PAINOME";
            this.PAINOME.HeaderText = "Nome";
            this.PAINOME.Name = "PAINOME";
            this.PAINOME.ReadOnly = true;
            this.PAINOME.Width = 69;
            // 
            // frmConsDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.tbcConsDados);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Dados";
            this.Load += new System.EventHandler(this.frmConsDados_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsDados_KeyDown);
            this.tbcConsDados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcConsDados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvbairro;
        private System.Windows.Forms.DataGridView dgvendereco;
        private System.Windows.Forms.DataGridView dgvestado;
        private System.Windows.Forms.DataGridView dgvmunicipio;
        private System.Windows.Forms.DataGridView dgvpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDENDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAINOMEEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAICODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOMEEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAICODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNNOMEBAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTNOMEMUN;
    }
}