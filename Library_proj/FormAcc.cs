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
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            ShowBook();
        }
      
        void ShowBook()
        {
            listViewBook.Items.Clear();
            foreach (BookSet booksSet in Program.libDb.BookSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    booksSet.id.ToString(), booksSet.Title, booksSet.Description, booksSet.Genre, booksSet.Date_of_capture, booksSet.Date_of_delivery
                });
                item.Tag = booksSet;
                listViewBook.Items.Add(item);

            }
            listViewBook.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count == 1)
            {
                BookSet booksSet = listViewBook.SelectedItems[0].Tag as BookSet;
                textBoxTitle.Text = booksSet.Title;
                textBoxDescription.Text = booksSet.Description;
                textBoxGenre.Text = booksSet.Genre;
                textBoxDateCap.Text = booksSet.Date_of_capture;
                textBoxDateDeliv.Text = booksSet.Date_of_delivery;
            }
            else
            {
                textBoxTitle.Text = "";
                textBoxDateCap.Text = "";
                textBoxDescription.Text = "";
                textBoxGenre.Text = "";
                textBoxDateDeliv.Text = "";
            }
        }

       

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            BookSet booksSet = new BookSet();
            booksSet.Title = textBoxTitle.Text;
            booksSet.Description = textBoxDescription.Text;
            booksSet.Genre = textBoxGenre.Text;
            booksSet.Date_of_capture = textBoxDateCap.Text;
            booksSet.Date_of_delivery = textBoxDateDeliv.Text;
            Program.libDb.BookSet.Add(booksSet);
            Program.libDb.SaveChanges();
            ShowBook();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count == 1)
            {
                BookSet booksSet = listViewBook.SelectedItems[0].Tag as BookSet;
                booksSet.Title = textBoxTitle.Text;
                booksSet.Description = textBoxDescription.Text;
                booksSet.Genre = textBoxGenre.Text;
                booksSet.Date_of_capture = textBoxDateCap.Text;
                booksSet.Date_of_delivery = textBoxDateDeliv.Text;
                Program.libDb.SaveChanges();
                ShowBook();
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewBook.SelectedItems.Count == 1)
                {
                    BookSet booksSet = listViewBook.SelectedItems[0].Tag as BookSet;
                    Program.libDb.BookSet.Remove(booksSet);
                    Program.libDb.SaveChanges();
                    ShowBook();
                }
                textBoxTitle.Text = "";
                textBoxDateCap.Text = "";
                textBoxDescription.Text = "";
                textBoxGenre.Text = "";
                textBoxDateDeliv.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта кнопка используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

