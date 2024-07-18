using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    // Using ":" sysbol will inherit the properties and functions of the parent class (Animal class)

    // Inheritance
    // One class inherits properties and methods from another.
    internal class Reptile : Animal
    {
        private string habitat;
        private bool hasScales;

        public Reptile() { }
        public Reptile(string habitat, bool hasScales)
        {
            this.habitat = habitat;
            this.hasScales = hasScales;
        }


        public string Habitat { get => habitat; set => habitat = value; }
        public bool HasScales { get => hasScales; set => hasScales = value; }

        public void Eat()
        {
            Console.WriteLine("This animal is eating.");
        }












    }
}
