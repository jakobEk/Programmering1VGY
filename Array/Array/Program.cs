using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            string[] namn = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in ett namn: ");
                namn[i] = Console.ReadLine();
            }
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
            */
            /* Övning 2
            int[] tal = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Mata in ett tal: ");
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tal.Length; i++)
            {
                Console.WriteLine(tal[i]);
            }
            */

            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };

            for (int i = 0; i < numbArray.Length; i++)
            {
                int x = numbArray[i];
                for (int y = i+1; y < numbArray.Length ; y++)
                {
                    if (x < numbArray[y])
                    {
                        numbArray[i] = x;
                    }
                }
            }
            for (int i = 0; i < numbArray.Length; i++)
            {
                Console.WriteLine(numbArray[i]);
            }
            Console.ReadKey();
        }
    }
}
