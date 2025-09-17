using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UptownStudioApplication
{
    public partial class Dashboard : Form
    {
        //Declare Datafields
        public int EmployeeID;
        public string employeeFirstName;
        public string employeeLastName;
        public string employeeRole;

        public Dashboard()
        {
            InitializeComponent();
        }



        // Custom Control button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Side menu Panel

        //Menu controls
        private void menuAtStartUp()
        {
            salesPanel.Visible = false;
            reportPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (salesPanel.Visible == true)
            {
                salesPanel.Visible = false;
            }
            if (reportPanel.Visible == true)
            {
                reportPanel.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            showSubMenu(salesPanel);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(reportPanel);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            menuAtStartUp();
            openChildForm(new Home(),btnHome);
            Login login = new Login();
            lblUserName.Text = "Welcome \n" + employeeFirstName +" "+ employeeLastName;
            if(employeeRole == "Assistant")
            {
                btnBackUp.Enabled = false;
                btnEmployees.Enabled = false;
            }

        }



        //Using mainPanel to display child forms
        private Form activeForm = null;
        

        private void openChildForm(Form childForm, Button clickedButton)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home(), btnHome);
            menuAtStartUp();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSale(), btnSalesOrder);
            
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesHistory(), btnSalesHistory);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new Customers(), btnCustomers);
            menuAtStartUp();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            openChildForm(new Employees(), btnEmployees);
            menuAtStartUp();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventory(), btnInventory);
            menuAtStartUp();
        }



        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesReport(), btnBackUp);
            
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerReport(), btnCustomerReport);
           
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            openChildForm(new Backup(), btnBackUp);
            menuAtStartUp();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
