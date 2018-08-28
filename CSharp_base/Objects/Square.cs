using System;

namespace CSharp_base.Objects
{
    public class Square : Shape
    {
        public float A { get; private set; }

        public Square(float a)
        {
            A = a;
        }

        public override void CalculateField()
        {
            Console.WriteLine("Square field: " + A * A);
        }
    }
}
