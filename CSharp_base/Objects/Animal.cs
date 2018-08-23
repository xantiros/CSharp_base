using System;

namespace CSharp_base
{
    public class Animal
    {
        //properties
        private string Species { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }

        //methods
        public void AddAnimal()
        {
            Console.WriteLine("Add new animal");
            Species = Console.ReadLine();
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void GiveVoice()
        {
            if(Species=="cat")
                Console.WriteLine(Name + " " + Age + " Miau!");
            else if (Species == "dog")
                Console.WriteLine(Name + " " + Age + " Hau!");
            else if (Species == "bird")
                Console.WriteLine(Name + " " + Age + " Brr!");
            else 
                Console.WriteLine(" No species ");
        }
    }
}
