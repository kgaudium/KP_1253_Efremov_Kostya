using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz;

public partial class Quiz_q1 : Form
{
    public Quiz_q1()
    {
        InitializeComponent();
    }

    private void GroupTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            return;
        e.Handled = true;
    }

    private void CardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            return;
        e.Handled = true;
    }

    private void Quiz_q1_FormClosed(object sender, FormClosedEventArgs e)
    {
        AppController.menuForm.Location = Location;
        AppController.menuForm.Show();
    }

    private void NextButton_Click(object sender, EventArgs e)
    {
        if (IsCorrectInput())
        {
            ApplyAnswers();
            Hide();
            if (AppController.quiz_q2 == null || AppController.quiz_q2.IsDisposed)
                AppController.quiz_q2 = new Quiz_q2();
            AppController.quiz_q2.Location = Location;
            AppController.quiz_q2.Show();
        }
        else
        {
            AppController.ShowError();
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        NameTextBox.Text = null;
        SurnameTextBox.Text = null;
        GroupTextBox.Text = null;
        BudgetCheckBox.Checked = false;
        CardNumberTextBox.Text = null;
        FacultyComboBox.Text = null;
    }

    private bool IsCorrectInput()
    {
        return (NameTextBox.Text.Length > 0)
               & (SurnameTextBox.Text.Length > 0)
               & (GroupTextBox.Text.Length == 4)
               & (CardNumberTextBox.Text.Length == 16)
               & (FacultyComboBox.Text != null);
    }

    private void ApplyAnswers()
    {
        AppController.CurrentResult.Name = NameTextBox.Text;
        AppController.CurrentResult.Surname = SurnameTextBox.Text;
        AppController.CurrentResult.Group = new int?(Convert.ToInt32(GroupTextBox.Text));
        AppController.CurrentResult.Budget = new bool?(BudgetCheckBox.Checked);
        AppController.CurrentResult.CardNumber = CardNumberTextBox.Text;
        AppController.Faculty result;
        Enum.TryParse(FacultyComboBox.Text, out result);
        AppController.CurrentResult.Faculty = result;
    }

    private void DebugButton_Click(object sender, EventArgs e)
    {
        NameTextBox.Text = "Kostya";
        SurnameTextBox.Text = "Efremov";
        GroupTextBox.Text = "1253";
        BudgetCheckBox.Checked = true;
        CardNumberTextBox.Text = "1234567898765432";
        FacultyComboBox.Text = AppController.Faculty.ISAM.ToString();
    }
}