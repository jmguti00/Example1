using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinnComics
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

   private void AddCustomer_Load(object sender, EventArgs e)
        {
            //clear all fields
           
            txtFN.Clear();
            txtLN.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

 private void btnCancel_Click(object sender, EventArgs e)
        {
            //clear all fields
            
            txtFN.Clear();
            txtLN.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //variables, db connection & command
            string sConnection = null;
            OleDbConnection dbConnection;
            OleDbCommand dbCommand;
            string sql = null;

            try
            {
                sConnection = ("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ComicStore.accdb"); //connection to database
                //sql statement for insert
                sql = "INSERT INTO CustomerTable (FirstName, LastName, PhoneNumber, Email) VALUES ('" + txtFN.Text + "', '" + txtLN.Text + "', '" + txtPhone.Text + "', '" + txtEmail + "');";
                dbConnection = new OleDbConnection(sConnection);

                dbConnection.Open();
                dbCommand = new OleDbCommand(sql, dbConnection);
                dbCommand.ExecuteNonQuery();
                dbCommand.Dispose();
                dbConnection.Close();

            }
            catch(Exception a)
            {
                MessageBox.Show("Error Opening " + a.ToString());
            }
            this.Hide();
        }

       
    }
}
