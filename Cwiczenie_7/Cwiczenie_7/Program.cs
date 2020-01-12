using System;
using System.Threading;

namespace Cwiczenie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 7");

            int[,] m1 = new int[,] {
                {1, 1, 1},
                {1, 1, 1},
                {1, 1, 1}
            };
            int[,] m2 = new int[,] {
                {2, 2, 2},
                {2, 2, 2},
                {2, 2, 2}
            };
            int[,] m3 = new int[,] {
                {3, 3, 3},
                {3, 3, 3},
                {3, 3, 3}
            };
            int[,] m4 = new int[,] {
                {4, 4, 4},
                {4, 4, 4},
                {4, 4, 4}
            };
            int[,] m5 = new int[,] {
                {5, 5, 5},
                {5, 5, 5},
                {5, 5, 5}
            };

            Thread t1 = new Thread(() => wypisz_sumę(m1));
            Thread t2 = new Thread(() => wypisz_sumę(m2));
            Thread t3 = new Thread(() => wypisz_sumę(m3));
            Thread t4 = new Thread(() => wypisz_sumę(m4));
            Thread t5 = new Thread(() => wypisz_sumę(m5));
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }

        static void wypisz_sumę(int[,] m)
        {
            int suma = 0;

            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    suma += m[i, j];
                }
            }

            Console.WriteLine(suma);
        }
    }
}
