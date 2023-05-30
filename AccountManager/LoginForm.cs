using System;
using System.Windows.Forms;

namespace AccountManager;

public partial class LoginForm : Form
{
    private bool hidePassword = true;
    
    public LoginForm()
    {
        InitializeComponent();
        PasswordTextBox.UseSystemPasswordChar = hidePassword;
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        if (LoginTextBox.Text == "")
        {
            ErrorLabel.Text = "Введите логин!";
            return;
        }

        if (PasswordTextBox.Text == "")
        {
            ErrorLabel.Text = "Введите пароль!";
            return;
        }

        if (AppController.accountDataBase.IsLoginExist(LoginTextBox.Text) &&
            AppController.accountDataBase.GetAccount(LoginTextBox.Text).PasswordHash == PasswordTextBox.Text.ToSHA256())
        {
            Hide();
            if (AppController.mainForm == null || AppController.mainForm.IsDisposed)
            {
                AppController.mainForm = new MainForm(AppController.accountDataBase.GetAccount(LoginTextBox.Text));
            }
            AppController.mainForm.Location = Location;
            AppController.mainForm.Show();
            ClearAllFields();
            // AppController.loginForm.Dispose();
        }
        else
        {
            ErrorLabel.Text = "Неверный логин или пароль!";
            return;
        }
    }

    private void GuestButton_Click(object sender, EventArgs e)
    {
        Hide();
        if (AppController.mainForm == null || AppController.mainForm.IsDisposed)
        {
            AppController.mainForm = new MainForm(new Account());
        }
        AppController.mainForm.Location = Location;
        AppController.mainForm.Show();
        ClearAllFields();
    }

    private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 127)
        {
            ((TextBox)sender).Text = "";
            e.Handled = true;
        }
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        hidePassword = !hidePassword;
        PasswordTextBox.UseSystemPasswordChar = hidePassword;
    }

    private void ClearAllFields()
    {
        LoginTextBox.Clear();
        PasswordTextBox.Clear();
        hidePassword = true;
        ErrorLabel.Text = "";
    }
}