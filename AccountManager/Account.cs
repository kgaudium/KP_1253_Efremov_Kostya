

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace AccountManager
{
    [Serializable]
    public class Account
    {
        private string login;
        public string Login
        {
            get => login;
            set
            {
                foreach (var symb in value)
                {
                    if (!symb.IsAllowedLoginSymbol())
                    {
                        throw new Exception($"You cannot use {symb} symbol in Login!");
                    }
                }

                login = value;
            }
        }

        private string passwordHash;

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public DateTime BirthDate { get; private set; }

        public int Age
        {
            get {
                TimeSpan age = DateTime.Now - BirthDate;
                return (int)(age.TotalDays / 365);
            }
        }

        public Account(string login, string password, string name, string surname, DateTime birthDate)
        {
            Login = login;
            passwordHash = password.ToSHA256();
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }
    }
}