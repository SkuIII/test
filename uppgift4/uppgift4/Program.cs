using System;

namespace uppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett tal mellan 1-10: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[tal];

            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine("Mata in ett tal; ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                arr[i] = tal1;
            }
            arr.GetValue(1);
        }
    }
}
