using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_base
{
    static class Excercises
    {
        public static void ID499()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            List<ulong> tab = new List<ulong>();
            if (t > 10) t = 10;
            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    tab.Add(ulong.Parse(s));
                }
                if (tab[0] == 1) Console.WriteLine(1);
                else if (tab[1] == 0) Console.WriteLine(1);
                else if (tab[0] == 0) Console.WriteLine(0);
                else
                {
                    int a = Convert.ToInt32(tab[0] % 10);
                    int b = Convert.ToInt32(tab[1] % 10);
                    if(a == 0 & b != 0)
                    {
                        Console.WriteLine(0);
                    }
                    if (a != 0 & b == 0)
                    {
                        int x = a;
                        for (int j = 1; j < 10; j++)
                        {
                            x *= x;
                        }
                        Console.WriteLine(x % 10);
                    }
                    else if(a==0 & b == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        int x = a;
                        for (int j = 1; j < b; j++)
                        {
                            x *= x;
                        }
                        Console.WriteLine(x % 10);
                    }

                }
                tab.Clear();
            }         
        }

        public static void ID606()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                List<int> tab = new List<int>();
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    tab.Add(Convert.ToInt32(s));
                }
                tab.Remove(tab[0]);
                tab.Reverse();
                foreach (var item in tab)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ID1502()
        {
            string text = Console.ReadLine();
            int[] tab = new int[4];
            int i = 0;
            string[] numbers = text.Split(' ');
            foreach (string s in numbers)
            {
                tab[i] = Convert.ToInt32(s);
                i++;
            }
            Console.WriteLine((tab[0]*tab[1])+(tab[2]*tab[3]));
        }

        public static void ID601()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] tab = new int[2];
                int jj = 0;
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    tab[jj] = Convert.ToInt32(s);
                    jj++;
                }
                Console.WriteLine(Nwd(tab[0], tab[1])); 
            }
        }
        static int Nwd(int a, int b)
        {
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        public static void ID496()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 0 || y == 1)
                    Console.WriteLine("0 1");
                else if (y == 2)
                    Console.WriteLine("0 2");
                else if (y == 3)
                    Console.WriteLine("0 6");
                else if (y == 4)
                    Console.WriteLine("2 4");
                else if (y == 5 || y == 6 || y == 8)
                    Console.WriteLine("2 0");
                else if (y == 7)
                    Console.WriteLine("4 0");
                else if (y == 9)
                    Console.WriteLine("8 0");
                else
                    Console.WriteLine("0 0");

            }

        }

        public static void ID1828()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x+y+z);
        }


        public static void Silnia_vs_Silnia2()
        {
            int[] t = new int[int.MaxValue/2];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = i;
            }

            DateTime time_start = DateTime.Now;
            Console.WriteLine("Start: " + time_start.Millisecond);

            Console.WriteLine(Silnia(13));

            DateTime time_end = DateTime.Now;
            Console.WriteLine("End: " + time_end.Millisecond);
            Console.WriteLine("Time: " + (time_end.Millisecond - time_start.Millisecond));

            for (int i = 0; i < t.Length; i++)
            {
                t[i] = i;
            }

            time_start = DateTime.Now;
            Console.WriteLine("Start: " + time_start.Millisecond);

            Console.WriteLine(Silnia2(13));

            time_end = DateTime.Now;
            Console.WriteLine("End: " + time_end.Millisecond);
            Console.WriteLine("Time: " + (time_end.Millisecond - time_start.Millisecond));
        }

        public static int Silnia2(int a)
        {
            int suma = 1;
            for (int i = 1; i <= a; i++)
            {
                suma *= i;
            }
            return suma;
        }

        public static int Silnia(int a)
        {
            if (a == 1) return 1;
            else return a * Silnia(a - 1);
        }

        public static int Potega(int p, int w) //3`4 3*3*3*3
        {
            if (w == 0) return 1;
            else return Potega(p, w - 1) * p;
        }

        public static int Fibonaci(int a) // 1 1 2 3 5 
        {
            if (a == 0) return 0;
            if (a == 1) return 1; //1
            else return Fibonaci(a - 2) + Fibonaci(a - 1);
        }

        public static void ID438()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                int num = Convert.ToInt32(Console.ReadLine());
                int primary = 1;
                if (num == 1) primary = 0;
                for (int j = 2; j < num-1; j++)
                {
                    if (num % j == 0)
                    {
                        primary = 0;
                        break;
                    }
                    else
                        primary = 1;
                }
                if (primary == 1)
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }
        }

        public static void ID549()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                int suma = 0;
                foreach (var num in numbers)
                {
                    suma += Convert.ToInt32(num);
                }
                Console.WriteLine(suma);
            }
        }

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
