using System;

namespace CSharp_base.Objects
{
    internal class Point
    {
        protected internal string Name { get; set; }
        protected internal float X { get; set; }
        protected internal float Y { get; set; }

        protected internal Point(string name = "A", float x = 0, float y = 0)
        {
            Name = name;
            X = x;
            Y = y;
        }
        protected internal void Load()
        {
            Name = Console.ReadLine();
            X = Convert.ToSingle(Console.ReadLine());
            Y = Convert.ToSingle(Console.ReadLine());
        }
    }
    internal class Rectangle
    {
        protected internal string Name { get; set; }
        protected internal float X { get; set; }
        protected internal float Y { get; set; }
        protected internal float Width { get; set; }
        protected internal float Height { get; set; }

        protected internal Rectangle(string name = "brak", float x = 0, float y = 0, float width = 1, float height = 1)
        {
            Name = name;
            X = x;
            Y = x;
            Width = width;
            Height = height;
        }
        protected internal void Load()
        {
            //Name = Console.ReadLine();
            //X = Convert.ToSingle(Console.ReadLine());
            //Y = Convert.ToSingle(Console.ReadLine());
            //Width = Convert.ToSingle(Console.ReadLine());
            //Height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(Name);
        }

        internal void Judge(Point point, Rectangle rectangle)
        {
            rectangle.Name = "aaa"; //podmiana nazwy
            if ((point.X >= rectangle.X) && (point.X <= rectangle.X + rectangle.Width)
                && (point.Y >= rectangle.Y) && (point.Y <= rectangle.Y + rectangle.Height))
                Console.WriteLine($"Point: {point.Name} belong to rectangle {rectangle.Name}");
            else
                Console.WriteLine($"Point: {point.Name} doesnt belong to rectangle {rectangle.Name}");
        }
    }
}
