namespace aBay
{
    partial class login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(91, 50);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(163, 20);
            this.userID.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(91, 105);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(163, 20);
            this.password.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.CausesValidation = false;
            this.LoginButton.Location = new System.Drawing.Point(28, 176);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(226, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // exit
            // 
            this.exit.CausesValidation = false;
            this.exit.Location = new System.Drawing.Point(28, 214);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(226, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button exit;
    }
}