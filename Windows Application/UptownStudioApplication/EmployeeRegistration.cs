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
    public partial class EmployeeRegistration : Form
    {

        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;

        //Declare Datafields
        public int EmployeeID;
        public string employeeFirstName;
        public string employeeLastName;
        public string employeeRole;
        public string employeePhoneNo;
        public string employeeEmail;
        public string Username;
        public string Password;
        

        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" || tbLastName.Text != "" || cbEmployeeRole.Text != "" || tbPhoneNo.Text != "" || tbEmailAddress.Text != "")
            {
                if (tbPassword.Text == tbConfirmPassword.Text)
                {
                    try
                    {
                        connection.Open();

                        //Read data from textboxes
                        employeeFirstName = tbFirstName.Text;
                        employeeLastName = tbLastName.Text;
                        employeeRole = cbEmployeeRole.Text;
                        employeeEmail = tbEmailAddress.Text;
                        employeePhoneNo = tbPhoneNo.Text;
                        Username = tbUsername.Text;
                        Password = tbPassword.Text;

                        //Create SQL Command
                        string commandString = $"INSERT INTO Employee(Emp_First_Name, Emp_Last_Name,Emp_Role," +
                            $"Emp_Email,Emp_Phone_No,Emp_Username,Emp_Password) " +
                            $"VALUES ('{employeeFirstName}','{employeeLastName}','{employeeRole}'," +
                            $"'{employeeEmail}','{employeePhoneNo}','{Username}','{Password}')";

                        command = new SqlCommand(commandString, connection);
                        adapter = new SqlDataAdapter();

                        adapter.InsertCommand = command;
                        adapter.InsertCommand.ExecuteNonQuery();

                        connection.Close();

                        //confirmation message
                        MessageBox.Show("Employee successfuly registed.");
                        this.Close();

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
                    MessageBox.Show("Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Please specify all fields");
            }

        }
    }
}
