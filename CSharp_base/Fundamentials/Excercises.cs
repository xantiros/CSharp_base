using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSharp_base
{
    public static class Excercises
    {
        public static void ID1139()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 1 || x > 1000)
                    Console.WriteLine();
                else
                    Console.WriteLine(x * x);
            }
        }

        public static void ID968()
        {
            int suma = 0;
            string line;
            TextReader textReader = Console.In;

            while((line = textReader.ReadLine()) != null)
            {
                suma += Convert.ToInt32(line);
                Console.WriteLine(suma);
            }
        }

        public static void ID522()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                List<int> tab = new List<int>();
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    tab.Add(Convert.ToInt32(s));
                }
                if (tab[0] < 10 || tab[0] > 30 || tab[1] < 10 || tab[1] > 30) Console.WriteLine(0);
                else if (tab[0] == tab[1]) Console.WriteLine(tab[0]);
                else
                {
                    Console.WriteLine(tab[0] * tab[1] / Nwd(tab[0], tab[1]));
                }
            }
        }

        public static void ID506()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] c = new int[char.MaxValue];
                string text = Console.ReadLine();
                string new_text = null;
                char last_character = ' ';
                int count_char = 0;
                foreach (char s in text) 
                {                                   //aaaabbb
                    c[s]++;
                    if (s != last_character && count_char > 2)
                    {
                        new_text = new_text + last_character + count_char;
                        count_char = 0;
                    }
                    else if (s != last_character && count_char == 2)
                    {
                        new_text = new_text + last_character + last_character;
                        count_char = 0;
                    }
                    else if (s != last_character && count_char == 1) //aabaa 
                    {
                        new_text = new_text + last_character;
                        count_char = 0;
                    }
                    count_char++;
                    last_character = s;
                }
                if (count_char > 2)
                    new_text = new_text + last_character + count_char;
                else if(count_char == 2)
                    new_text = new_text + last_character + last_character;
                else new_text = new_text + last_character;
                Console.WriteLine(new_text);
                //for (int j = 0; j < char.MaxValue; j++)
                //{
                //    if (c[j] > 0 && char.IsLetter((char)j))
                //    {
                //        Console.WriteLine("Letter: {0}  Frequency: {1}",(char)j, c[j]);
                //    }
                //}
            }
        }

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
                    double a = Convert.ToDouble(tab[0] % 10);
                    double b = Convert.ToDouble(tab[1] % 10);
                    if (a == 0 & b != 0)
                    {
                        Console.WriteLine(0);
                    }
                    else if (a != 0 & b == 0)
                    {
                        double x = Math.Pow(a, b);
                        //int x = a;
                        //for (int j = 1; j < 10; j++)
                        //{
                        //    x *= a;
                        //}
                        Console.WriteLine((int)x % 10); 
                    }
                    else if (a == 0 & b == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else if (a == 1) Console.WriteLine(1);
                    else if (a == 2)
                    {
                        ulong mod = tab[1] % 4;
                        if (mod == 1) Console.WriteLine(2); 
                        else if (mod == 2) Console.WriteLine(4);
                        else if (mod == 3) Console.WriteLine(8);
                        else Console.WriteLine(6); 
                    }
                    else if (a == 3)
                    {
                        ulong mod = tab[1] % 4;
                        if (mod == 0) Console.WriteLine(1);
                        else if (mod == 1) Console.WriteLine(3);
                        else if (mod == 2) Console.WriteLine(9);
                        else Console.WriteLine(7);
                    }
                    else if (a == 6) Console.WriteLine(6);
                    else if (a == 8)
                    {
                        ulong mod = tab[1] % 4;
                        if (mod == 0) Console.WriteLine(1);
                        else if (mod == 1) Console.WriteLine(8);
                        else if (mod == 2) Console.WriteLine(4);
                        else if (mod == 3) Console.WriteLine(2);
                        else Console.WriteLine(6);
                    }
                    else if (a == 8)
                    {
                        ulong mod = tab[1] % 2;
                        if (mod == 0) Console.WriteLine(1);
                        else if (mod == 1) Console.WriteLine(9);
                        else Console.WriteLine(1);//if (mod == 2)
                    }
                    else
                    {
                        double x = Math.Pow(a, b);
                        //int x = a;
                        //for (int j = 1; j < b; j++)
                        //{
                        //    x *= a;
                        //}
                        Console.WriteLine((int)x % 10); 
                    }
                }
                tab.Clear();
            }         
        }
        public static int ID499_Tests2(ulong num0, ulong num1)
        {
            if (num0 == 1) return 1;
            else if (num1 == 0) return 1;
            else if (num0 == 0) return 0;
            else
            {
                double a = Convert.ToDouble(num0 % 10);
                double b = Convert.ToDouble(num1 % 10);
                if (a == 0 & b != 0)
                {
                    return 0;
                }
                else if (a != 0 & b == 0)
                {
                    double x = Math.Pow(a, b);
                    //int x = a;
                    //for (int j = 1; j < 10; j++)
                    //{
                    //    x *= a;
                    //}
                    return (int)x % 10;
                }
                else if (a == 0 & b == 0)
                {
                    return 0;
                }
                else if (a == 1) return 1;
                else if (a == 2)
                {
                    ulong mod = num1 % 4;
                    if (mod == 1) return 2;
                    else if (mod == 2) return 4;
                    else if (mod == 3) return 8;
                    else return 6; //(mod == 0) 
                    //else return 6; //if (mod == 4) 
                }
                else if (a == 3)
                {
                    ulong mod = num1 % 4;
                    if (mod == 0) return 1;
                    else if (mod == 1) return 3;
                    else if (mod == 2) return 9;
                    else return 7; //(mod == 3)
                }
                else if (a == 6) return 6;
                else if (a == 8)
                {
                    ulong mod = num1 % 4;
                    if (mod == 0) return 1;
                    else if (mod == 1) return 8;
                    else if (mod == 2) return 4;
                    else if (mod == 3) return 2;
                    else return 6; //if (mod == 4)
                }
                else if (a == 8)
                {
                    ulong mod = num1 % 2;
                    if (mod == 0) return 1;
                    else if (mod == 1) return 9;
                    else return 1; //if (mod == 2)
                }
                else
                {
                    double x = Math.Pow(a, b);
                    //int x = a;
                    //for (int j = 1; j < b; j++)
                    //{
                    //    x *= a;
                    //}
                    return (int)x % 10;
                }
            }
        }
        public static int ID499_Tests(ulong num0, ulong num1)
        {
            int[,] tab = new int[10,4] {
            {0, 0, 0, 0},
            {1, 1, 1, 1},
            {6, 2, 4, 8},
            {1, 3, 9, 7},
            {6, 4, 6, 4},
            {5, 5, 5, 5},
            {6, 6, 6, 6},
            {1, 7, 9, 3},
            {6, 8, 3, 2},
            {1, 9, 1, 9}
            };

            return tab[num0%10, num1%4];

        }
        public static void ID499_2()
        {
            int t = Convert.ToInt16(Console.ReadLine());
            int[,] tab = new int[10, 4] {
            {0, 0, 0, 0},
            {1, 1, 1, 1},
            {6, 2, 4, 8},
            {1, 3, 9, 7},
            {6, 4, 6, 4},
            {5, 5, 5, 5},
            {6, 6, 6, 6},
            {1, 7, 9, 3},
            {6, 8, 3, 2},
            {1, 9, 1, 9}
            };
            List<ulong> tab2 = new List<ulong>();
            if (t > 10) t = 10;
            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();
                string[] numbers = text.Split(' ');
                foreach (string s in numbers)
                {
                    tab2.Add(ulong.Parse(s));
                }
                Console.WriteLine(tab[tab2[0] % 10, tab2[1] % 4]);
                tab2.Clear();
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
