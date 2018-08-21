﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_base
{
    static class Excercises
    {
        public static void ID626()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[2];
            int zero_jeden = 0;
            int[] czasy = new int[10000];
            int[] zjedzone = new int[10000];
            int suma_zjedzone = 0;
            for (int i = 0; i < m; i++)
            {
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    x[zero_jeden] = Convert.ToInt32(s);
                    zero_jeden++;
                    //osoby ciastka_w_pudelku
                }
                for (int j = 0; j < x[0]; j++)
                {
                    zjedzone[j] = 86400 / Convert.ToInt32(Console.ReadLine());
                    suma_zjedzone += zjedzone[j];
                }

                //wynik - ile pudełek kupić
                Console.WriteLine(Math.Ceiling((double)suma_zjedzone / x[1]));
                zero_jeden = 0; suma_zjedzone = 0;
            }
        }

        public static void ID1016()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[n];
            int[] v = new int[2];
            int[] t_vsrednia = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    v[j] = Convert.ToInt32(s);
                    j++;
                    // perform your operation on integers here
                }

                t_vsrednia[i] = (2 * v[0] * v[1]) / (v[0] + v[1]);

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(t_vsrednia[i]);
            }
        }

        public static void ID1()
        {
            int[] t = new int[100];
            int i = 0;
            do
            {
                i++;
                t[i] = Convert.ToInt32(Console.ReadLine());
            } while (t[i] != 42);
            i = 1;
            while (t[i] != 42)
            {
                Console.WriteLine(t[i]);
                i++;
            }
        }

        public static void Find()
        {
            //cyfra najblizej sredniej

            decimal[] tab = new decimal[5];
            decimal suma = 0, srednia = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Convert.ToDecimal(Console.ReadLine());
                suma += tab[i];
            }
            srednia = suma / tab.Length;

            var nearest = tab.OrderBy(v => Math.Abs((decimal)v - srednia)).First();
            //1, 2, 3, 4, 5 - srednia 3 
            //-2, -1, 0, 1, 5
            Console.WriteLine(srednia);
            Console.WriteLine(nearest);

        }

        public static void FindMax()
        {
            int a, b, c, m;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            m = a;
            if (b > m ) m = b;
            
            if (c > m) m = c;

                Console.WriteLine(" " + m);

        }
    }
}