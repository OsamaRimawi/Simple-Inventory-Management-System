using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Driver
    {
        static Inventory inventory = new Inventory();

        public static void Main(string[] args)
        {
            string? userSelection;
            do
            {
                Console.WriteLine("************     Simple Inventory Managemen System      ************");
                Console.WriteLine("********************");
                Console.WriteLine("* Select an action *");
                Console.WriteLine("********************");
                Console.WriteLine("1: Add a product");
                Console.WriteLine("2: View all products");
                Console.WriteLine("3: Edit a product");
                Console.WriteLine("4: Delete a product:");
                Console.WriteLine("5: Search for a product");
                Console.WriteLine("0: Close application");

                Console.Write("Your selection: ");

                userSelection = Console.ReadLine();
                switch (userSelection)
                {
                    case "1":
                        AddNewProduct();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            } while (userSelection != "0");
        }

        private static void AddNewProduct()
        {

            Product newProduct;

            Console.Write("Enter the name of the product: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter the price of the product: ");
            double price = double.Parse(Console.ReadLine() ?? "0.0");

            Console.Write("Enter the quantity of the product: ");
            int quantity = int.Parse(Console.ReadLine() ?? "0");

            newProduct = new Product(name, price, quantity);
            inventory.Add(newProduct);
        }
    }
}
