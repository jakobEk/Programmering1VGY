using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSatser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.Write("Skriv in mönsterdjup: ");
            string inmatat = Console.ReadLine();
            double djup = double.Parse(inmatat);

            if(djup < 1.6)
            {
                Console.WriteLine("Olagligt däck!");
            }
            else 
            {
                Console.WriteLine("Lagligt däck!");
            }
            */

            //Övning 2
            /*
            Console.Write("Mata in ålder: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder <= 12 && ålder >= 0)
            {
                Console.Write("Färg: Vit");
            }
            else if (ålder <= 18 && ålder >= 13)
            {
                Console.Write("Färg: Grön");
            }
            else if (ålder <= 25 && ålder >= 19)
            {
                Console.Write("Färg: Röd");
            }
            else if (ålder <= 99 && ålder >= 26)
            {
                Console.Write("Färg: Blå");
            }
            else 
            {
                Console.Write("Ogiltig ålder");
            }
            */

            //Övning 3
            /*
            Console.Write("Mata in tal 1: ");
            decimal tal1 = decimal.Parse(Console.ReadLine());

            Console.Write("Mata in tal 2: ");
            decimal tal2 = decimal.Parse(Console.ReadLine());

            if(tal1 > tal2)
            {
                Console.Write("Tal 1 var störst: " + tal1);
            }
            else if(tal1 < tal2)
            {
                Console.Write("Tal 2 var strörst: " + tal2);
            }
            else
            {
                Console.Write("Talen var lika!");
            }
            */

            //Övning 4

            Console.Write("Mata in ett tal: ");
            int tal = int.Parse(Console.ReadLine());

            tal = tal % 7;

            if (tal == 0)
            {
                Console.Write("Talet är jämnt delbart med 7!");
            }
            else
            {
                Console.Write("Talet är ej delbart med 7. Resten blir: " + tal);
            }
            Console.ReadKey();


        
        }
    }
}
