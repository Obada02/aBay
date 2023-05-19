using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;

namespace aBay
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Password FROM Users WHERE ID =" + userID.Text + ";";
            string entredPassword = password.Text;
            string userPassword = "123";
            bool seller = true, buyer = true, delivery = true;
            if (entredPassword == userPassword){
                if (seller)
                {

                }else if (buyer)
                {

                }else
                {

                }
            }else
            {
                MessageBox.Show("Wrong ID or Password!");
            }
            //SQLiteCommand command = new SQLiteCommand(sql, conn);
            //SQLiteDataReader reader = command.ExecuteReader();
        }
    }
}
