using System;

namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt favoritcitat?");
            string favQuote = Console.ReadLine();
            int wordCount = 0;

            // Loopa genom strängen
            for (int i = 0; i < favQuote.Length - 1; i++)
            {
                // Räknar alla mellanslag i strängen
                if (favQuote[i] == ' ' && Char.IsLetter(favQuote[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            // Lägg till 1 för att räkna sista ordet
            wordCount++;

            Console.WriteLine("Antalet ord i citatet är: " + wordCount);

            // Dela upp strängen vid varje mellanslag
            string[] splitString = favQuote.Split(' ');

            // Loopa genom den splittade strängen och printa varje ord
            foreach (string word in splitString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
