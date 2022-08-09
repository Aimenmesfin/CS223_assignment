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



namespace assignment3
{
    public partial class Form1 : Form
    {
        Form loginPage;
        public Form1(string user,Form login)
        {
            InitializeComponent();
            lblun.Text = user;
            loginPage =login;
        }

        product p =new product();

        private void btnAdd_Click(object sender, EventArgs e)
        {


            Regex reg = new Regex(@"[a-z]{4}$");

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
                    p1.quantity = Convert.ToInt32(txtcount.Text);
                    p1.price = Convert.ToDouble(txtprice.Text);
                    p1.number = Convert.ToInt32(txtnumber.Text);
                    p1.inventoryNumber = Convert.ToInt32(sku.Text); 
                    p1.isAvailable=checkisavailable.Checked;
                    

                }
                catch
                {

                }
     
                p1.date = dt_registered_date.Text;
                p1.Name = txtobjname.Text;
                p1.isAvailable = checkisavailable.Checked;

                string message = " ";

               foreach(var i in item.CheckedItems)
                {
                    message+=i.ToString();
                   
                }
                MessageBox.Show(message);
                if (message == null)
                {
                    MessageBox.Show("Nothing checked");
                }
                p1.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getAllProduct();

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

        private void checkisavailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            loginPage.Show();
            Hide();
        }
    }
}
