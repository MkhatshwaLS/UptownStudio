using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UptownStudioApplication
{
    public partial class Customers : Form
    {


        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;

        //Declare Datafields
        public int CustomerID;
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string phoneNo;
        public string streetAddress;
        public string suburb;
        public string town;
        public string province;
        public string postalCode;

        public Customers()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            // Load Data Grid View 
            try
            {
                connection.Open();

                //Create SQL command
                string commandString = @"SELECT * FROM Customer";
                command = new SqlCommand(commandString, connection);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Customer");

                //Populate datagridview and display data
                dgvCustomers.DataSource = dataset;
                dgvCustomers.DataMember = "Customer";

                //Create custom heading
                dgvCustomers.Columns[0].HeaderText = "ID";
                dgvCustomers.Columns[1].HeaderText = "First Name";
                dgvCustomers.Columns[2].HeaderText = "Last Name";
                dgvCustomers.Columns[3].HeaderText = "Email";
                dgvCustomers.Columns[4].HeaderText = "Phone No";
                dgvCustomers.Columns[5].HeaderText = "Street Address";
                dgvCustomers.Columns[6].HeaderText = "Suburb";
                dgvCustomers.Columns[7].HeaderText = "Town";
                dgvCustomers.Columns[8].HeaderText = "Province";
                dgvCustomers.Columns[9].HeaderText = "Postal Code";
                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }

            //Fill Customer ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = @"SELECT CustomerID FROM Customer";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();

                // Read data and populate combobox
                while (reader.Read())
                {
                    cbCustomerID.Items.Add(reader.GetValue(0));
                }
                connection.Close();

            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }
            finally
            {
                connection.Close();
            }

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search for customer by name
            try
            {
                connection.Open();

                //Create SQL command
                string commandString = $"SELECT * FROM Customer WHERE Cus_First_Name LIKE '%{tbSearch.Text}%'";
                command = new SqlCommand(commandString, connection);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Customer");

                //Populate datagridview and display data
                dgvCustomers.DataSource = dataset;
                dgvCustomers.DataMember = "Customer";

                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if(tbFirstName.Text !="" || tbLastName.Text !="" || tbEmailAddress.Text !="" || tbPhoneNo.Text != "" || tbStreetAddress.Text != "" || tbSuburb.Text != "" || tbTown.Text != "" || tbProvince.Text != "" || tbPostalCode.Text != "")
            {
                try
                {
                    connection.Open();

                    //Read data from textboxes
                    firstName = tbFirstName.Text;
                    lastName = tbLastName.Text;
                    emailAddress = tbEmailAddress.Text;
                    phoneNo = tbPhoneNo.Text;
                    streetAddress = tbStreetAddress.Text;
                    suburb = tbSuburb.Text;
                    town = tbTown.Text;
                    province = tbProvince.Text;
                    postalCode = tbPostalCode.Text;

                    //Create SQL Command
                    string commandString = $"INSERT INTO Customer(Cus_First_Name, Cus_Last_Name, Cus_Email, Cus_Phone_No, Cus_Street_Address," +
                        $" Cus_Suburb, Cus_Town, Cus_Province, Cus_Postal_Code) VALUES ('{firstName}','{lastName}','{emailAddress}'," +
                        $"'{phoneNo}','{streetAddress}','{suburb}','{town}','{province}','{postalCode}')";

                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    connection.Close();

                    //confirmation message
                    MessageBox.Show("Customer information captured successfully");

                }
                catch (Exception message)
                {
                    MessageBox.Show("Connection Failed\n\n" + message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please specify all fields");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update entry ONLY if customer ID is specified in the comboBox

            if (cbCustomerID.Text!="" )
            {
                try
                {
                    //Read data from textboxes
                    firstName = tbFirstName.Text;
                    lastName = tbLastName.Text;
                    emailAddress = tbEmailAddress.Text;
                    phoneNo = tbPhoneNo.Text;
                    streetAddress = tbStreetAddress.Text;
                    suburb = tbSuburb.Text;
                    town = tbTown.Text;
                    province = tbProvince.Text;
                    postalCode = tbPostalCode.Text;

                    connection.Open();

                    //Create SQL Command
                    string commandString = $"UPDATE Customer SET Cus_First_Name='{firstName}',Cus_Last_Name='{lastName}'," +
                                            $"Cus_Email = '{emailAddress}', Cus_Phone_No = '{phoneNo}',Cus_Street_Address = '{streetAddress}'," +
                                            $"Cus_Suburb = '{suburb}', Cus_Town = '{town}',Cus_Province = '{province}'," +
                                            $"Cus_Postal_Code = '{postalCode}' WHERE CustomerID = {int.Parse(cbCustomerID.Text)}";

                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = command;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Customer ID " + cbCustomerID.Text + "  was successfully updated.");

                }
                catch (Exception message)
                {
                    MessageBox.Show("Connection Failed \n\n" + message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please specify Customer ID to be updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete entry ONLY if customer ID is specified in the comboBox
            
            if(cbCustomerID.Text != "")
            {
                try
                {
                    connection.Open();

                    //Create SQL Command
                    string commandString = $"DELETE FROM Customer WHERE CustomerID = {int.Parse(cbCustomerID.Text)}";
                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    //Execute Delete command
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Customer ID " + cbCustomerID.Text +" was successfully removed");
                    
                }
                catch (Exception message)
                {
                    MessageBox.Show("Connection Failed\n\n" + message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please specify Customer ID to be deleted.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and comboBox Items
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmailAddress.Text = "";
            tbPhoneNo.Text = "";
            tbStreetAddress.Text = "";
            tbSuburb.Text = "";
            tbTown.Text = "";
            tbProvince.Text = "";
            tbPostalCode.Text = "";
            cbCustomerID.Items.Clear();

            //Reload dataGridView and ComboBox
            loadData();
        }


        private void cbCustomerID_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerID = int.Parse(cbCustomerID.Text);
            
            //Fill Customer ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = $"SELECT * FROM Customer WHERE CustomerID LIKE {CustomerID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Read data and fill textboxes
                if (reader.Read())
                {
                    tbFirstName.Text = reader.GetValue(1).ToString();
                    tbLastName.Text = reader.GetValue(2).ToString();
                    tbEmailAddress.Text = reader.GetValue(3).ToString();
                    tbPhoneNo.Text = reader.GetValue(4).ToString();
                    tbStreetAddress.Text = reader.GetValue(5).ToString();
                    tbSuburb.Text = reader.GetValue(6).ToString();
                    tbTown.Text = reader.GetValue(7).ToString();
                    tbProvince.Text = reader.GetValue(8).ToString();
                    tbPostalCode.Text = reader.GetValue(9).ToString();
                }

                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
