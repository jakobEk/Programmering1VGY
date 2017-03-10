using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSatsen
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1.1
            int i = 0;
            while (i++ < 100)
            {
                Console.WriteLine(i);
            }
            */
            /* Övning 1.2
            Console.Write("Lösenord: ");
            string losen = Console.ReadLine();

            while (losen != "Feelthebern")
            {
                Console.WriteLine("Fel lösenord!");
                losen = Console.ReadLine();
            }
            Console.WriteLine("Välkomen!");
            */
            /* Övning 2.1
            int i = 1;
     
            while (i <= 100)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            /* Övning 2.2
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
            */
            /* Övning 2.3
            Console.Write("SKriv valfri text: ");
            string text = Console.ReadLine();

            while (true)
            {
                Console.WriteLine(text);
            }
            */
            /* Övning 2.4
            Console.Write("Gissa ett tal mellan 1 och 100: ");
            string inmatat = Console.ReadLine();
            int tal = int.Parse(inmatat);
            int n = 0;

            while (tal != 91)
            {
                if (tal < 91)
                {
                    Console.WriteLine("För lågt!");
                    inmatat = Console.ReadLine();
                    tal = int.Parse(inmatat);
                    n++;
                }
                else if (tal > 91)
                {
                    Console.WriteLine("För högt!");
                    inmatat = Console.ReadLine();
                    tal = int.Parse(inmatat);
                    n++;
                }
            }
            Console.WriteLine("Grattis det tog dig " + n + " gissningar!");
            */
            /* Övning 2.5
            int fib_0 = 0;
            int fib_1 = 1;
            int fib_n = 1;

            while (fib_n < 1000000)
            {
                Console.WriteLine(fib_n + " ");
                fib_n = fib_0 + fib_1;
                fib_0 = fib_1;
                fib_1 = fib_n;
            }
            */

            Console.Write("Ange saldo på konto (kr): ");
            string inmatat_1 = Console.ReadLine();
            int saldo = int.Parse(inmatat_1);

            Console.Write("Ange ränta (%): ");
            string inmatat_2 = Console.ReadLine();
            int ranat = int.Parse(inmatat_2);

            Console.Write("Ange mål (kr): ");
            string inmatat_3 = Console.ReadLine();
            int mål = int.Parse(inmatat_3);

            while (true)
            {
                
            }
            Console.ReadKey();
        }
    }
}
