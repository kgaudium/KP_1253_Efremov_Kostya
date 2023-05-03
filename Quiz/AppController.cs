using System;
using System.Collections;
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
        public static ResultsForm resultsForm;
        
        private static List<QuizResult> resultsList = new List<QuizResult>();
        public static QuizResult? CurrentResult;

        public static List<QuizResult> ResultsList
        {
            get { return resultsList; }
            internal set { resultsList = value; }
        }

        public static bool IsListSaved = false;

        public enum Faculty
        {
            [Description("ИСАУ")]   ISAM,
            [Description("ФЕИН")]   FNES,
            [Description("ИФИ")]    EPI,
            [Description("ФСГН")]   FSHS
        }

        public enum FutureEnum
        {
            [Description("Бизнесмен")]                          Businessman,
            [Description("Кибератлет")]                         Gamer,
            [Description("Без Определённого Места Жительства")] Homeless,
            [Description("Кiт")]                                Kitten
        }
        
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
//             string bruh1 = JSON.Dump(new Dictionary<bool, string>() {{true, "hello"}, {false, "goodbye"}});
//             string bruh2 = JSON.Dump(new Dictionary<string, bool>(){{"hello", true}, {"goodbye", false}});
//             string bruh3 = JSON.Dump(new float[] {1.55f, 2, 4, 464564});
//             string bruh4 = JSON.Dump(@"asd
// dasd
// fdf\tfdfs");
//             string bruh5 = JSON.Dump(null);

            // string bruh = JSON.Dump(new Dictionary<bool, Dictionary<string, int>>()
            // {
            //     {true, new Dictionary<string, int>()
            //     {
            //         {"hello", 3}, 
            //         {"goodbye", 8}
            //     }},
            //     {false, new Dictionary<string, int>()
            //     {
            //         {"bruh", 14}, 
            //         {"hurb", 77}
            //     }}
            // });
            //
            // MessageBox.Show(bruh);
            //
            // Dictionary<string, object>? dict = (Dictionary<string, object>?) JSON.Parse(bruh);
            //
            // MessageBox.Show(MyUtils.DictToString(dict.ToDictionary(item => (object) item.Key, item => item.Value)));
            //
//             
//             // MessageBox.Show(bruh1);
//             // MessageBox.Show(bruh2);
//             MessageBox.Show(bruh3);
//             // MessageBox.Show(bruh4);
//             // MessageBox.Show(bruh5);
//
//             Dictionary<string, object>? dict1 = (Dictionary<string, object>?) JSON.Parse(bruh1);
//             Dictionary<string, object>? dict2 = (Dictionary<string, object>?) JSON.Parse(bruh2);
//             List<object>? arr1 = (List<object>?) JSON.Parse(bruh3);
//             string? str1 = (string?) JSON.Parse(bruh4);
//             object? null1 = JSON.Parse(bruh5);
//             
//             MessageBox.Show(MyUtils.DictToString(dict1.ToDictionary(item => (object)item.Key, item => item.Value)));
//             MessageBox.Show(MyUtils.DictToString(dict2.ToDictionary(item => (object)item.Key, item => item.Value)));
//             MessageBox.Show(MyUtils.ListToString(arr1));
//             MessageBox.Show(str1);
//             MessageBox.Show((null1 == null).ToString());

            menuForm = new MenuForm();
            Application.Run(menuForm);
        }

        public static void ShowError()
        {
            MessageBox.Show("Некорректные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void AddResult(QuizResult result)
        {
            IsListSaved = false;
            resultsList.Add(result);
        }

        public static Faculty GetFacultyByDescription(string description)
        {
            switch (description)
            {
                case "ИСАУ":
                    return Faculty.ISAM;
                case "ФЕИН":
                    return Faculty.FNES;
                case "ИФИ":
                    return Faculty.EPI;
                case "ФСГН":
                    return Faculty.FSHS;
                default:
                    throw new Exception($"There is no Faculty with this description: {description}");
            }
        }
        
        public static FutureEnum GetFutureByDescription(string description)
        {
            switch (description)
            {
                case "Бизнесмен":
                    return FutureEnum.Businessman;
                case "Кибератлет":
                    return FutureEnum.Gamer;
                case "Без Определённого Места Жительства":
                    return FutureEnum.Homeless;
                case "Кiт":
                    return FutureEnum.Kitten;
                default:
                    throw new Exception($"There is no Future with this description: {description}");
            }
        }

        public static string ResultsListToJson()
        {
            return JSON.Dump(ResultsList.Select(result => result.ToDictionary()).ToList());
        }

        public static List<QuizResult> JsonToResultsList(string json)
        {
            // List<QuizResult> result;
            // List<object?> list = (List<object?>) JSON.Parse(json);
            // List<Dictionary<string, object?>> list1 = ((List<object?>) JSON.Parse(json)).Select(item => (Dictionary<string, object?>) item).ToList();
            // result = list.Select(item => new QuizResult(item)).ToList();
    
            
            // Ну мне очень хотелось попробовать написать в одну строку)) 
            // Сверху нормальный вариант (только он в виде наброска)
            // Ну там вообщем метод Parse возвращает List<object?>, мы эти обжекты переводим в Dictionary<string, object?>
            // А потом формируем список List<QuizResult> с помощью конструктора QuizResult(Dictionary<string, object?> dict)
            return ((List<object?>) JSON.Parse(json)).Select(item => (Dictionary<string, object?>) item).ToList().Select(item => new QuizResult(item)).ToList();
        }
    }
}