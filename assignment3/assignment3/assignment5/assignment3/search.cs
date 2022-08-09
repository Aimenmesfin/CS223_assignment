using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void buttonesearch_Click(object sender, EventArgs e)
        {
            if (product.find(textBox1.Text) != null)
            {
                MessageBox.Show("product found");

            }
            else
                MessageBox.Show("product not found");
        }
    }
}
