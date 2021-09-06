using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många favoritmaträtter har du?");

            int amountOfQuestions = Convert.ToInt32(Console.ReadLine());
            string[] foods = new string[amountOfQuestions];

            // Frågar om maträtter lika många gånger som längden av foods[] och sparar sedan varje svar i foods[]
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("Mata in en av dina favoritmaträtter:");
                foods[i] = Console.ReadLine();
            }

            // Printar varje maträtt på samma rad
            foreach (var meal in foods)
            {
                Console.Write($"{meal} ");
            }

            // Ny rad
            Console.WriteLine();

            // Printar varje maträtt och hur många tecken den har
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine($"{foods[i]} är ({foods[i].Length}) bokstäver lång.");
            }
            
            string longestFood = "";

            // Printa längsta maträtten
            for (int i = 0; i < foods.Length - 1; i++) // foods.Length är alltid 1 mer än vad datorn räknar till därför - 1
            {
                // Om längden på maträtten är större än nästa i listan spara det
                if (foods[i].Length > foods[i + 1].Length)
                {
                      longestFood = foods[i];
                }
            }

            Console.WriteLine($"Maträtten med mest bokstäver är: {longestFood}!");
        }
    }
}
