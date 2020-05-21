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
    public partial class FormEmp : Form
    {
      
        
            public FormEmp()
            {
                InitializeComponent();
                ShowEmps();
            }

            void ShowEmps()
            {
                listViewEmp.Items.Clear();
                foreach (EmpSet empsSet in Program.libDb.EmpSet)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    empsSet.id.ToString(), empsSet.Name, empsSet.Phone, empsSet.Email, empsSet.Position
                    });
                    item.Tag = empsSet;
                    listViewEmp.Items.Add(item);

                }
                listViewEmp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            }

            private void listViewEmp_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (listViewEmp.SelectedItems.Count == 1)
                {
                    EmpSet empsSet = listViewEmp.SelectedItems[0].Tag as EmpSet;
                    textBoxName.Text = empsSet.Name;
                    textBoxPhone.Text = empsSet.Phone;
                    textBoxEmail.Text = empsSet.Email;
                    textBoxPos.Text = empsSet.Position;
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxPos.Text = "";
                    textBoxPhone.Text = "";
                    textBoxEmail.Text = "";
                }
            }

           

           

        private void FormEmp_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            EmpSet empsSet = new EmpSet();
            empsSet.Name = textBoxName.Text;
            empsSet.Phone = textBoxPhone.Text;
            empsSet.Email = textBoxEmail.Text;
            empsSet.Position = textBoxPos.Text;
            Program.libDb.EmpSet.Add(empsSet);
            Program.libDb.SaveChanges();
            ShowEmps();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewEmp.SelectedItems.Count == 1)
            {
                EmpSet empsSet = listViewEmp.SelectedItems[0].Tag as EmpSet;
                empsSet.Name = textBoxName.Text;
                empsSet.Phone = textBoxPhone.Text;
                empsSet.Email = textBoxEmail.Text;
                empsSet.Position = textBoxPos.Text;
                Program.libDb.SaveChanges();
                ShowEmps();
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmp.SelectedItems.Count == 1)
                {
                    EmpSet empsSet = listViewEmp.SelectedItems[0].Tag as EmpSet;
                    Program.libDb.EmpSet.Remove(empsSet);
                    Program.libDb.SaveChanges();
                    ShowEmps();
                }
                textBoxName.Text = "";
                textBoxPos.Text = "";
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
