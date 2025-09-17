using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace UptownStudioApplication
{
    public partial class AddSale : Form
    {

        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;
        public SqlTransaction transaction;

        // Declare Datafields
        public int OrderID;
        public int CustomerID;
        public int EmployeeID=1;
        public string CustomerName;
        public string CustomerEmail;
        public string CustomerPhone;
        public string CustomerAddress;
        public double OrderTotal;
        public int OrderItemsTotal;
        public string OrderStatus;
        public DateTime OrderDate;
        public DateTime CollectionDate;
        public string inventoryName;
        public int quantitySold;
        public int quantityInStock;
        public double sellingPrice;
        public double totalPerItem;
        public double costPrice;
        public int itemNum = -1;
        public string response;


        public AddSale()
        {
            InitializeComponent();
        }

        //Generate qaunity values based on maximum quantity available
        public void AvaliableInventory(Label lblInventoryID,ComboBox cbQuantity)
        {
            //Clear comboBox Items
            cbQuantity.Items.Clear();

            //Retrieve data
            int inventoryID = int.Parse(lblInventoryID.Text);
            int quantityInStock = 0;

            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = $"SELECT Quantity_in_Stock FROM Inventory WHERE InventoryID = {inventoryID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    quantityInStock = (int)reader.GetValue(0);
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

            //Load com
            for (int i = 0; i<= quantityInStock; i++)
            {
                cbQuantity.Items.Add(i);
            }
        }
        private void AddSale_Load(object sender, EventArgs e)
        {
            //// Retrive available inventory for each item
            AvaliableInventory(lblHoddieID, cbQuantityHoddie);
            AvaliableInventory(lblGolfTshirtID, cbQuantityGolfTshirt);
            AvaliableInventory(lblTshirtCrewNeckID, cbQuantityTshirtCrewNeck);
            AvaliableInventory(lblTshirtVNeckID, cbQuantityTshirtVNeck);
            AvaliableInventory(lblBeanieID, cbQuantityBeanie);
            AvaliableInventory(lblCapID, cbQuantityCap);
            AvaliableInventory(lblMugStandardID, cbQuantityMugStandard);
            AvaliableInventory(lblMugConicalID, cbQuantityMugConical);
            AvaliableInventory(lblMugTravelID, cbQuantityMugTravel);
            AvaliableInventory(lblTumblerSkinnyID, cbQuantityTumblerSkinny);
            AvaliableInventory(lblTumblerWineID, cbQuantityTumblerWine);
            AvaliableInventory(lblWaterBottleID, cbQuantityWaterBottle);
            AvaliableInventory(lblKeyringRectangularID, cbQuantityKeyringRectangular);
            AvaliableInventory(lblKeyringSquareID, cbQuantityKeyringSquare);
            AvaliableInventory(lblKeyringRoundID, cbQuantityKeyringRound);

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

        // Array that stores order data
        // Array stores [inventoryID, inventoryName, quantitySold, SellingPrice, Total]num
        public static int noOfInventoryItems = 15;
        public static int noOfEntriesPerItem = 5;
        public static string[,] orderInfo = new string[noOfInventoryItems, noOfEntriesPerItem];
        
        public double Subtotal()
        {
            double subtotal = 0;

            for (int i = 0; i < orderInfo.GetLength(0); i++)
            {
                if (double.TryParse(orderInfo[i, 4], out double value))
                {
                    subtotal += value;
                }
            }

            return subtotal;
        }
       
        private int ItemIndex(int inventoryID)
        {
            for (int i = 0; i < orderInfo.GetLength(0); i++)
            {
                if (orderInfo[i, 0] == inventoryID.ToString())
                {
                    return i;
                }
            }
            itemNum++;
            return itemNum;
        }




        
        

        // Method to add an item to the cart
        public void addToCart(Label lblInventoryID, Label lblPrice, ComboBox cbQuantity, Label lblHeading)
        {
            //Read input information
            if (!int.TryParse(lblInventoryID.Text, out int inventoryID))
            {
                MessageBox.Show("Invalid inventory ID");
                return;
            }
            if (!double.TryParse(lblPrice.Text, out double sellingPrice))
            {
                MessageBox.Show("Invalid Price Value.");
                return;
            }
            if (!int.TryParse(cbQuantity.Text, out int quantitySold))
            {
                MessageBox.Show("Invalid Quantity Value.");
                return;
            }

            inventoryName = lblHeading.Text;
            
            if(quantitySold != 0)
            {
                //Add items to orderInfo Array
                int index = ItemIndex(inventoryID);

                orderInfo[index, 0] = inventoryID.ToString();
                orderInfo[index, 1] = inventoryName;
                orderInfo[index, 2] = quantitySold.ToString();
                orderInfo[index, 3] = sellingPrice.ToString();
                totalPerItem = quantitySold * sellingPrice;
                orderInfo[index, 4] = totalPerItem.ToString();

            }
            else if (quantitySold == 0)
            {
                //Remove item from orderInfo Array 
                int index = ItemIndex(inventoryID);

                if (index >= 0)
                {
                    // Clear the array entry
                    orderInfo[index, 0] = null;
                    orderInfo[index, 1] = null;
                    orderInfo[index, 2] = null;
                    orderInfo[index, 3] = null;
                    orderInfo[index, 4] = null;

                    //Reset quantity comboBox
                    cbQuantity.Text = "";
                }
            }
            // Display updated cart
            DisplayCartItems();

            //Calcualate subtatol,vat and grandTotal
            double vat = Subtotal() * 0.14;
            OrderTotal = Subtotal() + vat;

            lblSubtotalAmount.Text = "R" + Subtotal().ToString("F2");
            lblVatTotal.Text = "R" + vat.ToString("F2");
            lblGrandTotalAmount.Text = "R" + OrderTotal.ToString("F2");
        }

        public void DisplayCartItems()
        {   
            //Clear listbox
            lbCartSummary.Items.Clear();
            //Listbox Headings
            string heading = string.Format("{0,-5} {1,-20} {2,-10} {3,-10} {4,-10}", "ID","PRODUCT","QTY", "UNIT PRICE","TOTAL");
            lbCartSummary.Items.Add(heading);

            //Add sold items to listbox
            for (int i = 0; i < orderInfo.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(orderInfo[i, 0]))
                {
                    string cartItem = string.Format("{0,-5} {1,-20} {2,-10} {3,-10} {4,-10}", orderInfo[i, 0], orderInfo[i, 1], orderInfo[i, 2], orderInfo[i, 3], orderInfo[i, 4]);
                    lbCartSummary.Items.Add(cartItem);
                }
            }
                
        }

        private void btnAddToCartHoddie_Click(object sender, EventArgs e)
        {
            addToCart(lblHoddieID, lblPriceHoddie, cbQuantityHoddie, lblHeadingHoddie);
        }

        private void btnAddToCartGolfTshirt_Click(object sender, EventArgs e)
        {
            addToCart(lblGolfTshirtID,lblPriceGolfTshirt, cbQuantityGolfTshirt, lblHeadingGolfTshirt);
        }


        private void btnAddToCartTshirtCrewNeck_Click(object sender, EventArgs e)
        {
            addToCart(lblTshirtCrewNeckID,lblPriceTshirtCrewNeck, cbQuantityTshirtCrewNeck, lblHeadingTshirtCrewNeck);
        }

        private void btnAddToCartTshirtVNeck_Click(object sender, EventArgs e)
        {
            addToCart(lblTshirtVNeckID,lblPriceTshirtVNeck,cbQuantityTshirtVNeck, lblHeadingTshirtVNeck);
        }

        private void btnAddToCartBeanie_Click(object sender, EventArgs e)
        {
            addToCart(lblBeanieID,lblPriceBeanie,cbQuantityBeanie, lblHeadingBeanie);

        }

        private void btnAddToCartCap_Click(object sender, EventArgs e)
        {
            addToCart(lblCapID,lblPriceCap, cbQuantityCap, lblHeadingCap);

        }

        private void btnAddToCartMugStandard_Click(object sender, EventArgs e)
        {
            addToCart(lblMugStandardID,lblPriceMugStandard, cbQuantityMugStandard, lblHeadingMugStandard);
        }

        private void btnAddToCartMugConical_Click(object sender, EventArgs e)
        {
            addToCart(lblMugConicalID,lblPriceMugConical, cbQuantityMugConical, lblHeadingMugConical);


        }

        private void btnAddToCartMugTravel_Click(object sender, EventArgs e)
        {
            addToCart(lblMugTravelID,lblPriceMugTravel, cbQuantityMugTravel, lblHeadingMugTravel);

        }

        private void btnAddToCartTumblerSkinny_Click(object sender, EventArgs e)
        {
            addToCart(lblTumblerSkinnyID,lblPriceTumblerSkinny, cbQuantityTumblerSkinny, lblHeadingTumblerSkinny);

        }

        private void btnAddToCartTumblerWine_Click(object sender, EventArgs e)
        {
            addToCart(lblTumblerWineID,lblPriceTumblerWine, cbQuantityTumblerWine, lblHeadingTumblerWine);

        }

        private void btnAddToCartWaterBottle_Click(object sender, EventArgs e)
        {
            addToCart(lblWaterBottleID,lblPriceWaterBottle, cbQuantityWaterBottle, lblHeadingWaterBottle);

        }

        private void btnAddToCartKeyringRectangular_Click(object sender, EventArgs e)
        {
            addToCart(lblKeyringRectangularID,lblPriceKeyringRectangular, cbQuantityKeyringRectangular, lblHeadingKeyringRectangular);

        }

        private void btnAddToCartKeyringSquare_Click(object sender, EventArgs e)
        {
            addToCart(lblKeyringSquareID,lblPriceKeyringSquare, cbQuantityKeyringSquare, lblHeadingKeyringSquare);

        }

        private void btnAddToCartKeyringRound_Click(object sender, EventArgs e)
        {
            addToCart(lblKeyringRoundID, lblPriceKeyringRound, cbQuantityKeyringRound, lblHeadingKeyringRound);

        }
        private void btnAddToCartMugConical_Click_1(object sender, EventArgs e)
        {
            addToCart(lblMugConicalID, lblPriceMugConical, cbQuantityMugConical, lblHeadingMugConical);
        }

        private void cbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerID = int.Parse(cbCustomerID.Text);

            //Customer information
            try
            {
                connection.Open();

                //Create SQL command 
                string commandString = $"SELECT * FROM Customer WHERE CustomerID = {CustomerID}";
                command = new SqlCommand(commandString, connection);

                //Create SQL Data Reader Object
                reader = command.ExecuteReader();


                // Read data and fill textboxes
                while (reader.Read())
                {
                    CustomerName = reader.GetValue(1).ToString() +" " + reader.GetValue(2).ToString();
                    CustomerEmail = reader.GetValue(3).ToString();
                    CustomerPhone = reader.GetValue(4).ToString();
                    CustomerAddress = reader.GetValue(5).ToString()+
                        "\n" + reader.GetValue(6).ToString() +
                        "\n" + reader.GetValue(7).ToString() +
                        "\n" + reader.GetValue(8).ToString() +
                        "\n" + reader.GetValue(9).ToString();
                    
                }
                lblCustomerName.Text = "Name : " + CustomerName;
                lblCustomerEmail.Text = "Email : " + CustomerEmail;
                

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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            OrderStatus = "Created";
            OrderDate = DateTime.Now;
            CollectionDate = DateTime.Now.AddDays(10);

            // Check if items are added to the cart
            bool itemsAdded = false;
            for (int i = 0; i < orderInfo.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(orderInfo[i, 0]))
                {
                    itemsAdded = true;
                    break;
                }
            }

            if (!itemsAdded)
            {
                MessageBox.Show("No items have been added to the cart. Please add items before checking out.");
                return;
            }

            // Check if customer is selected
            if (!int.TryParse(cbCustomerID.Text, out CustomerID))
            {
                MessageBox.Show("Please select a customer before proceeding.");
                return;
            }

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                // Create new Order
                string createOrder = $"INSERT INTO [Order] (EmployeeID, CustomerID, Order_Total, Order_Status, Order_CreationDate, Order_CollectionDate) " +
                                     $"VALUES ({EmployeeID}, {CustomerID}, {OrderTotal}, '{OrderStatus}', '{OrderDate:yyyy-MM-dd}', '{CollectionDate:yyyy-MM-dd}')";

                command = new SqlCommand(createOrder, connection, transaction);
                command.ExecuteNonQuery();

                // Retrieve the latest OrderID
                string newOrderIDQuery = "SELECT MAX(OrderID) FROM [Order]";
                command = new SqlCommand(newOrderIDQuery, connection, transaction);
                OrderID = (int)command.ExecuteScalar();

                // Add all Inventory Items to the database
                for (int i = 0; i < orderInfo.GetLength(0); i++)
                {
                    if (!string.IsNullOrEmpty(orderInfo[i, 0]))
                    {
                        int inventoryID = int.Parse(orderInfo[i, 0]);
                        int quantitySold = int.Parse(orderInfo[i, 2]);
                        double sellingPrice = double.Parse(orderInfo[i, 3]);

                        string addToOrderedInventory = $"INSERT INTO Ordered_Inventory (OrderID, InventoryID, Unit_Selling_Price, Quantity_Sold) " +
                                                        $"VALUES ({OrderID}, {inventoryID}, {sellingPrice}, {quantitySold})";

                        command = new SqlCommand(addToOrderedInventory, connection, transaction);
                        command.ExecuteNonQuery();
                    }
                }

                // Deduct items from inventory table
                for (int i = 0; i < orderInfo.GetLength(0); i++)
                 {
                    if (!string.IsNullOrEmpty(orderInfo[i, 0]))
                    {
                        int inventoryID = int.Parse(orderInfo[i, 0]);
                        int quantitySold = int.Parse(orderInfo[i, 2]);

                        string updateInventory = $"UPDATE Inventory SET Quantity_in_Stock = Quantity_in_Stock - {quantitySold} WHERE InventoryID = {inventoryID}";

                        command = new SqlCommand(updateInventory, connection, transaction);
                        command.ExecuteNonQuery();
                    }
                 }


                // Display confirmation dialog
                OrderConfirmation confirmation = new OrderConfirmation
                {
                    OrderID = this.OrderID,
                    OrderDate = this.OrderDate,
                    CustomerName = this.CustomerName,
                    CustomerEmail = this.CustomerEmail,
                    CustomerPhone = this.CustomerPhone,
                    CustomerAddress = this.CustomerAddress,
                    OrderTotal = this.OrderTotal
                };
                confirmation.ShowDialog();

                //Get Response from Order Confirmation
                OrderConfirmation orderResponse = new OrderConfirmation();
                this.response = orderResponse.response;

                if (response == "canceled")
                {
                    transaction.Rollback();
                    MessageBox.Show("Order Cancelled");
                    return;
                }

                else if(response == "confirmed")
                {
                }    
                // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Order created successfully.");
                    return;
                
              
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

            //Clear all and reload form
            btnClearAll_Click(null, EventArgs.Empty);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Clear customer info
            cbCustomerID.Text = "";
            lblCustomerName.Text = "Name : ";
            lblCustomerEmail.Text = "Email : ";

            // Clear all quantity comboBoxes
            cbQuantityHoddie.Text = "";
            cbQuantityGolfTshirt.Text = "";
            cbQuantityTshirtCrewNeck.Text = "";
            cbQuantityTshirtVNeck.Text = "";
            cbQuantityBeanie.Text = "";
            cbQuantityCap.Text = "";
            cbQuantityMugStandard.Text = "";
            cbQuantityMugConical.Text = "";
            cbQuantityMugTravel.Text = "";
            cbQuantityTumblerSkinny.Text = "";
            cbQuantityTumblerWine.Text = "";
            cbQuantityWaterBottle.Text = "";
            cbQuantityKeyringRectangular.Text = "";
            cbQuantityKeyringSquare.Text = "";
            cbQuantityKeyringRound.Text = "";

            // Clear Cart Summary ListBox
            lbCartSummary.Items.Clear();

            // Reset orderInfo array
            Array.Clear(orderInfo, 0, orderInfo.Length);

            // Reset subtotal, VAT, and grand total labels
            lblSubtotalAmount.Text = "R0.00";
            lblVatTotal.Text = "R0.00";
            lblGrandTotalAmount.Text = "R0.00";

            // Reload form data
            AddSale_Load(null, EventArgs.Empty);
        }


    }
}
