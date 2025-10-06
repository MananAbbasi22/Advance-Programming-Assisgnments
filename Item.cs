using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Item
    {
        public readonly string Name;
        public readonly int Price;
        public int Quantity;
        public int Stock;

        public Item(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Quantity = 0;
        }
    }
}
