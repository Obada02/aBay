using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace aBay.screens
{
    public partial class all_Items : Form
    {
        SqlConnection conn;
        int itemID;
        string name;
        float price;
        int userID;
        public all_Items(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            RefreshData();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet1);

        }

        private void all_Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet1.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.dbProjectDataSet1.buy);
            // TODO: This line of code loads data into the 'dbProjectDataSet1.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dbProjectDataSet1.item);
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbProject.mdf;Integrated Security=True;Connect Timeout=30");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            //for (int i = 0; i < 3; i++) {
            //    MessageBox.Show(row.Cells[i].Value.ToString());
            //}

            itemID = int.Parse(row.Cells[0].Value.ToString());
            name = row.Cells[1].Value.ToString();
            price = float.Parse(row.Cells[2].Value.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "insert into buy (cost,purchaseDate,itemID,userID,DeliveryID) Values (" + price + ",'" + DateTime.Today + "'," + itemID + ",1,1)";
            SqlCommand com = new SqlCommand(sql, conn);
            com.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added successfully");
            RefreshData();
        }
        private void RefreshData()
        {
            conn.Open();
            string Myquery = "select purchaseID,cost,purchaseDate,itemID,userID,DeliveryID from buy where userID="+userID+"";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            name=txtbx1Search.Text;
            if (name != string.Empty)
            {
                conn.Open();
                string Myquery = "select itemID,name,price from item where name like '%" + name + "%'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            else { 
                txtbx1Search.Text = "please enter anything here";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
