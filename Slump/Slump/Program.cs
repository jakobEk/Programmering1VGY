using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1 
            Console.WriteLine("Programmet slumpar fram 10 tal mellan 1-20 och beräknar medelvärdet.");
            int medel = 0;
            Random slump = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int tal = slump.Next(1, 21);
                medel = medel + tal; 
                Console.Write(tal + " ");
            }
            medel = medel / 10;
            Console.Write("Medelvärdet blev " + medel);
            */
            /*
            Console.WriteLine("Programmet slumpar fram 20 tal mellan 15-30 och beräknar medianvärdet.");
            Console.WriteLine("På platsen där medianvärdet beräknas visas ett stolptecken |");
            Random slump = new Random();
            int[] minarray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                minarray[i] = slump.Next(15, 31);       
            }
            Array.Sort(minarray);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(minarray[i] + " ");
                if ( i == 9)
                {
                    Console.Write("| ");
                }
            }
            double medel = minarray[9] + minarray[10];
            Console.Write("Medianen är " + medel / 2);
            */

            Console.WriteLine("Du ska gissa ett tal som slumpas fram mellan 0 och 100.");
            Random slump = new Random();
            int tal = slump.Next(1, 101);

            Console.WriteLine("Vilket är ditt tal?");
            String gissning = Console.ReadLine();
            int gissningtal = int.Parse(gissning);

            while (gissningtal != tal)
            {
                if (gissningtal > tal)
                {
                    Console.WriteLine("För högt gissa igen.");
                    gissning = Console.ReadLine();
                    gissningtal = int.Parse(gissning);
                }
                else if (gissningtal < tal)
                {
                    Console.WriteLine("För lågt gissa igen.");
                    gissning = Console.ReadLine();
                    gissningtal = int.Parse(gissning);
                }
            }
            Console.WriteLine("Rätt gissat");
            Console.ReadKey();
        }
    }
}
