using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Panels : Form
    {
        public Panels()
        {
            InitializeComponent();
            
        }
       

       

        private void Panels_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Item.getAllProduct())
            {
                ProductUserControl product = new ProductUserControl();
                product.ProductName = item.Name;
                product.Price = item.price;
                product.Quantity = item.quantity;
                flowLayoutPanel1.Controls.Add(product);
            }

            
            

        }
    }
}
