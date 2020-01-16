namespace HyperCargoProject.UsersControl
{
    partial class ucCalculatonCargo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTransportCargo = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.pnlHeight = new System.Windows.Forms.Panel();
            this.pnlWidth = new System.Windows.Forms.Panel();
            this.pnlLength = new System.Windows.Forms.Panel();
            this.lblLengthUnit = new System.Windows.Forms.Label();
            this.lblWidthUnit = new System.Windows.Forms.Label();
            this.lblHeightUnit = new System.Windows.Forms.Label();
            this.pblFrom = new System.Windows.Forms.Panel();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCalculationCargo = new System.Windows.Forms.Button();
            this.lblCashPersAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTransportCargo
            // 
            this.lblTransportCargo.AutoSize = true;
            this.lblTransportCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblTransportCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransportCargo.ForeColor = System.Drawing.Color.White;
            this.lblTransportCargo.Location = new System.Drawing.Point(36, 30);
            this.lblTransportCargo.Name = "lblTransportCargo";
            this.lblTransportCargo.Size = new System.Drawing.Size(192, 21);
            this.lblTransportCargo.TabIndex = 3;
            this.lblTransportCargo.Text = "Расчет грузоперевозки";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLength.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLength.Location = new System.Drawing.Point(13, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(66, 21);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Длина:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWidth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidth.Location = new System.Drawing.Point(13, 117);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(82, 21);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Ширина:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeight.Location = new System.Drawing.Point(13, 163);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(71, 21);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Высота:";
            // 
            // tbxLength
            // 
            this.tbxLength.BackColor = System.Drawing.Color.White;
            this.tbxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLength.ForeColor = System.Drawing.Color.Black;
            this.tbxLength.Location = new System.Drawing.Point(85, 76);
            this.tbxLength.Multiline = true;
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(194, 26);
            this.tbxLength.TabIndex = 13;
            this.tbxLength.Text = "2";
            // 
            // tbxWidth
            // 
            this.tbxWidth.BackColor = System.Drawing.Color.White;
            this.tbxWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxWidth.ForeColor = System.Drawing.Color.Black;
            this.tbxWidth.Location = new System.Drawing.Point(101, 120);
            this.tbxWidth.Multiline = true;
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(194, 26);
            this.tbxWidth.TabIndex = 14;
            this.tbxWidth.Text = "2";
            // 
            // tbxHeight
            // 
            this.tbxHeight.BackColor = System.Drawing.Color.White;
            this.tbxHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHeight.ForeColor = System.Drawing.Color.Black;
            this.tbxHeight.Location = new System.Drawing.Point(90, 166);
            this.tbxHeight.Multiline = true;
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(194, 26);
            this.tbxHeight.TabIndex = 15;
            this.tbxHeight.Text = "1";
            // 
            // pnlHeight
            // 
            this.pnlHeight.BackColor = System.Drawing.Color.Black;
            this.pnlHeight.Location = new System.Drawing.Point(17, 190);
            this.pnlHeight.Name = "pnlHeight";
            this.pnlHeight.Size = new System.Drawing.Size(250, 1);
            this.pnlHeight.TabIndex = 16;
            // 
            // pnlWidth
            // 
            this.pnlWidth.BackColor = System.Drawing.Color.Black;
            this.pnlWidth.Location = new System.Drawing.Point(12, 144);
            this.pnlWidth.Name = "pnlWidth";
            this.pnlWidth.Size = new System.Drawing.Size(250, 1);
            this.pnlWidth.TabIndex = 17;
            // 
            // pnlLength
            // 
            this.pnlLength.BackColor = System.Drawing.Color.Black;
            this.pnlLength.Location = new System.Drawing.Point(12, 99);
            this.pnlLength.Name = "pnlLength";
            this.pnlLength.Size = new System.Drawing.Size(250, 1);
            this.pnlLength.TabIndex = 18;
            // 
            // lblLengthUnit
            // 
            this.lblLengthUnit.AutoSize = true;
            this.lblLengthUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblLengthUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLengthUnit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLengthUnit.Location = new System.Drawing.Point(271, 72);
            this.lblLengthUnit.Name = "lblLengthUnit";
            this.lblLengthUnit.Size = new System.Drawing.Size(24, 21);
            this.lblLengthUnit.TabIndex = 21;
            this.lblLengthUnit.Text = "м";
            // 
            // lblWidthUnit
            // 
            this.lblWidthUnit.AutoSize = true;
            this.lblWidthUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblWidthUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWidthUnit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWidthUnit.Location = new System.Drawing.Point(271, 117);
            this.lblWidthUnit.Name = "lblWidthUnit";
            this.lblWidthUnit.Size = new System.Drawing.Size(24, 21);
            this.lblWidthUnit.TabIndex = 22;
            this.lblWidthUnit.Text = "м";
            // 
            // lblHeightUnit
            // 
            this.lblHeightUnit.AutoSize = true;
            this.lblHeightUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblHeightUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHeightUnit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeightUnit.Location = new System.Drawing.Point(271, 163);
            this.lblHeightUnit.Name = "lblHeightUnit";
            this.lblHeightUnit.Size = new System.Drawing.Size(24, 21);
            this.lblHeightUnit.TabIndex = 23;
            this.lblHeightUnit.Text = "м";
            // 
            // pblFrom
            // 
            this.pblFrom.BackColor = System.Drawing.Color.Black;
            this.pblFrom.Location = new System.Drawing.Point(17, 233);
            this.pblFrom.Name = "pblFrom";
            this.pblFrom.Size = new System.Drawing.Size(250, 1);
            this.pblFrom.TabIndex = 26;
            // 
            // tbxFrom
            // 
            this.tbxFrom.BackColor = System.Drawing.Color.White;
            this.tbxFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFrom.ForeColor = System.Drawing.Color.Black;
            this.tbxFrom.Location = new System.Drawing.Point(90, 209);
            this.tbxFrom.Multiline = true;
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(194, 26);
            this.tbxFrom.TabIndex = 25;
            this.tbxFrom.Text = "Казань";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(13, 206);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(70, 21);
            this.lblFrom.TabIndex = 24;
            this.lblFrom.Text = "Откуда:";
            // 
            // pnlTo
            // 
            this.pnlTo.BackColor = System.Drawing.Color.Black;
            this.pnlTo.Location = new System.Drawing.Point(17, 272);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(250, 1);
            this.pnlTo.TabIndex = 29;
            // 
            // tbxTo
            // 
            this.tbxTo.BackColor = System.Drawing.Color.White;
            this.tbxTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTo.ForeColor = System.Drawing.Color.Black;
            this.tbxTo.Location = new System.Drawing.Point(90, 249);
            this.tbxTo.Multiline = true;
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(194, 26);
            this.tbxTo.TabIndex = 28;
            this.tbxTo.Text = "Москва";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTo.Location = new System.Drawing.Point(13, 245);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(51, 21);
            this.lblTo.TabIndex = 27;
            this.lblTo.Text = "Куда:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(318, 70);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 21);
            this.lblPrice.TabIndex = 30;
            this.lblPrice.Text = "К оплате: 0";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPayment.Image = global::HyperCargoProject.Properties.Resources.icons8_наличные_30;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(317, 94);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(250, 44);
            this.btnPayment.TabIndex = 31;
            this.btnPayment.Text = "Оплатить";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCalculationCargo
            // 
            this.btnCalculationCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.btnCalculationCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculationCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculationCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnCalculationCargo.Image = global::HyperCargoProject.Properties.Resources.icons8_бумажник_30;
            this.btnCalculationCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculationCargo.Location = new System.Drawing.Point(17, 279);
            this.btnCalculationCargo.Name = "btnCalculationCargo";
            this.btnCalculationCargo.Size = new System.Drawing.Size(250, 44);
            this.btnCalculationCargo.TabIndex = 20;
            this.btnCalculationCargo.Text = "Расчитать перевозку";
            this.btnCalculationCargo.UseVisualStyleBackColor = false;
            this.btnCalculationCargo.Click += new System.EventHandler(this.btnCalculationCargo_Click);
            // 
            // lblCashPersAcc
            // 
            this.lblCashPersAcc.AutoSize = true;
            this.lblCashPersAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblCashPersAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCashPersAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCashPersAcc.Location = new System.Drawing.Point(347, 30);
            this.lblCashPersAcc.Name = "lblCashPersAcc";
            this.lblCashPersAcc.Size = new System.Drawing.Size(130, 21);
            this.lblCashPersAcc.TabIndex = 32;
            this.lblCashPersAcc.Text = "lblCashPersAcc";
            // 
            // ucCalculatonCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCashPersAcc);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.pblFrom);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblHeightUnit);
            this.Controls.Add(this.lblWidthUnit);
            this.Controls.Add(this.lblLengthUnit);
            this.Controls.Add(this.btnCalculationCargo);
            this.Controls.Add(this.pnlLength);
            this.Controls.Add(this.pnlWidth);
            this.Controls.Add(this.pnlHeight);
            this.Controls.Add(this.tbxHeight);
            this.Controls.Add(this.tbxWidth);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblTransportCargo);
            this.Name = "ucCalculatonCargo";
            this.Size = new System.Drawing.Size(570, 435);
            this.Load += new System.EventHandler(this.ucCalculatonCargo_Load);
            this.MouseLeave += new System.EventHandler(this.ucCalculatonCargo_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransportCargo;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Panel pnlHeight;
        private System.Windows.Forms.Panel pnlWidth;
        private System.Windows.Forms.Panel pnlLength;
        private System.Windows.Forms.Button btnCalculationCargo;
        private System.Windows.Forms.Label lblLengthUnit;
        private System.Windows.Forms.Label lblWidthUnit;
        private System.Windows.Forms.Label lblHeightUnit;
        private System.Windows.Forms.Panel pblFrom;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label lblTo;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblCashPersAcc;
    }
}
