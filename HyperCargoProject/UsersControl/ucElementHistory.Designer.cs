namespace HyperCargoProject.UsersControl
{
    partial class ucElementHistory
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
            this.lblCargoHistory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCargoHistory
            // 
            this.lblCargoHistory.AutoSize = true;
            this.lblCargoHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblCargoHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargoHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCargoHistory.Location = new System.Drawing.Point(16, 9);
            this.lblCargoHistory.Name = "lblCargoHistory";
            this.lblCargoHistory.Size = new System.Drawing.Size(56, 21);
            this.lblCargoHistory.TabIndex = 21;
            this.lblCargoHistory.Text = "Заказ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 52);
            this.panel1.TabIndex = 22;
            // 
            // ucElementHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCargoHistory);
            this.Name = "ucElementHistory";
            this.Size = new System.Drawing.Size(498, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargoHistory;
        private System.Windows.Forms.Panel panel1;
    }
}
