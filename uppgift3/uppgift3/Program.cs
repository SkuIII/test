using System;

namespace uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Skriv ett palindrom: ");
             string input = Console.ReadLine();

             // Gör om strängen till en array och vänd på den, spara sen i en ny variabel
             char[] myArr = input.ToCharArray();
             Array.Reverse(myArr);
             string palindrom = new string(myArr);

             Console.WriteLine($"{input}\n{palindrom}");
        }
    }
}
