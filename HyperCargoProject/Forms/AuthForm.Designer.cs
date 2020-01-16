namespace HyperCargoProject.Forms
{
    partial class AuthForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.linklblAuth = new System.Windows.Forms.LinkLabel();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.tbxPasswordAuth = new System.Windows.Forms.TextBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.pnlLoginReg = new System.Windows.Forms.Panel();
            this.tbxLoginAuth = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.lblAuth = new System.Windows.Forms.Label();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(339, 15);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.White;
            this.pnlFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFill.Controls.Add(this.linklblAuth);
            this.pnlFill.Controls.Add(this.pbxPassword);
            this.pnlFill.Controls.Add(this.pnlPassword);
            this.pnlFill.Controls.Add(this.tbxPasswordAuth);
            this.pnlFill.Controls.Add(this.pbxLogin);
            this.pnlFill.Controls.Add(this.pnlLoginReg);
            this.pnlFill.Controls.Add(this.tbxLoginAuth);
            this.pnlFill.Controls.Add(this.btnAuth);
            this.pnlFill.Controls.Add(this.lblAuth);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.ForeColor = System.Drawing.Color.Black;
            this.pnlFill.Location = new System.Drawing.Point(0, 15);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(339, 326);
            this.pnlFill.TabIndex = 3;
            // 
            // linklblAuth
            // 
            this.linklblAuth.AutoSize = true;
            this.linklblAuth.Location = new System.Drawing.Point(87, 272);
            this.linklblAuth.Name = "linklblAuth";
            this.linklblAuth.Size = new System.Drawing.Size(189, 13);
            this.linklblAuth.TabIndex = 8;
            this.linklblAuth.TabStop = true;
            this.linklblAuth.Text = "Нет аккаунта? Зарегистрируйтесь?";
            this.linklblAuth.Click += new System.EventHandler(this.linklblAuth_Click);
            // 
            // pbxPassword
            // 
            this.pbxPassword.BackgroundImage = global::HyperCargoProject.Properties.Resources.icons8_пароль_30;
            this.pbxPassword.Location = new System.Drawing.Point(51, 165);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(30, 30);
            this.pbxPassword.TabIndex = 7;
            this.pbxPassword.TabStop = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Black;
            this.pnlPassword.Location = new System.Drawing.Point(51, 197);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(250, 1);
            this.pnlPassword.TabIndex = 6;
            // 
            // tbxPasswordAuth
            // 
            this.tbxPasswordAuth.BackColor = System.Drawing.Color.White;
            this.tbxPasswordAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPasswordAuth.ForeColor = System.Drawing.Color.Black;
            this.tbxPasswordAuth.Location = new System.Drawing.Point(90, 172);
            this.tbxPasswordAuth.Multiline = true;
            this.tbxPasswordAuth.Name = "tbxPasswordAuth";
            this.tbxPasswordAuth.PasswordChar = '*';
            this.tbxPasswordAuth.Size = new System.Drawing.Size(194, 26);
            this.tbxPasswordAuth.TabIndex = 5;
            this.tbxPasswordAuth.Text = "qawsed";
            this.tbxPasswordAuth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPasswordAuth_KeyPress);
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackgroundImage = global::HyperCargoProject.Properties.Resources.icons8_login_30;
            this.pbxLogin.Location = new System.Drawing.Point(51, 108);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(30, 30);
            this.pbxLogin.TabIndex = 4;
            this.pbxLogin.TabStop = false;
            // 
            // pnlLoginReg
            // 
            this.pnlLoginReg.BackColor = System.Drawing.Color.Black;
            this.pnlLoginReg.Location = new System.Drawing.Point(51, 140);
            this.pnlLoginReg.Name = "pnlLoginReg";
            this.pnlLoginReg.Size = new System.Drawing.Size(250, 1);
            this.pnlLoginReg.TabIndex = 3;
            // 
            // tbxLoginAuth
            // 
            this.tbxLoginAuth.BackColor = System.Drawing.Color.White;
            this.tbxLoginAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLoginAuth.ForeColor = System.Drawing.Color.Black;
            this.tbxLoginAuth.Location = new System.Drawing.Point(90, 115);
            this.tbxLoginAuth.Multiline = true;
            this.tbxLoginAuth.Name = "tbxLoginAuth";
            this.tbxLoginAuth.Size = new System.Drawing.Size(194, 26);
            this.tbxLoginAuth.TabIndex = 2;
            this.tbxLoginAuth.Text = "babazaeb";
            this.tbxLoginAuth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoginAuth_KeyPress);
            // 
            // btnAuth
            // 
            this.btnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAuth.Image = global::HyperCargoProject.Properties.Resources.icons8_войти_30__1_;
            this.btnAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuth.Location = new System.Drawing.Point(63, 214);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(221, 44);
            this.btnAuth.TabIndex = 1;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblAuth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(111, 58);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(112, 21);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Авторизация";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 341);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthForm";
            this.Text = "ГиперГруз / Авторизация";
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.LinkLabel linklblAuth;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox tbxPasswordAuth;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.Panel pnlLoginReg;
        private System.Windows.Forms.TextBox tbxLoginAuth;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label lblAuth;
    }
}