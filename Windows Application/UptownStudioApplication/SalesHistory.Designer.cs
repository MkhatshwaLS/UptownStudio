namespace UptownStudioApplication
{
    partial class SalesHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbOrderInventory = new System.Windows.Forms.GroupBox();
            this.tbInventoryUnitPrice = new System.Windows.Forms.TextBox();
            this.tbInventoryDescription = new System.Windows.Forms.TextBox();
            this.tbInventoryName = new System.Windows.Forms.TextBox();
            this.tbInventoryQuantity = new System.Windows.Forms.TextBox();
            this.lblInventoryDescription = new System.Windows.Forms.Label();
            this.lblInventoryUnitPrice = new System.Windows.Forms.Label();
            this.lblInventoryName = new System.Windows.Forms.Label();
            this.lblInventoryQuantity = new System.Windows.Forms.Label();
            this.cbInventoryID = new System.Windows.Forms.ComboBox();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.gbEmployList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.gbOrderInventory.SuspendLayout();
            this.gbEmployList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::UptownStudioApplication.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(974, 773);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 40);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "         Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::UptownStudioApplication.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(803, 773);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "         Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbOrderID
            // 
            this.cbOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(192, 64);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(300, 32);
            this.cbOrderID.TabIndex = 5;
            this.cbOrderID.SelectedValueChanged += new System.EventHandler(this.cbOrderID_SelectedValueChanged);
            // 
            // dgvSales
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSales.Location = new System.Drawing.Point(20, 87);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(1060, 304);
            this.dgvSales.TabIndex = 1;
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOrderID.Location = new System.Drawing.Point(32, 68);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(88, 24);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::UptownStudioApplication.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(59, 773);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "         Update Quantity";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbOrderInventory
            // 
            this.gbOrderInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOrderInventory.AutoSize = true;
            this.gbOrderInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.gbOrderInventory.Controls.Add(this.tbInventoryUnitPrice);
            this.gbOrderInventory.Controls.Add(this.tbInventoryDescription);
            this.gbOrderInventory.Controls.Add(this.tbInventoryName);
            this.gbOrderInventory.Controls.Add(this.tbInventoryQuantity);
            this.gbOrderInventory.Controls.Add(this.lblInventoryDescription);
            this.gbOrderInventory.Controls.Add(this.lblInventoryUnitPrice);
            this.gbOrderInventory.Controls.Add(this.lblInventoryName);
            this.gbOrderInventory.Controls.Add(this.lblInventoryQuantity);
            this.gbOrderInventory.Controls.Add(this.cbInventoryID);
            this.gbOrderInventory.Controls.Add(this.cbOrderID);
            this.gbOrderInventory.Controls.Add(this.lblInventoryID);
            this.gbOrderInventory.Controls.Add(this.lblOrderID);
            this.gbOrderInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderInventory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.gbOrderInventory.Location = new System.Drawing.Point(24, 449);
            this.gbOrderInventory.Name = "gbOrderInventory";
            this.gbOrderInventory.Size = new System.Drawing.Size(1100, 300);
            this.gbOrderInventory.TabIndex = 22;
            this.gbOrderInventory.TabStop = false;
            this.gbOrderInventory.Text = "ORDERED INVENTORY INFORMATION";
            // 
            // tbInventoryUnitPrice
            // 
            this.tbInventoryUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryUnitPrice.Location = new System.Drawing.Point(752, 209);
            this.tbInventoryUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryUnitPrice.Name = "tbInventoryUnitPrice";
            this.tbInventoryUnitPrice.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryUnitPrice.TabIndex = 14;
            // 
            // tbInventoryDescription
            // 
            this.tbInventoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryDescription.Location = new System.Drawing.Point(752, 143);
            this.tbInventoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryDescription.Name = "tbInventoryDescription";
            this.tbInventoryDescription.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryDescription.TabIndex = 15;
            // 
            // tbInventoryName
            // 
            this.tbInventoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryName.Location = new System.Drawing.Point(192, 143);
            this.tbInventoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryName.Name = "tbInventoryName";
            this.tbInventoryName.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryName.TabIndex = 16;
            // 
            // tbInventoryQuantity
            // 
            this.tbInventoryQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryQuantity.Location = new System.Drawing.Point(192, 209);
            this.tbInventoryQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryQuantity.Name = "tbInventoryQuantity";
            this.tbInventoryQuantity.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryQuantity.TabIndex = 13;
            // 
            // lblInventoryDescription
            // 
            this.lblInventoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryDescription.AutoSize = true;
            this.lblInventoryDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryDescription.Location = new System.Drawing.Point(564, 146);
            this.lblInventoryDescription.Name = "lblInventoryDescription";
            this.lblInventoryDescription.Size = new System.Drawing.Size(105, 24);
            this.lblInventoryDescription.TabIndex = 9;
            this.lblInventoryDescription.Text = "Description : ";
            // 
            // lblInventoryUnitPrice
            // 
            this.lblInventoryUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryUnitPrice.AutoSize = true;
            this.lblInventoryUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryUnitPrice.Location = new System.Drawing.Point(564, 212);
            this.lblInventoryUnitPrice.Name = "lblInventoryUnitPrice";
            this.lblInventoryUnitPrice.Size = new System.Drawing.Size(142, 24);
            this.lblInventoryUnitPrice.TabIndex = 10;
            this.lblInventoryUnitPrice.Text = "Unit Selling Price :";
            // 
            // lblInventoryName
            // 
            this.lblInventoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryName.AutoSize = true;
            this.lblInventoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryName.Location = new System.Drawing.Point(31, 146);
            this.lblInventoryName.Name = "lblInventoryName";
            this.lblInventoryName.Size = new System.Drawing.Size(131, 24);
            this.lblInventoryName.TabIndex = 11;
            this.lblInventoryName.Text = "Product Name : ";
            // 
            // lblInventoryQuantity
            // 
            this.lblInventoryQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryQuantity.AutoSize = true;
            this.lblInventoryQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryQuantity.Location = new System.Drawing.Point(32, 212);
            this.lblInventoryQuantity.Name = "lblInventoryQuantity";
            this.lblInventoryQuantity.Size = new System.Drawing.Size(119, 24);
            this.lblInventoryQuantity.TabIndex = 12;
            this.lblInventoryQuantity.Text = "Quantity Sold :";
            // 
            // cbInventoryID
            // 
            this.cbInventoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInventoryID.FormattingEnabled = true;
            this.cbInventoryID.Location = new System.Drawing.Point(752, 64);
            this.cbInventoryID.Name = "cbInventoryID";
            this.cbInventoryID.Size = new System.Drawing.Size(300, 32);
            this.cbInventoryID.TabIndex = 5;
            this.cbInventoryID.SelectedValueChanged += new System.EventHandler(this.cbInventoryID_SelectedValueChanged);
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryID.Location = new System.Drawing.Point(564, 68);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(116, 24);
            this.lblInventoryID.TabIndex = 0;
            this.lblInventoryID.Text = "Inventory ID : ";
            // 
            // gbEmployList
            // 
            this.gbEmployList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbEmployList.AutoSize = true;
            this.gbEmployList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.gbEmployList.Controls.Add(this.dgvSales);
            this.gbEmployList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbEmployList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.gbEmployList.Location = new System.Drawing.Point(24, 25);
            this.gbEmployList.Name = "gbEmployList";
            this.gbEmployList.Size = new System.Drawing.Size(1100, 420);
            this.gbEmployList.TabIndex = 21;
            this.gbEmployList.TabStop = false;
            this.gbEmployList.Text = "SALES HISTORY";
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 839);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbOrderInventory);
            this.Controls.Add(this.gbEmployList);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "SalesHistory";
            this.Load += new System.EventHandler(this.SalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.gbOrderInventory.ResumeLayout(false);
            this.gbOrderInventory.PerformLayout();
            this.gbEmployList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbOrderInventory;
        private System.Windows.Forms.GroupBox gbEmployList;
        private System.Windows.Forms.ComboBox cbInventoryID;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.TextBox tbInventoryUnitPrice;
        private System.Windows.Forms.TextBox tbInventoryDescription;
        private System.Windows.Forms.TextBox tbInventoryName;
        private System.Windows.Forms.TextBox tbInventoryQuantity;
        private System.Windows.Forms.Label lblInventoryDescription;
        private System.Windows.Forms.Label lblInventoryUnitPrice;
        private System.Windows.Forms.Label lblInventoryName;
        private System.Windows.Forms.Label lblInventoryQuantity;
    }
}