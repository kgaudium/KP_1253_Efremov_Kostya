using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Quiz
{
    public static class AppController
    {
        public static MenuForm menuForm;
        public static Quiz_q1 quiz_q1;
        public static Quiz_q2 quiz_q2;
        public static List<QuizResult> ResultsList = new List<QuizResult>();
        public static QuizResult? CurrentResult;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menuForm = new MenuForm();
            Application.Run(menuForm);
        }

        public static void ShowError()
        {
            MessageBox.Show("Некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public enum Faculty
        {
            [Description("ИСАУ")] ISAM,
            [Description("ФЕИН")] FNES,
            [Description("ИФИ")] EPI,
            [Description("ФСГН")] FSHS,
        }
    }
}