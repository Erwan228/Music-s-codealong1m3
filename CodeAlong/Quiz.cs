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
            var Question5 = new Question("Hvem hadde skylda i forsvinnelsen av mesetabarna", 'a', "James Hendricks", "John Begay");
            questions.Add(Question5);
            var Question6 = new Question("Hvem manifesterte en tulpa", 'f', "Chase", "Flynn", "Jenna", "Tobias", "Carl", "Leo");
            questions.Add(Question6);
            var Question7 = new Question("Hvilken primal av disse blir ikke tilkalt av Summoner", 'd', "Ifrit", "Titan", "Garuda", "Shiva", "Bahamut", "Phoenix");
            questions.Add(Question7);
            var Question8 = new Question("Hvilken extension får duty support i patch 6.4?", 'c', "A REAL REBORN", "HEAVENSWARD", "STORMBLOOD", "SHADOWBRINGERS", "ENDWALKER");
            questions.Add(Question8);
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
