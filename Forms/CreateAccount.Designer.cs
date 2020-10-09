namespace AcmeBank.Forms
{
    partial class CreateAccount
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
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cbxAccountType = new System.Windows.Forms.ComboBox();
            this.tbDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(68, 37);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(77, 13);
            this.lblAccountType.TabIndex = 1;
            this.lblAccountType.Text = "Account Type:";
            // 
            // cbxAccountType
            // 
            this.cbxAccountType.FormattingEnabled = true;
            this.cbxAccountType.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.cbxAccountType.Location = new System.Drawing.Point(151, 35);
            this.cbxAccountType.Name = "cbxAccountType";
            this.cbxAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbxAccountType.TabIndex = 2;
            this.cbxAccountType.SelectedValueChanged += new System.EventHandler(this.cbxAccountType_SelectedValueChanged);
            // 
            // tbDepositAmount
            // 
            this.tbDepositAmount.Location = new System.Drawing.Point(151, 70);
            this.tbDepositAmount.Name = "tbDepositAmount";
            this.tbDepositAmount.Size = new System.Drawing.Size(121, 20);
            this.tbDepositAmount.TabIndex = 3;
            this.tbDepositAmount.Visible = false;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(60, 73);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(85, 13);
            this.lblDepositAmount.TabIndex = 4;
            this.lblDepositAmount.Text = "Deposit Amount:";
            this.lblDepositAmount.Visible = false;
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.Location = new System.Drawing.Point(151, 106);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(121, 23);
            this.btnRegisterAccount.TabIndex = 7;
            this.btnRegisterAccount.Text = "Register Account";
            this.btnRegisterAccount.UseVisualStyleBackColor = true;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(136, 157);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 192);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegisterAccount);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.tbDepositAmount);
            this.Controls.Add(this.cbxAccountType);
            this.Controls.Add(this.lblAccountType);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cbxAccountType;
        private System.Windows.Forms.TextBox tbDepositAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Button btnRegisterAccount;
        private System.Windows.Forms.Button btnBack;
    }
}