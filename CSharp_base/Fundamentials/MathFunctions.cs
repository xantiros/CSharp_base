using System;

namespace CSharp_base
{
    public static class MathFunctions
    {
        public static void Ogame()
        {
            int metal = Convert.ToInt32(Console.ReadLine());
            int krysztal = Convert.ToInt32(Console.ReadLine());
            int deuter = Convert.ToInt32(Console.ReadLine());

            //20000 7000 2000

            int x = metal / 20000;
            int y = krysztal / 7000;
            int z = deuter / 2000;

            if(x <= 0 || y <= 0 || z <= 0)
                Console.WriteLine("blad");
            else if(x <= y && x <= z )
                Console.WriteLine("Krązowników: " + x);
            else if(y <= x && y <= z)
                Console.WriteLine("Krązowników: " + y);
            else if(z <= x && z <= y)
                Console.WriteLine("Krązowników: " + y);

        }

        public static void Test()
        {
            Console.WriteLine("Podaj: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Round: {0}", Math.Round(x));
            Console.WriteLine("Ceil: {0}", Math.Ceiling(x));
            Console.WriteLine("Floor: {0}", Math.Floor(x));
            Console.WriteLine("Trunc: {0}", Math.Truncate(x));

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);

            double kat = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Sin((kat*Math.PI)/180));
            Console.WriteLine(Math.Cos((kat * Math.PI) / 180));
            Console.WriteLine(Math.Tan((kat * Math.PI) / 180));
            Console.WriteLine(1/Math.Tan((kat * Math.PI) / 180));
        }

        public static void Test3()
        {
            uint x = (uint)(Math.Pow(2, 32)) - 1;
            Console.WriteLine(x);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(Math.Cbrt(27));
            Console.WriteLine(Math.Pow(49, 0.5));
            Console.WriteLine(Math.Pow(27, 1/3d));

            double x_1 = Convert.ToDouble(Console.ReadLine());
            double y_1 = Convert.ToDouble(Console.ReadLine());
            double x_2 = Convert.ToDouble(Console.ReadLine());
            double y_2 = Convert.ToDouble(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2));
            Console.WriteLine(d);
        }

        public static void Test2()
        {
            int x = 31;
            Console.WriteLine("Pytanie: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int o1 = Math.Abs(x - a);
            int o2 = Math.Abs(x - b);

            if (o1 < o2)
                Console.WriteLine("1 Won");
            else if (o2 < o1)
                Console.WriteLine("2 Won");
            else Console.WriteLine("Draft");
        }
    }
}
