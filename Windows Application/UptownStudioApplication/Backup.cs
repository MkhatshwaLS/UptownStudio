using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UptownStudioApplication
{
    public partial class Backup : Form
    {
        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public string commandString;

        //Declare datafields
        public string backUpData;
        public Backup()
        {
            InitializeComponent();
        }

        private void cbDataBackUp_SelectedValueChanged(object sender, EventArgs e)
        {
            backUpData = cbDataBackUp.Text;
  
            //Fill Employee ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                switch (backUpData)
                { 
                    case "Customer":
                        commandString = @"SELECT * FROM Customer";
                        break;
                    case "Employee":
                        commandString = @"SELECT * FROM Employee";
                        break;
                    case "Inventory":
                        commandString = @"SELECT * FROM Inventory";
                        break;
                    case "Order":
                        commandString = @"SELECT * FROM [Order]";
                        break;
                    case "Ordered Inventory":
                        commandString = @"SELECT * FROM Ordered_Inventory";
                        break;
                    default:
                        break;
                }

                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Backup");

                //Populate datagridview and display data
                dgvPreview.DataSource = dataset;
                dgvPreview.DataMember = "BackUp";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Use the saveFileDialog to specify backUp file  location
            
            backDataDialog.Filter = "CSV file(*.csv)|*.csv"; //specify file extension
            backDataDialog.InitialDirectory = @"c:\";

            if (backDataDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Get file path and Open streamWriter
                    string backUpFilePath = backDataDialog.FileName;
                    StreamWriter writer = new StreamWriter(backUpFilePath);

                    //Get column heading from the specified table and write them into file
                    string[] columnHeading = dataset.Tables["Backup"].Columns.Cast<DataColumn>()
                                          .Select(column => column.ColumnName)
                                          .ToArray();
                    writer.WriteLine(string.Join(",", columnHeading));

                    //Read data from each row in the table and write into file

                    DataTable table = dataset.Tables["Backup"];
                    int rowIndex = 0;

                    while (rowIndex < table.Rows.Count)
                    {
                        DataRow row = table.Rows[rowIndex];
                        string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                        writer.WriteLine(string.Join(",", fields));
                        rowIndex++;
                    }

                    writer.Close();

                    MessageBox.Show("Data successfully backed up to " + backUpFilePath);
                }
                catch(Exception message)
                {
                    MessageBox.Show("Failed to backup file\n\n" + message);
                }
               

            }

        }
    }
}
