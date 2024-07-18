using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Turtle : Reptile
    {
        private string name;
        private int age;

        public Turtle() { }
        // We can utilize the getters and setters inherited from the base/parent classes to include fields to be instantiated when an object is instantiated
        public Turtle(string name, int age, string classification, string dietType, string habitat, bool hasScales)
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

        public void Swim()
        {
            Console.WriteLine("This turtle is swimming using it's limbs and webbed feet.");
        }

        public void Eat(string food)
        {
            Console.WriteLine("The turtle is chewing " + food);
        }









    }
}
