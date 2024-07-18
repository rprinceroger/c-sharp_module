using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Casio : ICalculator
    {

        private string brand;
        private string price;

        public string Brand { get => brand; set => brand = value; }
        public string Price { get => price; set => price = value; }

        public Casio() { }

        public Casio(string brand, string price)
        {
            this.brand = brand;
            this.price = price;
        }

        public void Compute(double numA, double numB, String operation)
        {
            if (operation.Equals("add", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(numA + numB);
            }
            else if (operation.Equals("subtract", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(numA - numB);
            }
            else if (operation.Equals("multiply", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(numA * numB);
            }
            else if (operation.Equals("divide", StringComparison.InvariantCultureIgnoreCase) && numA > 0 && numB > 0)
            {
                Console.WriteLine(numA / numB);
            }
            else
            {
                Console.WriteLine("Invalid number or operation provided");
            }


        }

        public void TurnOff()
        {
            Console.WriteLine($"Closing {brand} calculator.");
        }





    }
}
