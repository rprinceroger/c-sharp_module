using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Crocodile : Reptile
    {

        private string name;
        private int age;

        public Crocodile() { }
        // We can utilize the getters and setters inherited from the base/parent classes to include fields to be instantiated when an object is instantiated
        public Crocodile(string name, int age, string classification, string dietType, string habitat, bool hasScales)
        {
            this.name = name;
            this.age = age;
            Classification = classification;
            DietType = dietType;
            Habitat = habitat;
            HasScales = hasScales;
        }
        // Getter and Setters
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void DescribePet()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            // Since the crocodile class inherits from the Animal and Reptile classes, we have access to the getter methods denoted by the Capital letters for printing out values
            Console.WriteLine($"Classification: {Classification}");
            Console.WriteLine($"Diet Type: {DietType}");
            Console.WriteLine($"Habitat: {Habitat}");

        }

        public void Swim()
        {
            Console.WriteLine("This crocodile is swimming through it's limbs and tail.");
        }

        public void Swim(int speed)
        {
            Console.WriteLine("This crocodile is swimming through it's limbs and tail " + speed + " kmph.");
        }









    }
}
