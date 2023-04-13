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
        public int? InTheFuture;

        public QuizResult(string name, string surname, int group, bool budget, string cardNumber,
            AppController.Faculty faculty, int inTheFuture)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Budget = budget;
            CardNumber = cardNumber;
            Faculty = faculty;
            InTheFuture = inTheFuture;
        }

        public QuizResult()
        {
        }
    }
}