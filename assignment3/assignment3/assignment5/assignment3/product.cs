using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class product
    {
        static List<product> item = new List<product>();
        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string Name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public bool isAvailable { get; set; }
        public bool paymentMethod { get; set; }
        public void save()
        {

            item.Add(this);
        }

        public static List<product> getAllProduct()
        {
            return item;
        }

        public static product find(string Name)
        {
            return item.Find(i => i.Name == Name);

        }

    }
}
