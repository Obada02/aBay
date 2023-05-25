using aBay.screens;
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
using System.Xml.Linq;

namespace aBay
{
    public partial class seller : Form
    {
        public int id;
        SqlConnection conn;
        public seller(int ID)
        {
            id = ID;
            InitializeComponent();
        }

        private void seller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet1.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dbProjectDataSet1.item);
            // TODO: This line of code loads data into the 'dbProjectDataSet1.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.dbProjectDataSet1.buy);
            conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\dbProject.mdf;Integrated Security=True;Connect Timeout=30");

        }

        private void buyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            itemBindingSource.Filter = $"item IN (SELECT * FROM item WHERE storeID = (select userID from store where storeID = {id}))";
            this.Validate();
            this.buyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet1);

        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string name = txtbxSearch.Text;
            if (name != string.Empty)
            {
                conn.Open();
                string Myquery = "select itemID,name,price,quantity from item where name like '%" + name + "%'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                itemDataGridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
            {
                txtbxSearch.Text = "please enter anything here";
            }
        }

        private void StoreData_Click(object sender, EventArgs e)
        {
            StoreData sd1 = new StoreData(id);
            this.Hide();
            sd1.Show();
        }
    }
}
