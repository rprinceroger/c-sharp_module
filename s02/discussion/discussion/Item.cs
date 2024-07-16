using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal class Item
    {
        // Fields
        private string name;
        private readonly string branch;
        private int beginningInventory;
        private int stockIn;
        private int stockOut;
        private int totalBalance;

        // Getters and Setters
        public string Name { get => name; set => name = value; }
        public string Branch { get => branch; }
        public int BeginningInventory { get => beginningInventory; set => beginningInventory = value; }
        public int StockIn { get => stockIn; set => stockIn = value; }
        public int StockOut { get => stockOut; set => stockOut = value; }
        public int TotalBalance { get => totalBalance; set => totalBalance = value; }

        // Constructors
        public Item()
        {
            this.name = "Item";
            this.branch = "South";
            this.stockIn = 0;
            this.stockOut = 0;
            this.totalBalance = 0;
        }

        public Item(string name, string branch, int beginningInventory, int stockIn, int stockOut)
        {
            this.name = name;
            this.branch = branch;
            this.beginningInventory = beginningInventory;
            this.stockIn = stockIn;
            this.stockOut = stockOut;
            this.totalBalance = CalculateTotalBalance();
        }

        public int CalculateTotalBalance()
        {
            return BeginningInventory + StockIn - StockOut;
        }

        public override string ToString()
        {
            return $"{{Name: {name}, Branch: {branch}, Beginning Inventory: {beginningInventory}, Stock In: {stockIn}, Stock Out: {stockOut}, Total Balance: {totalBalance}}}";
        }
    }
}
