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
        public Form1(string UserName)
        {
            InitializeComponent();
            label7.Text = UserName;
        }

        product p = new product();
        
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
                p1.isavailable = checkBox1.Checked;
                string msg = " ";
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    msg += item.ToString();
                }
                MessageBox.Show(msg + " ");
        

                
                
                        
                p1.Save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getallproducts();

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
       