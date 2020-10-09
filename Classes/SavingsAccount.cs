using AcmeBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBank.Classes
{
    public class SavingsAccount : AccountService
    {
        const int minimumBalance = 1000;

        private long _id;
        private string _customerNumber;
        private long _balance;
        private BankAccount bankAccount = new BankAccount();


        public long id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string CustomerNumber
        {
            get
            {
                return _customerNumber;
            }

            set
            {
                _customerNumber = value;
            }
        }

        public long Balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }

        public void openSavingsAccount(long accountId, long amountToDeposit)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.id = accountId;
            savingsAccount.CustomerNumber = accountId.ToString();

            if (amountToDeposit < minimumBalance)
            {
                MessageBox.Show("Deposit amount is not sufficient to open a savings account. Atleast 1000 is required.", "Invalid Deposit Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new DepositAmountNotSufficientException(amountToDeposit);
            }
            else
            {
                savingsAccount.Balance = amountToDeposit;
            }

            SystemDB.DBInstance.savingsAccounts.Add(savingsAccount);
            bankAccount.SaveBankAccount();
        }

        public void openCurrentAccount(long accountId)
        {

        }

        public void withdraw(long accountId, int amountToWithdraw)
        {
            var accountVerification = SystemDB.DBInstance.savingsAccounts.FirstOrDefault(x => x.CustomerNumber == accountId.ToString());
            if (accountVerification == null)
            {
                MessageBox.Show("Account number not found.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new AccountNotFoundException(accountId);
            }

            foreach (SavingsAccount savingsAccount in SystemDB.DBInstance.savingsAccounts)
            {
                long newBalance;
                if (savingsAccount.id == accountId)
                {
                    newBalance = savingsAccount.Balance - amountToWithdraw;
                    if (newBalance < 1000)
                    {
                        MessageBox.Show("Withdrawl amount exceeds current balance or limit.", "Invalid Withdrawl Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new WithdrawalAmountTooLargeException(amountToWithdraw);
                    }

                    savingsAccount.Balance = newBalance;
                    bankAccount.SaveBankAccount();
                    break;
                }
            }
        }

        public void deposit(long accountId, int amountToDeposit)
        {
            var accountVerification = SystemDB.DBInstance.savingsAccounts.FirstOrDefault(x => x.CustomerNumber == accountId.ToString());
            if (accountVerification == null)
            {
                MessageBox.Show("Account number not found.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new AccountNotFoundException(accountId);
            }

            foreach (SavingsAccount savingsAccount in SystemDB.DBInstance.savingsAccounts)
            {
                if (savingsAccount.id == accountId)
                {
                    savingsAccount.Balance = savingsAccount.Balance + amountToDeposit;

                    bankAccount.SaveBankAccount();
                    break;
                }
            }
        }
    }
}
