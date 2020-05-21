﻿using System;
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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }
    
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientsSet in Program.libDb.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.id.ToString(), clientsSet.Name, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);

            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxName.Text = clientsSet.Name;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                textBoxName.Text = "";

                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

       

   

        private void listViewClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            ClientSet clientsSet = new ClientSet();
            clientsSet.Name = textBoxName.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            Program.libDb.ClientSet.Add(clientsSet);
            Program.libDb.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientsSet.Name = textBoxName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.libDb.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.libDb.ClientSet.Remove(clientsSet);
                    Program.libDb.SaveChanges();
                    ShowClient();
                }
                textBoxName.Text = "";

                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
