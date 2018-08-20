using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_base
{

    static class Pointers
    {
        public static void Test()
        {
            float[] tab = { 1, 2, 3.4f };

            Srednia(ref tab, tab.Length);

            Console.WriteLine(tab[0]);


            float Srednia(ref float[] tabb, int ile)
            {
                float suma = 0;
                for (int i = 0; i < ile; i++)
                {
                    suma += tabb[i];
                    tabb[i] = 99;
                }
                return suma / ile;
            }

        }

        public static void Test2()
        {
            int[] ile = new int[100000001];

            DateTime time_start = DateTime.Now;
            Console.WriteLine(time_start);

            for (int i = 1; i < ile.Length; i++)
            {
                ile[i] = i;
                ile[i] = +50;
                ile[i] = +50;
                ile[i] = ile[i-1] + i + 50;
            }

            DateTime time_end = DateTime.Now;
            Console.WriteLine(time_end);

            Console.WriteLine(time_end-time_start);

            /////////////////////////////

            Array.Clear(ile, 0, ile.Length);

            time_start = DateTime.Now;
            Console.WriteLine(time_start);

            unsafe
            {


                fixed (int* p = ile)
                {
                    long last_adress = 0;
                    int last_value = 0;
                    Console.WriteLine("Value:{0} @ Address:{1}", *p, (long)p);
                    int i = 0, x;
                    for (int* p2 = p; p2 < p+ile.Length; p2++ )
                    {

                        *p2 = i;
                        *p2 += 50;
                        *p2 += 50;
                        p2--;
                        x = *p2;
                        p2++;
                        *p2 = + i + 50;
                        i++;

                        last_value = *p2;
                        last_adress = (long)p2;

                        //Console.WriteLine("Value:{0} @ Address:{1}", *p2, (long)p2);
                    }

                    Console.WriteLine(i);
                    Console.WriteLine("Value:{0} @ Address:{1}", *p, (long)p);
                    Console.WriteLine("Value:{0} @ Address:{1}", last_value, last_adress);
                }

            }

            time_end = DateTime.Now;
            Console.WriteLine(time_end);

            Console.WriteLine(time_end - time_start);
        }


        static void Temp()
        {
            unsafe
            {
                int ile = 5;

                int* tab;

                tab = &ile;

                for (int i = 0; i < ile; i++)
                {
                    Console.WriteLine((int)tab); //kolejne adresy są co 4 bo 4 bajty ma int
                    tab++;
                }

            }

        }
    }
}
