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

        public string PasswordHash { get; private set; }

        public string Name { get;  set; }
        public string Surname { get;  set; }

        public DateTime BirthDate { get;  set; }

        public int Age
        {
            get {
                TimeSpan age = DateTime.Now - BirthDate;
                return (int)(age.TotalDays / 365);
            }
        }

        public Permissions AccountPermissions;
        
        [Flags]
        public enum Permissions
        {
            None = 0,
            ViewUsers = 1,
            ViewAdmins = 2,
            EditSelf = 4,
            EditOther = 8,
            DeleteUsers = 16,

            Guest = ViewUsers,
            CommonUser = ViewAdmins | ViewUsers,
            ExtendedUser = CommonUser | EditSelf,
            Moderator = ExtendedUser | EditOther,
            Admin = Moderator | DeleteUsers
        }

        public Account()
        {
            Login = "";
            PasswordHash = "";
            Name = "Guest";
            Surname = "";
            BirthDate = default(DateTime);
            AccountPermissions = Permissions.Guest;
        }

        public Account(string login, string password, string name, string surname, DateTime birthDate, Permissions permissions)
        {
            Login = login;
            PasswordHash = password.ToSHA256();
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            AccountPermissions = permissions;
        }

        public override string ToString()
        {
            return $"{Login} ({Name} {Surname}) - {AccountPermissions.ToString().Substring(0,1)}";
        }

        public void ChangePassword(string newPassword)
        {
            PasswordHash = newPassword.ToSHA256();
        }
        
    }
}