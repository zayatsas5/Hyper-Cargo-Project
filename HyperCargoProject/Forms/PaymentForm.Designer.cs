namespace HyperCargoProject.Forms
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnPaymentRub = new System.Windows.Forms.Button();
            this.lblSummRub = new System.Windows.Forms.Label();
            this.tbxSummPay = new System.Windows.Forms.TextBox();
            this.lblSummPay = new System.Windows.Forms.Label();
            this.pnlSummPay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(21, 9);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(96, 21);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "К оплате: 0";
            // 
            // btnPaymentRub
            // 
            this.btnPaymentRub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnPaymentRub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentRub.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPaymentRub.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentRub.Image")));
            this.btnPaymentRub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentRub.Location = new System.Drawing.Point(25, 81);
            this.btnPaymentRub.Name = "btnPaymentRub";
            this.btnPaymentRub.Size = new System.Drawing.Size(250, 44);
            this.btnPaymentRub.TabIndex = 32;
            this.btnPaymentRub.Text = "Оплатить";
            this.btnPaymentRub.UseVisualStyleBackColor = false;
            this.btnPaymentRub.Click += new System.EventHandler(this.btnPaymentRub_Click);
            // 
            // lblSummRub
            // 
            this.lblSummRub.AutoSize = true;
            this.lblSummRub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblSummRub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSummRub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummRub.Location = new System.Drawing.Point(254, 42);
            this.lblSummRub.Name = "lblSummRub";
            this.lblSummRub.Size = new System.Drawing.Size(40, 21);
            this.lblSummRub.TabIndex = 39;
            this.lblSummRub.Text = "руб";
            // 
            // tbxSummPay
            // 
            this.tbxSummPay.BackColor = System.Drawing.Color.White;
            this.tbxSummPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSummPay.ForeColor = System.Drawing.Color.Black;
            this.tbxSummPay.Location = new System.Drawing.Point(81, 42);
            this.tbxSummPay.Multiline = true;
            this.tbxSummPay.Name = "tbxSummPay";
            this.tbxSummPay.Size = new System.Drawing.Size(194, 26);
            this.tbxSummPay.TabIndex = 38;
            // 
            // lblSummPay
            // 
            this.lblSummPay.AutoSize = true;
            this.lblSummPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblSummPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSummPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummPay.Location = new System.Drawing.Point(9, 44);
            this.lblSummPay.Name = "lblSummPay";
            this.lblSummPay.Size = new System.Drawing.Size(75, 21);
            this.lblSummPay.TabIndex = 37;
            this.lblSummPay.Text = "Оплата:";
            // 
            // pnlSummPay
            // 
            this.pnlSummPay.BackColor = System.Drawing.Color.Black;
            this.pnlSummPay.Location = new System.Drawing.Point(13, 73);
            this.pnlSummPay.Name = "pnlSummPay";
            this.pnlSummPay.Size = new System.Drawing.Size(250, 1);
            this.pnlSummPay.TabIndex = 36;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 137);
            this.Controls.Add(this.lblSummRub);
            this.Controls.Add(this.tbxSummPay);
            this.Controls.Add(this.lblSummPay);
            this.Controls.Add(this.pnlSummPay);
            this.Controls.Add(this.btnPaymentRub);
            this.Controls.Add(this.lblPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnPaymentRub;
        private System.Windows.Forms.Label lblSummRub;
        private System.Windows.Forms.TextBox tbxSummPay;
        private System.Windows.Forms.Label lblSummPay;
        private System.Windows.Forms.Panel pnlSummPay;
    }
}