using Codealong;

namespace CodeAlong
{
    public class Quiz
    {
        public void RunQuiz()
        {
            string[] optionsArray = { "En karakter fra en visuell skrekkroman", "En Arkitekt", "En guvernør i Elysium" };
            var Question1 = new Question("Hvem er Samuel Ayers", optionsArray, 'a');
            string[] optionsArray2 = { "Minearbeider", "Butikkmedarbeider", "Utforsker", "Sheriff", "Hore" };
            var Question2 = new Question("Hva er Sams opprinnelige yrke?", optionsArray2, 'e');
            string[] optionsArray3 = { "Han falt ned fra en klippe", "Han druknet i innsjøen", "Han ble drept av en tulpa" };
            var Question3 = new Question("Hvordan døde Sydney?", optionsArray3, 'b');
            string[] optionsArray4 = { "Drukna av seg selv", "Chase", "Flynn", "Jenna", "Tobias", "Carl", "Leo" };
            var Question4 = new Question("Hvem drukna Sydney", optionsArray4, 'b');
            int points = 0;
            points += Question1.RunQuestion();
            points += Question2.RunQuestion();
            points += Question3.RunQuestion();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            points += Question4.RunQuestion();
            Console.WriteLine(points + " Poeng");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
