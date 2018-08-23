using System;

namespace CSharp_base
{
    static class Lancuchy
    {

        public static void Reverse()
        {
            string wyraz = Console.ReadLine();

            char[] chars = wyraz.ToCharArray();
            Array.Reverse(chars);
            wyraz = new string(chars);

            Console.WriteLine(wyraz);
        }

        public static void Temp()
        {
            string imie;
            imie = Console.ReadLine();

            if(imie.EndsWith('a'))
            {
                Console.WriteLine("iffffffffff"); 
            }
            else Console.WriteLine("else");

            string jeden = "abc ", dwa = "bbb";
            string trzy = jeden + dwa;
            Console.WriteLine(trzy);

            Console.WriteLine(trzy.ToUpper());
            Console.WriteLine(trzy.ToLower());
            Console.WriteLine(trzy.Replace("abc", "111")); 


        }
    }
}
