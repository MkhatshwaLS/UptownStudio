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
    public partial class OrderConfirmation : Form
    {
        //Declare Global Connection
        public SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=UptownStudioDB;Integrated Security=True");

        //Declare SQL objects
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;
        public SqlDataReader reader;

        // Declare Datafields
        public int OrderID;
        public int CustomerID;
        public int EmployeeID = 1;
        public string CustomerName;
        public string CustomerEmail;
        public string CustomerPhone;
        public string CustomerAddress;
        public double OrderTotal;
        public string OrderStatus;
        public int OrderItemsTotal;
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


        public OrderConfirmation()
        {
            InitializeComponent();
        }
        private void OrderConfirmation_Load(object sender, EventArgs e)
        {
            lblFirstAndLastName.Text = "Name : " + CustomerName;
            lblEmailAddress.Text = "Email Address : " + CustomerEmail;
            lblPhoneNo.Text = "Phone No : " + CustomerPhone;
            lblPhysicalAddress.Text = "Physical Address : \n" + CustomerAddress;
            lblOrderNo.Text = "Order #" + OrderID.ToString();
            lblOrderTotal.Text = "Order Total : R " + OrderTotal.ToString(); 

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AddSale addSale = new AddSale();
            addSale.response = "cancelled";
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AddSale addSale = new AddSale();
            addSale.response = "confirmed";
            addSale.OrderStatus = "Paid";
            this.Close();
        }


    }
}
