namespace AcmeBank.Forms
{
    partial class DepositToAccount
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.numDepositAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(173, 139);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(100, 23);
            this.btnDeposit.TabIndex = 9;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(82, 99);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(85, 13);
            this.lblDepositAmount.TabIndex = 8;
            this.lblDepositAmount.Text = "Deposit Amount:";
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(173, 54);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.tbAccountNumber.TabIndex = 6;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(77, 57);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 5;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(139, 185);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numDepositAmount
            // 
            this.numDepositAmount.Location = new System.Drawing.Point(173, 97);
            this.numDepositAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDepositAmount.Name = "numDepositAmount";
            this.numDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.numDepositAmount.TabIndex = 11;
            // 
            // DepositToAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 220);
            this.Controls.Add(this.numDepositAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Name = "DepositToAccount";
            this.Text = "DepositToAccount";
            ((System.ComponentModel.ISupportInitialize)(this.numDepositAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numDepositAmount;
    }
}