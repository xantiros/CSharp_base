using CSharp_base.Objects;
using CSharp_base.Quiz;
using System;
using System.Collections.Generic;

namespace CSharp_base.Fundamentials
{
    public static class Tmp
    {
        public static void Test()
        {
            var shapes = new List<Shape>
            {
                new Circle2(6),
                new Circle2(1),
                new Square(5),
                new Circle2(2)
            };
            foreach (var item in shapes)
            {
                item.CalculateField();
                //Calculate(item); //z c++
            }

            //Circle2 circle = new Circle2(5);
            //Square square = new Square(5);
            //circle.CalculateField();
            //square.CalculateField();
        }
        private static void Calculate(Shape shape)
        {
            shape.CalculateField();
        }

        public static void Point()
        {
            Circle circle = new Circle("Abc", 5, 5, 5);
            circle.Show();
            Ball ball = new Ball();
            ball.Show();
        }

        public static void Point2()
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
