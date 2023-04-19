using Codealong;

namespace CodeAlong
{
    public class Quiz
    {
        List<Question> questions = new List<Question>();
        public Quiz()
        {
            var Question1 = new Question("Hvem er Samuel Ayers", 'a', "En karakter fra en visuell skrekkroman", "En Arkitekt", "En guvernør i Elysium");
            questions.Add(Question1);
            var Question2 = new Question("Hva er Sams opprinnelige yrke?", 'e', "Minearbeider", "Butikkmedarbeider", "Utforsker", "Sheriff", "Hore");
            questions.Add(Question2);
            var Question3 = new Question("Hvordan døde Sydney?", 'b', "Han falt ned fra en klippe", "Han druknet i innsjøen", "Han ble drept av en tulpa");
            questions.Add(Question3);
            var Question4 = new Question("Hvem drukna Sydney", 'b', "Drukna av seg selv", "Chase", "Flynn", "Jenna", "Tobias", "Carl", "Leo");
            questions.Add(Question4);
        }
        public int RunQuiz()
        {
            int points = 0;
            foreach (var question in questions)
            {
                points += question.RunQuestion();
            }
            //points += Question1.RunQuestion();
            //points += Question2.RunQuestion();
            //points += Question3.RunQuestion();
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //points += Question4.RunQuestion();
            return points;

        }

    }
}
