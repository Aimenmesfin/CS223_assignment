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
    public partial class ProductUserControl : UserControl

    {
        private String _ProductName;
        private double _price;
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; label3.Text = value.ToString(); }
        }


        public double Price
        {
            get { return _price; }
            set { _price = value; label2.Text = value.ToString(); }
        }


        public String ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; label1.Text = value; }
        }
        

        public ProductUserControl()
        {
            InitializeComponent();
        }

    }
}
