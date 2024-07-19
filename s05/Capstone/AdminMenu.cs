using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class AdminMenu : MenuBase
    {
        private User _user;

        public AdminMenu(User user)
        {
            _user = user;
        }

        public void Display()
        {
            while (true)
            {
                DisplayHeader($"Welcome {_user.Username}!");
                Console.WriteLine("Choose an option: [1] Retrieve All Items, [2] Create Item, [3] Edit Item, [4] Delete Item, [5] Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        ItemManagement.RetrieveAllItems();
                        break;
                    case "2":
                        ItemManagement.CreateItem();
                        break;
                    case "3":
                        ItemManagement.EditItem();
                        break;
                    case "4":
                        ItemManagement.DeleteItem();
                        break;
                    case "5":
                        return;
                    default:
                        DisplayMessage("Invalid option, please try again.");
                        break;
                }
            }
        }






    }
}
