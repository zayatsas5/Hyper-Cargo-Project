namespace HyperCargoProject.Forms
{
    partial class MainForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnCargoHistory = new System.Windows.Forms.Button();
            this.btnCalcCargo = new System.Windows.Forms.Button();
            this.btnPersonalAccount = new System.Windows.Forms.Button();
            this.ucPersonalAccount1 = new HyperCargoProject.UsersControl.ucPersonalAccount();
            this.ucCalculatonCargo1 = new HyperCargoProject.UsersControl.ucCalculatonCargo();
            this.ucCargoHistory1 = new HyperCargoProject.UsersControl.ucCargoHistory();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 15);
            this.pnlTop.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnCargoHistory);
            this.pnlLeft.Controls.Add(this.btnCalcCargo);
            this.pnlLeft.Controls.Add(this.btnPersonalAccount);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 15);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(230, 435);
            this.pnlLeft.TabIndex = 6;
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlFill.Controls.Add(this.ucPersonalAccount1);
            this.pnlFill.Controls.Add(this.ucCalculatonCargo1);
            this.pnlFill.Controls.Add(this.ucCargoHistory1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(230, 15);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(570, 435);
            this.pnlFill.TabIndex = 7;
            // 
            // btnCargoHistory
            // 
            this.btnCargoHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnCargoHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargoHistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargoHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCargoHistory.Image = global::HyperCargoProject.Properties.Resources.icons8_история_заказов_30;
            this.btnCargoHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargoHistory.Location = new System.Drawing.Point(0, 82);
            this.btnCargoHistory.Name = "btnCargoHistory";
            this.btnCargoHistory.Size = new System.Drawing.Size(230, 44);
            this.btnCargoHistory.TabIndex = 4;
            this.btnCargoHistory.Text = "История заказов";
            this.btnCargoHistory.UseVisualStyleBackColor = false;
            this.btnCargoHistory.Click += new System.EventHandler(this.btnCargoHistory_Click);
            // 
            // btnCalcCargo
            // 
            this.btnCalcCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnCalcCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCalcCargo.Image = global::HyperCargoProject.Properties.Resources.icons8_грузовая_машина_30;
            this.btnCalcCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcCargo.Location = new System.Drawing.Point(0, 41);
            this.btnCalcCargo.Name = "btnCalcCargo";
            this.btnCalcCargo.Size = new System.Drawing.Size(230, 44);
            this.btnCalcCargo.TabIndex = 3;
            this.btnCalcCargo.Text = "Расчет грузоперевозки";
            this.btnCalcCargo.UseVisualStyleBackColor = false;
            this.btnCalcCargo.Click += new System.EventHandler(this.btnCalcCargo_Click);
            // 
            // btnPersonalAccount
            // 
            this.btnPersonalAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnPersonalAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalAccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPersonalAccount.Image = global::HyperCargoProject.Properties.Resources.icons8_пользователь_30;
            this.btnPersonalAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalAccount.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalAccount.Name = "btnPersonalAccount";
            this.btnPersonalAccount.Size = new System.Drawing.Size(230, 44);
            this.btnPersonalAccount.TabIndex = 2;
            this.btnPersonalAccount.Text = "Личный кабинет";
            this.btnPersonalAccount.UseVisualStyleBackColor = false;
            this.btnPersonalAccount.Click += new System.EventHandler(this.btnPersonalAccount_Click);
            // 
            // ucPersonalAccount1
            // 
            this.ucPersonalAccount1.BackColor = System.Drawing.Color.White;
            this.ucPersonalAccount1.Location = new System.Drawing.Point(0, 0);
            this.ucPersonalAccount1.Name = "ucPersonalAccount1";
            this.ucPersonalAccount1.Size = new System.Drawing.Size(570, 435);
            this.ucPersonalAccount1.TabIndex = 2;
            // 
            // ucCalculatonCargo1
            // 
            this.ucCalculatonCargo1.BackColor = System.Drawing.Color.White;
            this.ucCalculatonCargo1.Location = new System.Drawing.Point(0, 0);
            this.ucCalculatonCargo1.Name = "ucCalculatonCargo1";
            this.ucCalculatonCargo1.Size = new System.Drawing.Size(570, 435);
            this.ucCalculatonCargo1.TabIndex = 1;
            // 
            // ucCargoHistory1
            // 
            this.ucCargoHistory1.BackColor = System.Drawing.Color.White;
            this.ucCargoHistory1.Location = new System.Drawing.Point(0, 0);
            this.ucCargoHistory1.Name = "ucCargoHistory1";
            this.ucCargoHistory1.Size = new System.Drawing.Size(570, 435);
            this.ucCargoHistory1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlLeft.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnPersonalAccount;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Button btnCalcCargo;
        private System.Windows.Forms.Button btnCargoHistory;
        private UsersControl.ucPersonalAccount ucPersonalAccount1;
        private UsersControl.ucCalculatonCargo ucCalculatonCargo1;
        private UsersControl.ucCargoHistory ucCargoHistory1;
    }
}