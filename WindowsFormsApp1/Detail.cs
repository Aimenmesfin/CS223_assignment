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
    public partial class Detail : Form
    {
        public Detail(string itemName , double price , int qty , bool isavailable,int inventoryNum)
        {
           
            InitializeComponent();
            label1.Text = itemName;
            label2.Text = price.ToString();
            label3.Text = qty.ToString();
            label4.Text = isavailable.ToString();
            label10.Text = inventoryNum.ToString();
        }
    }
}
