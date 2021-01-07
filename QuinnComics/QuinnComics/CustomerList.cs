using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinnComics
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                comics newBook = new comics();  //create new comic - book object
                newBook.book = txtBook.Text;
                Form1.cart.Add(newBook); //add book to cart

                RefreshBookList();

                //empty textbox
                txtBook.Clear();
            }
            catch(Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void RefreshBookList()
        {
            try
            {
                listCBooks.Items.Clear();
                foreach (comics c in Form1.cart)
                {
                    listCBooks.Items.Add(c);
                }
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }

        }

        private void btnCancelList_Click(object sender, EventArgs e)
        {
            Form1.cart.Clear(); //clear cart to cancel
            this.Hide();

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            listCBooks.Items.Remove(listCBooks.Items[listCBooks.SelectedIndex]);
        }
    }
}
