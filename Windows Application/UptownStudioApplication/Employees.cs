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
    public partial class Employees : Form
    {


        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;

        //Declare Datafields
        public int employeeID;
        public string employeeFirstName;
        public string employeeLastName;
        public string employeeRole;
        public string employeeEmail;
        public string employeePhoneNo;


        public Employees()
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
                string commandString = @"SELECT EmployeeID,Emp_First_Name,Emp_Last_Name,Emp_Role,Emp_Email,Emp_Phone_No FROM Employee";
                command = new SqlCommand(commandString, connection);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Employee");

                //Populate datagridview and display data
                dgvEmployees.DataSource = dataset;
                dgvEmployees.DataMember = "Employee";

                //Create Emptom heading
                dgvEmployees.Columns[0].HeaderText = "ID";
                dgvEmployees.Columns[1].HeaderText = "First Name";
                dgvEmployees.Columns[2].HeaderText = "Last Name";
                dgvEmployees.Columns[3].HeaderText = "Role";
                dgvEmployees.Columns[4].HeaderText = "Email Address";
                dgvEmployees.Columns[5].HeaderText = "Phone";

                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }

            //Fill Employee ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = @"SELECT EmployeeID FROM Employee";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();

                // Read data and populate combobox
                while (reader.Read())
                {
                    cbEmployeeID.Items.Add(reader.GetValue(0));
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

        private void Employees_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" || tbLastName.Text != "" || tbEmployeeRole.Text != "" || tbPhoneNo.Text != "" || tbEmailAddress.Text != "")
            {
                try
                {
                    connection.Open();

                    //Read data from textboxes
                    employeeFirstName = tbFirstName.Text;
                    employeeLastName = tbLastName.Text;
                    employeeRole = tbEmployeeRole.Text;
                    employeeEmail = tbEmailAddress.Text;
                    employeePhoneNo = tbPhoneNo.Text;
                    

                    //Create SQL Command
                    string commandString = $"INSERT INTO Employee(Emp_First_Name, Emp_Last_Name,Emp_Role,Emp_Email,Emp_Phone_No) " +
                        $"VALUES ('{employeeFirstName}','{employeeLastName}','{employeeRole}','{employeeEmail}','{employeePhoneNo}')";
                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    connection.Close();

                    //confirmation message
                    MessageBox.Show("Employee information captured successfully");

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
            //Update entry ONLY if Employee ID is specified in the comboBox

            if (cbEmployeeID.Text != "")
            {
                try
                {
                    //Read data from textboxes
                    employeeFirstName = tbFirstName.Text;
                    employeeLastName = tbLastName.Text;
                    employeeRole = tbEmployeeRole.Text;
                    employeeEmail = tbEmailAddress.Text;
                    employeePhoneNo = tbPhoneNo.Text;

                    connection.Open();

                    //Create SQL Command
                    string commandString = $"UPDATE Employee SET Emp_First_Name='{employeeFirstName}',Emp_Last_Name='{employeeLastName}'," +
                                            $"Emp_Role = '{employeeRole}', Emp_Phone_No = {employeePhoneNo}," +
                                            $"Emp_Email = '{employeeEmail}'WHERE EmployeeID = {int.Parse(cbEmployeeID.Text)}";

                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = command;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Employee ID " + cbEmployeeID.Text + "  was successfully updated.");

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
                MessageBox.Show("Please specify Employee ID to be updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete entry ONLY if Employee ID is specified in the comboBox

            if (cbEmployeeID.Text != "")
            {
                try
                {
                    connection.Open();

                    //Create SQL Command
                    string commandString = $"DELETE FROM Employee WHERE EmployeeID = {int.Parse(cbEmployeeID.Text)}";
                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    //Execute Delete command
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Employee ID " + cbEmployeeID.Text + " was successfully removed");

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
                MessageBox.Show("Please specify Employee ID to be deleted.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and comboBox Items
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmployeeRole.Text = "";
            tbPhoneNo.Text = "";
            tbEmailAddress.Text = "";
            cbEmployeeID.Text = "";
            cbEmployeeID.Items.Clear();

            //Reload dataGridView and ComboBox
            loadData();
        }


        private void cbEmployeeID_SelectedValueChanged(object sender, EventArgs e)
        {
            employeeID = int.Parse(cbEmployeeID.Text);

            //Fill Employee ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = $"SELECT Emp_Role,Emp_First_Name,Emp_Last_Name,Emp_Phone_No,Emp_Email FROM Employee WHERE EmployeeID LIKE {employeeID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Read data and fill textboxes
                if (reader.Read())
                {
                    
                    tbFirstName.Text = reader.GetValue(1).ToString();
                    tbLastName.Text = reader.GetValue(2).ToString();
                    tbEmployeeRole.Text = reader.GetValue(0).ToString();
                    tbEmailAddress.Text = reader.GetValue(4).ToString();
                    tbPhoneNo.Text = reader.GetValue(3).ToString();
                    
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

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

    }
}
