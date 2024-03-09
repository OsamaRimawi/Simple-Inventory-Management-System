using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    public class Inventory
    {
        public List<Product> Products { get; set; }
        public Inventory() {
            Products = [];
        }
        public Inventory(List<Product> products)
        {
            Products = products;
        }

    }
}
