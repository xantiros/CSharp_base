using System;

namespace CSharp_base.Objects
{
    public class Circle2 : Shape
    {
        public float R { get; private set; }

        public Circle2(float r)
        {
            R = r;
        }

        public override void CalculateField()
        {
            Console.WriteLine("Circle Field: " + Math.PI * R * R);
        }
    }
}
