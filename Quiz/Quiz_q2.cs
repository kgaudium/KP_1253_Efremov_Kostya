using System;
using System.Windows.Forms;

namespace Quiz;

public partial class Quiz_q2 : Form
{
    public Quiz_q2()
    {
        InitializeComponent();
    }

    private void Quiz_q2_FormClosed(object sender, FormClosedEventArgs e)
    {
        AppController.menuForm.Location = Location;
        AppController.menuForm.Show();
    }

    private void FutureRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        var radioButton = (RadioButton)sender;
        if (!radioButton.Checked)
            return;
        var name = radioButton.Name;
        AppController.CurrentResult.InTheFuture = new int?(int.Parse(name.Substring(name.Length - 1)));
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        for (var index = 0; index < 4; ++index)
        {
            ((RadioButton)Controls.Find(string.Format("FutureRadioButton{0}", index), true)[0]).Checked = false;
        }
    }

    private void EndButton_Click(object sender, EventArgs e)
    {
        if (AppController.CurrentResult.InTheFuture.HasValue)
        {
            if (MessageBox.Show("Завершить?", "Спасибо за участие в опросе!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk) != DialogResult.OK)
                return;
            AppController.ResultsList.Add(AppController.CurrentResult);
            AppController.CurrentResult = (QuizResult)null;
            AppController.menuForm.Location = Location;
            AppController.quiz_q1.Dispose();
            AppController.quiz_q2.Dispose();
            AppController.menuForm.Show();
        }
        else
        {
            AppController.ShowError();
        }
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        AppController.quiz_q1.Location = Location;
        Hide();
        AppController.quiz_q1.Show();
    }

    private void FuturePictureBox3_Click(object sender, EventArgs e)
    {
        FutureRadioButton3.Checked = true;
    }

    private void FuturePictureBox2_Click(object sender, EventArgs e)
    {
        FutureRadioButton2.Checked = true;
    }

    private void FuturePictureBox1_Click(object sender, EventArgs e)
    {
        FutureRadioButton1.Checked = true;
    }

    private void FuturePictureBox0_Click(object sender, EventArgs e)
    {
        FutureRadioButton0.Checked = true;
    }
}