using Quiz.Properties;
using System;
using System.Collections.Generic;
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
        
        private void ResultsButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (AppController.resultsForm == null || AppController.resultsForm.IsDisposed)
            {
                AppController.resultsForm = new ResultsForm();
            }
            
            AppController.resultsForm.Location = Location;
            AppController.resultsForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e) {
            // Предупреждение о том, что результаты не сохранены
            if (!AppController.IsListSaved && AppController.ResultsList.Count != 0)     
            {
                if (MessageBox.Show("Изменения не сохранены!\nПродолжить?", "Внимание!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Asterisk) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
            
            
        }
    }
}