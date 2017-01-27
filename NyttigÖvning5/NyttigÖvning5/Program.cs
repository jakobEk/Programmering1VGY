// Skapad av Henric, Axel och Jakob. Datum: 2017-01-27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyttigÖvning5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumKvadraten = 0;
            int sum = 0;

            // Här räknar vi ut Summan av kvadraten.
            for (int i = 1; i < 101; i++) {
                sumKvadraten = sumKvadraten + i * i;
            }

            // Den här loopen räknar ut 1 + 2 + 3... upp till och med 100.
            for (int i = 1; i < 101;i++)
            {
                sum = sum + i;
            }
            
            int kvadSumma = sum * sum;// Här räknar vi det sista i kvadraten av summan.
            int skillnad = kvadSumma - sumKvadraten;// I denna uträckning så tar vi reda på skillnaden mellan summan av kvadraten och kvadraten av summan. 
            
            Console.WriteLine("Summan av kvadraten: " + sumKvadraten);
            Console.WriteLine("Kvadraten av summan: " + kvadSumma);
            Console.WriteLine("Skilnaden mellan summan av kvadraten och kvadraten av summan: " + skillnad);
            Console.ReadKey();
        }
    }
}
