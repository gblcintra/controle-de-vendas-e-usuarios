namespace LES_17_I_M {
    partial class frmlogin {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.chkmostrar = new System.Windows.Forms.CheckBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::LES_17_I_M.Properties.Resources.user_login_icon_14;
            this.pictureBox1.Location = new System.Drawing.Point(120, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(205, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(193, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtuser.Location = new System.Drawing.Point(101, 254);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(251, 25);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpass.Location = new System.Drawing.Point(101, 326);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(251, 25);
            this.txtpass.TabIndex = 4;
            // 
            // chkmostrar
            // 
            this.chkmostrar.AutoSize = true;
            this.chkmostrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkmostrar.Location = new System.Drawing.Point(173, 357);
            this.chkmostrar.Name = "chkmostrar";
            this.chkmostrar.Size = new System.Drawing.Size(113, 21);
            this.chkmostrar.TabIndex = 5;
            this.chkmostrar.Text = "&Mostrar Senha";
            this.chkmostrar.UseVisualStyleBackColor = false;
            this.chkmostrar.CheckedChanged += new System.EventHandler(this.chkmostrar_CheckedChanged);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(12, 424);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 24);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnlogar
            // 
            this.btnlogar.Location = new System.Drawing.Point(367, 424);
            this.btnlogar.Name = "btnlogar";
            this.btnlogar.Size = new System.Drawing.Size(75, 24);
            this.btnlogar.TabIndex = 6;
            this.btnlogar.Text = "&OK";
            this.btnlogar.UseVisualStyleBackColor = true;
            this.btnlogar.Click += new System.EventHandler(this.btnlogar_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(454, 455);
            this.Controls.Add(this.btnlogar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.chkmostrar);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmlogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox chkmostrar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlogar;
    }
}