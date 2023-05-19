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
            string sql = "SELECT * FROM Login WHERE ID =" + userID.Text + ";";
            //SQLiteCommand command = new SQLiteCommand(sql, conn);
            //SQLiteDataReader reader = command.ExecuteReader();
        }
    }
}
