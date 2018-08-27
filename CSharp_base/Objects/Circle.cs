using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_base.Objects
{
    public class Circle : Point
    {
        public float R { get; private set; }
        public new string Name { get; private set; }

        public Circle(string name = "A", float x = 0, float y = 0, float r = 0) : base(name, x, y)
        {
            Name = name;
            R = r;
        }
        public new void Show()
        {
            Console.WriteLine($"Circle: {Name}, {X}, {Y}");
            base.Show();
            Console.WriteLine("Radius {0}", R);
            Console.WriteLine("Field of circle: {0}", Math.PI*R*R);
        }
    }
    public class Ball : Circle
    {
        public new string Name { get; private set; }

        public Ball(string name = "Ball", float x = 5, float y = 5, float r = 5) :base(name, x, y, r)
        {

        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Radius {0}", R);
            Console.WriteLine("Field of Ball: {0}", (4/3)*Math.PI * R * R * R);
        }
    }
}
