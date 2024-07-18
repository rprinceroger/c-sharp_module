using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace discussion
{
    class Discussion
    {
        static List<Item> items = new List<Item>();
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            // Original items
            Item itemA = new Item(); // we used the empty constructor
            itemA.Name = "Pork";
            itemA.BeginningInventory = 100;
            itemA.StockIn = 10;
            itemA.StockOut = 5;
            itemA.TotalBalance = itemA.CalculateTotalBalance();

            Console.WriteLine(itemA.ToString());

            Item itemB = new Item("Beef", "South", 0, 0, 0);
            itemB.TotalBalance = itemB.CalculateTotalBalance();
            Console.WriteLine(itemB.ToString());

            Item itemC = new Item("Chicken", "South", 0, 0, 0);
            itemC.TotalBalance = itemC.CalculateTotalBalance();
            Console.WriteLine(itemC.ToString());

            Item itemD = new Item
            {
                Name = "Fish",
                BeginningInventory = 100,
                StockIn = 10,
                StockOut = 5,
                TotalBalance = 0
            };
            itemD.TotalBalance = itemD.CalculateTotalBalance();
            Console.WriteLine(itemD.ToString());

            items.Add(itemA);
            items.Add(itemB);
            items.Add(itemC);
            items.Add(itemD);

            // User
            User userA = new User("johndoe", "john@mail.com", "john1234", "123 Washington St.", "09123456789");
            Console.WriteLine(userA.ToString());

            // Main loop for user interaction
            while (true)
            {
                Console.WriteLine("Welcome to Zuitt Asset Management App!");
                Console.WriteLine("Choose an option: [1] Create Item, [2] Create User, [3] Exit");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CreateItem();
                        break;
                    case "2":
                        CreateUser();
                        break;
                    case "3":
                        Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        static void CreateItem()
        {
            Console.WriteLine("Enter item name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter item branch:");
            string branch = Console.ReadLine();

            Console.WriteLine("Enter item beginning inventory:");
            if (!int.TryParse(Console.ReadLine(), out int beginningInventory))
            {
                Console.WriteLine("Invalid input for beginning inventory. Please enter a number.");
                return;
            }

            Console.WriteLine("Enter item stock in:");
            if (!int.TryParse(Console.ReadLine(), out int stockIn))
            {
                Console.WriteLine("Invalid input for stock in. Please enter a number.");
                return;
            }

            Console.WriteLine("Enter item stock out:");
            if (!int.TryParse(Console.ReadLine(), out int stockOut))
            {
                Console.WriteLine("Invalid input for stock out. Please enter a number.");
                return;
            }

            // Validate stockOut against beginningInventory and stockIn
            if (stockOut > (beginningInventory + stockIn))
            {
                Console.WriteLine("Invalid input for stock out. Stock out cannot exceed the total stock available (Beginning Inventory + Stock In).");
                return;
            }

            // Calculate total balance
            Item newItem = new Item(name, branch, beginningInventory, stockIn, stockOut);
            newItem.TotalBalance = newItem.CalculateTotalBalance();
            items.Add(newItem);

            Console.WriteLine(newItem.ToString());
        }

        static void CreateUser()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            while (!IsValidEmail(email))
            {
                Console.WriteLine("Invalid email format. Please enter a valid email:");
                email = Console.ReadLine();
            }

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter contact number:");
            string contactNumber = Console.ReadLine();
            while (!IsValidContactNumber(contactNumber))
            {
                Console.WriteLine("Invalid contact number format. Please enter a valid contact number:");
                contactNumber = Console.ReadLine();
            }

            User newUser = new User(username, email, password, address, contactNumber);
            users.Add(newUser);

            Console.WriteLine(newUser.ToString());
        }

        static bool IsValidEmail(string email)
        {
            // Email validation
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        static bool IsValidContactNumber(string contactNumber)
        {
            // Validate contact number
            string pattern = @"^\d{10,15}$";
            return Regex.IsMatch(contactNumber, pattern);
        }
    }
}
