using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UptownStudioApplication
{
    public partial class ForgotPassword : Form
    {
        //Declare global connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL Objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public DataSet dataset;

        //Declare datafields
        public string Username;

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text!="" && tbPassword.Text != "")
            {
                if(tbPassword.Text == tbConfirmPassword.Text)
                {
                    try
                    {
                        connection.Open();

                        //Create SQL command 
                        string commandString = $"SELECT Emp_UserName FROM Employee WHERE Emp_UserName LIKE '{tbUsername.Text}'";
                        command = new SqlCommand(commandString, connection);

                        //Create SQL Data Reader Object
                        reader = command.ExecuteReader();


                        // Read data and fill textboxes
                        if (reader.Read())
                        {
                            Username = reader.GetValue(0).ToString();
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

                    if(tbUsername.Text == Username)
                    {

                        try
                        {
                            connection.Open();

                            //Create SQL Command
                            string commandString = $"UPDATE Employee SET Emp_Password='{tbPassword.Text}' WHERE Emp_UserName = '{Username}'";

                            command = new SqlCommand(commandString, connection);
                            adapter = new SqlDataAdapter();

                            adapter.UpdateCommand = command;
                            adapter.UpdateCommand.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("Password Updated Successfully");
                            this.Close();

                        }
                        catch (Exception message)
                        {
                            MessageBox.Show("Connection Failed or Username NOT FOUND \n\n" + message.ToString());
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match, Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
        }
    }
}
