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
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void mdi_Load(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Form1 form = new Form1(" login ", this);
            form.MdiParent=this;
            form.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            displayall display = new displayall();
            display.MdiParent = this;  
            display.Show();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            search s= new search();
            s.MdiParent = this;
            s.Show();
        }
    }
}
