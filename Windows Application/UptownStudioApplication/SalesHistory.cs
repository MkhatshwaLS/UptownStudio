using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UptownStudioApplication
{
    public partial class SalesHistory : Form
    {
        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;
        public SqlTransaction transaction;

        //Declare Datafields
        public int OrderID;
        public double OrderTotal;
        public int InventoryID;
        public string inventoryName;
        public string inventoryDescription;
        public double inventoryUnitCostPrice;
        public int quantityInStock;
        public SalesHistory()
        {
            InitializeComponent();
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            // Load Data Grid View 
            try
            {
                connection.Open();

                //Create SQL command
                string commandString = @"SELECT [dbo].[Order].*, Ordered_Inventory.InventoryID, Ordered_Inventory.Quantity_Sold,  Ordered_Inventory.Unit_Selling_Price                 
                 FROM Ordered_Inventory 
                 inner join  [dbo].[Order]  
                 on Ordered_Inventory.OrderID =  [dbo].[Order].OrderID";
                command = new SqlCommand(commandString, connection);

                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                // Fetch data and Fill dataset
                adapter.SelectCommand = command;
                adapter.Fill(dataset, "OrderInventory");

                //Populate datagridview and display data
                dgvSales.DataSource = dataset;
                dgvSales.DataMember = "OrderInventory";

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

            //Fill Order ID ComboBox
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = @"SELECT OrderID FROM Ordered_Inventory";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();

                // Read data and populate combobox
                while (reader.Read())
                {
                    cbOrderID.Items.Add(reader.GetValue(0));
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

        private void cbOrderID_SelectedValueChanged(object sender, EventArgs e)
        {
            //Fill Inventory ID ComboBox
            try
            {
                connection.Open();
                
                // Read data from comboboxes
                OrderID = int.Parse(cbOrderID.Text);

                //Create SQL command 
                string commandString = $"SELECT InventoryID FROM Ordered_Inventory WHERE OrderID ={OrderID}";
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

        private void cbInventoryID_SelectedValueChanged(object sender, EventArgs e)
        {
            
            // Read data from comboboxes
            OrderID = int.Parse(cbOrderID.Text);
            InventoryID = int.Parse(cbInventoryID.Text);

            //Fill Inventory ID ComboBox
            try
            {
                connection.Open();
                

                //Create SQL command 
                string commandString = $"SELECT Inventory_Name,Inventory_Description FROM Inventory WHERE InventoryID ={InventoryID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Fill data into textboxes
                if (reader.Read())
                {
                    tbInventoryName.Text = reader.GetValue(0).ToString();
                    tbInventoryDescription.Text = reader.GetValue(1).ToString();
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

            //Fill Textboxes
            try
            {
                connection.Open();
                // Read data from comboboxes
                OrderID = int.Parse(cbOrderID.Text);
                InventoryID = int.Parse(cbInventoryID.Text);

                //Create SQL command 
                string commandString = $"SELECT Unit_Selling_Price,Quantity_Sold FROM Ordered_Inventory WHERE OrderID ={OrderID} AND InventoryID ={InventoryID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Fill data into textboxes
                if (reader.Read())
                {
                    tbInventoryUnitPrice.Text = reader.GetValue(0).ToString();
                    tbInventoryQuantity.Text = reader.GetValue(1).ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbOrderID.Text != "" && cbInventoryID.Text == "")
            {
                //Delete entry ONLY if Order ID is specified in the comboBox
                //Delete CASCADDE...when Order is deleted Ordered_Inventory of corresponding order will be deleted
                if (int.TryParse(cbOrderID.Text, out int OrderID))
                {
                    try
                    {
                        connection.Open();

                        //Create SQL Command
                        string commandString = $"DELETE FROM [Order] WHERE OrderID = {OrderID}";
                        SqlCommand command = new SqlCommand(commandString, connection);

                        //Execute Delete command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Information for Order ID " + OrderID + " was successfully removed");
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
                    MessageBox.Show("Please specify a valid Order ID to be deleted.");
                }
            }
            else if (cbOrderID.Text != "" && cbInventoryID.Text != "")
            {
                // Delete entry when Inventory ID is specified in the comboBox
                if (int.TryParse(cbInventoryID.Text, out int InventoryID))
                {
                    try
                    {
                        connection.Open();
                        transaction = connection.BeginTransaction();

                        // 1. Delete inventory item from Ordered_Inventory
                        string deleteString = $"DELETE FROM Ordered_Inventory WHERE InventoryID = {InventoryID}";
                        command = new SqlCommand(deleteString, connection, transaction);

                        // Execute Delete command
                        command.ExecuteNonQuery();

                        // Get the returned quantity from the textbox
                        int quantityReturned = int.Parse(tbInventoryQuantity.Text);

                        // 2. Update the inventory table to add the returned quantity
                        string updateInventory = $"UPDATE Inventory SET Quantity_in_Stock = Quantity_in_Stock + {quantityReturned} WHERE InventoryID = {InventoryID}";
                        command = new SqlCommand(updateInventory, connection, transaction);
                        command.ExecuteNonQuery();

                        // 3. Update the Order Total by deducting the amount corresponding to the returned inventory
                        double sellingPrice = double.Parse(tbInventoryUnitPrice.Text);
                        double deductionAmount = sellingPrice * quantityReturned;

                        string updateOrderTotal = $"UPDATE [dbo].[Order] SET Order_Total = Order_Total - {deductionAmount} WHERE OrderID = {OrderID}";
                        command = new SqlCommand(updateOrderTotal, connection, transaction);  // Corrected this line to use `updateOrderTotal`
                        command.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();
                        MessageBox.Show("Information for Inventory# " + InventoryID + " was successfully removed from Order#" + OrderID);
                    }
                    catch (Exception message)
                    {
                        // Rollback the transaction in case of an error
                        transaction?.Rollback();
                        MessageBox.Show("Transaction failed: \n\n" + message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please specify a valid Inventory ID to be deleted.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbInventoryQuantity.Text, out int quantityToUpdate))
            {
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    //1. Update quantity in Ordered_Inventory
                    string updateOrderedInventory = $"UPDATE Ordered_Inventory SET Quantity_Sold = {quantityToUpdate} WHERE InventoryID = {InventoryID}";
                    command = new SqlCommand(updateOrderedInventory, connection, transaction);

                    //Execute Update command
                    command.ExecuteNonQuery();

                    //2. Update inventory table
                    string updateInventory = $"UPDATE Inventory SET Quantity_in_Stock = Quantity_in_Stock - {quantityToUpdate} WHERE InventoryID = {InventoryID}";
                    command = new SqlCommand(updateInventory, connection, transaction);
                    command.ExecuteNonQuery();

                    //3. Update Order Total
                    double sellingPrice = double.Parse(tbInventoryUnitPrice.Text);
                    double deductionAmount = sellingPrice * quantityToUpdate;

                    string updateOrderTotal = $"UPDATE [dbo].[Order] SET Order_Total = Order_Total + {deductionAmount} WHERE OrderID = {OrderID}";
                    command = new SqlCommand(updateOrderTotal, connection, transaction);
                    command.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Information for Inventory# " + InventoryID + " was successfully updated for Order#" + OrderID);
                }
                catch (Exception message)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Transaction failed: \n\n" + message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please specify a valid quantity.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Clear all textboxes and comboBoxes
            cbInventoryID.Items.Clear();
            cbOrderID.Items.Clear();
            cbInventoryID.Text = "";
            cbOrderID.Text = "";
            tbInventoryDescription.Text = "";
            tbInventoryName.Text = "";
            tbInventoryQuantity.Text = "";
            tbInventoryUnitPrice.Text = "";

            //Reload Datagridview
            SalesHistory_Load(null, EventArgs.Empty);
        }
    }
}
