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
    public partial class seller : Form
    {
        public seller(int ID)
        {
            InitializeComponent();
        }

        private void seller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectDataSet1.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dbProjectDataSet1.item);
            // TODO: This line of code loads data into the 'dbProjectDataSet1.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.dbProjectDataSet1.buy);

        }

        private void buyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectDataSet1);

        }

        private void itemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
