using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aBay
{
    public partial class delivery : Form
    {
        int id;
        public delivery(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            buyBindingSource1.Filter = $"item IN (SELECT * FROM item WHERE storeID = (select userID from store where storeID = {id}))";
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet);

        }

        private void delivery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet1.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter1.Fill(this.dbProjectDataSet1.buy);
            // TODO: This line of code loads data into the 'dbProjectDataSet.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.dbProjectDataSet.buy);
            // TODO: This line of code loads data into the 'dbProjectDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.dbProjectDataSet.Delivery);

        }
    }
}
