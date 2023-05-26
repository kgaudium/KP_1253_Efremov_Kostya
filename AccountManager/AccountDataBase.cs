using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace AccountManager
{
    [Serializable]
    public class AccountDataBase
    {
        private List<Account> accountList = new List<Account>();

        public void AddAccount(Account account)
        {
            accountList.Add(account);
        }

        public List<Account> GetAccountList()
        {
            return accountList;
        }

        public Account GetAccount(int index)
        {
            return accountList[index];
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
                return (AccountDataBase) formatter.Deserialize(fs);
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