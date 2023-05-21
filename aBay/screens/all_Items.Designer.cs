namespace aBay.screens
{
    partial class all_Items
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
            this.dbProjectDataSet1 = new aBay.dbProjectDataSet1();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new aBay.dbProjectDataSet1TableAdapters.itemTableAdapter();
            this.tableAdapterManager = new aBay.dbProjectDataSet1TableAdapters.TableAdapterManager();
            this.buyTableAdapter = new aBay.dbProjectDataSet1TableAdapters.buyTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.purchaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtbx1Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbProjectDataSet1
            // 
            this.dbProjectDataSet1.DataSetName = "dbProjectDataSet1";
            this.dbProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.dbProjectDataSet1;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buyTableAdapter = this.buyTableAdapter;
            this.tableAdapterManager.deliveryTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.UpdateOrder = aBay.dbProjectDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userPhoneTableAdapter = null;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // buyTableAdapter
            // 
            this.buyTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "all items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataMember = "buy";
            this.buyBindingSource.DataSource = this.dbProjectDataSet1;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.dbProjectDataSet1;
            // 
            // itemBindingSource2
            // 
            this.itemBindingSource2.DataMember = "item";
            this.itemBindingSource2.DataSource = this.dbProjectDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 127);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn1,
            this.deliveryIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.buyBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(16, 231);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(575, 125);
            this.dataGridView2.TabIndex = 5;
            // 
            // purchaseIDDataGridViewTextBoxColumn
            // 
            this.purchaseIDDataGridViewTextBoxColumn.DataPropertyName = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.HeaderText = "PurchaseID";
            this.purchaseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseIDDataGridViewTextBoxColumn.Name = "purchaseIDDataGridViewTextBoxColumn";
            this.purchaseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "purchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "purchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            // 
            // buyBindingSource1
            // 
            this.buyBindingSource1.DataMember = "buy";
            this.buyBindingSource1.DataSource = this.dbProjectDataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbx1Search
            // 
            this.txtbx1Search.Location = new System.Drawing.Point(291, 31);
            this.txtbx1Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbx1Search.Name = "txtbx1Search";
            this.txtbx1Search.Size = new System.Drawing.Size(182, 20);
            this.txtbx1Search.TabIndex = 7;
            // 
            // all_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtbx1Search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "all_Items";
            this.Text = "all_Items";
            this.Load += new System.EventHandler(this.all_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectDataSet1 dbProjectDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private dbProjectDataSet1TableAdapters.itemTableAdapter itemTableAdapter;
        private dbProjectDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private dbProjectDataSet1TableAdapters.buyTableAdapter buyTableAdapter;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.BindingSource itemBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buyBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbx1Search;
    }
}