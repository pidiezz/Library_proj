using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_proj
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            

        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClients();
            formClient.Show();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            Form formEmp = new FormEmp();
            formEmp.Show();
        }

        private void buttonBox_Click(object sender, EventArgs e)
        {
            Form formBook = new FormBook();
            formBook.Show();
        }


    }
}
