/* SwitchSatser är övningar från csharpskolan 
 * Jakob Ek den 9 sept 2016
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSatser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Console.Write("Ange ett heltal mellan 1-4: ");
            int heltal = int.Parse(Console.ReadLine());

            switch (heltal)
            {
                case 1:
                    Console.WriteLine("Ett"); break;
                case 2:
                    Console.WriteLine("Två"); break;
                case 3:
                    Console.WriteLine("Tre"); break;
                case 4:
                    Console.WriteLine("Fyra"); break;
                default:
                    Console.WriteLine("Ogiltigt alternativ!"); break;
            }
            */
            /* Övning 2
            Console.Write("Chose a between N,S,E eller W: ");
            string letter = Console.ReadLine();

            switch (letter)
            {
                case "N":
                    Console.WriteLine("You walk north"); break;
                case "S":
                    Console.WriteLine("You travel south"); break;
                case "E":
                    Console.WriteLine("You wander east"); break;
                case "W":
                    Console.WriteLine("You stroll west"); break;
                default:
                    Console.WriteLine("I do not understand"); break;
            }
            */

            

            Console.WriteLine("Ange ett tal: ");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett till tal: ");
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Vilket räknesätt skall användas? ");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraktion");
            Console.WriteLine("Division");
            Console.WriteLine("Multiplikation");

            string räknesätt = Console.ReadLine();
            
            switch (räknesätt)
            {
                case "Addition":
                    Console.WriteLine(tal1 + tal2); break;
                case "Subtraktion":
                    Console.WriteLine(tal1 - tal2); break;
                case "Divisíon":
                    Console.WriteLine(tal1 / tal2); break;
                case "Multiplikation":
                    Console.WriteLine(tal1 * tal2); break;
            }
            Console.ReadKey();
        }
    }
}
;