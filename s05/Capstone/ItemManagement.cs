using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal static class ItemManagement
    {
        private static List<Item> items = new List<Item>();
        private static int nextItemId = 1;

        public static void RetrieveAllItems()
        {
            Console.Clear();
            Console.WriteLine("Retrieve All Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Branch: {item.Branch}, Beginning Inventory: {item.BeginningInventory}, Stock In: {item.StockIn}, Stock Out: {item.StockOut}");
            }
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }

        public static void CreateItem()
        {
            Console.Clear();
            Console.WriteLine("Create Item:");

            string itemName = GetInput("Enter item name: ");
            string itemBranch = GetInput("Enter item branch: ");
            int itemBeginningInventory = int.Parse(GetInput("Enter item beginning inventory: "));
            int itemStockIn = int.Parse(GetInput("Enter item stock in: "));
            int itemStockOut = int.Parse(GetInput("Enter item stock out: "));

            Item newItem = new Item
            {
                Id = nextItemId++,
                Name = itemName,
                Branch = itemBranch,
                BeginningInventory = itemBeginningInventory,
                StockIn = itemStockIn,
                StockOut = itemStockOut
            };

            items.Add(newItem);
            DisplayMessage($"Item created successfully!\nOverview:\nID: {newItem.Id}\nName: {newItem.Name}\nBranch: {newItem.Branch}\nBeginning Inventory: {newItem.BeginningInventory}\nStock In: {newItem.StockIn}\nStock Out: {newItem.StockOut}");
        }

        public static void EditItem()
        {
            Console.Clear();
            Console.WriteLine("Edit Item:");

            int itemId = GetValidItemId(out Item item);

            string newItemName = GetInput("Enter new item name: ");
            string newItemBranch = GetInput("Enter new item branch: ");

            int newItemBeginningInventory;
            while (!int.TryParse(GetInput("Enter new item beginning inventory: "), out newItemBeginningInventory) || newItemBeginningInventory < 0)
            {
                DisplayMessage("Beginning inventory must be a non-negative integer. Please try again.");
            }

            int newItemStockIn;
            while (!int.TryParse(GetInput("Enter new item stock in: "), out newItemStockIn) || newItemStockIn < 0)
            {
                DisplayMessage("Stock in must be a non-negative integer. Please try again.");
            }

            int newItemStockOut;
            while (!int.TryParse(GetInput("Enter new item stock out: "), out newItemStockOut) || newItemStockOut < 0 || newItemStockOut > newItemStockIn)
            {
                if (newItemStockOut < 0)
                {
                    DisplayMessage("Stock out must be a non-negative integer. Please try again.");
                }
                else
                {
                    DisplayMessage("Stock out cannot be greater than stock in. Please try again.");
                }
            }

            item.Name = newItemName;
            item.Branch = newItemBranch;
            item.BeginningInventory = newItemBeginningInventory;
            item.StockIn = newItemStockIn;
            item.StockOut = newItemStockOut;

            DisplayMessage($"Item edited successfully!\nOverview:\nID: {item.Id}\nName: {item.Name}\nBranch: {item.Branch}\nBeginning Inventory: {item.BeginningInventory}\nStock In: {item.StockIn}\nStock Out: {item.StockOut}");
        }

        public static void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("Delete Item:");

            int itemId = GetValidItemId(out Item item);

            items.Remove(item);
            DisplayMessage("Item deleted successfully!");
        }

        private static int GetValidItemId(out Item item)
        {
            item = null;
            int itemId;
            do
            {
                Console.Write("Enter item ID: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out itemId))
                {
                    item = items.Find(i => i.Id == itemId);
                }
                if (item == null)
                {
                    DisplayMessage("Invalid item ID. Please try again.");
                }
            } while (item == null);
            return itemId;
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to return...");
            Console.ReadKey();
        }











    }
}
