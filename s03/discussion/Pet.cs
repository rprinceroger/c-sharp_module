using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    // Encapsulation
    // Wraps (Encapsulate) data and methods (function) into a single unit (class).
    internal class Pet
    {
        // Fields
        private string name;
        private string gender;
        private string classification;
        private int age;
        private string address;
        private string sound;

        // Getters and setters
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Classification { get => classification; set => classification = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public string Sound { get => sound; set => sound = value; }


        // constructors
        // empty constructor
        public Pet() { }

        // parametized constructor
        public Pet(string name, string gender, string classification, int age, string address, string sound)
        {
            this.name = name;
            this.gender = gender;
            this.classification = classification;
            this.age = age;
            this.address = address;
            this.sound = sound;
        }

        // 
        public void DescribePet()
        {
            Console.WriteLine($"{this.name} is a {this.gender} {this.classification} who is {this.age} years old and lives in {this.address}");
        }

        public void MakeSound()
        {
            Console.WriteLine(this.name + " says " + this.sound);
        }





    }
}
