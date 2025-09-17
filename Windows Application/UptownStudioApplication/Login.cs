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
    public partial class Login : Form
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
        public string Username;
        public string Password;

        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text != "" && tbPassword.Text != "")
            {
                try
                {
                    connection.Open();

                    //Create SQL command
                    string commandString = $"SELECT EmployeeID,Emp_First_Name,Emp_Last_Name,Emp_Role,Emp_UserName,Emp_Password FROM Employee WHERE Emp_Username ='{tbUsername.Text}'";
                    command = new SqlCommand(commandString, connection);
                    reader = command.ExecuteReader();

                    //Find Matching Username and Password Combo from the Employee table
                    while (reader.Read())
                    {
                        EmployeeID = Convert.ToInt32(reader.GetValue(0));
                        employeeFirstName = reader.GetValue(1).ToString();
                        employeeLastName = reader.GetValue(2).ToString();
                        employeeRole = reader.GetValue(3).ToString();
                        Username = reader.GetValue(4).ToString();
                        Password = reader.GetValue(5).ToString();

                        while (Username != tbUsername.Text || Password != tbPassword.Text)
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }

                        if (Username == tbUsername.Text && Password == tbPassword.Text)
                        {
                            //Send EmployeeID to AddSale Form
                            AddSale addSale = new AddSale
                            {
                                EmployeeID = this.EmployeeID
                            };

                            //Sends Employee Information to Dashboard Form
                            Dashboard dashboard = new Dashboard
                            {
                                employeeFirstName = this.employeeFirstName,
                                employeeRole = this.employeeRole,
                                employeeLastName = this.employeeLastName
                            };
                            
                            
                            dashboard.Show();

                            tbUsername.Text = "Username";
                            tbPassword.Text = "Password";

                        }
                        
                    }
                    
                    connection.Close();
                }
                catch (Exception message)
                {
                    MessageBox.Show("Connection Failed\n\n" + message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid username and password");
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();

        }

        private void llblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            EmployeeRegistration registration = new EmployeeRegistration();
            registration.Show();
        }
    }
}
