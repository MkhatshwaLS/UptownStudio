namespace UptownStudioApplication
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbInventoryList = new System.Windows.Forms.GroupBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.gbInventoryInfo = new System.Windows.Forms.GroupBox();
            this.cbInventoryID = new System.Windows.Forms.ComboBox();
            this.tbInventoryUnitPrice = new System.Windows.Forms.TextBox();
            this.tbInventoryDescription = new System.Windows.Forms.TextBox();
            this.tbInventoryName = new System.Windows.Forms.TextBox();
            this.tbInventoryQuantity = new System.Windows.Forms.TextBox();
            this.lblInventoryDescription = new System.Windows.Forms.Label();
            this.lblInventoryUnitPrice = new System.Windows.Forms.Label();
            this.lblInventoryName = new System.Windows.Forms.Label();
            this.lblInventoryQuantity = new System.Windows.Forms.Label();
            this.lblInventoryID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.gbInventoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(461, 774);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 39);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "         New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(975, 774);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 39);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "         Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(633, 774);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 39);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "         Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbInventoryList
            // 
            this.gbInventoryList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInventoryList.AutoSize = true;
            this.gbInventoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.gbInventoryList.Controls.Add(this.dgvInventory);
            this.gbInventoryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInventoryList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventoryList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.gbInventoryList.Location = new System.Drawing.Point(25, 26);
            this.gbInventoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInventoryList.Name = "gbInventoryList";
            this.gbInventoryList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInventoryList.Size = new System.Drawing.Size(1100, 418);
            this.gbInventoryList.TabIndex = 33;
            this.gbInventoryList.TabStop = false;
            this.gbInventoryList.Text = "INVENTORY LIST";
            // 
            // dgvInventory
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.Location = new System.Drawing.Point(20, 85);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(1060, 300);
            this.dgvInventory.TabIndex = 1;
            // 
            // gbInventoryInfo
            // 
            this.gbInventoryInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInventoryInfo.AutoSize = true;
            this.gbInventoryInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.gbInventoryInfo.Controls.Add(this.cbInventoryID);
            this.gbInventoryInfo.Controls.Add(this.tbInventoryUnitPrice);
            this.gbInventoryInfo.Controls.Add(this.tbInventoryDescription);
            this.gbInventoryInfo.Controls.Add(this.tbInventoryName);
            this.gbInventoryInfo.Controls.Add(this.tbInventoryQuantity);
            this.gbInventoryInfo.Controls.Add(this.lblInventoryDescription);
            this.gbInventoryInfo.Controls.Add(this.lblInventoryUnitPrice);
            this.gbInventoryInfo.Controls.Add(this.lblInventoryName);
            this.gbInventoryInfo.Controls.Add(this.lblInventoryQuantity);
            this.gbInventoryInfo.Controls.Add(this.lblInventoryID);
            this.gbInventoryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInventoryInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventoryInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.gbInventoryInfo.Location = new System.Drawing.Point(25, 450);
            this.gbInventoryInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInventoryInfo.Name = "gbInventoryInfo";
            this.gbInventoryInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbInventoryInfo.Size = new System.Drawing.Size(1100, 300);
            this.gbInventoryInfo.TabIndex = 34;
            this.gbInventoryInfo.TabStop = false;
            this.gbInventoryInfo.Text = "INVENTORY INFORMATION";
            // 
            // cbInventoryID
            // 
            this.cbInventoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInventoryID.FormattingEnabled = true;
            this.cbInventoryID.Location = new System.Drawing.Point(499, 66);
            this.cbInventoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbInventoryID.Name = "cbInventoryID";
            this.cbInventoryID.Size = new System.Drawing.Size(300, 32);
            this.cbInventoryID.TabIndex = 5;
            this.cbInventoryID.SelectedValueChanged += new System.EventHandler(this.cbInventoryID_SelectedValueChanged);
            // 
            // tbInventoryUnitPrice
            // 
            this.tbInventoryUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryUnitPrice.Location = new System.Drawing.Point(755, 202);
            this.tbInventoryUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryUnitPrice.Name = "tbInventoryUnitPrice";
            this.tbInventoryUnitPrice.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryUnitPrice.TabIndex = 7;
            // 
            // tbInventoryDescription
            // 
            this.tbInventoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryDescription.Location = new System.Drawing.Point(755, 135);
            this.tbInventoryDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryDescription.Name = "tbInventoryDescription";
            this.tbInventoryDescription.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryDescription.TabIndex = 8;
            // 
            // tbInventoryName
            // 
            this.tbInventoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryName.Location = new System.Drawing.Point(255, 135);
            this.tbInventoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryName.Name = "tbInventoryName";
            this.tbInventoryName.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryName.TabIndex = 8;
            // 
            // tbInventoryQuantity
            // 
            this.tbInventoryQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbInventoryQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventoryQuantity.Location = new System.Drawing.Point(255, 202);
            this.tbInventoryQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInventoryQuantity.Name = "tbInventoryQuantity";
            this.tbInventoryQuantity.Size = new System.Drawing.Size(300, 30);
            this.tbInventoryQuantity.TabIndex = 6;
            // 
            // lblInventoryDescription
            // 
            this.lblInventoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryDescription.AutoSize = true;
            this.lblInventoryDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryDescription.Location = new System.Drawing.Point(599, 138);
            this.lblInventoryDescription.Name = "lblInventoryDescription";
            this.lblInventoryDescription.Size = new System.Drawing.Size(105, 24);
            this.lblInventoryDescription.TabIndex = 0;
            this.lblInventoryDescription.Text = "Description : ";
            // 
            // lblInventoryUnitPrice
            // 
            this.lblInventoryUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryUnitPrice.AutoSize = true;
            this.lblInventoryUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryUnitPrice.Location = new System.Drawing.Point(599, 204);
            this.lblInventoryUnitPrice.Name = "lblInventoryUnitPrice";
            this.lblInventoryUnitPrice.Size = new System.Drawing.Size(129, 24);
            this.lblInventoryUnitPrice.TabIndex = 0;
            this.lblInventoryUnitPrice.Text = "Unit Cost Price :";
            // 
            // lblInventoryName
            // 
            this.lblInventoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryName.AutoSize = true;
            this.lblInventoryName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryName.Location = new System.Drawing.Point(43, 138);
            this.lblInventoryName.Name = "lblInventoryName";
            this.lblInventoryName.Size = new System.Drawing.Size(131, 24);
            this.lblInventoryName.TabIndex = 0;
            this.lblInventoryName.Text = "Product Name : ";
            // 
            // lblInventoryQuantity
            // 
            this.lblInventoryQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryQuantity.AutoSize = true;
            this.lblInventoryQuantity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryQuantity.Location = new System.Drawing.Point(44, 204);
            this.lblInventoryQuantity.Name = "lblInventoryQuantity";
            this.lblInventoryQuantity.Size = new System.Drawing.Size(152, 24);
            this.lblInventoryQuantity.TabIndex = 0;
            this.lblInventoryQuantity.Text = "Quantity In Stock : ";
            // 
            // lblInventoryID
            // 
            this.lblInventoryID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInventoryID.AutoSize = true;
            this.lblInventoryID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInventoryID.Location = new System.Drawing.Point(311, 70);
            this.lblInventoryID.Name = "lblInventoryID";
            this.lblInventoryID.Size = new System.Drawing.Size(116, 24);
            this.lblInventoryID.TabIndex = 0;
            this.lblInventoryID.Text = "Inventory ID : ";
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
            this.btnDelete.Location = new System.Drawing.Point(804, 774);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 39);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "         Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 839);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbInventoryList);
            this.Controls.Add(this.gbInventoryInfo);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.gbInventoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.gbInventoryInfo.ResumeLayout(false);
            this.gbInventoryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbInventoryList;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox gbInventoryInfo;
        private System.Windows.Forms.ComboBox cbInventoryID;
        private System.Windows.Forms.TextBox tbInventoryUnitPrice;
        private System.Windows.Forms.TextBox tbInventoryDescription;
        private System.Windows.Forms.TextBox tbInventoryName;
        private System.Windows.Forms.TextBox tbInventoryQuantity;
        private System.Windows.Forms.Label lblInventoryDescription;
        private System.Windows.Forms.Label lblInventoryUnitPrice;
        private System.Windows.Forms.Label lblInventoryName;
        private System.Windows.Forms.Label lblInventoryQuantity;
        private System.Windows.Forms.Label lblInventoryID;
        private System.Windows.Forms.Button btnDelete;
    }
}