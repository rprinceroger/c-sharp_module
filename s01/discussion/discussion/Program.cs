using System.Collections;

namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLing()
            Console.WriteLine("Hello, World");

            // [Section] variables, data types, and Constants
            String myString = "Zuitt Asset Manager";
            int myInt = 0;        // int: Stores whole numbers from -2,147,483,648 to 2,147,483,647.
            float myFloat = 5.12345678F; // float: Single-precision floating-point type. Stores fractional numbers with 6-7 digits of precision. Requires 'F' suffix.
            double myDouble = 2.5D; // double: Double-precision floating-point type. Stores fractional numbers with 15-16 digits of precision. Default type for floating-point literals; 'D' suffix is optional.
            decimal myDecimal = 8.4M; // decimal: High-precision decimal type. Stores fractional numbers with 28-29 significant digits. Used for financial and monetary calculations. Requires 'M' suffix.
            long myLong = 57390L; // long: Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. Requires 'L' suffix.
            bool myBoolean = false;
            const double interest = 5.3;



            Console.WriteLine("Result of Data Types: ");
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);
            Console.WriteLine(myLong);
            Console.WriteLine(myBoolean);
            Console.WriteLine(interest);

            // interest = 6 %;

            // Interpolation (Sting Interpolation)
            Console.WriteLine("double: {0}, decimal: {1}, boolean: {2}", myDouble, myDecimal, myBoolean);

            // [Section] Operators
            int numA = 10;
            int numB = 3;

            // Arithmetic Operators
            Console.WriteLine("Result of Arithmetic Operators: ");
            Console.WriteLine(numA + numB); // 13
            Console.WriteLine(numA - numB); // 7
            Console.WriteLine(numA * numB); // 30
            Console.WriteLine(numA / numB); // 3
            Console.WriteLine(numA % numB); // 1

            // Increment
            numA++; // 11
            // numA = numA + 1
            // numA+=1
            Console.WriteLine(numA);

            // Decrement
            numA--; // 10
            // numA = numA - 1
            // numA-=1
            Console.WriteLine(numA);

            // Relational Operators
            Console.WriteLine("Result of Relational Operators: ");
            Console.WriteLine(numA == numB); // false
            Console.WriteLine(numA != numB); // true
            Console.WriteLine(numA > numB); // true
            Console.WriteLine(numA < numB); // false
            Console.WriteLine(numA >= numB); // true
            Console.WriteLine(numA <= numB); // false

            // Logical Operators
            Console.WriteLine("Result of Logical Operators: ");
            // OR operator (one True always True)
                                // false        // true
            Console.WriteLine(numA == numB || numA > numB); // true
            // AND operator (one False always False)
                                // false        // true
            Console.WriteLine(numA == numB && numA > numB); // false
            // NOT operator
            Console.WriteLine(!myBoolean); // !false --> true

            // [Section] Conditional Statements
            // If, Else if, Else Statement
            Console.WriteLine("Result of If, Else If and Else Statements:");
            if (numA > numB)
            {
                Console.WriteLine("numA is greater than numB");
            }
            else if (numA == numB)
            {
                Console.WriteLine("numA is equal to numB");
            }
            else
            {
                Console.WriteLine("numA is less than numB");
            }

            // Switch Statements
            Console.WriteLine("What day of the week is today: ");
            String day = Console.ReadLine(); // .ReadLine() accepts the input of the user the console.
            day = day.ToLower();

            // case / situation / scenario
            Console.WriteLine("Result of Switch statements: ");
            switch (day)
            {
                case "monday":
                    Console.WriteLine("Red");
                    break;
                case "tuesday":
                    Console.WriteLine("Blue");
                    break;
                case "wednesday":
                    Console.WriteLine("Green");
                    break;
                default:
                    Console.WriteLine("Black");
                    break;
            }

            // Conditional Operator
            Console.WriteLine("Result of Conditional Operator: ");
            Console.WriteLine(numA > numB ? "I'm greater." : "I'm just lesser or equal to numB.");

            // [Section] Loops
            Console.WriteLine("Result of While Loops:");
            // numA = 0
            while (numA > 0) // (numA >= 0) // numA = 0
            {
                Console.WriteLine("value of numA: {0}", numA);
                numA--;
            }

            numA = 10;
            // it assures that it will do the task atleast once.
            do
            {
                Console.WriteLine("value of numA (Using do while loop): {0}", numA);
                numA--;
            }
            while (numA > 0); // (-10 > 0) // false

            // declaration, condition, change of value, 
            numA = 0;
            for (int numX = 10; numX > 0; numX--) 
            {
                Console.WriteLine("value of i {0}", numX);
            }

            // Continue and Break Statements
            Console.WriteLine("Result of Continue and Break Statement");

            int numC = 0;
            while (numC > 20)
            {

                if (numC % 5 == 0)
                {
                    Console.WriteLine("value of numC: {0}", numC); // 0
                    numC++;
                    continue;
                }
                Console.WriteLine("You can see me, because I'm not skipped. numC: {0}", numC);

                if (numC == 11)
                {
                    Console.WriteLine("Stop the loop!");
                    break;
                }

                numC++;

            }

            // [Section] Arrays
            int[] sales = new int[3];
            sales[0] = 10;
            sales[1] = 5;
            sales[2] = 27;
            Console.WriteLine("Result from arrays: ");
            Console.WriteLine(sales[0]);
            Console.WriteLine(sales[1]);
            Console.WriteLine(sales[2]);
            // Console.WriteLine(sales[3]);
            Console.WriteLine(sales);

            // ArrayList
            
            // Declaring a list without a single item initially
            ArrayList myArrayList = new ArrayList();

            // Declaring and initializing
            ArrayList customers = new ArrayList(new string[] { "Donald", "Mickey", "Goofy" });

            customers.Add("Minnie");
            customers.Add("Ichigo");
            customers.Add("John");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("number of customers: " + customers.Count);
            customers.Remove("Mickey");
            customers.RemoveAt(2);

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            // Donald, Goofy, Ichigo, John
            
            customers.Insert(2, "Luffy");
            Console.WriteLine("Result of insert method: ");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            customers.RemoveRange(1, 2);
            Console.WriteLine("Result of RemoveRange method: ");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            // Donald, Ichigo, John
            customers[0] = "Donald Duck";
            Console.WriteLine("Result from updating an element: ");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            customers.Sort();
            Console.WriteLine("Result from Sort method: ");

            foreach (string customer in customers)
            {
                Console.WriteLine(customer);
            }

            // Hashtable
            Hashtable address = new Hashtable();

            address.Add("houseNumber", "15");
            address.Add("street", "Apple");
            address.Add("city", "California");
            address.Add("zip", "19463");

            // Get the keys of our hashtable

            // Collect all the keys and store it in a variable named "addressKeys"
            ICollection addressKeys = address.Keys;
            // ["houseNumbers", "street", "city", "zip"]

            Console.WriteLine("Result from accessing Hashtable keys: ");
            Console.WriteLine(address["street"]);

            foreach (string key in addressKeys)
            {
                Console.WriteLine(address[key]);
            }


        }
    }
}