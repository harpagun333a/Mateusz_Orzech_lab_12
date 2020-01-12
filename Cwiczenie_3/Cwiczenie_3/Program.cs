using System;
using System.Threading;

namespace Cwiczenie_3
{
    class ThreadTest
    {
        bool done;
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 3");

            ThreadTest tt = new ThreadTest();
            new Thread(tt.Run).Start();
            tt.Run();
        }

        void Run()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done"); // Zostanie wywołany raz, ponieważ zmienna done zostanie zmieniona w jednym wątku zanim drugi wejdzie w ifa
            }
        }
    }
}
