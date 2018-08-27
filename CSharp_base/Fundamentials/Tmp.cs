using CSharp_base.Objects;
using CSharp_base.Quiz;
using System;
using System.Collections.Generic;

namespace CSharp_base.Fundamentials
{
    public static class Tmp
    {
        public static void Point()
        {
            Point p1 = new Point("A", 3, 1);

            Rectangle r1 = new Rectangle("Rectangle", 0, 0, 6, 4);

            Judge(p1, r1);

            r1.Load();

            r1.Judge(p1, r1);

            r1.Load();

        }
        internal static void Judge(Point point, Rectangle rectangle)
        {
            rectangle.Name = "abc"; //podmiana nazwy
            if((point.X>=rectangle.X) && (point.X <= rectangle.X+rectangle.Width)
                && (point.Y>=rectangle.Y) && (point.Y <= rectangle.Y+rectangle.Height))
                Console.WriteLine($"Point: {point.Name} belong to rectangle {rectangle.Name}");
            else
                Console.WriteLine($"Point: {point.Name} doesnt belong to rectangle {rectangle.Name}");
        }

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
