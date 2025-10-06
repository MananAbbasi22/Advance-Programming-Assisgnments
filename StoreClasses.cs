using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class Item
    {
        public string Name { get; }
        public int Price { get; }
        public int Quantity { get; set; }
        public int Stock { get; set; }

        public Item(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Quantity = 0;
        }
    }

    public class StoreManager
    {
        private readonly List<Item> cart = new List<Item>();
        private readonly Dictionary<string, int> itemCount = new Dictionary<string, int>();
        private readonly Dictionary<string, Item> store = new Dictionary<string, Item>();
        private int totalSales = 0;

        public StoreManager()
        {
            store.Add("Men Cotton", new Item("Men Cotton", 4000, 10));
            store.Add("Men Silk", new Item("Men Silk", 4500, 10));
            store.Add("Men Wool", new Item("Men Wool", 4700, 10));
            store.Add("Women Cotton", new Item("Women Cotton", 6000, 10));
            store.Add("Women Silk", new Item("Women Silk", 6500, 10));
            store.Add("Women Wool", new Item("Women Wool", 6700, 10));
            store.Add("Children Cotton", new Item("Children Cotton", 3000, 10));
            store.Add("Children Silk", new Item("Children Silk", 3500, 10));
            store.Add("Children Wool", new Item("Children Wool", 3700, 10));
            store.Add("Hat", new Item("Hat", 500, 15));
            store.Add("Scarf", new Item("Scarf", 700, 15));
        }

        public Dictionary<string, Item> GetStoreItems() => store;

        public List<Item> GetCartItems() => cart;

        public int GetTotalSales() => totalSales;

        public bool AddToCart(string itemName, int qty)
        {
            if (string.IsNullOrWhiteSpace(itemName)) return false;
            if (!store.ContainsKey(itemName)) return false;
            var storeItem = store[itemName];
            if (qty <= 0) return false;
            if (qty > storeItem.Stock) return false;

            var existing = cart.Find(x => x.Name == itemName);
            if (existing != null)
            {
                existing.Quantity += qty;
            }
            else
            {
                cart.Add(new Item(storeItem.Name, storeItem.Price, storeItem.Stock) { Quantity = qty });
            }

            storeItem.Stock -= qty;
            return true;
        }

        public bool RemoveFromCart(string itemName)
        {
            var found = cart.Find(x => x.Name == itemName);
            if (found == null) return false;

            if (store.ContainsKey(itemName))
            {
                store[itemName].Stock += found.Quantity;
            }

            cart.Remove(found);
            return true;
        }

        public int Checkout(bool giftWrap, string promoCode)
        {
            int subtotal = 0;
            foreach (var item in cart)
            {
                int totalPrice = item.Price * item.Quantity;
                if (item.Quantity >= 3)
                    totalPrice = (int)(totalPrice * 0.9);

                subtotal += totalPrice;
                if (itemCount.ContainsKey(item.Name))
                    itemCount[item.Name] += item.Quantity;
                else
                    itemCount[item.Name] = item.Quantity;
            }

            if (giftWrap)
                subtotal += cart.Count * 200;

            if (subtotal > 20000)
                subtotal = (int)(subtotal * 0.95);

            if (!string.IsNullOrWhiteSpace(promoCode) && promoCode == "SALE10")
                subtotal = (int)(subtotal * 0.9);

            totalSales += subtotal;
            cart.Clear();
            return subtotal;
        }

        public string GetTopItem()
        {
            if (itemCount.Count == 0) return "No sales yet.";
            string top = null;
            int max = 0;
            foreach (var kv in itemCount)
            {
                if (kv.Value > max)
                {
                    max = kv.Value;
                    top = kv.Key;
                }
            }
            return $"{top} ({max} sold)";
        }
    }
}
