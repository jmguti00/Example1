using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FomeUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
           
            UpdateBindding();
        }

        static Exception myException = new Exception("Either last name does not exist, or you did not enter a last name");

        private void UpdateBindding()
        {
            try
            {
                PeopleFoundListbox.DataSource = people;
                PeopleFoundListbox.DisplayMember = "FullInfo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.GetPeople(LastNameText.Text);

            people = db.GetPeople(LastNameText.Text);

            UpdateBindding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";

        }
    }
}
