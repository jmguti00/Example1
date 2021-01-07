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
    public partial class Form1 : Form
    {
        public static List<comics> cart = new List<comics>(); //create comics list
        public static customer cCustomer = new customer(); //new customer for customer class

        //db connectivity info
        private OleDbDataAdapter comicDataAdapter;
        private DataSet comicDataSet;
        private OleDbCommandBuilder comicBuilder;
        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //connection to db file
                dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ComicStore.accdb");
                dbCommand = new OleDbCommand();
                dbCommand.CommandText = "SELECT * FROM CustomerTable Order By CustomerID ASC;"; //sql selection

                //tie command object and set the select command
                dbCommand.Connection = dbConnection;

                //create the DataAdapter and set the select command
                comicDataAdapter = new OleDbDataAdapter();
                comicDataAdapter.SelectCommand = dbCommand;

                //create and fill the data set
                comicDataSet = new DataSet();
                comicDataAdapter.Fill(comicDataSet, "Customers");

                //populate the data grid using data from data set
                dataGridView1.DataSource = comicDataSet;
                dataGridView1.DataMember = "Customers";
            }
            catch(Exception o)
            {
                MessageBox.Show(o.Message); //error message
            }
                       
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sSearch = txtSearch.ToString();
            try
            {
                //check radio buttons for search command
                if (rdoBtnLN.Checked)
                {
                    dbCommand.CommandText = "SELECT * FROM CustomerTable WHERE LastName = '" + txtSearch.Text + "';";
                }
                if (rdoBtnPhone.Checked)
                {
                    dbCommand.CommandText = "SELECT * FROM CustomerTable WHERE PhoneNumber = '" + txtSearch.Text + "';";
                }

                //create DataAdapter and set the select command
                comicDataAdapter = new OleDbDataAdapter();
                comicDataAdapter.SelectCommand = dbCommand;

                //create and fill the data set
                comicDataSet = new DataSet();
                comicDataAdapter.Fill(comicDataSet, "Customers");
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer f2 = new AddCustomer();
            f2.Show();
        }

        private void btnPullList_Click(object sender, EventArgs e)
        {
            PullList f3 = new PullList();
            f3.Show();
        }
    }

    public class customer
    {
        //customer class with get-set variables
        public string sCustomer { get; set; }
        public string sFN { get; set; }
        public string sLN { get; set; }
        public string sPhone { get; set; }
        public string sEmail { get; set; }
    }
    public class comics
    {
        public string book { get; set; }
    }
}
