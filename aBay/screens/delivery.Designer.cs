namespace aBay
{
    partial class delivery
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dbProjectDataSet = new aBay.dbProjectDataSet();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new aBay.dbProjectDataSetTableAdapters.DeliveryTableAdapter();
            this.tableAdapterManager = new aBay.dbProjectDataSetTableAdapters.TableAdapterManager();
            this.buyTableAdapter = new aBay.dbProjectDataSetTableAdapters.buyTableAdapter();
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbProjectDataSet1 = new aBay.dbProjectDataSet1();
            this.buyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buyTableAdapter1 = new aBay.dbProjectDataSet1TableAdapters.buyTableAdapter();
            this.tableAdapterManager1 = new aBay.dbProjectDataSet1TableAdapters.TableAdapterManager();
            this.buyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // dbProjectDataSet
            // 
            this.dbProjectDataSet.DataSetName = "dbProjectDataSet";
            this.dbProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.dbProjectDataSet;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buyTableAdapter = this.buyTableAdapter;
            this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.UpdateOrder = aBay.dbProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userPhoneTableAdapter = null;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // buyTableAdapter
            // 
            this.buyTableAdapter.ClearBeforeFill = true;
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataMember = "buy";
            this.buyBindingSource.DataSource = this.dbProjectDataSet;
            // 
            // dbProjectDataSet1
            // 
            this.dbProjectDataSet1.DataSetName = "dbProjectDataSet1";
            this.dbProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyBindingSource1
            // 
            this.buyBindingSource1.DataMember = "buy";
            this.buyBindingSource1.DataSource = this.dbProjectDataSet1;
            // 
            // buyTableAdapter1
            // 
            this.buyTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.buyTableAdapter = this.buyTableAdapter1;
            this.tableAdapterManager1.deliveryTableAdapter = null;
            this.tableAdapterManager1.itemTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = aBay.dbProjectDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.userPhoneTableAdapter = null;
            this.tableAdapterManager1.userTableAdapter = null;
            // 
            // buyDataGridView
            // 
            this.buyDataGridView.AllowUserToDeleteRows = false;
            this.buyDataGridView.AutoGenerateColumns = false;
            this.buyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.buyDataGridView.DataSource = this.buyBindingSource1;
            this.buyDataGridView.Location = new System.Drawing.Point(28, 66);
            this.buyDataGridView.Name = "buyDataGridView";
            this.buyDataGridView.ReadOnly = true;
            this.buyDataGridView.RowHeadersWidth = 51;
            this.buyDataGridView.RowTemplate.Height = 24;
            this.buyDataGridView.Size = new System.Drawing.Size(739, 397);
            this.buyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn2.HeaderText = "cost";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "purchaseDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "purchaseDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "itemID";
            this.dataGridViewTextBoxColumn4.HeaderText = "itemID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "userID";
            this.dataGridViewTextBoxColumn5.HeaderText = "userID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DeliveryID";
            this.dataGridViewTextBoxColumn6.HeaderText = "DeliveryID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.buyDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "delivery";
            this.Text = "delivery";
            this.Load += new System.EventHandler(this.delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private dbProjectDataSet dbProjectDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private dbProjectDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private dbProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbProjectDataSetTableAdapters.buyTableAdapter buyTableAdapter;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private dbProjectDataSet1 dbProjectDataSet1;
        private System.Windows.Forms.BindingSource buyBindingSource1;
        private dbProjectDataSet1TableAdapters.buyTableAdapter buyTableAdapter1;
        private dbProjectDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView buyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}