using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class RegisterMenu : MenuBase
    {
        public void Display()
        {
            while (true)
            {
                Console.Clear();
                DisplayHeader("Register Menu:");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("[1] Register");
                Console.WriteLine("[2] Contact Support");
                Console.WriteLine("[3] Return to Main Menu");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        ContactSupport();
                        break;
                    case "3":
                        return;
                    default:
                        DisplayMessage("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void RegisterUser()
        {
            string username = GetUniqueUsername();
            string email = GetUniqueEmail();
            string password = GetValidatedPassword();
            string address = GetValidatedInput("Enter address: ");
            string contactNumber = GetValidatedInput("Enter contact number: ");

            var newUser = new User
            {
                Username = username,
                Email = email,
                Password = password,
                Address = address,
                ContactNumber = contactNumber,
                IsAdmin = false
            };

            MainMenu.users.Add(newUser);

            DisplayRegistrationSuccess(newUser);
        }

        private void ContactSupport()
        {
            Console.Clear();
            Console.WriteLine("Contact Support:");
            Console.WriteLine("For assistance, please reach out to support@example.com.");
            Console.WriteLine("Press any key to return to the registration menu...");
            Console.ReadKey();
        }

        private string GetUniqueUsername()
        {
            string username;
            do
            {
                username = GetValidatedInput("Enter username: ");
                if (IsUsernameTaken(username))
                {
                    DisplayMessage("Username already exists. Please choose another username.");
                }
            } while (IsUsernameTaken(username));
            return username;
        }

        private string GetUniqueEmail()
        {
            string email;
            do
            {
                email = GetValidatedInput("Enter email: ");
                if (IsEmailTaken(email))
                {
                    DisplayMessage("Email already exists. Please choose another email.");
                }
            } while (IsEmailTaken(email));
            return email;
        }

        private string GetValidatedPassword()
        {
            string password, confirmPassword;
            do
            {
                password = GetValidatedInput("Enter password: ");
                confirmPassword = GetValidatedInput("Confirm password: ");
                if (password != confirmPassword)
                {
                    DisplayMessage("Passwords do not match. Please try again.");
                }
            } while (password != confirmPassword);
            return password;
        }

        private string GetValidatedInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    DisplayMessage("Input cannot be null or empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        private bool IsUsernameTaken(string username)
        {
            return MainMenu.users.Exists(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        private bool IsEmailTaken(string email)
        {
            return MainMenu.users.Exists(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        private void DisplayRegistrationSuccess(User user)
        {
            Console.Clear();
            Console.WriteLine("Registration successful!");
            Console.WriteLine("User Overview:");
            Console.WriteLine($"Username: {user.Username}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Address: {user.Address}");
            Console.WriteLine($"Contact Number: {user.ContactNumber}");
            Console.WriteLine("Press any key to return to the registration menu...");
            Console.ReadKey();
        }

        private void DisplayMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }





    }
}
