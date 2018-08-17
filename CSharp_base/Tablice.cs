using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_base
{
    static class Tablice
    {
        public static void Fibb()
        {
            long[] fibb = new long[99999];
            int n;
            Console.WriteLine("ile cyfr?");
            n = int.Parse(Console.ReadLine());

            fibb[0] = 1;
            fibb[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibb[i] = fibb[i - 1] + fibb[i - 2];
                //Console.WriteLine($"Wyraz nr {i+1} : {fibb[i]}");
            }
            Console.WriteLine($"Wyraz nr {n} : {fibb[n-1]}");

            Console.WriteLine(fibb[n - 1]);
        }

        public static void Tablica_jednowymiarowa()
        {
            float[] oceny = new float[5];
            float suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Podaj {i+1} ocene: ");
                oceny[i] = float.Parse(Console.ReadLine());

                suma += oceny[i];
            }
            Console.WriteLine($"Średnia: {suma}");
        }
    }
}
