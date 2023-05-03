using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quiz
{
    public class QuizResult
    {
        public string? Name;
        public string? Surname;
        public int? Group;
        public bool? Budget;
        public string? CardNumber;
        public AppController.Faculty? Faculty;
        public AppController.FutureEnum? InTheFuture;

        public QuizResult(string name, string surname, int group, bool budget, string cardNumber,
            AppController.Faculty faculty, AppController.FutureEnum inTheFuture)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Budget = budget;
            CardNumber = cardNumber;
            Faculty = faculty;
            InTheFuture = inTheFuture;
        }

        public QuizResult(){}
        
        // Конструктор, используемый для десериализации (JSON парсер возвращает словарь<строка, объект?>)
        public QuizResult(Dictionary<string, object?> dict)
        {
            foreach (var pair in dict)
            {
                string key = pair.Key;
                object? value = pair.Value;

                if (value == null)
                {
                    throw new Exception("Incorrect Data. Value is Null.");
                }
                
                switch (key)
                {
                    case "Name":
                        Name = (string?) value;
                        break;
                    case "Surname":
                        Surname = (string?) value;
                        break;
                    case "Group":
                        Group = (int?) Convert.ToInt32(value);
                        break;
                    case "Budget":
                        Budget = (bool?) value;
                        break;
                    // по-хорошему сделать проверку корректности десериализованных данных, но увы, мне лень.
                    case "CardNumber":
                        CardNumber = (string?) value;
                        break;
                    case "Faculty":
                        // Faculty = (AppController.Faculty) Enum.Parse(typeof(AppController.Faculty), (string) value);
                        Faculty = AppController.GetFacultyByDescription((string) value);
                        break;
                    case "InTheFuture":
                        InTheFuture = AppController.GetFutureByDescription((string) value);
                        break;
                    default:
                        throw new Exception($"Invalid parameter name: {key}");
                }
            }
            
            if (Name == null || Surname == null || Group == null || Budget == null || CardNumber == null ||
                Faculty == null || InTheFuture == null)
            {
                throw new Exception("Incorrect Data. Some parameters were not specified.");
            }
        }

        public override string ToString()
        {
            return $"{Surname} {Name.Substring(0, 1)}. ({Group})";
        }

        // Приводим к словарю<строка, объект?>. Такой формат принимает JSON.Dump()
        public Dictionary<string, object?> ToDictionary()
        {
            return new Dictionary<string, object?>()
            {
                {"Name", Name},
                {"Surname", Surname},
                {"Group", Group},
                {"Budget", Budget},
                {"CardNumber", CardNumber},
                {"Faculty", ((AppController.Faculty) Faculty).ToDescription()},
                {"InTheFuture", ((AppController.FutureEnum) InTheFuture).ToDescription()}
            };
        }
    }
}