using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1  
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            */
            /* Övning 2
            for (int i = 0; i < 11; i++)
            {
                int modulo = i % 2;
                if (modulo == 0) {
                    for (int x = 0; x < 11; x++)
                    {
                        int modulo2 = x % 2;
                        if (modulo2 == 0)
                        {
                            Console.Write("o");
                        }
                        else
                        {
                            Console.Write("#");
                        }
                    }
                }
                else
                {
                    for (int y = 0; y < 11; y++)
                    {
                        int modulo3 = y % 2;
                        if (modulo3 ==0)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write("o");
                        }
                    }
                }
                Console.WriteLine();
            }
            */

            for (int i = 10; i > 10; i--)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write("#");
                }
            }

            Console.ReadKey();
        }
    }
}
