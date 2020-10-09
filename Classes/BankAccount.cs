using AcmeBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AcmeBank.Classes
{
    public class BankAccount
    {
        public void SaveBankAccount()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("BankAccounts");
            xmlDoc.AppendChild(rootNode);

            foreach (SavingsAccount savingsAccount in SystemDB.DBInstance.savingsAccounts)
            {
                XmlNode bankAccountNode = xmlDoc.CreateElement("BankAccount");
                rootNode.AppendChild(bankAccountNode);

                XmlAttribute attribute = xmlDoc.CreateAttribute("AccountType");
                attribute.Value = "Savings";
                bankAccountNode.Attributes.Append(attribute);

                XmlNode id = xmlDoc.CreateElement("ID");
                id.InnerText = savingsAccount.id.ToString();
                bankAccountNode.AppendChild(id);

                XmlNode customerNumber = xmlDoc.CreateElement("CustomerNumber");
                customerNumber.InnerText = savingsAccount.CustomerNumber;
                bankAccountNode.AppendChild(customerNumber);

                XmlNode balance = xmlDoc.CreateElement("Balance");
                balance.InnerText = savingsAccount.Balance.ToString();
                bankAccountNode.AppendChild(balance);
            }

            foreach (CurrentAccount currentAccount in SystemDB.DBInstance.currentAccounts)
            {
                XmlNode bankAccountNode = xmlDoc.CreateElement("BankAccount");
                rootNode.AppendChild(bankAccountNode);

                XmlAttribute attribute = xmlDoc.CreateAttribute("AccountType");
                attribute.Value = "Current";
                bankAccountNode.Attributes.Append(attribute);

                XmlNode id = xmlDoc.CreateElement("ID");
                id.InnerText = currentAccount.id.ToString();
                bankAccountNode.AppendChild(id);

                XmlNode customerNumber = xmlDoc.CreateElement("CustomerNumber");
                customerNumber.InnerText = currentAccount.CustomerNumber;
                bankAccountNode.AppendChild(customerNumber);

                XmlNode balance = xmlDoc.CreateElement("Balance");
                balance.InnerText = currentAccount.Balance.ToString();
                bankAccountNode.AppendChild(balance);

                XmlNode overdraftAmount = xmlDoc.CreateElement("OverdraftAmount");
                overdraftAmount.InnerText = currentAccount.OverdraftAmount.ToString();
                bankAccountNode.AppendChild(overdraftAmount);
            }

            xmlDoc.Save(@"Data/BankAccounts.xml");
        }
    }

    class AccountNotFoundException: Exception
    {
        public AccountNotFoundException(long accountID)
        : base(String.Format("Account number: {0} not found", accountID))
        {

        }
    }

    class WithdrawalAmountTooLargeException : Exception
    {
        public WithdrawalAmountTooLargeException(long balance)
        : base(String.Format("Withdrawl amount: {0} exceeds current balance or limit.", balance))
        {

        }
    }

    class DepositAmountNotSufficientException : Exception
    {
        public DepositAmountNotSufficientException(long balance)
        : base(String.Format("Deposit amount: {0} is not sufficient to open a savings account. Atleast 1000 is required.", balance))
        {

        }
    }
}
