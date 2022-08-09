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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
            {
                Form1 f1 = new Form1(txtUsername.Text);
                this.Hide();
                f1.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Incorrect Credintial");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
