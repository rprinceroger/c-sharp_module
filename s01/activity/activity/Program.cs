using System;
using System.Collections;

namespace ShoppingListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList();
            int choice;

            do
            {
                Console.WriteLine("Welcome to your shopping list app!");
                Console.WriteLine("=============== Menu ============");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("[1] Display all items in shopping list");
                Console.WriteLine("[2] Add a new item in shopping list");
                Console.WriteLine("[3] Remove an item in shopping list");
                Console.WriteLine("[4] Clear all items in shopping list");
                Console.WriteLine("[5] Exit");
                Console.WriteLine("=================================");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayItems(shoppingList);
                        break;
                    case 2:
                        AddItem(shoppingList);
                        break;
                    case 3:
                        RemoveItem(shoppingList);
                        break;
                    case 4:
                        shoppingList.Clear();
                        Console.WriteLine("All items cleared from the shopping list.");
                        break;
                    case 5:
                        Console.WriteLine("Exiting the app. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 5);
        }

        static void DisplayItems(ArrayList list)
        {
            Console.WriteLine("--------Shopping List Items----------");
            if (list.Count == 0)
            {
                Console.WriteLine("The shopping list is empty.");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"[{i}] {list[i]}");
                }
            }
            Console.WriteLine("-----------------------------------------");
        }

        static void AddItem(ArrayList list)
        {
            Console.Write("Enter the new item: ");
            string newItem = Console.ReadLine();
            list.Add(newItem);
            Console.WriteLine($"'{newItem}' added successfully.");
        }

        static void RemoveItem(ArrayList list)
        {
            Console.Write("Enter the index of the item to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index < list.Count)
                {
                    string itemToRemove = (string)list[index];
                    list.RemoveAt(index);
                    Console.WriteLine($"'{itemToRemove}' removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid index.");
            }
        }
    }
}
