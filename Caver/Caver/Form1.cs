using Caver;
using System.Data;

namespace Caver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the options for the LicenseType ComboBox
            comboBoxLicenseType.Items.Add("A");
            comboBoxLicenseType.Items.Add("B");
            comboBoxLicenseType.Items.Add("AM");
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Gather the input values
            string firstname = textBoxFirstname.Text;
            string lastname = textBoxLastname.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string street = textBoxStreet.Text;
            int houseNum = Convert.ToInt32(textBoxHouseNum.Text);
            string zipcode = textBoxZipcode.Text;
            string licenseType = comboBoxLicenseType.SelectedItem?.ToString();
            string handicapVehicle = checkBoxYes.Checked ? "Yes" : "No";

            // Create an instance of the Database class
            Database database = new Database();

            // Check if the email or phone already exist in the database
            bool emailExists = database.CheckEmailExists(email);
            bool phoneExists = database.CheckPhoneExists(phone);

            if (emailExists || phoneExists)
            {
                MessageBox.Show("This email address or phone number is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate the INSERT query
            string prospectInsert = $"INSERT INTO Prospect (Firstname, Lastname, Email, Phone, Street, HouseNum, Zipcode, LicenceType, HandicapVehicle) VALUES ('{firstname}', '{lastname}', '{email}', '{phone}', '{street}', {houseNum}, '{zipcode}', '{licenseType}', '{handicapVehicle}')";

            // Call the Insert method and pass the prospectInsert query
            database.Insert(prospectInsert);

            // Clear the input fields
            ClearInputFields();

            // Show success message
            MessageBox.Show("Prospect successfully added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearInputFields()
        {
            textBoxFirstname.Text = string.Empty;
            textBoxLastname.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            textBoxHouseNum.Text = string.Empty;
            textBoxZipcode.Text = string.Empty;
            comboBoxLicenseType.SelectedItem = null;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;
        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxYes.Checked)
            {
                checkBoxNo.Checked = false;
            }
        }
        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked)
            {
                checkBoxYes.Checked = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create an instance of the Database class
            Database database = new Database();

            // Call the ViewProspects method to retrieve all prospects
            DataTable prospectsTable = database.ViewProspects();

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = prospectsTable;
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            // Create an instance of the Database class
            Database database = new Database();

            // Call the ViewProspects method to retrieve all prospects
            DataTable prospectsTable = database.ViewProspects();

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = prospectsTable;
        }
    }
}