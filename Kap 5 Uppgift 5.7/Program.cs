using System;
namespace Uppgift5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "Kina", "Indien", "USA", "Indonesien", "Pakistan" };
           
            //Utskrift av länder
            for (int i = 0; i < countries.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {countries[i]}");
            }

            bool loop = true; //Skapar en loop (ifall något går fel)
            do
            {
                try
                {
                    //Input
                    Console.WriteLine("Skriv in siffrorna på de städer som ska skrivas ut igen, seperade med ett mellanslag.");
                    string[] userChoice = Console.ReadLine().Split(" ");

                    //Skriver ut vad användaren ville
                    for (int i = 0; i < userChoice.Length; i++)
                    {
                        int nrFromChoice = int.Parse(userChoice[i]);
                        Console.WriteLine($"{nrFromChoice}. {countries[nrFromChoice - 1]}");
                    }
                    //Gick allt rätt? Stäng av loopen!
                    loop = false;
                }
                catch
                {
                    Console.WriteLine($"Skriv bara in heltal mellan 1 och {countries.Length}!");
                }
            }
            while (loop);
        }
    }
}
/*Skapa ett program som skriver som sparar världens fem folkrikaste länder och sedan
skriver ut dem till användaren på detta sätt:
1. Kina
2. Indien
3. USA
4. Indonesien
5. Pakistan
Be därefter användaren att mata in de länder som ska visas igen genom att skriva
deras nummer på en rad separerat av mellanslag, t.ex. 1 3 5. Därefter ska
programmet visa de länder som användaren valde en gång till. Med de
exempelnummer vi valde ska programmet skriva
1. Kina
3. USA
5. Pakistan*/