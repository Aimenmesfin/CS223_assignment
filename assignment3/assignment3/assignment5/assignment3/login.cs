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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
         
            string un=txtun.Text;
            string ps=txtps.Text; 
            
            Form1 screen = new Form1(txtun.Text,this);    
            screen.Show();
            Hide();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
