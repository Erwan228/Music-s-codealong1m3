namespace Codealong
{
    public class Question
    {
        public string QuestionText { get; private set; }
        public string[] Options { get; private set; }
        public char RightAnswer { get; private set; }
        public Question(string questionText, char rightAnswer, params string[] answerOptions)
        {
            QuestionText = questionText;
            Options = answerOptions;
            RightAnswer = rightAnswer;
        }
        public int RunQuestion()
        {
            Console.WriteLine(QuestionText);
            for (int i = 0; i < Options.Length; i++)
            {
                var letter = (Char)('A' + i);
                string? question = Options[i];
                Console.WriteLine(letter + ": " + question);
            }
            Console.Write("Skriv inn svaret ditt: ");
            var answer = Console.ReadLine();
            if (answer[0] == RightAnswer)
            {
                Console.WriteLine("Svaret er riktig.");
                Console.WriteLine();
                return 1;
            }

            Console.WriteLine("Svaret er feil!");
            Console.WriteLine();
            return 0;

        }

    }
}

