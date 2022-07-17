using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3.model
{
    internal class product
    {
        static List<product>products = new List<product>();
       public String objname { get; set; }
        public int number { get; set; }
        public int inventorynumber { get; set; }
        public String date{ get; set; }
        public int count { get; set; }
        public double price { get; set; }

        public void Save()
        {
            products.Add(this);
            MessageBox.Show($"{objname} added");
        }
         static public List<product>getallproducts()
        {
            return products;
        }
        

    }
}

