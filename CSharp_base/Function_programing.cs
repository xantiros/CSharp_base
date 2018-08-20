using System;

namespace CSharp_base
{
    static class Function_programing
    {
        public static void Temp()
        {
            float metry = float.Parse(Console.ReadLine());
            Console.WriteLine(Cal(metry));
            Console.WriteLine(Yards(metry));
            Console.WriteLine(Mils(metry));

        }

        static float Cal(float m)
        {
            return m * 39.37f;
        }
        static float Yards(float m)
        {
            return m * 1.0936f;
        }
        static float Mils(float m)
        {
            return m * 0.000621371192f;
        }

    }
}
