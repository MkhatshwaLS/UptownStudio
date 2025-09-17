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
    public partial class Inventory : Form
    {
        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;

        //Declare Datafields
        public int InventoryID;
        public string inventoryName;
        public string inventoryDescription;
        public double inventoryUnitCostPrice;
        public int quantityInStock;

        public Inventory()
        {
            InitializeComponent();
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            
        }
        private void loadData()
        {
            // Load Data Grid View 
            try
            {
                connection.Open();

                //Create SQL command
                string commandString = @"SELECT * FROM Inventory";
                command = new SqlCommand(commandString, connection);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "Inventory");

                //Populate datagridview and display data
                dgvInventory.DataSource = dataset;
                dgvInventory.DataMember = "Inventory";

                //Create custom heading
                dgvInventory.Columns[0].HeaderText = "ID";
                dgvInventory.Columns[1].HeaderText = "Product Name";
                dgvInventory.Columns[2].HeaderText = "Description";
                dgvInventory.Columns[3].HeaderText = "Unit Price";
                dgvInventory.Columns[4].HeaderText = "Quantity";

                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show("Connection Failed\n\n" + message.ToString());
            }
            finally{

                connection.Close();
            }

            //Fill Inventory ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = @"SELECT InventoryID FROM Inventory";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();

                // Read data and populate combobox
                while (reader.Read())
                {
                    cbInventoryID.Items.Add(reader.GetValue(0));
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tbInventoryName.Text != "" || tbInventoryDescription.Text != "" || tbInventoryUnitPrice.Text != "" || tbInventoryQuantity.Text != "")
            {
                try
                {
                    connection.Open();

                    //Read data from textboxes
                    inventoryName = tbInventoryName.Text;
                    inventoryDescription = tbInventoryDescription.Text;

                    //Check if the price entered is valid
                    if (!double.TryParse(tbInventoryUnitPrice.Text, out inventoryUnitCostPrice))
                    {
                        MessageBox.Show("Invalid value: Inventory unit cost price not a numeric value");
                    }

                    //Clear if the quantity entered is valid
                    if (!int.TryParse(tbInventoryQuantity.Text, out quantityInStock))
                    {
                        MessageBox.Show("Invalid value: Inventory quantity not a numeric value");
                    }


                    //Create SQL Command
                    string commandString = $"INSERT INTO Inventory(Inventory_Name, Inventory_Description, Inventory_Unit_Cost_Price, Quantity_in_Stock) " +
                                            $"VALUES ('{inventoryName}','{inventoryDescription}',{inventoryUnitCostPrice},{quantityInStock})";

                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();

                    connection.Close();

                    //confirmation message
                    MessageBox.Show("Inventory information captured successfully");

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
            //Update entry ONLY if Inventory ID is specified in the comboBox

            if (cbInventoryID.Text != "")
            {
                try
                {
                    //Read data from textboxes
                    inventoryName = tbInventoryName.Text;
                    inventoryDescription = tbInventoryDescription.Text;

                    //Check if the price entered is valid
                    if (!double.TryParse(tbInventoryUnitPrice.Text, out inventoryUnitCostPrice))
                    {
                        MessageBox.Show("Invalid value: Inventory unit cost price not a numeric value");
                    }

                    //Clear if the quantity entered is valid
                    if (!int.TryParse(tbInventoryQuantity.Text, out quantityInStock))
                    {
                        MessageBox.Show("Invalid value: Inventory quantity not a numeric value");
                    }

                    connection.Open();

                    //Create SQL Command
                    string commandString = $"UPDATE Inventory SET Inventory_Name='{inventoryName}',Inventory_Description='{inventoryDescription}'," +
                                            $"Inventory_Unit_Cost_Price = {inventoryUnitCostPrice}, Quantity_in_Stock = {quantityInStock}" +
                                            $" WHERE InventoryID = {int.Parse(cbInventoryID.Text)}";

                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = command;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Inventory ID " + cbInventoryID.Text + "  was successfully updated.");

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
                MessageBox.Show("Please specify Inventory ID to be updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete entry ONLY if Inventory ID is specified in the comboBox

            if (cbInventoryID.Text != "")
            {
                try
                {
                    connection.Open();

                    //Create SQL Command
                    string commandString = $"DELETE FROM Inventory WHERE InventoryID = {int.Parse(cbInventoryID.Text)}";
                    command = new SqlCommand(commandString, connection);
                    adapter = new SqlDataAdapter();

                    //Execute Delete command
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Information for Inventory ID " + cbInventoryID.Text + " was successfully removed");

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
                MessageBox.Show("Please specify Inventory ID to be deleted.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and comboBox Items
            tbInventoryName.Text = "";
            tbInventoryDescription.Text = "";
            tbInventoryUnitPrice.Text = "";
            tbInventoryQuantity.Text = "";
            cbInventoryID.Items.Clear();

            //Reload dataGridView and ComboBox
            loadData();
        }

        private void cbInventoryID_SelectedValueChanged(object sender, EventArgs e)
        {
            InventoryID = int.Parse(cbInventoryID.Text);

            //Fill Inventory ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = $"SELECT * FROM Inventory WHERE InventoryID LIKE {InventoryID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Read data and fill textboxes
                if (reader.Read())
                {
                    tbInventoryName.Text = reader["Inventory_Name"].ToString();
                    tbInventoryDescription.Text = reader["Inventory_Description"].ToString();
                    tbInventoryUnitPrice.Text = reader["Inventory_Unit_Cost_Price"].ToString();
                    tbInventoryQuantity.Text = reader["Quantity_in_Stock"].ToString();
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
