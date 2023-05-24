namespace aBay
{
    partial class signUp
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
            this.Fname = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.TextBox();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(178, 62);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(125, 20);
            this.Fname.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(178, 191);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(125, 20);
            this.password.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(178, 148);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(125, 20);
            this.Email.TabIndex = 2;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(178, 104);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(125, 20);
            this.Lname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(178, 238);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(125, 20);
            this.Location.TabIndex = 9;
            // 
            // userType
            // 
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "Buyer",
            "Seller",
            "Delivery"});
            this.userType.Location = new System.Drawing.Point(178, 273);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(125, 49);
            this.userType.TabIndex = 10;
            this.userType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.userType_ItemCheck);
            this.userType.SelectedIndexChanged += new System.EventHandler(this.userType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "User Type";
            // 
            // carType
            // 
            this.carType.Location = new System.Drawing.Point(178, 348);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(125, 20);
            this.carType.TabIndex = 12;
            this.carType.Visible = false;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(115, 351);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(50, 13);
            this.carTypeLabel.TabIndex = 13;
            this.carTypeLabel.Text = "Car Type";
            this.carTypeLabel.Visible = false;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(115, 391);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(188, 23);
            this.create.TabIndex = 14;
            this.create.Text = "Sign Up";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.create);
            this.Controls.Add(this.carTypeLabel);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Fname);
            this.Name = "signUp";
            this.Text = "signUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.CheckedListBox userType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox carType;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.Button create;
    }
}