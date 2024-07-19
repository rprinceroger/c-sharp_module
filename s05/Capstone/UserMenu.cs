using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class UserMenu : MenuBase
    {
        private User _user;

        public UserMenu(User user)
        {
            _user = user;
        }

        public void Display()
        {
            while (true)
            {
                DisplayHeader($"Welcome {_user.Username}!");
                Console.WriteLine("Choose an option: [1] Retrieve All Items [2] Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        ItemManagement.RetrieveAllItems();
                        break;
                    case "2":
                        return;
                    default:
                        DisplayMessage("Invalid option, please try again.");
                        break;
                }
            }
        }






    }
}
