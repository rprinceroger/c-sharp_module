using System;

namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            // Data about pet
            string petAName = "Franky";
            string petAGender = "Female";
            string petAClassification = "Dog";
            int petAAge = 10;
            string petAAddress = "Manila, Philippines";
            string petASound = "Bark!";

            // Invocation (calling the function we want to execute)
            describePet(petAName, petAGender, petAClassification, petAAge, petAAddress);
            makeSound(petAName, petASound);

            string petBName = "Simba";
            string petBGender = "Male";
            string petBClassification = "Lion";
            int petBAge = 1;
            string petBAddress = "Pride Lands";
            string petBSound = "Rar";

            describePet(petBName, petBGender, petBClassification, petBAge, petBAddress);
            makeSound(petBName, petBSound);

            string carName = "Honda";
            string carColor = "Red";
            */


            // Features or function of a pet
            /*
            public static void describePet(string name, string gender, string classification, int age, string address)
            {
                Console.WriteLine($"{name} is a {gender} {classification} who is {age} years old and lives in {address}");
            }

            public static void makeSound(string name, string sound)
            {
                Console.WriteLine(name + " says " + sound);
            }
            */

            // Restricts direct access to some components, protecting data.
            // Creates a pet object using Pet Class.
            Pet petA = new Pet("Franky", "Female", "Dog", 10, "Manila", "Philippines");
            petA.DescribePet();
            petA.MakeSound();

            Pet petB = new Pet("Simba", "Male", "Lion", 1, "Pride Lands", "Rawr!");
            petA.DescribePet();
            petA.MakeSound();

            /*Calculator myCalculator = new Calculator("Casio", "500");
            myCalculator.Compute(23, 45, "divide");*/

            Casio myCalculator = new Casio("Casio", "500");
            myCalculator.Compute(23, 45, "divide");

            Sharp myOtherCalculator = new Sharp("Sharp", "1000");
            myOtherCalculator.Compute(23, 45, "divide");

            // Inheritance
            // One class inherits properties and methods from another.
            Reptile newReptile = new Reptile("water/land", true);
            newReptile.Sleep();


            Crocodile crocoBoy = new Crocodile();
            crocoBoy.Classification = "Reptile";
            crocoBoy.DietType = "Carnivore";
            crocoBoy.Habitat = "Fresh Water (Wilkins)";
            crocoBoy.HasScales = true;
            crocoBoy.Name = "Croco D Elia";
            crocoBoy.Age = 40;

            // Result of Inheritance
            Console.WriteLine("Result of Inheritance");
            crocoBoy.DescribePet(); // function from Crocodile
            crocoBoy.Swim(); // function from Crocodile
            crocoBoy.Sleep(); // Inherited from Reptile, which Reptile class inherited from Animal class
            crocoBoy.Eat(); // Inherited from Reptile class

            // name, age, classification, diettype, habitat, hasscales
            Crocodile myOtherPet = new Crocodile("Godzilla", 1000, "Reptile", "Carnivore", "Underground", true);
            Console.WriteLine("Result of Inheritance");
            myOtherPet.DescribePet(); // function from Crocodile
            myOtherPet.Swim(); // function from Crocodile
            myOtherPet.Sleep(); // Inherited from Reptile, which Reptile class inherited from Animal class
            myOtherPet.Eat(); // Inherited from Reptile class


            // Polymorphism
            // Allows methods to have the same use (function) but different implemention
            Console.WriteLine("Result of Polymorphism:");
            Turtle myFavoritePet = new Turtle("Rhaegal", 7, "Reptile", "Herbivore", "Salt Water", false);
            crocoBoy.Swim();
            crocoBoy.Swim(120);
            myFavoritePet.Swim();
            myFavoritePet.Eat();
            myFavoritePet.Eat("grass leaves");
            










        }
    }
}
