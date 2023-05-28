using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    public partial class MainForm : Form
    {
        private PasswordGenerator passwordGenerator;
        private Account selectedAccount;
        private Account currentUser;
        
        public MainForm(Account loggedInAccount)
        {
            InitializeComponent();
            passwordGenerator = new PasswordGenerator(AppController.PasswordGeneratorPath);
            currentUser = loggedInAccount;

            if (!currentUser.AccountPermissions.HasFlag(Account.Permissions.EditSelf) &&
                !currentUser.AccountPermissions.HasFlag(Account.Permissions.EditOther))
            {
                AddButton.Visible = false;
                ApplyButton.Visible = false;
                // DeleteButton.Visible = false;
                SaveButton.Visible = false;
                PasswordPanel.Visible = false;

                if (currentUser.AccountPermissions != Account.Permissions.Guest)
                {
                    PasswordLabel.Visible = true;
                    PasswordLabel.Text = "Хэш пароля";
                    PasswordHashTextBox.Visible = true;
                }

                ChangeFieldsReadOnlyState(true);
            }

            if (!currentUser.AccountPermissions.HasFlag(Account.Permissions.DeleteUsers))
            {
                DeleteButton.Visible = false;
            }
            
            if (currentUser.AccountPermissions != Account.Permissions.Guest)
            {
                PasswordLabel.Visible = true;
            }
            
            LoginTextBox.Visible = currentUser.AccountPermissions != Account.Permissions.Guest;
            LoginLabel.Visible = currentUser.AccountPermissions != Account.Permissions.Guest;

            AccountTypeComboBox.Items.Add(Account.Permissions.CommonUser.ToString());
            AccountTypeComboBox.Items.Add(Account.Permissions.ExtendedUser.ToString());
            AccountTypeComboBox.Items.Add(Account.Permissions.Moderator.ToString());
            AccountTypeComboBox.Items.Add(Account.Permissions.Admin.ToString());
            
            UpdateAccountList();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // if (LoginTextBox.Text.Length == 0 || AccountUtils.TransliterateRussian(((TextBox) sender).Text).Contains(LoginTextBox.Text))
            LoginTextBox.Text = AccountUtils.TransliterateRussian(((TextBox) sender).Text);
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 127)
            {
                ((TextBox)sender).Text = "";
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !e.KeyChar.IsRussianLetter())
            {
                SystemSounds.Exclamation.Play();  
                e.Handled = true;
            }
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 127)
            {
                ((TextBox)sender).Text = "";
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !e.KeyChar.IsAllowedLoginSymbol())
            {
                SystemSounds.Exclamation.Play();  
                e.Handled = true;
            }
        }
        
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            passwordGenerator.DigitsCount = DigitsUpDown.ReadOnly ? null : int.Parse(DigitsUpDown.Text);
            passwordGenerator.LettersCount = LettersUpDown.ReadOnly ? null : int.Parse(LettersUpDown.Text);
            passwordGenerator.Length = int.Parse(LengthUpDown.Text);
            passwordGenerator.Seed = SeedUpDown.ReadOnly ? null : int.Parse(SeedUpDown.Text);
            passwordGenerator.UseUpper = UpperCheckBox.Checked;
            passwordGenerator.UseLower = LowerCheckBox.Checked;
            passwordGenerator.UseSpecial = SpecialCheckBox.Checked;
            
            PasswordTextBox.Text = passwordGenerator.Generate();
        }

        private void LettersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LettersUpDown.ReadOnly = !(((CheckBox) sender).Checked && (UpperCheckBox.Checked || LowerCheckBox.Checked));
            passwordGenerator.LettersCount = ((CheckBox) sender).Checked ? Int32.Parse(LettersUpDown.Text) : null;
        }

        private void DigitsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                DigitsUpDown.ReadOnly = false;
            }
            else
            {
                DigitsUpDown.ReadOnly = true;
            }
        }

        private void SeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                SeedUpDown.ReadOnly = false;
            }
            else
            {
                SeedUpDown.ReadOnly = true;
            }
        }

        private void UpperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LettersUpDown.ReadOnly = !(((CheckBox) sender).Checked && LettersCheckBox.Checked);
        }

        private void LowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LettersUpDown.ReadOnly = !(((CheckBox) sender).Checked && LettersCheckBox.Checked);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AppController.accountDataBase.IsLoginExist(LoginTextBox.Text))
            {
                MessageBox.Show("Пользователь с таким лоигном уже существует!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            if (AccountTypeComboBox.Text == "" || LoginTextBox.Text == "" || NameTextBox.Text == "" ||
                SurnameTextBox.Text == "")
            {
                MessageBox.Show("Заданы не все значения!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }
            
            Account account = new Account(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text, SurnameTextBox.Text, 
                BirthDatePicker.Value, (Account.Permissions)Enum.Parse(typeof(Account.Permissions), AccountTypeComboBox.Text));
            AppController.accountDataBase.AddAccount(account);
            UpdateAccountList();
        }

        public void UpdateAccountList()
        {
            AccountListBox.Items.Clear();
            foreach (var acc in AppController.accountDataBase.GetAccountList())
            {
                if (currentUser.AccountPermissions.HasFlag(Account.Permissions.ViewUsers) && acc.AccountPermissions != Account.Permissions.Admin ||
                    currentUser.AccountPermissions.HasFlag(Account.Permissions.ViewAdmins))
                    AccountListBox.Items.Add(acc.ToString());
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AppController.accountDataBase.SaveAccounts();
        }

        private void AccountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AccountListBox.SelectedIndex < 0)
                return;
            
            selectedAccount = GetSelectedAccount();

            ShowAccountData(selectedAccount,
                (selectedAccount == currentUser
                    ? !currentUser.AccountPermissions.HasFlag(Account.Permissions.EditSelf)
                    : !currentUser.AccountPermissions.HasFlag(Account.Permissions.EditOther)) 
                    || currentUser.AccountPermissions == Account.Permissions.Guest);
        }

        private void ResetSelectionButton_Click(object sender, EventArgs e)
        {
            AccountListBox.ClearSelected();
            PasswordLabel.Text = "Пароль";
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            BirthDatePicker.Value = DateTime.Today;
            LoginTextBox.Clear();
            PasswordHashTextBox.Clear();
            AccountTypeComboBox.Text = "";
            
            PasswordTextBox.Clear();
            LettersUpDown.Text = "0";
            DigitsUpDown.Text = "0";
            LengthUpDown.Text = "0";
            SeedUpDown.Text = "0";

            LettersCheckBox.Checked = false;
            DigitsCheckBox.Checked = false;
            SeedCheckBox.Checked = false;
            UpperCheckBox.Checked = false;
            LowerCheckBox.Checked = false;
            SpecialCheckBox.Checked = false;

            PasswordPanel.Visible = true;
            PasswordHashTextBox.Visible = false;
            NewPasswordTextBox.Visible = false;
            ChangePasswordButton.Visible = false;
            
            LoginTextBox.ReadOnly = false;
            NameTextBox.ReadOnly = false;
            SurnameTextBox.ReadOnly = false;
            BirthDatePicker.Enabled = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppController.loginForm.Location = Location;
            AppController.loginForm.Show();
            Dispose();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            AppController.loginForm.Location = Location;
            AppController.loginForm.Show();
            Dispose();
        }

        private void ShowAccountData(Account account, bool readOnly)
        {
            NameTextBox.Text = account.Name;
            SurnameTextBox.Text = account.Surname;
            BirthDatePicker.Value = account.BirthDate;
            AccountTypeComboBox.Text = account.AccountPermissions.ToString();

            PasswordPanel.Visible = false;
            if (currentUser.AccountPermissions != Account.Permissions.Guest)
            {
                LoginTextBox.Text = account.Login;
                PasswordHashTextBox.Visible = true;
                PasswordHashTextBox.Text = account.PasswordHash;
                PasswordLabel.Text = "Хэш пароля";
            }

            bool canChangePassword = currentUser.AccountPermissions.HasFlag(Account.Permissions.EditOther) ||
                                     account == currentUser &&
                                     currentUser.AccountPermissions.HasFlag(Account.Permissions.EditSelf);

            ChangePasswordButton.Visible = canChangePassword;
            NewPasswordTextBox.Visible = canChangePassword;
            

            ChangeFieldsReadOnlyState(readOnly);
        }

        private void ChangeFieldsReadOnlyState(bool readOnly)
        {
            LoginTextBox.ReadOnly = true;
            NameTextBox.ReadOnly = readOnly;
            SurnameTextBox.ReadOnly = readOnly;
            AccountTypeComboBox.Enabled = !readOnly;
            BirthDatePicker.Enabled = !readOnly;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AccountListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Пользователь не выбран!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            selectedAccount = GetSelectedAccount();
            AppController.accountDataBase.DeleteAccount(selectedAccount.Login);
            UpdateAccountList();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (AccountListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Пользователь не выбран!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            selectedAccount = GetSelectedAccount();
            
            selectedAccount.Name = NameTextBox.Text;
            selectedAccount.Surname = SurnameTextBox.Text;
            selectedAccount.BirthDate = BirthDatePicker.Value;
            selectedAccount.AccountPermissions =
                (Account.Permissions) Enum.Parse(typeof(Account.Permissions), AccountTypeComboBox.Text);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            GetSelectedAccount().ChangePassword(NewPasswordTextBox.Text);
            PasswordHashTextBox.Text = GetSelectedAccount().PasswordHash;
        }

        private Account GetSelectedAccount()
        {
            return AppController.accountDataBase.GetAccount(AccountListBox.Text.Split(' ')[0]);
        }
    }
}