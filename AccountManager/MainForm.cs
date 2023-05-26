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
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если логина нет или 
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
                passwordGenerator.DigitsCount = int.Parse(DigitsUpDown.Text);
            }
            else
            {
                DigitsUpDown.ReadOnly = true;
                passwordGenerator.DigitsCount = null;
            }
        }

        private void LengthUpDown_ValueChanged(object sender, EventArgs e)
        {
            passwordGenerator.Length = int.Parse(((NumericUpDown) sender).Text);
        }

        private void SeedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                SeedUpDown.ReadOnly = false;
                passwordGenerator.Seed = int.Parse(SeedUpDown.Text);
            }
            else
            {
                SeedUpDown.ReadOnly = true;
                passwordGenerator.Seed = null;
            }
        }

        private void LettersUpDown_ValueChanged(object sender, EventArgs e)
        {
            passwordGenerator.LettersCount = int.Parse(((NumericUpDown) sender).Text);
        }

        private void DigitsUpDown_ValueChanged(object sender, EventArgs e)
        {
            passwordGenerator.DigitsCount = int.Parse(((NumericUpDown) sender).Text);
        }

        private void SeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            passwordGenerator.Seed = int.Parse(((NumericUpDown) sender).Text);
        }

        private void UpperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordGenerator.UseUpper = ((CheckBox) sender).Checked;
            LettersUpDown.ReadOnly = !(((CheckBox) sender).Checked && LettersCheckBox.Checked);
        }

        private void LowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordGenerator.UseUpper = ((CheckBox) sender).Checked;
            LettersUpDown.ReadOnly = !(((CheckBox) sender).Checked && LettersCheckBox.Checked);
        }

        private void SpecialCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordGenerator.UseUpper = ((CheckBox) sender).Checked;
        }
    }
}