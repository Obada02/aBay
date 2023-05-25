using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aBay
{
    public partial class signUp : Form
    {
        SqlConnection conn;
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbProject.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int buyer = 0, seller = 0, delivery=0;
        private void userType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;

            // Uncheck all items except for the currently checked item
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }
            carType.Visible = (e.Index == 2);
            carTypeLabel.Visible = (e.Index == 2);
            if (e.Index == 0)
            {
                buyer = 1;
            }else
            {
                buyer = 0;
            }

            if (e.Index == 1)
            {
                seller = 1;
            }
            else
            {
                seller = 0;
            }

            if (e.Index == 2)
            {
                delivery = 1;
            }
            else
            {
                delivery = 0;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "INSERT INTO [user] (FName, LName, Email, Password, Location, buyer, seller, delivery, CarType)" +
                " VALUES (@FName, @LName, @Email, @Password, @Location, @Buyer, @Seller, @Delivery, @CarType)";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("@FName", Fname.Text);
            command.Parameters.AddWithValue("@LName", Lname.Text);
            command.Parameters.AddWithValue("@Email", Email.Text);
            command.Parameters.AddWithValue("@Password", password.Text);
            command.Parameters.AddWithValue("@Location", Location.Text);
            command.Parameters.AddWithValue("@Buyer", buyer);
            command.Parameters.AddWithValue("@Seller", seller);
            command.Parameters.AddWithValue("@Delivery", delivery);
            command.Parameters.AddWithValue("@CarType", carType.Text);

            command.ExecuteNonQuery();
            MessageBox.Show("Added successfully!");
            conn.Close();

            
            this.Hide();
            
        }
    }
}
