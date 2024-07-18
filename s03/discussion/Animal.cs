using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    // This class will be serve as Parent class
    internal class Animal
    {
        // Properties / field / keys
        private string classification;
        private string dietType;

        // Constructor
        public Animal() { }
        public Animal(string classification, string dietType)
        {
            this.classification = classification;
            this.dietType = dietType;
        }


        // Getters and Setters
        public string Classification { get => classification; set => classification = value; }
        public string DietType { get => dietType; set => dietType = value; }

        // Function / Methods - When a function is inside a class it is called 'Method'.
        public void Sleep()
        {
            Console.WriteLine("This animal is sleeping.");
        }









    }
}
