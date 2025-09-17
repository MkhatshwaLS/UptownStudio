
namespace UptownStudioApplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginSidePanel = new System.Windows.Forms.Panel();
            this.uptownStudioLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginMainPanel = new System.Windows.Forms.Panel();
            this.llblRegistration = new System.Windows.Forms.LinkLabel();
            this.lblNewEmployee = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHeadingII = new System.Windows.Forms.Label();
            this.lblHeadingI = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginSidePanel.SuspendLayout();
            this.loginMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginSidePanel
            // 
            this.loginSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.loginSidePanel.Controls.Add(this.pictureBox1);
            this.loginSidePanel.Controls.Add(this.uptownStudioLogo);
            this.loginSidePanel.Controls.Add(this.label1);
            this.loginSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginSidePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSidePanel.Location = new System.Drawing.Point(0, 0);
            this.loginSidePanel.Name = "loginSidePanel";
            this.loginSidePanel.Size = new System.Drawing.Size(300, 600);
            this.loginSidePanel.TabIndex = 0;
            // 
            // uptownStudioLogo
            // 
            this.uptownStudioLogo.AutoSize = true;
            this.uptownStudioLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uptownStudioLogo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptownStudioLogo.ForeColor = System.Drawing.Color.White;
            this.uptownStudioLogo.Location = new System.Drawing.Point(107, 490);
            this.uptownStudioLogo.Name = "uptownStudioLogo";
            this.uptownStudioLogo.Size = new System.Drawing.Size(84, 27);
            this.uptownStudioLogo.TabIndex = 0;
            this.uptownStudioLogo.Text = "STUDIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPTOWN";
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.Controls.Add(this.pbPassword);
            this.loginMainPanel.Controls.Add(this.pbUsername);
            this.loginMainPanel.Controls.Add(this.llblRegistration);
            this.loginMainPanel.Controls.Add(this.lblNewEmployee);
            this.loginMainPanel.Controls.Add(this.btnForgetPassword);
            this.loginMainPanel.Controls.Add(this.btnLogin);
            this.loginMainPanel.Controls.Add(this.btnClose);
            this.loginMainPanel.Controls.Add(this.tbPassword);
            this.loginMainPanel.Controls.Add(this.tbUsername);
            this.loginMainPanel.Controls.Add(this.lblPassword);
            this.loginMainPanel.Controls.Add(this.lblUsername);
            this.loginMainPanel.Controls.Add(this.lblHeadingII);
            this.loginMainPanel.Controls.Add(this.lblHeadingI);
            this.loginMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginMainPanel.Location = new System.Drawing.Point(300, 0);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(500, 600);
            this.loginMainPanel.TabIndex = 1;
            // 
            // llblRegistration
            // 
            this.llblRegistration.AutoSize = true;
            this.llblRegistration.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegistration.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.llblRegistration.Location = new System.Drawing.Point(268, 512);
            this.llblRegistration.Name = "llblRegistration";
            this.llblRegistration.Size = new System.Drawing.Size(62, 22);
            this.llblRegistration.TabIndex = 8;
            this.llblRegistration.TabStop = true;
            this.llblRegistration.Text = "Register";
            this.llblRegistration.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(254)))), ((int)(((byte)(234)))));
            this.llblRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistration_LinkClicked);
            // 
            // lblNewEmployee
            // 
            this.lblNewEmployee.AutoSize = true;
            this.lblNewEmployee.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmployee.Location = new System.Drawing.Point(145, 512);
            this.lblNewEmployee.Name = "lblNewEmployee";
            this.lblNewEmployee.Size = new System.Drawing.Size(117, 22);
            this.lblNewEmployee.TabIndex = 7;
            this.lblNewEmployee.Text = "New Employee ?";
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.ForeColor = System.Drawing.Color.White;
            this.btnForgetPassword.Location = new System.Drawing.Point(264, 428);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(173, 53);
            this.btnForgetPassword.TabIndex = 6;
            this.btnForgetPassword.Text = "Forget Password";
            this.btnForgetPassword.UseVisualStyleBackColor = false;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(62, 428);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 53);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(100, 358);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(300, 27);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Password";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(98, 269);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(300, 27);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(61, 324);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 22);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(58, 235);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 22);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username :";
            // 
            // lblHeadingII
            // 
            this.lblHeadingII.AutoSize = true;
            this.lblHeadingII.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingII.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblHeadingII.Location = new System.Drawing.Point(114, 143);
            this.lblHeadingII.Name = "lblHeadingII";
            this.lblHeadingII.Size = new System.Drawing.Size(244, 33);
            this.lblHeadingII.TabIndex = 1;
            this.lblHeadingII.Text = "Management System";
            // 
            // lblHeadingI
            // 
            this.lblHeadingI.AutoSize = true;
            this.lblHeadingI.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.lblHeadingI.Location = new System.Drawing.Point(153, 99);
            this.lblHeadingI.Name = "lblHeadingI";
            this.lblHeadingI.Size = new System.Drawing.Size(177, 33);
            this.lblHeadingI.TabIndex = 1;
            this.lblHeadingI.Text = "Uptown Studio";
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.pbPassword.Image = global::UptownStudioApplication.Properties.Resources.password;
            this.pbPassword.Location = new System.Drawing.Point(67, 359);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(27, 27);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 9;
            this.pbPassword.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.pbUsername.Image = global::UptownStudioApplication.Properties.Resources.username;
            this.pbUsername.Location = new System.Drawing.Point(65, 269);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(27, 27);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 9;
            this.pbUsername.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnClose.Image = global::UptownStudioApplication.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(462, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UptownStudioApplication.Properties.Resources.UptownLogoII;
            this.pictureBox1.Location = new System.Drawing.Point(26, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.loginMainPanel);
            this.Controls.Add(this.loginSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginSidePanel.ResumeLayout(false);
            this.loginSidePanel.PerformLayout();
            this.loginMainPanel.ResumeLayout(false);
            this.loginMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginSidePanel;
        private System.Windows.Forms.Label uptownStudioLogo;
        private System.Windows.Forms.Panel loginMainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblRegistration;
        private System.Windows.Forms.Label lblNewEmployee;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblHeadingII;
        private System.Windows.Forms.Label lblHeadingI;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.PictureBox pbPassword;
    }
}

