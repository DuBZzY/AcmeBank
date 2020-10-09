using AcmeBank.Classes;
using AcmeBank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBank
{
    public partial class MainPortal : Form
    {
        public MainPortal()
        {
            InitializeComponent();
        }

        private void frmMainPortal_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
            Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawFromAccount withdrawFromAccount = new WithdrawFromAccount();
            withdrawFromAccount.Show();
            Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositToAccount depositToAccount = new DepositToAccount();
            depositToAccount.Show();
            Hide();
        }
    }
}
