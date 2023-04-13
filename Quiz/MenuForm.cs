using Quiz.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
  public partial class MenuForm : Form 
  {
    

      public MenuForm()
      {
        InitializeComponent();
        CenterToScreen();
      }

      private void StartQuizButton_Click(object sender, EventArgs e)
      {
        Hide();
        if (AppController.quiz_q1 == null || AppController.quiz_q1.IsDisposed)
        {
          AppController.quiz_q1 = new Quiz_q1();
        }
        
        AppController.CurrentResult = new QuizResult();
        AppController.quiz_q1.Location = Location;
        AppController.quiz_q1.Show();
      }

      private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

      private void MenuForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

      private void ResultsButton_Click(object sender, EventArgs e)
      {
        throw new NotImplementedException();
      }
  }
}