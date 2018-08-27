using CSharp_base.Objects;
using CSharp_base.Quiz;
using System;
using System.Collections.Generic;

namespace CSharp_base.Fundamentials
{
    public static class Tmp
    {
        public static void Event()
        {
            //Event ev = new Event(2, 10, 1992, 10, 08, "war");
            Event ev = new Event("abc", 22);
            //ev.Load();
            ev.Show();
        }

        public static void Question()
        {
            var questions = new List<Question>()
            {
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question(),
                new Question()
            };

            int i = 1, suma = 0;
            foreach (var q in questions)
            {
                q.Question_number(i);
                q.Read();
                q.Ask();
                q.Check();
                i++;
                suma += q.Points;
            }
            Console.WriteLine("Koniec, punktow: " + suma);
        }
    }
}
