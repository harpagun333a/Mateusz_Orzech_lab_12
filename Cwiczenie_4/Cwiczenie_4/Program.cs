using System;
using System.Threading;

namespace Cwiczenie_4
{
    class ThreadExample
    {
        static bool done;

        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 4");

            new Thread (Run).Start();
            Run();
        }

        static void Run()
        {
            if (!done)
            {
                //done = true;
                Console.WriteLine("Done");
                done = true;

                // Po zmianie kolejności "Done" pojawia się 2 razy, ponieważ drugi wątek zdąży wejść w warunek if zanim zmienna done zmieni wartość na true
            }
        }
    }
}
