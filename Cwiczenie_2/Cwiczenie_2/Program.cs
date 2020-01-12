using System;
using System.Threading;

namespace Cwiczenie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 2");

            new Thread (Run).Start();       // Zostanie wypisane 10 razy bo funkcja Run() wywoływana jest dwukrotnie
            Run();
        }

        static void Run()
        {
            for(int cycles = 0; cycles < 5; cycles++)
            {
                Console.Write('x');
            }
        }
    }
}
