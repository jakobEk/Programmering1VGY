using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Övning 1
            Console.Write("Mata in Celsius: ");
            string text = Console.ReadLine();
            double celsius = double.Parse(text);
             
            Console.WriteLine(celsius + " grader Celsius är lika med " + CelsiusTillFarenheit(celsius) + " grader farenheit.");
            
            Console.ReadKey();
            
            static double CelsiusTillFarenheit(double celsius)
            {
                double farenheit = (celsius / 5.0) * 9 + 32;
                return farenheit;
            }
            */
            /* Övning 2
                    Console.Write("Mata in cirkelns radie: ");
                    string text = Console.ReadLine();
                    double radie = double.Parse(text);

                    Console.WriteLine("Area: " + RaknarUtArea(radie));
                    Console.WriteLine("Omkrets: " + RaknarUtOmkrets(radie));

                    Console.ReadKey();
                }
                static double RaknarUtArea (double radie)
                {
                    double area = Math.PI * radie * radie;
                    area = Math.Round(area,2);
                    return area;
                }
                static double RaknarUtOmkrets (double radie)
                {
                    double omkrets = 2 * Math.PI * radie;
                    omkrets = Math.Round(omkrets,2);
                    return omkrets;
                }
                */
            Console.Write("Antal tärningskast: ");
            string text = Console.ReadLine();
            int antalKast = int.Parse(text);
        }
            static double AntalTärningskast (double antalkast)
        {

        }
  }
}
