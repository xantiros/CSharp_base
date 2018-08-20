using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_base
{
    static class Excercises
    {
        public static void Find()
        {
            //cyfra najblizej sredniej

            decimal[] tab = new decimal[5];
            decimal suma = 0, srednia = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = Convert.ToDecimal(Console.ReadLine());
                suma = +tab[i];
            }
            srednia = suma / tab.Length;

            tab.




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
