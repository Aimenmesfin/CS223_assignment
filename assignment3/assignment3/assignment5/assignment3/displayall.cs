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
    public partial class displayall : Form
    {
        public displayall()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = product.getAllProduct();

        }
    }
}
