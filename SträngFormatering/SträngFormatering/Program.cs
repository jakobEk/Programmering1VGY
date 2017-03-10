using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SträngFormatering
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Console.WriteLine("{0,10:d}",DateTime.Now);
            */
            /*Övning 2
            double radie = 4;
            double piNumber = Math.PI;
            double area = radie * radie * piNumber;

            Console.WriteLine(area.ToString("F4"));
            */
            /* Övning 3
            Console.WriteLine("{0:0,0}", 1000000000);
            */
            /* Övning 4
            double value = 123.00;

            Console.WriteLine(value.ToString("\\#\\#\\# ## kronor och \\0\\0 öre \\#\\#\\#"));
            */
            /* Övning 5
            Console.Write("Skriv in ditt personnummer: ");
            string text = Console.ReadLine();
            long personnummer = long.Parse(text);

            Console.WriteLine("{0:#### ## ## - ####}", personnummer);
            */

            const string myformat = "{0,-12} | {1,-12} | {2,-12} | {3,-12} | {4,-20}";
            Console.WriteLine("------------------------------Veckoschema----------------------------");
            Console.WriteLine("Måndag       | Tisdag       | Onsdag       | Torsdag      | Fredag       ");
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine(string.Format(myformat, "Fysik", "Engelska", "Matematik", "Matematik", "Fysik"));
            Console.WriteLine(string.Format(myformat, "Matematik", "", "Teknik", "Engelska", "Webbutveckling"));
            Console.WriteLine(string.Format(myformat, "", "", "Idrott", "Fysik", "Programmering"));
            Console.WriteLine(string.Format(myformat, "", "", "Svenska", "Teknik", "Engelska"));

            Console.ReadKey();
        }
    }
}
