﻿using AcmeBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBank.Forms
{
    public partial class WithdrawFromAccount : Form
    {
        CurrentAccount currentAccount = new CurrentAccount();
        SavingsAccount savingsAccount = new SavingsAccount();

        public WithdrawFromAccount()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(inputValidation())
            {
                var isCurrentAccount = SystemDB.DBInstance.currentAccounts.FirstOrDefault(x => x.id == Convert.ToInt64(tbAccountNumber.Text));
                var isSavingsAccount = SystemDB.DBInstance.savingsAccounts.FirstOrDefault(x => x.id == Convert.ToInt64(tbAccountNumber.Text));

                if (isCurrentAccount != null)
                {
                    currentAccount.withdraw(Convert.ToInt64(tbAccountNumber.Text), Convert.ToInt32(numWithdrawlAmount.Value));
                    MessageBox.Show("Withdrawl of " + numWithdrawlAmount.Value + " completed successfully.");
                    ClearForm();
                }
                else if(isSavingsAccount != null)
                {
                    savingsAccount.withdraw(Convert.ToInt64(tbAccountNumber.Text), Convert.ToInt32(numWithdrawlAmount.Value));
                    MessageBox.Show("Withdrawl of " + numWithdrawlAmount.Value + " completed successfully.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Account number not found.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new AccountNotFoundException(Convert.ToInt64(tbAccountNumber.Text));
                }
            }
        }

        private void ClearForm()
        {
            tbAccountNumber.Clear();
            numWithdrawlAmount.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPortal mainPortal = new MainPortal();
            mainPortal.Show();
            Hide();
        }

        private bool inputValidation()
        {
            if (tbAccountNumber.Text == "")
            {
                MessageBox.Show("Please enter a valid account number.", "Invalid account number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
