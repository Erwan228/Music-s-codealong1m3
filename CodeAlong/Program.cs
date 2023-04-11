using Codealong;

namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
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





            //var points = 0;
            //Console.WriteLine("Hva er 2+2?");
            //Console.WriteLine(" A: 2");
            //Console.WriteLine(" B: 3");
            //Console.WriteLine(" C: 4");
            //Console.Write("Skriv inn a, b eller c: ");
            //var answer1 = Console.ReadLine();
            //if (answer1 == "c")
            //{
            //    points++;
            //    Console.WriteLine("Riktig!");
            //}
            //else
            //{
            //    Console.WriteLine("Feil");
            //}
            //Console.WriteLine("Hvilken by er norsk?");
            //Console.WriteLine(" A: Oslo");
            //Console.WriteLine(" B: Ohio");
            //Console.WriteLine(" C: Omaha");
            //Console.Write("Skriv inn a, b eller c: ");
            //var answer2 = Console.ReadLine();
            //if (answer2 == "a")
            //{
            //    points++;
            //    Console.WriteLine("Riktig!");
            //}
            //else
            //{
            //    Console.WriteLine("Feil");
            //}
            //Console.WriteLine("Hvilken farge er ikke i den norske flagget?");
            //Console.WriteLine(" A: Rød");
            //Console.WriteLine(" B: Grønn");
            //Console.WriteLine(" C: Blå");
            //Console.Write("Skriv inn a, b eller c: ");
            //var answer3 = Console.ReadLine();
            //if (answer3 == "b")
            //{
            //    points++;
            //    Console.WriteLine("Riktig!");
            //}
            //else
            //{
            //    Console.WriteLine("Feil");
            //}

            //Console.WriteLine($"Du fikk {points} riktige.");
        }

    }
}
