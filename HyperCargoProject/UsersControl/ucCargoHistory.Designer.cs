namespace HyperCargoProject.UsersControl
{
    partial class ucCargoHistory
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCargoHistory
            // 
            this.lblCargoHistory.AutoSize = true;
            this.lblCargoHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(213)))), ((int)(((byte)(200)))));
            this.lblCargoHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCargoHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCargoHistory.Location = new System.Drawing.Point(35, 25);
            this.lblCargoHistory.Name = "lblCargoHistory";
            this.lblCargoHistory.Size = new System.Drawing.Size(141, 21);
            this.lblCargoHistory.TabIndex = 21;
            this.lblCargoHistory.Text = "История заказов";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(39, 71);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(498, 302);
            this.pnlMain.TabIndex = 22;
            // 
            // ucCargoHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblCargoHistory);
            this.Name = "ucCargoHistory";
            this.Size = new System.Drawing.Size(570, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargoHistory;
        private System.Windows.Forms.Panel pnlMain;
    }
}
