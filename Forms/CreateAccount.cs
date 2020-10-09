using AcmeBank.Classes;
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
    public partial class CreateAccount : Form
    {
        CurrentAccount currentAccount = new CurrentAccount();
        SavingsAccount savingsAccount = new SavingsAccount();
        int lastAccountID = SystemDB.DBInstance.bankAccountIDs.Count;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            if(inputValidation())
            {
                if (cbxAccountType.SelectedItem == "Current")
                {
                    currentAccount.openCurrentAccount(lastAccountID + 1);
                    lastAccountID++;
                    ClearForm();
                    MessageBox.Show("Current account has been created.");
                }
                else if (cbxAccountType.SelectedItem == "Savings")
                {
                    savingsAccount.openSavingsAccount(lastAccountID + 1, Convert.ToInt64(tbDepositAmount.Text));
                    lastAccountID++;
                    ClearForm();
                    MessageBox.Show("Savings account has been created.");
                }
            }
        }

        private void ClearForm()
        {
            tbDepositAmount.Clear();
            cbxAccountType.SelectedItem = null;
            tbDepositAmount.Visible = false;
            lblDepositAmount.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPortal mainPortal = new MainPortal();
            mainPortal.Show();
            Hide();
        }

        private void cbxAccountType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxAccountType.SelectedItem == "Savings")
            {
                tbDepositAmount.Visible = true;
                lblDepositAmount.Visible = true;
            }
            else if (cbxAccountType.SelectedItem == "Current")
            {
                tbDepositAmount.Visible = false;
                lblDepositAmount.Visible = false;
            }
        }

        private bool inputValidation()
        {
            if(cbxAccountType.SelectedItem == null)
            {
                MessageBox.Show("Please select an account type.", "No Account type selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(cbxAccountType.SelectedItem == "Savings")
            {
                if(tbDepositAmount.Text == "" || Convert.ToInt32(tbDepositAmount.Text) < 1000)
                {
                    MessageBox.Show("Please enter a valid deposit amount.", "Invalid deposit amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}
