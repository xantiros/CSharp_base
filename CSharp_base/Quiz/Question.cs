using System;
using System.IO;

namespace CSharp_base.Quiz
{
    public class Question
    {
        public string Content { get; private set; }
        public string A { get; private set; }
        public string B { get; private set; }
        public string C { get; private set; }
        public string D { get; private set; }
        public int Number { get; private set; }
        public string Correct { get; private set; }
        public string Answer { get; private set; }
        public int Points { get; private set; }

        public void Read()
        {
            string path = @"C:\Users\bklima\source\repos\CSharp_base\CSharp_base\Fundamentials\quiz.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("blad");
            }

            int start_line= (Number - 1) * 6 + 1;
            int current_line = 1;
            string line;

            StreamReader file = new StreamReader(path);
            //file.BaseStream.Position = start_line;
            while ((line = file.ReadLine()) != null)
            {

                //Console.WriteLine(line);
                if (current_line == start_line) Content = line;
                if (current_line == start_line+1) A = line;
                if (current_line == start_line+2) B = line;
                if (current_line == start_line+3) C = line;
                if (current_line == start_line+4) D = line;
                if (current_line == start_line+5) Correct = line;

                current_line++;
            }
            file.Close();
        }
        public void Ask()
        {
            Console.WriteLine(Content);
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("C: " + C);
            Console.WriteLine("D: " + D);
        }
        public void Check()
        {
            Console.WriteLine("Twoja odp: ");
            Answer = Console.ReadLine();

            if (Answer.ToLower() == Correct)
            {
                Console.WriteLine("Dobrze");
                Points=1;
            }
            else
            {
                Console.WriteLine("Zle: poprawna: " + Correct.ToUpper());
                Points = 0;
             }
        }
        public void Question_number(int number)
        {
            Number = number;
        }
    }
}
