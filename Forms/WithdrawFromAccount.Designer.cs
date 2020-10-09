namespace AcmeBank.Forms
{
    partial class WithdrawFromAccount
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.lblWithdrawlAmount = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.numWithdrawlAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawlAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(76, 55);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(172, 52);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.tbAccountNumber.TabIndex = 1;
            // 
            // lblWithdrawlAmount
            // 
            this.lblWithdrawlAmount.AutoSize = true;
            this.lblWithdrawlAmount.Location = new System.Drawing.Point(70, 97);
            this.lblWithdrawlAmount.Name = "lblWithdrawlAmount";
            this.lblWithdrawlAmount.Size = new System.Drawing.Size(96, 13);
            this.lblWithdrawlAmount.TabIndex = 3;
            this.lblWithdrawlAmount.Text = "Withdrawl Amount:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(172, 137);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(100, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(136, 185);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numWithdrawlAmount
            // 
            this.numWithdrawlAmount.Location = new System.Drawing.Point(172, 95);
            this.numWithdrawlAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWithdrawlAmount.Name = "numWithdrawlAmount";
            this.numWithdrawlAmount.Size = new System.Drawing.Size(100, 20);
            this.numWithdrawlAmount.TabIndex = 12;
            // 
            // WithdrawFromAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 220);
            this.Controls.Add(this.numWithdrawlAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblWithdrawlAmount);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "WithdrawFromAccount";
            this.Text = "Withdraw";
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawlAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label lblWithdrawlAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numWithdrawlAmount;
    }
}