using System;

namespace CSharp_base.Objects
{
    public class Event
    {
        public string Name { get; private set; }
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }
        public int Hour { get; private set; }
        public int Minutes { get; private set; }

        public Event(string name, int day = 1, int month = 1, int year = 2000, int hour = 0, int minutes = 0)
        {
            Name = name;
            Day = day;
            Month = month;
            Year = year;
            Hour = hour;
            Minutes = minutes;
        }

        ~Event()
        {
            Console.WriteLine("Destructor");
        }

        public void Load()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Day: ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month: ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hour: ");
            Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes: ");
            Minutes = Convert.ToInt32(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {Day}/{Month}/{Year} {Hour}:{Minutes}");
        }
    }
}
