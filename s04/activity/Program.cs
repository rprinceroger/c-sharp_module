namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please input a number");
            int numA = Convert.ToInt32(Console.ReadLine());
            */

            /*
            int numA;

            try
            {
                Console.WriteLine("Please input a number");
                numA = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("The input you provided is not a number");
                Console.WriteLine("Please input a valid number");
                numA = Convert.ToInt32(Console.ReadLine());
            }
            
            catch(Exception e) { // generic
                // Console.WriteLine(e.ToString()); // This shows the error exception encountered and the kind of Exception
                Console.WriteLine(e.Message);
                Console.WriteLine("Please input a valid number");
                numA = Convert.ToInt32(Console.ReadLine());
            }
            finally // finally - works with our without Exception Error
            {
                // Console.WriteLine("Please input a valid number");
                // numA = Convert.ToInt32(Console.ReadLine());
            }
            */
            try
            {
                MultipleExceptions();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide a number by zero.");
                Console.WriteLine(e.Message);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("The element you are trying to access does not exist.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(e.Message);
            }
        }

        public static void MultipleExceptions()
        {
            Console.WriteLine("Which error would you like to receive? [1]DivideByZeroException, [2]UserDefinedException, [3]IndexOutOfRangeException");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please input a number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int divideByZero = number / 0;
                    break;

                case 2:
                    Console.WriteLine("Input age:");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age < 0)
                    {
                        throw new MyException("Negative number is not allowed for age.");
                    }
                    break;

                case 3:
                    int[] array = new int[3];
                    Console.WriteLine(array[3]);
                    break;

                default:
                    Console.WriteLine("Please input a valid option.");
                    break;
            }
        }





    }
}