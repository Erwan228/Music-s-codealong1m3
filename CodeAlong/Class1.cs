namespace Codealong
{
    public class Question
    {
        public string QuestionText { get; private set; }
        public string[] Options { get; private set; }
        public char RightAnswer { get; private set; }
        public Question(string questionText, string[] options, char rightAnswer)
        {
            QuestionText = questionText;
            Options = options;
            RightAnswer = rightAnswer;
        }
        public void RunQuiz()
        {
            Console.WriteLine(QuestionText);
            for (int i = 0; i < Options.Length; i++)
            {
                var letter = (Char)('A' + i);
                string? question = Options[i];
                Console.WriteLine(question);
            }
            Console.Write("Skriv inn a, b eller c: ");
            var answer = Console.ReadLine();
            if (answer[0] == RightAnswer)
            {

            }
        }

    }
}

