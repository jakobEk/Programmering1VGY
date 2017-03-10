using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strängar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Console.WriteLine("\u0056\u00E4\u0157\u006D\u0064\u00F6\u0020\u0047\u0079\u006D\u006E\u0061\u0073\u0069\u0075\u006D");
            */
            /* Övning 2
            Console.WriteLine("\"Hello World\"");
            */
            /* Övning 3a
            string str = "Hello World";
            string ver = str.ToUpper();
            Console.WriteLine(ver);
            */
            /* Övning 3b
            string str = "Hello World";
            string gem = str.ToLower();
            Console.WriteLine(gem);
            */
            /* Övning 4
            Console.WriteLine("Hello World");
            string hello = "Hello World";
            Console.WriteLine(hello + " innehåller " + hello.Length + " tecken lång");
            */
            /* Övning 5
            Console.Write("Mata in text: ");
            string inmatat = Console.ReadLine();
            char[] inmatatArray = inmatat.ToCharArray();

            for (int i = inmatat.Length - 1 ; i >= 0; i--)
            {
                Console.Write(inmatat[i]);
            }
            */

            string textMedParam = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n"
                                  + "Det tyckte {2} var så intressant,\n"
                                  + "så {2} gick och hämtade en annan elefant.\n";

            string finalText = string.Format(textMedParam, "En", "", "de");
            Console.WriteLine(finalText);
            
            for (int i = 1; i < 10; i++)
            {
                finalText = string.Format(textMedParam, ++i, "er", "de");
                Console.WriteLine(finalText);
                if (i == 10)
                {
                    Console.WriteLine
                }
            } 


            Console.ReadKey();
        }
    }
}
