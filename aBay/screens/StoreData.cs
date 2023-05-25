using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aBay.screens
{
    public partial class StoreData : Form
    {
        int ID;
        public StoreData(int ID)
        {
            this.ID = ID;
            InitializeComponent();
        }

        private void storeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet2);

        }

        private void StoreData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet2.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.dbProjectDataSet2.Store);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            seller s1=new seller(ID);
            this.Hide();
            s1.Show();
        }

        private void StoreData_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet2.Store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.dbProjectDataSet2.Store);

        }

        private void storeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.storeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet2);

        }
    }
}
