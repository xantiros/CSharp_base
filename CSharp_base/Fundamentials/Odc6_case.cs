using System;

namespace CSharp_base
{
    static class Odc6_case
    {
        public static void Miesiace()
        {
            int miesiac;
            miesiac = int.Parse(Console.ReadLine());

            switch(miesiac)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("29 lub 28");
                    break;
            }

        }


        public static void Cases()
        {
            float x, y;
            char wybor;

            while(true)
            {
                Console.WriteLine("Podaj 1: ");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj 2: ");
                y = float.Parse(Console.ReadLine());
                Console.WriteLine("Menu: ");
                Console.WriteLine("1: Dodawanie");
                Console.WriteLine("2: Odejmowanie");
                Console.WriteLine("Wybierz: ");
                wybor = char.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case '1':
                        Console.WriteLine($"Suma: {x + y}");
                        break;
                    case '2':
                        Console.WriteLine($"Roznica: {x - y}");
                        break;
                    case '5':
                        return;
                    default:
                        Console.WriteLine("Wybierz cos");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }

           

        }

    }
}
