using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            int inkomst = 0 , timmar = 0;
                try
                {
                    Console.Write("Ange din inkomst: ");
                    inkomst = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                }
                try
                {
                    Console.Write("Ange antal timmar: ");
                    timmar = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                }
            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
            Console.ReadKey();
        }
    }
}
