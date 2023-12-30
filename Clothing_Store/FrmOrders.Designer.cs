namespace Clothing_Store
{
    partial class FrmOrders
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.sidepanelitems = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnHomeOrders = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.dataGridViewManage = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ordersClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.sidepanelitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 39);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Orders Management";
            // 
            // sidepanelitems
            // 
            this.sidepanelitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidepanelitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.sidepanelitems.Controls.Add(this.lbltotal);
            this.sidepanelitems.Controls.Add(this.btnHomeOrders);
            this.sidepanelitems.Controls.Add(this.btnTotal);
            this.sidepanelitems.Controls.Add(this.btnManage);
            this.sidepanelitems.Controls.Add(this.btnAddStock);
            this.sidepanelitems.Location = new System.Drawing.Point(12, 81);
            this.sidepanelitems.Name = "sidepanelitems";
            this.sidepanelitems.Size = new System.Drawing.Size(120, 431);
            this.sidepanelitems.TabIndex = 14;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(47, 291);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(19, 20);
            this.lbltotal.TabIndex = 40;
            this.lbltotal.Text = "0";
            // 
            // btnHomeOrders
            // 
            this.btnHomeOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnHomeOrders.FlatAppearance.BorderSize = 0;
            this.btnHomeOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHomeOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeOrders.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeOrders.Location = new System.Drawing.Point(3, 3);
            this.btnHomeOrders.Name = "btnHomeOrders";
            this.btnHomeOrders.Size = new System.Drawing.Size(114, 63);
            this.btnHomeOrders.TabIndex = 14;
            this.btnHomeOrders.Text = "Home";
            this.btnHomeOrders.UseVisualStyleBackColor = false;
            this.btnHomeOrders.Click += new System.EventHandler(this.btnHomeOrders_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotal.Location = new System.Drawing.Point(3, 225);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(114, 63);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManage.Location = new System.Drawing.Point(3, 72);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(114, 63);
            this.btnManage.TabIndex = 12;
            this.btnManage.Text = "Manage ";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStock.Location = new System.Drawing.Point(3, 141);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(114, 63);
            this.btnAddStock.TabIndex = 11;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.AllowUserToAddRows = false;
            this.dataGridViewHome.AllowUserToDeleteRows = false;
            this.dataGridViewHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.ReadOnly = true;
            this.dataGridViewHome.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewHome.TabIndex = 18;
            // 
            // dataGridViewManage
            // 
            this.dataGridViewManage.AllowUserToAddRows = false;
            this.dataGridViewManage.AllowUserToDeleteRows = false;
            this.dataGridViewManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManage.AutoGenerateColumns = false;
            this.dataGridViewManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.totalItemDataGridViewTextBoxColumn,
            this.staffsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.Date,
            this.Delete});
            this.dataGridViewManage.DataSource = this.ordersClassBindingSource;
            this.dataGridViewManage.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewManage.Name = "dataGridViewManage";
            this.dataGridViewManage.ReadOnly = true;
            this.dataGridViewManage.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewManage.TabIndex = 44;
            this.dataGridViewManage.Visible = false;
            this.dataGridViewManage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManage_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "Order_Id";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "Product_Id";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalItemDataGridViewTextBoxColumn
            // 
            this.totalItemDataGridViewTextBoxColumn.DataPropertyName = "Total_Item";
            this.totalItemDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalItemDataGridViewTextBoxColumn.Name = "totalItemDataGridViewTextBoxColumn";
            this.totalItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffsDataGridViewTextBoxColumn
            // 
            this.staffsDataGridViewTextBoxColumn.DataPropertyName = "Staffs";
            this.staffsDataGridViewTextBoxColumn.HeaderText = "Staff";
            this.staffsDataGridViewTextBoxColumn.Name = "staffsDataGridViewTextBoxColumn";
            this.staffsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Order_Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 25F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::Clothing_Store.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 25;
            // 
            // ordersClassBindingSource
            // 
            this.ordersClassBindingSource.DataSource = typeof(Clothing_Store.classes.ordersClass);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(680, 40);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(74, 21);
            this.cbFilter.TabIndex = 47;
            this.cbFilter.Text = "Filter";
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblsearch.Location = new System.Drawing.Point(633, 43);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 46;
            this.lblsearch.Text = "Search";
            this.lblsearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblsearch_MouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(437, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 45;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AllowUserToDeleteRows = false;
            this.dataGridViewSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewSearch.TabIndex = 48;
            this.dataGridViewSearch.Visible = false;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.sidepanelitems);
            this.Controls.Add(this.dataGridViewManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.sidepanelitems.ResumeLayout(false);
            this.sidepanelitems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel sidepanelitems;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnHomeOrders;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.DataGridView dataGridViewManage;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.BindingSource ordersClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
    }
}