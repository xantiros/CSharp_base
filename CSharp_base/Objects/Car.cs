using System;

namespace CSharp_base.Objects
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Mileage { get; private set; }

        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void Show()
        {
            Console.WriteLine($"{Brand}, {Model}, {Year}, {Mileage}");
        }

    }
}
