using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            Bil nyBil = new Bil();

            Console.WriteLine("Ange märke: ");
            nyBil.Märke = Console.ReadLine();

            Console.WriteLine("Ange modell: ");
            nyBil.Modell = Console.ReadLine();

            Console.WriteLine("Ange hästkafter: ");
            nyBil.Hästkrafter = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange regnummer: ");
            nyBil.Regnr = Console.ReadLine();

            Console.WriteLine("Ange årgång: ");
            nyBil.År = int.Parse(Console.ReadLine());

            Console.WriteLine("Märke: " + nyBil.Märke);
            Console.WriteLine("Modell: " + nyBil.Modell);
            Console.WriteLine("Hästkrafter: " + nyBil.Hästkrafter);
            Console.WriteLine("Regnummer: " + nyBil.Regnr);
            Console.WriteLine("Årgång: " + nyBil.År);
            */
            /* Övning 2
            Namn nyttNamn = new Namn();

            Console.WriteLine("Ange förnamn: ");
            nyttNamn.Förnamn = Console.ReadLine();

            Console.WriteLine("Ange efternamn: ");
            nyttNamn.Efternamn = Console.ReadLine();

            Console.WriteLine("Fullständigtnamn: " + nyttNamn.FullständigtNamn);
            */

            Namn nyttNamn = new Namn();
            Datum nyttDatum = new Datum();

            Console.WriteLine("Ange förnamn: ");
            nyttNamn.Förnamn = Console.ReadLine();
            Console.WriteLine("Ange efternamn: ");
            nyttNamn.Efternamn = Console.ReadLine();

            Console.WriteLine("Ange födelseår: ");
            nyttDatum.År = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange födelsemånad: ");
            nyttDatum.Månad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange födelsedag: ");
            nyttDatum.Dag = int.Parse(Console.ReadLine());


            Console.WriteLine("Fullständigtnamn: " + nyttNamn.FullständigtNamn);

            Console.ReadKey();
        }
    }
}
