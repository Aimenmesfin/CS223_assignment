using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
            //lblDisplayName.Text = userName;
                
        }

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"[a-z]{3}$");
            //to check if the text area is null or empty and also to check the length of the string 
            if (String.IsNullOrEmpty(txtName.Text) || txtName.Text.Length < 3)
            {
                //gives error symbol if textarea is empty or null and takes 2 parameters the text area and the message
                errorProvider1.SetError(txtName, "Name is required and must be morethan 3 char...");
            }

           else if(reg.IsMatch(txtName.Text))
            {
//we have to clear the error provider or it wont stop generating an error
                errorProvider1.Clear();
                Item it = new Item();


                    try
                {
                    it.number = Convert.ToInt32(txt_num.Text);
                    it.price = Convert.ToDouble(txtPrice.Text);
                    it.quantity = Convert.ToInt32(txtQty.Text);
                    it.inventoryNumber = Convert.ToInt32(txt_InventoryNum.Text);
                }
                catch
                {

                }
                it.Name = txtName.Text;
                it.date = dateTimePicker1.Text;
                it.isAvailable = chkAvailable.Checked;
                string msg = " ";
              foreach(var item in chklistbox.CheckedItems)
                {
                    msg += item.ToString();
                    if (msg.Length == 0)
                    {
                        MessageBox.Show("Nothing checked");
                    }
                }
                MessageBox.Show(msg + " ");
                it.save();
//data grid view used to display the data after the add button is clicked
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.getAllProduct();
                MessageBox.Show($"the Item {it.Name}Saved ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAvailable_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_inventory_Click(object sender, EventArgs e)
        {

        }
    }
}
