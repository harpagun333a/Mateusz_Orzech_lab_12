using System;
using System.Threading;

namespace Cwiczenie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 6");

            Thread t = new Thread(Run);
            t.Start();
            //t.Join();         // Bez joina program nie czeka na wykonanie wątku t, a od razu idzie dalej i wypisuje "Thread t has ended"
            Console.WriteLine("Thread t has ended");
        }

        static void Run()
        {
            for(int i = 0; i < 777; i++)
            {
                Console.Write("[]");
            }
        }
    }
}
