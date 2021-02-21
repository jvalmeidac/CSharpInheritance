using System;
using System.Collections.Generic;
using CSharpHeritage.Entities;

namespace CSharpHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choose = char.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 'c':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());

                            products.Add(new Product(name, price));
                            break;
                        }

                    case 'u':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Manufacturedate (DD/MM/YYYY): ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                            products.Add(new UsedProduct(name, price, manufactureDate));
                            break;
                        }

                    case 'i':
                        {
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Price: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Custom Fee: ");
                            double customFee = double.Parse(Console.ReadLine());

                            products.Add(new ImportedProduct(name, price, customFee));
                            break;
                        }
                    default:
                        Console.Write("Invalid option!");
                        return;
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
