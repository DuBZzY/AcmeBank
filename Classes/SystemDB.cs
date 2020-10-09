using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AcmeBank.Classes
{
    public sealed class SystemDB
    {
        public List<long> bankAccountIDs { get; } = new List<long>();
        public List<SavingsAccount> savingsAccounts { get; } = new List<SavingsAccount>();
        public List<CurrentAccount> currentAccounts { get; } = new List<CurrentAccount>();

        private SystemDB()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"Data/BankAccounts.xml");
            foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                switch(node.Attributes["AccountType"].InnerText)
                {
                    case "Savings":
                        SavingsAccount savingsAccount = new SavingsAccount();
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            switch (childNode.Name)
                            {
                                case "ID":
                                    savingsAccount.id = Convert.ToInt64(childNode.InnerText);
                                    break;
                                case "CustomerNumber":
                                    savingsAccount.CustomerNumber = childNode.InnerText;
                                    break;
                                case "Balance":
                                    savingsAccount.Balance = Convert.ToInt64(childNode.InnerText);
                                    break;
                            }
                        }

                        savingsAccounts.Add(savingsAccount);
                        bankAccountIDs.Add(savingsAccount.id);
                        break;

                    case "Current":
                        CurrentAccount currentAccount = new CurrentAccount();
                        foreach (XmlNode childNode in node.ChildNodes)
                        {
                            switch (childNode.Name)
                            {
                                case "ID":
                                    currentAccount.id = Convert.ToInt64(childNode.InnerText);
                                    break;
                                case "CustomerNumber":
                                    currentAccount.CustomerNumber = childNode.InnerText;
                                    break;
                                case "Balance":
                                    currentAccount.Balance = Convert.ToInt64(childNode.InnerText);
                                    break;
                                case "OverdraftAmount":
                                    currentAccount.OverdraftAmount = Convert.ToInt64(childNode.InnerText);
                                    break;
                            }
                        }

                        currentAccounts.Add(currentAccount);
                        bankAccountIDs.Add(currentAccount.id);
                        break;
                }
            }
        }

        private static SystemDB dbInstance = null;

        public static SystemDB DBInstance
        {
            get
            {
                if (dbInstance == null)
                {
                    dbInstance = new SystemDB();
                }

                return dbInstance;
            }
        }
    }
}
