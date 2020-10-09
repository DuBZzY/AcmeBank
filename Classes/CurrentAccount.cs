using AcmeBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcmeBank.Classes
{
    public class CurrentAccount : AccountService
    {
        const int maximumOverdraft = 100000;

        private long _id;
        private string _customerNumber;
        private long _balance;
        private long _overdraftAmount;
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

        public long OverdraftAmount
        {
            get
            {
                return _overdraftAmount;
            }

            set
            {
                _overdraftAmount = value;
            }
        }

        public void openSavingsAccount(long accountId, long amountToDeposit)
        {

        }

        public void openCurrentAccount(long accountId)
        {
            CurrentAccount currentAccount = new CurrentAccount();
            currentAccount.id = accountId;
            currentAccount.CustomerNumber = accountId.ToString();
            currentAccount.OverdraftAmount = 0;
            currentAccount.Balance = 0;

            SystemDB.DBInstance.currentAccounts.Add(currentAccount);
            bankAccount.SaveBankAccount();
        }

        public void withdraw(long accountId, int amountToWithdraw)
        {
            var accountVerification = SystemDB.DBInstance.currentAccounts.FirstOrDefault(x => x.CustomerNumber == accountId.ToString());
            if (accountVerification == null)
            {
                MessageBox.Show("Account number not found.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new AccountNotFoundException(accountId);
            }

            foreach (CurrentAccount currentAccount in SystemDB.DBInstance.currentAccounts)
            {
                long newBalance;
                if (currentAccount.id == accountId)
                {
                    newBalance = currentAccount.Balance - amountToWithdraw;

                    if (newBalance < 0)
                    {
                        if (newBalance < (0 - currentAccount.OverdraftAmount))
                        {
                            MessageBox.Show("Withdrawl amount exceeds current balance or limit.", "Invalid Withdrawl Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw new WithdrawalAmountTooLargeException(amountToWithdraw);
                        }
                    }

                    currentAccount.Balance = newBalance;
                    bankAccount.SaveBankAccount();
                    break;
                }
            }
        }

        public void deposit(long accountId, int amountToDeposit)
        {
            var accountVerification = SystemDB.DBInstance.currentAccounts.FirstOrDefault(x => x.CustomerNumber == accountId.ToString());
            if (accountVerification == null)
            {
                MessageBox.Show("Account number not found.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new AccountNotFoundException(accountId);
            }

            foreach (CurrentAccount currentAccount in SystemDB.DBInstance.currentAccounts)
            {
                if (currentAccount.id == accountId)
                {
                    currentAccount.Balance = currentAccount.Balance + amountToDeposit;

                    bankAccount.SaveBankAccount();
                    break;
                }
            }
        }
    }
}
