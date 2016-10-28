using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSatser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            */
            /* Övning 2
            for (int i = 20; i >= 1; i= i-1)
            {
                Console.WriteLine(i);
            }
            */
            /* Övning 3
            for (int i = 0; i <= 50; i=i+2)
            {
                Console.WriteLine(i);
            }
            */
            /* Övning 4
            Console.Write("Mata in start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Mata in stop: ");
            int stop = int.Parse(Console.ReadLine());

            Console.Write("Mata in steg: ");
            int steg = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i= i + steg)
            {
                Console.Write(" " +i);
            }
            */
            /* Övning 5
            int summa = 0;
            Console.Write("Mata in ett heltal: ");
            int heltal = int.Parse(Console.ReadLine());

            for (int i = 1; i <= heltal; i++)
            {
                summa = summa + i;
            }
            Console.Write("Summan av alla tal från 1 till " + heltal + " blir: " + summa);
            */
            Console.Write("Mata in ett heltal: ");
            int heltal = int.Parse(Console.ReadLine());
            int heltal2 = 1;
            int heltal3 = 0;
            int heltal4 = 1;

            for (int i = 0; i <= heltal; i++)
            {
                int modulo1 = heltal2 % 3;
                int modulo2 = heltal2 % 7;

                if (modulo1 == 0 && modulo2 == 0)
                {
                    Console.WriteLine("Talet " + heltal2 + " är jämnt delbart med både 3 och 7");
                    heltal3 = heltal3++;
                }
                if(heltal3 == 0 && heltal4 == 0)
                {
                    Console.WriteLine("Hittade inga tal...");
                    heltal4++;
                }
                heltal2 = heltal2 + 1;
            }
            Console.ReadKey();
        }
    }
}
