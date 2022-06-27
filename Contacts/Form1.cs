using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Form1 : Form
    {

        private Contact[] arrPhonebook = new Contact[1];


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.FirstName = txtfirstName.Text;
            c.LastName = txtlastName.Text;
            c.Phone = txtPhone.Text;

            listContacts.Items.Add(c.ToString());
        }
    }
}
