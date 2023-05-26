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
        
        
        public MainForm()
        {
            InitializeComponent();
            passwordGenerator = new PasswordGenerator(AppController.PasswordGeneratorPath);
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
            Account account = new Account(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text, SurnameTextBox.Text, BirthDatePicker.Value);
            AppController.accountDataBase.AddAccount(account);
            UpdateAccountList();
        }

        public void UpdateAccountList()
        {
            AccountListBox.Items.Clear();
            foreach (var acc in AppController.accountDataBase.GetAccountList())
            {
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
            
            Account account = AppController.accountDataBase.GetAccount(AccountListBox.SelectedIndex);

            NameTextBox.Text = account.Name;
            SurnameTextBox.Text = account.Surname;
            BirthDatePicker.Value = account.BirthDate;
            LoginTextBox.Text = account.Login;

            PasswordPanel.Visible = false;
            PasswordHashTextBox.Visible = true;
            PasswordHashTextBox.Text = account.PasswordHash;
            PasswordLabel.Text = "Хэш пароля";
            
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
            
            PasswordTextBox.Clear();
            LettersUpDown.Text = "";
            DigitsUpDown.Text = "";
            LengthUpDown.Text = "";
            SeedUpDown.Text = "";

            LettersCheckBox.Checked = false;
            DigitsCheckBox.Checked = false;
            SeedCheckBox.Checked = false;
            UpperCheckBox.Checked = false;
            LowerCheckBox.Checked = false;
            SpecialCheckBox.Checked = false;

            PasswordPanel.Visible = true;
            PasswordHashTextBox.Visible = false;
        }
    }
}