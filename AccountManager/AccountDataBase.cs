using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AccountManager
{
    [Serializable]
    public class AccountDataBase
    {
        // private List<Account> accountList = new List<Account>();
        private Dictionary<string, Account> accountDictionary = new Dictionary<string, Account>(){};

        public void AddAccount(Account account)
        {
            // accountList.Add(account);
            accountDictionary.Add(account.Login, account);
        }

        public List<Account> GetAccountList()
        {
            return accountDictionary == null ? new List<Account>() : accountDictionary.Select(x => x.Value).ToList();
        }

        public Dictionary<string, Account> GetAccountDictionary()
        {
            return accountDictionary;
        }

        public Account GetAccount(int index)
        {
            // return accountList[index];
            return accountDictionary.ElementAt(index).Value;
        }

        public Account GetAccount(string login)
        {
            return accountDictionary[login];
        }

        public void DeleteAccount(string login)
        {
            accountDictionary.Remove(login);
        }

        public bool IsLoginExist(string login)
        {
            // return accountList.Select(x => x.Login == login).ToArray().Length > 0;
            return accountDictionary != null &&
                   accountDictionary.Where(x => x.Value.Login == login).ToArray().Length > 0;
        }

        public void SaveAccounts()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("accounts.dat", FileMode.Create);
            formatter.Serialize(fs, this);
            fs.Close();
        }

        public static AccountDataBase? OpenAccounts()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                FileStream fs = new FileStream("accounts.dat", FileMode.Open);
                AccountDataBase dataBase = (AccountDataBase) formatter.Deserialize(fs);
                if (dataBase.accountDictionary == null)
                    dataBase.accountDictionary = new Dictionary<string, Account>();
                fs.Close();

                // foreach (var pair in dataBase.accountDictionary)
                // {
                //     pair.Value.AccountPermissions = Account.Permissions.Admin;
                // }
                return dataBase;
            }
            catch (SerializationException)
            {
                MessageBox.Show("Файл сохранения повреждён!", "Ошибка файла", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return null;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл сохранения не найден!", "Ошибка файла", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return null;
            }
        }
    }
}