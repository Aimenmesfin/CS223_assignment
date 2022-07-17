using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment3.model;


namespace assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        product p =new product();

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Regex reg = new Regex(@"[a-z]{3}$");
            if (String.IsNullOrEmpty(txtobjname.Text) || txtobjname.Text.Length < 3)
            {
                errorProvider1.SetError(txtobjname, "name is required");
            }
            else if (reg.IsMatch(txtobjname.Text)) 
                    {                 
                errorProvider1.Clear();
                product p1 = new product();
                try
                {
                    p1.count = Convert.ToInt32(txtcount.Text);
                    p1.price = Convert.ToDouble(txtprice.Text);
                    p1.number = Convert.ToInt32(txtnumber.Text);
                    p1.inventorynumber = Convert.ToInt32(sku.Text);   

                }
                catch
                {

                }
     
                p1.date = dt_registered_date.Text;
                p1.objname = txtobjname.Text;


                p1.Save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getallproducts();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
