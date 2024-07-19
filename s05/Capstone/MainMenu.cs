using System;
using System.Collections.Generic;

namespace Capstone
{
    internal class MainMenu : MenuBase
    {
        public static List<User> users = new List<User>
        {
            new User { Username = "admin", Email = "admin@mail.com", Password = "1234", IsAdmin = true }
        };

        public void Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Zuitt Asset Management App!");
                Console.WriteLine("Choose an option: [1] Login, [2] Register, [3] Contact Support, [4] Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        new LoginMenu().Display();
                        break;
                    case "2":
                        new RegisterMenu().Display();
                        break;
                    case "3":
                        DisplayContactSupport();
                        break;
                    case "4":
                        DisplayFarewellMessage();
                        Environment.Exit(0);
                        break;
                    default:
                        DisplayMessage("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void DisplayMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }

        private static void DisplayFarewellMessage()
        {
            Console.Clear();
            Console.WriteLine("Thank you for your hard work and see you again!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void DisplayContactSupport()
        {
            Console.Clear();
            Console.WriteLine("Contact Support:");
            Console.WriteLine("For any issues or inquiries, please reach out to support@zuitt.com.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
        }






    }
}
