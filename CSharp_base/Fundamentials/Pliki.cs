using System;
using System.IO;

namespace CSharp_base
{
    static class Pliki
    {
        public static void Quiz()
        {

            string temat, nick, line, odpowiedz;
            int counter = 1, nr_pytania = 0, punkty = 0, count = 0;

            string path = @"C:\Users\bklima\source\repos\CSharp_base\CSharp_base\quiz.txt";


            if(!File.Exists(path))
            {
                Console.WriteLine("blad");
            }

            StreamReader file2 = new StreamReader(path);
            while ((line = file2.ReadLine()) != null)
            {
                count++;
            }

            int max_questions = (count - 2) / 6;

            string[] tresc = new string[max_questions], odpA = new string[max_questions], odpB = new string[max_questions],
                odpC = new string[max_questions], odpD = new string[max_questions], poprawna = new string[max_questions];

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);

                switch(counter)
                {
                    case 1: temat = line; break;
                    case 2: nick = line; break;
                    case 3: tresc[nr_pytania] = line; break;
                    case 4: odpA[nr_pytania] = line; break;
                    case 5: odpB[nr_pytania] = line; break;
                    case 6: odpC[nr_pytania] = line; break;
                    case 7: odpD[nr_pytania] = line; break;
                    case 8: poprawna[nr_pytania] = line; break;
                }

                if (counter == 8)
                {
                    counter = 2;
                    nr_pytania++;
                }

                counter++;
            }
            file.Close();

            for (int i = 0; i < tresc.Length; i++)
            {
                Console.WriteLine(tresc[i]);
                Console.WriteLine("A: " + odpA[i]);
                Console.WriteLine("B: " + odpB[i]);
                Console.WriteLine("C: " + odpC[i]);
                Console.WriteLine("D: " + odpD[i]);

                Console.WriteLine("Twoja odp: ");
                odpowiedz = Console.ReadLine();

                if (odpowiedz.ToLower() == poprawna[i])
                {
                    Console.WriteLine("Dobrze");
                    punkty++;
                }
                else Console.WriteLine("Zle: poprawna: " + poprawna[i]);
            }
            Console.WriteLine("koniec");

            System.Console.WriteLine("There were {0} lines.", count);

        }




        public static void Plik()
        {
            string a, b, c;

           string path = @"C:\Users\bklima\source\repos\CSharp_base\CSharp_base\MyTest.txt";

            try
            {

                if (!File.Exists(path))
                {
                    a = 1 + Console.ReadLine();
                    b = 2 + Console.ReadLine();
                    c = 3 + Console.ReadLine();

                    // Create a file to write to.
                    //string createText = "Hello and Welcome" + Environment.NewLine;
                    //File.WriteAllText(path, createText);
                    File.AppendAllText(path, a + Environment.NewLine);
                    File.AppendAllText(path, b + Environment.NewLine);
                    File.AppendAllText(path, c + Environment.NewLine);
                }
                else
                {
                    //string readText = File.ReadAllText(path);
                    //Console.WriteLine(readText);

                    foreach (var tst in File.ReadLines(path))
                    {
                        Console.WriteLine(tst);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
