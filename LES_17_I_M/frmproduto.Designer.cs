namespace LES_17_I_M {
    partial class frmproduto {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproduto));
            this.tbcproduto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvprodutos = new System.Windows.Forms.DataGridView();
            this.PROCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCUST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROMARG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROLOCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cbounidade = new System.Windows.Forms.ComboBox();
            this.cbogrupo = new System.Windows.Forms.ComboBox();
            this.rtxtobs = new System.Windows.Forms.RichTextBox();
            this.txtproloca = new System.Windows.Forms.TextBox();
            this.txtproestoque = new System.Windows.Forms.TextBox();
            this.txtprovenda = new System.Windows.Forms.TextBox();
            this.txtpromarge = new System.Windows.Forms.TextBox();
            this.txtprocusto = new System.Windows.Forms.TextBox();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.txtprocodi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcproduto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcproduto
            // 
            this.tbcproduto.Controls.Add(this.tabPage1);
            this.tbcproduto.Controls.Add(this.tabPage2);
            this.tbcproduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcproduto.Location = new System.Drawing.Point(0, 0);
            this.tbcproduto.Name = "tbcproduto";
            this.tbcproduto.SelectedIndex = 0;
            this.tbcproduto.Size = new System.Drawing.Size(581, 464);
            this.tbcproduto.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvprodutos);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvprodutos
            // 
            this.dgvprodutos.AllowUserToAddRows = false;
            this.dgvprodutos.AllowUserToDeleteRows = false;
            this.dgvprodutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROCODI,
            this.PRONOME,
            this.PROCUST,
            this.PROMARG,
            this.PROVEND,
            this.PROESTO,
            this.PROLOCA,
            this.PROOBS,
            this.GRUNOME,
            this.UNINOME});
            this.dgvprodutos.Location = new System.Drawing.Point(8, 6);
            this.dgvprodutos.Name = "dgvprodutos";
            this.dgvprodutos.ReadOnly = true;
            this.dgvprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprodutos.Size = new System.Drawing.Size(557, 420);
            this.dgvprodutos.TabIndex = 0;
            this.dgvprodutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprodutos_CellDoubleClick);
            // 
            // PROCODI
            // 
            this.PROCODI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROCODI.DataPropertyName = "PROCODI";
            this.PROCODI.HeaderText = "Código";
            this.PROCODI.Name = "PROCODI";
            this.PROCODI.ReadOnly = true;
            this.PROCODI.Width = 76;
            // 
            // PRONOME
            // 
            this.PRONOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PRONOME.DataPropertyName = "PRONOME";
            this.PRONOME.HeaderText = "Nome";
            this.PRONOME.Name = "PRONOME";
            this.PRONOME.ReadOnly = true;
            this.PRONOME.Width = 69;
            // 
            // PROCUST
            // 
            this.PROCUST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROCUST.DataPropertyName = "PROCUST";
            this.PROCUST.HeaderText = "Custo";
            this.PROCUST.Name = "PROCUST";
            this.PROCUST.ReadOnly = true;
            this.PROCUST.Width = 66;
            // 
            // PROMARG
            // 
            this.PROMARG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROMARG.DataPropertyName = "PROMARG";
            this.PROMARG.HeaderText = "Margem";
            this.PROMARG.Name = "PROMARG";
            this.PROMARG.ReadOnly = true;
            this.PROMARG.Width = 83;
            // 
            // PROVEND
            // 
            this.PROVEND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROVEND.DataPropertyName = "PROVEND";
            this.PROVEND.HeaderText = "Venda";
            this.PROVEND.Name = "PROVEND";
            this.PROVEND.ReadOnly = true;
            this.PROVEND.Width = 69;
            // 
            // PROESTO
            // 
            this.PROESTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROESTO.DataPropertyName = "PROESTO";
            this.PROESTO.HeaderText = "Estoque";
            this.PROESTO.Name = "PROESTO";
            this.PROESTO.ReadOnly = true;
            this.PROESTO.Width = 80;
            // 
            // PROLOCA
            // 
            this.PROLOCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROLOCA.DataPropertyName = "PROLOCA";
            this.PROLOCA.HeaderText = "Locação";
            this.PROLOCA.Name = "PROLOCA";
            this.PROLOCA.ReadOnly = true;
            this.PROLOCA.Width = 81;
            // 
            // PROOBS
            // 
            this.PROOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PROOBS.DataPropertyName = "PROOBS";
            this.PROOBS.HeaderText = "OBS";
            this.PROOBS.Name = "PROOBS";
            this.PROOBS.ReadOnly = true;
            this.PROOBS.Width = 57;
            // 
            // GRUNOME
            // 
            this.GRUNOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GRUNOME.DataPropertyName = "GRUNOME";
            this.GRUNOME.HeaderText = "Grupo";
            this.GRUNOME.Name = "GRUNOME";
            this.GRUNOME.ReadOnly = true;
            this.GRUNOME.Width = 70;
            // 
            // UNINOME
            // 
            this.UNINOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UNINOME.DataPropertyName = "UNINOME";
            this.UNINOME.HeaderText = "Unidade";
            this.UNINOME.Name = "UNINOME";
            this.UNINOME.ReadOnly = true;
            this.UNINOME.Width = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cbounidade);
            this.tabPage2.Controls.Add(this.cbogrupo);
            this.tabPage2.Controls.Add(this.rtxtobs);
            this.tabPage2.Controls.Add(this.txtproloca);
            this.tabPage2.Controls.Add(this.txtproestoque);
            this.tabPage2.Controls.Add(this.txtprovenda);
            this.tabPage2.Controls.Add(this.txtpromarge);
            this.tabPage2.Controls.Add(this.txtprocusto);
            this.tabPage2.Controls.Add(this.txtpronome);
            this.tabPage2.Controls.Add(this.txtprocodi);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(490, 402);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 24);
            this.btnvoltar.TabIndex = 23;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(343, 402);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 24);
            this.btnexcluir.TabIndex = 22;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(169, 401);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 24);
            this.btngravar.TabIndex = 21;
            this.btngravar.Text = "&Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(10, 402);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 24);
            this.btnincluir.TabIndex = 20;
            this.btnincluir.Text = "&Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // cbounidade
            // 
            this.cbounidade.FormattingEnabled = true;
            this.cbounidade.Location = new System.Drawing.Point(95, 348);
            this.cbounidade.MaxDropDownItems = 100;
            this.cbounidade.Name = "cbounidade";
            this.cbounidade.Size = new System.Drawing.Size(185, 25);
            this.cbounidade.TabIndex = 19;
            // 
            // cbogrupo
            // 
            this.cbogrupo.FormattingEnabled = true;
            this.cbogrupo.Location = new System.Drawing.Point(95, 308);
            this.cbogrupo.MaxDropDownItems = 100;
            this.cbogrupo.Name = "cbogrupo";
            this.cbogrupo.Size = new System.Drawing.Size(185, 25);
            this.cbogrupo.TabIndex = 18;
            // 
            // rtxtobs
            // 
            this.rtxtobs.Location = new System.Drawing.Point(91, 192);
            this.rtxtobs.Name = "rtxtobs";
            this.rtxtobs.Size = new System.Drawing.Size(455, 92);
            this.rtxtobs.TabIndex = 17;
            this.rtxtobs.Text = "";
            // 
            // txtproloca
            // 
            this.txtproloca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproloca.Location = new System.Drawing.Point(91, 139);
            this.txtproloca.Name = "txtproloca";
            this.txtproloca.Size = new System.Drawing.Size(100, 25);
            this.txtproloca.TabIndex = 16;
            // 
            // txtproestoque
            // 
            this.txtproestoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproestoque.Location = new System.Drawing.Point(91, 98);
            this.txtproestoque.Name = "txtproestoque";
            this.txtproestoque.Size = new System.Drawing.Size(100, 25);
            this.txtproestoque.TabIndex = 15;
            // 
            // txtprovenda
            // 
            this.txtprovenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtprovenda.Location = new System.Drawing.Point(424, 60);
            this.txtprovenda.Name = "txtprovenda";
            this.txtprovenda.Size = new System.Drawing.Size(141, 25);
            this.txtprovenda.TabIndex = 14;
            // 
            // txtpromarge
            // 
            this.txtpromarge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpromarge.Location = new System.Drawing.Point(264, 62);
            this.txtpromarge.Name = "txtpromarge";
            this.txtpromarge.Size = new System.Drawing.Size(100, 25);
            this.txtpromarge.TabIndex = 13;
            // 
            // txtprocusto
            // 
            this.txtprocusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtprocusto.Location = new System.Drawing.Point(91, 60);
            this.txtprocusto.Name = "txtprocusto";
            this.txtprocusto.Size = new System.Drawing.Size(100, 25);
            this.txtprocusto.TabIndex = 12;
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(250, 19);
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(315, 25);
            this.txtpronome.TabIndex = 11;
            // 
            // txtprocodi
            // 
            this.txtprocodi.Location = new System.Drawing.Point(91, 19);
            this.txtprocodi.Name = "txtprocodi";
            this.txtprocodi.Size = new System.Drawing.Size(100, 25);
            this.txtprocodi.TabIndex = 10;
            this.txtprocodi.Leave += new System.EventHandler(this.txtprocodi_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Unidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grupo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Obs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Locação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Margem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // frmproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 464);
            this.Controls.Add(this.tbcproduto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmproduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmproduto_KeyDown);
            this.tbcproduto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcproduto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvprodutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprovenda;
        private System.Windows.Forms.TextBox txtpromarge;
        private System.Windows.Forms.TextBox txtprocusto;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.TextBox txtprocodi;
        private System.Windows.Forms.RichTextBox rtxtobs;
        private System.Windows.Forms.TextBox txtproloca;
        private System.Windows.Forms.TextBox txtproestoque;
        private System.Windows.Forms.ComboBox cbounidade;
        private System.Windows.Forms.ComboBox cbogrupo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRONOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCUST;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROMARG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROLOCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROOBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNINOME;
    }
}