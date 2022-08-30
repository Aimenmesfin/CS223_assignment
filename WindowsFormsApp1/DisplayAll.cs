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
    public partial class DisplayAll : Form
    {
        public DisplayAll()
        {
            InitializeComponent();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Item.getAllProduct();
        }



       

       
    }
}
