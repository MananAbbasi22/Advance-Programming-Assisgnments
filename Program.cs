using System;
using System.Collections.Generic;

namespace TuckShopInventory
{
    class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public string Category;
        public int Quantity;
        public string Company;
    }

    class Program
    {
        static List<Product> p = new List<Product>();

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\n******* Tuck Shop Inventory ********");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Search Product by ID");
                Console.WriteLine("5. Search Products by Price Range");
                Console.WriteLine("6. Display All Products");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    case 4:
                        SearchById();
                        break;
                    case 5:
                        SearchByPrice();
                        break;
                    case 6:
                        DisplayAll();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 7);
        }

        static void AddProduct()
        {
            Product p1 = new Product();
            Console.Write("Enter Product ID: ");
            p1.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            p1.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Category: ");
            p1.Category = Console.ReadLine();
            Console.Write("Enter Stock Quantity: ");
            p1.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Company Name: ");
            p1.Company = Console.ReadLine();

            p.Add(p1);
            Console.WriteLine("Product added successfully!");
        }

        static void UpdateProduct()
        {
            Console.Write("Enter Product ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Product found = p.Find(x => x.Id == id);

            if (found != null)
            {
                Console.Write("Enter New Name: ");
                found.Name = Console.ReadLine();
                Console.Write("Enter New Price: ");
                found.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter New Category: ");
                found.Category = Console.ReadLine();
                Console.Write("Enter New Quantity: ");
                found.Quantity = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter New Company: ");
                found.Company = Console.ReadLine();
                Console.WriteLine("Product updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void RemoveProduct()
        {
            Console.Write("Enter Product ID to Remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Product found = p.Find(x => x.Id == id);

            if (found != null)
            {
                p.Remove(found);
                Console.WriteLine("Product removed successfully!");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void SearchById()
        {
            Console.Write("Enter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Product found = p.Find(x => x.Id == id);

            if (found != null)
            {
                Console.WriteLine("ID: " + found.Id);
                Console.WriteLine("Name: " + found.Name);
                Console.WriteLine("Price: " + found.Price);
                Console.WriteLine("Category: " + found.Category);
                Console.WriteLine("Quantity: " + found.Quantity);
                Console.WriteLine("Company: " + found.Company);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void SearchByPrice()
        {
            Console.Write("Enter Minimum Price: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Maximum Price: ");
            double max = Convert.ToDouble(Console.ReadLine());

            bool found = false;
            foreach (var p in p)
            {
                if (p.Price >= min && p.Price <= max)
                {
                    Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("No products in this range");
        }

        static void DisplayAll()
        {
            if (p.Count == 0)
            {
                Console.WriteLine("No products available");
                return;
            }

            foreach (var p in p)
            {
                Console.WriteLine($"{p.Id} | {p.Name} | {p.Price} | {p.Category} | {p.Quantity} | {p.Company}");
            }
        }
    }
}
