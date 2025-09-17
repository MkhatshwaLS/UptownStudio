namespace UptownStudioApplication
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblParagraphOne = new System.Windows.Forms.Label();
            this.lblParagraphTwo = new System.Windows.Forms.Label();
            this.lblSubheading = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParagraphOne
            // 
            this.lblParagraphOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParagraphOne.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraphOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblParagraphOne.Location = new System.Drawing.Point(75, 366);
            this.lblParagraphOne.Name = "lblParagraphOne";
            this.lblParagraphOne.Size = new System.Drawing.Size(1000, 100);
            this.lblParagraphOne.TabIndex = 2;
            this.lblParagraphOne.Text = resources.GetString("lblParagraphOne.Text");
            this.lblParagraphOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblParagraphTwo
            // 
            this.lblParagraphTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParagraphTwo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraphTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblParagraphTwo.Location = new System.Drawing.Point(75, 490);
            this.lblParagraphTwo.Name = "lblParagraphTwo";
            this.lblParagraphTwo.Size = new System.Drawing.Size(1000, 100);
            this.lblParagraphTwo.TabIndex = 3;
            this.lblParagraphTwo.Text = resources.GetString("lblParagraphTwo.Text");
            this.lblParagraphTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubheading
            // 
            this.lblSubheading.AutoSize = true;
            this.lblSubheading.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.lblSubheading.Location = new System.Drawing.Point(375, 315);
            this.lblSubheading.Name = "lblSubheading";
            this.lblSubheading.Size = new System.Drawing.Size(401, 27);
            this.lblSubheading.TabIndex = 4;
            this.lblSubheading.Text = "to the Uptown Studio Management System!";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblHeading.Location = new System.Drawing.Point(460, 251);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(230, 40);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "Welcome, Guest";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 840);
            this.Controls.Add(this.lblParagraphOne);
            this.Controls.Add(this.lblParagraphTwo);
            this.Controls.Add(this.lblSubheading);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParagraphOne;
        private System.Windows.Forms.Label lblParagraphTwo;
        private System.Windows.Forms.Label lblSubheading;
        private System.Windows.Forms.Label lblHeading;
    }
}