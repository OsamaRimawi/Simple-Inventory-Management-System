using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Product(string name, double price, int quantity)
    {
        public string Name { get; set; } = name;
        public double Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;

        public override string ToString()
        {
            return ($"Product Name: {Name}, Price: {Price}, Quantity: {Quantity} ");
        }
    }
}
