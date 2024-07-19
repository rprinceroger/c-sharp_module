using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class LoginMenu : MenuBase
    {
        public void Display()
        {
            while (true)
            {
                DisplayHeader("Login Menu:");
                Console.WriteLine("Choose an option: [1] Login, [2] Contact Support, [3] Return to Main Menu");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ProcessLogin();
                        break;
                    case "2":
                        DisplayContactSupport();
                        break;
                    case "3":
                        return;
                    default:
                        DisplayMessage("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ProcessLogin()
        {
            string email = GetInput("Enter email: ");
            string password = GetPassword("Enter password: ");

            User user = MainMenu.users.Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                if (user.IsAdmin)
                {
                    new AdminMenu(user).Display();
                }
                else
                {
                    new UserMenu(user).Display();
                }
            }
            else
            {
                DisplayMessage("Invalid email or password.");
            }
        }

        private string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private string GetPassword(string prompt)
        {
            Console.Write(prompt);
            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(intercept: true);
                if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password.Append(keyInfo.KeyChar);
                    Console.Write('*');
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password.ToString();
        }

        private static void DisplayMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayContactSupport()
        {
            Console.Clear();
            Console.WriteLine("Contact Support:");
            Console.WriteLine("For any issues or inquiries, please reach out to support@zuitt.com.");
            Console.WriteLine("Press any key to return to the login menu...");
            Console.ReadKey();
        }





    }
}
