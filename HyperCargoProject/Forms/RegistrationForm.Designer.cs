namespace HyperCargoProject.Forms
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pbxEmail = new System.Windows.Forms.PictureBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.tbxEmailReg = new System.Windows.Forms.TextBox();
            this.linklblReg = new System.Windows.Forms.LinkLabel();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.tbxPasswordReg = new System.Windows.Forms.TextBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.pnlLoginReg = new System.Windows.Forms.Panel();
            this.tbxLoginReg = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.errorProvEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(339, 15);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.White;
            this.pnlFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlFill.Controls.Add(this.pbxEmail);
            this.pnlFill.Controls.Add(this.pnlEmail);
            this.pnlFill.Controls.Add(this.tbxEmailReg);
            this.pnlFill.Controls.Add(this.linklblReg);
            this.pnlFill.Controls.Add(this.pbxPassword);
            this.pnlFill.Controls.Add(this.pnlPassword);
            this.pnlFill.Controls.Add(this.tbxPasswordReg);
            this.pnlFill.Controls.Add(this.pbxLogin);
            this.pnlFill.Controls.Add(this.pnlLoginReg);
            this.pnlFill.Controls.Add(this.tbxLoginReg);
            this.pnlFill.Controls.Add(this.btnReg);
            this.pnlFill.Controls.Add(this.lblReg);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 15);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(339, 358);
            this.pnlFill.TabIndex = 2;
            // 
            // pbxEmail
            // 
            this.pbxEmail.BackgroundImage = global::HyperCargoProject.Properties.Resources.icons8_эл__адрес_30;
            this.pbxEmail.Location = new System.Drawing.Point(51, 217);
            this.pbxEmail.Name = "pbxEmail";
            this.pbxEmail.Size = new System.Drawing.Size(30, 30);
            this.pbxEmail.TabIndex = 11;
            this.pbxEmail.TabStop = false;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Black;
            this.pnlEmail.Location = new System.Drawing.Point(51, 249);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(250, 1);
            this.pnlEmail.TabIndex = 10;
            // 
            // tbxEmailReg
            // 
            this.tbxEmailReg.BackColor = System.Drawing.Color.White;
            this.tbxEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmailReg.ForeColor = System.Drawing.Color.Black;
            this.tbxEmailReg.Location = new System.Drawing.Point(90, 224);
            this.tbxEmailReg.Multiline = true;
            this.tbxEmailReg.Name = "tbxEmailReg";
            this.tbxEmailReg.Size = new System.Drawing.Size(194, 26);
            this.tbxEmailReg.TabIndex = 9;
            this.tbxEmailReg.Text = "alexsonz@yandex.ru";
            this.tbxEmailReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmailReg_KeyPress);
            // 
            // linklblReg
            // 
            this.linklblReg.AutoSize = true;
            this.linklblReg.Location = new System.Drawing.Point(60, 323);
            this.linklblReg.Name = "linklblReg";
            this.linklblReg.Size = new System.Drawing.Size(210, 13);
            this.linklblReg.TabIndex = 8;
            this.linklblReg.TabStop = true;
            this.linklblReg.Text = "Зарегистрированы? Войдите в аккаунт!";
            this.linklblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReg_LinkClicked);
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
            // tbxPasswordReg
            // 
            this.tbxPasswordReg.BackColor = System.Drawing.Color.White;
            this.tbxPasswordReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPasswordReg.ForeColor = System.Drawing.Color.Black;
            this.tbxPasswordReg.Location = new System.Drawing.Point(90, 172);
            this.tbxPasswordReg.Multiline = true;
            this.tbxPasswordReg.Name = "tbxPasswordReg";
            this.tbxPasswordReg.PasswordChar = '*';
            this.tbxPasswordReg.Size = new System.Drawing.Size(194, 26);
            this.tbxPasswordReg.TabIndex = 5;
            this.tbxPasswordReg.Text = "p6ketyup";
            this.tbxPasswordReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPasswordReg_KeyPress);
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
            // tbxLoginReg
            // 
            this.tbxLoginReg.BackColor = System.Drawing.Color.White;
            this.tbxLoginReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLoginReg.ForeColor = System.Drawing.Color.Black;
            this.tbxLoginReg.Location = new System.Drawing.Point(90, 115);
            this.tbxLoginReg.Multiline = true;
            this.tbxLoginReg.Name = "tbxLoginReg";
            this.tbxLoginReg.Size = new System.Drawing.Size(194, 26);
            this.tbxLoginReg.TabIndex = 2;
            this.tbxLoginReg.Text = "alexsonz";
            this.tbxLoginReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLoginReg_KeyPress);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnReg.Image = global::HyperCargoProject.Properties.Resources.icons8_добавить_пользователя_30;
            this.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.Location = new System.Drawing.Point(63, 263);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(221, 44);
            this.btnReg.TabIndex = 1;
            this.btnReg.Text = "Регистация";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReg.Location = new System.Drawing.Point(111, 58);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(110, 21);
            this.lblReg.TabIndex = 0;
            this.lblReg.Text = "Регистрация";
            // 
            // errorProvEmail
            // 
            this.errorProvEmail.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 373);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ГиперГруз / Регистрация";
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.LinkLabel linklblReg;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox tbxPasswordReg;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.Panel pnlLoginReg;
        private System.Windows.Forms.TextBox tbxLoginReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.PictureBox pbxEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox tbxEmailReg;
        private System.Windows.Forms.ErrorProvider errorProvEmail;
    }
}