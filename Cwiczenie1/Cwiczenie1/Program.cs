using System;
using System.Threading;

namespace Cwiczenie1
{
    class ThreadExample
    {
        static void Main()
        {
            Console.WriteLine("Cwiczenie 1");

            Thread t = new Thread(Write1);
            t.Start();

            for(int i = 0; i < 1000; i ++)
            {
                Console.Write("0");
            }
        }

        static void Write1()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("1");
            }
        }
    }
}

