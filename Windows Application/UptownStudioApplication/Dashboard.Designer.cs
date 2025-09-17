
namespace UptownStudioApplication
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.logoutPanel = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.salesPanel = new System.Windows.Forms.Panel();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnSalesOrder = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uptownStudioLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.logoutPanel.SuspendLayout();
            this.salesPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.topPanel.Location = new System.Drawing.Point(250, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1150, 60);
            this.topPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(1007, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 60);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnClose.Image = global::UptownStudioApplication.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(96, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnMinimize.Image = global::UptownStudioApplication.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(14, 10);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnMaximize.Image = global::UptownStudioApplication.Properties.Resources.Maximize;
            this.btnMaximize.Location = new System.Drawing.Point(55, 10);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.sidePanel.Controls.Add(this.btnBackUp);
            this.sidePanel.Controls.Add(this.reportPanel);
            this.sidePanel.Controls.Add(this.logoutPanel);
            this.sidePanel.Controls.Add(this.btnReports);
            this.sidePanel.Controls.Add(this.btnInventory);
            this.sidePanel.Controls.Add(this.btnEmployees);
            this.sidePanel.Controls.Add(this.btnCustomers);
            this.sidePanel.Controls.Add(this.salesPanel);
            this.sidePanel.Controls.Add(this.btnSales);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.userPanel);
            this.sidePanel.Controls.Add(this.LogoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 900);
            this.sidePanel.TabIndex = 0;
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackUp.FlatAppearance.BorderSize = 0;
            this.btnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.Color.White;
            this.btnBackUp.Image = global::UptownStudioApplication.Properties.Resources.backupIcon;
            this.btnBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackUp.Location = new System.Drawing.Point(0, 634);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBackUp.Size = new System.Drawing.Size(250, 40);
            this.btnBackUp.TabIndex = 15;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.reportPanel.Controls.Add(this.btnCustomerReport);
            this.reportPanel.Controls.Add(this.btnSalesReport);
            this.reportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportPanel.Location = new System.Drawing.Point(0, 554);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(250, 80);
            this.reportPanel.TabIndex = 23;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnCustomerReport.Image = global::UptownStudioApplication.Properties.Resources.customerReport;
            this.btnCustomerReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerReport.Location = new System.Drawing.Point(0, 40);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomerReport.Size = new System.Drawing.Size(250, 40);
            this.btnCustomerReport.TabIndex = 11;
            this.btnCustomerReport.Text = "Customer Report";
            this.btnCustomerReport.UseVisualStyleBackColor = false;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnSalesReport.Image = global::UptownStudioApplication.Properties.Resources.salesReport;
            this.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 0);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesReport.Size = new System.Drawing.Size(250, 40);
            this.btnSalesReport.TabIndex = 11;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // logoutPanel
            // 
            this.logoutPanel.Controls.Add(this.btnLogout);
            this.logoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutPanel.Location = new System.Drawing.Point(0, 800);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.Size = new System.Drawing.Size(250, 100);
            this.logoutPanel.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::UptownStudioApplication.Properties.Resources.Logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 40);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::UptownStudioApplication.Properties.Resources.reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 514);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(250, 40);
            this.btnReports.TabIndex = 13;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::UptownStudioApplication.Properties.Resources.Inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 474);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(250, 40);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::UptownStudioApplication.Properties.Resources.icons8_employee_24;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 434);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(250, 40);
            this.btnEmployees.TabIndex = 9;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::UptownStudioApplication.Properties.Resources.icons8_customer_24;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 394);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(250, 40);
            this.btnCustomers.TabIndex = 21;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // salesPanel
            // 
            this.salesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.salesPanel.Controls.Add(this.btnSalesHistory);
            this.salesPanel.Controls.Add(this.btnSalesOrder);
            this.salesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesPanel.Location = new System.Drawing.Point(0, 314);
            this.salesPanel.Name = "salesPanel";
            this.salesPanel.Size = new System.Drawing.Size(250, 80);
            this.salesPanel.TabIndex = 20;
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesHistory.FlatAppearance.BorderSize = 0;
            this.btnSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesHistory.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnSalesHistory.Image = global::UptownStudioApplication.Properties.Resources.salesHistory;
            this.btnSalesHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesHistory.Location = new System.Drawing.Point(0, 40);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesHistory.Size = new System.Drawing.Size(250, 40);
            this.btnSalesHistory.TabIndex = 12;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.UseVisualStyleBackColor = false;
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesOrder.FlatAppearance.BorderSize = 0;
            this.btnSalesOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesOrder.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnSalesOrder.Image = global::UptownStudioApplication.Properties.Resources.addShoppingCartColor;
            this.btnSalesOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesOrder.Size = new System.Drawing.Size(250, 40);
            this.btnSalesOrder.TabIndex = 11;
            this.btnSalesOrder.Text = "New Sales Order";
            this.btnSalesOrder.UseVisualStyleBackColor = false;
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::UptownStudioApplication.Properties.Resources.Sales;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 274);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(250, 40);
            this.btnSales.TabIndex = 7;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::UptownStudioApplication.Properties.Resources.Home1;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 234);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.lblUserName);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 134);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(250, 100);
            this.userPanel.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(5);
            this.lblUserName.Size = new System.Drawing.Size(250, 100);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Guest";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Controls.Add(this.uptownStudioLogo);
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 134);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UptownStudioApplication.Properties.Resources.UptownLogoII;
            this.pictureBox1.Location = new System.Drawing.Point(47, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // uptownStudioLogo
            // 
            this.uptownStudioLogo.AutoSize = true;
            this.uptownStudioLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uptownStudioLogo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptownStudioLogo.ForeColor = System.Drawing.Color.White;
            this.uptownStudioLogo.Location = new System.Drawing.Point(107, 70);
            this.uptownStudioLogo.Name = "uptownStudioLogo";
            this.uptownStudioLogo.Size = new System.Drawing.Size(62, 22);
            this.uptownStudioLogo.TabIndex = 2;
            this.uptownStudioLogo.Text = "STUDIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPTOWN";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1150, 840);
            this.mainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.logoutPanel.ResumeLayout(false);
            this.salesPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label uptownStudioLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel salesPanel;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnSalesOrder;
        private System.Windows.Forms.Panel logoutPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnCustomerReport;
    }
}