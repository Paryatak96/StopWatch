using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadanie_1___Stoper
{

    class Program
    {
        static void Main(string[] args)
        {
            var przelacznik = true;
            do
            {
                System.Console.Clear();
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("1 - Stoper Start");
                Console.WriteLine("2 - Stoper Stop");
                var przycisk = byte.Parse(Console.ReadLine());
                switch (przycisk)
                {
                    case 1:
                        {
                            if (przelacznik == true)
                            {
                                Stoper.Start();
                            }
                            else
                            {
                                throw new InvalidOperationException("NIE MOŻNA UŻYĆ 'Stoper Start' PRZED ZATRZYMANIEM!");
                            }
                            przelacznik = false;
                            break;
                        }
                    case 2:
                        {
                            Stoper.Stop();
                            przelacznik = true;
                            Console.WriteLine();
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (true);
        }
    }
}
