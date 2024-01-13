namespace Clothing_Store
{
    partial class FrmDelivery
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.dataGridView1Home = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnHomeDelivery = new System.Windows.Forms.Button();
            this.cbSortby = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewManagePending = new System.Windows.Forms.DataGridView();
            this.deliveryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intransit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.deliveryClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewManageIntransit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveredIntransit = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteIntransit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewManageDelivered = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Home)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagePending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageIntransit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageDelivered)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(3, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 63);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnManage.Location = new System.Drawing.Point(3, 141);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(114, 63);
            this.btnManage.TabIndex = 35;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // dataGridView1Home
            // 
            this.dataGridView1Home.AllowUserToAddRows = false;
            this.dataGridView1Home.AllowUserToDeleteRows = false;
            this.dataGridView1Home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Home.Location = new System.Drawing.Point(138, 81);
            this.dataGridView1Home.Name = "dataGridView1Home";
            this.dataGridView1Home.ReadOnly = true;
            this.dataGridView1Home.Size = new System.Drawing.Size(617, 431);
            this.dataGridView1Home.TabIndex = 36;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(335, 39);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Deliveries Management";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.btnHomeDelivery);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 431);
            this.panel1.TabIndex = 38;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(50, 276);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(19, 20);
            this.lbltotal.TabIndex = 40;
            this.lbltotal.Text = "0";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotal.Location = new System.Drawing.Point(3, 210);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(114, 63);
            this.btnTotal.TabIndex = 38;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            // 
            // btnHomeDelivery
            // 
            this.btnHomeDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnHomeDelivery.FlatAppearance.BorderSize = 0;
            this.btnHomeDelivery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHomeDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeDelivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeDelivery.Location = new System.Drawing.Point(3, 3);
            this.btnHomeDelivery.Name = "btnHomeDelivery";
            this.btnHomeDelivery.Size = new System.Drawing.Size(114, 63);
            this.btnHomeDelivery.TabIndex = 36;
            this.btnHomeDelivery.Text = "Home";
            this.btnHomeDelivery.UseVisualStyleBackColor = false;
            this.btnHomeDelivery.Click += new System.EventHandler(this.btnHomeDelivery_Click);
            // 
            // cbSortby
            // 
            this.cbSortby.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSortby.FormattingEnabled = true;
            this.cbSortby.Location = new System.Drawing.Point(515, 45);
            this.cbSortby.Name = "cbSortby";
            this.cbSortby.Size = new System.Drawing.Size(240, 21);
            this.cbSortby.TabIndex = 39;
            this.cbSortby.Text = "Sort by Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewManagePending
            // 
            this.dataGridViewManagePending.AllowUserToAddRows = false;
            this.dataGridViewManagePending.AllowUserToDeleteRows = false;
            this.dataGridViewManagePending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManagePending.AutoGenerateColumns = false;
            this.dataGridViewManagePending.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManagePending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManagePending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIdDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Intransit,
            this.Delete});
            this.dataGridViewManagePending.DataSource = this.deliveryClassBindingSource;
            this.dataGridViewManagePending.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewManagePending.Name = "dataGridViewManagePending";
            this.dataGridViewManagePending.ReadOnly = true;
            this.dataGridViewManagePending.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewManagePending.TabIndex = 40;
            this.dataGridViewManagePending.Visible = false;
            this.dataGridViewManagePending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManagePending_CellContentClick);
            // 
            // deliveryIdDataGridViewTextBoxColumn
            // 
            this.deliveryIdDataGridViewTextBoxColumn.DataPropertyName = "Delivery_Id";
            this.deliveryIdDataGridViewTextBoxColumn.HeaderText = "Delivery Id";
            this.deliveryIdDataGridViewTextBoxColumn.Name = "deliveryIdDataGridViewTextBoxColumn";
            this.deliveryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "Customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "order_Id";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Intransit
            // 
            this.Intransit.FillWeight = 30F;
            this.Intransit.HeaderText = "Intransit";
            this.Intransit.Image = global::Clothing_Store.Properties.Resources.move;
            this.Intransit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Intransit.Name = "Intransit";
            this.Intransit.ReadOnly = true;
            this.Intransit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Intransit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 25F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::Clothing_Store.Properties.Resources.delete_icon;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 5;
            // 
            // deliveryClassBindingSource
            // 
            this.deliveryClassBindingSource.DataSource = typeof(Clothing_Store.classes.deliveryClass);
            // 
            // dataGridViewManageIntransit
            // 
            this.dataGridViewManageIntransit.AllowUserToAddRows = false;
            this.dataGridViewManageIntransit.AllowUserToDeleteRows = false;
            this.dataGridViewManageIntransit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManageIntransit.AutoGenerateColumns = false;
            this.dataGridViewManageIntransit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManageIntransit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageIntransit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.DeliveredIntransit,
            this.DeleteIntransit});
            this.dataGridViewManageIntransit.DataSource = this.deliveryClassBindingSource;
            this.dataGridViewManageIntransit.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewManageIntransit.Name = "dataGridViewManageIntransit";
            this.dataGridViewManageIntransit.ReadOnly = true;
            this.dataGridViewManageIntransit.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewManageIntransit.TabIndex = 41;
            this.dataGridViewManageIntransit.Visible = false;
            this.dataGridViewManageIntransit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageIntransit_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Delivery_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Delivery Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contact_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contact No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "order_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Order Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DeliveredIntransit
            // 
            this.DeliveredIntransit.FillWeight = 30F;
            this.DeliveredIntransit.HeaderText = "Delivered";
            this.DeliveredIntransit.Image = global::Clothing_Store.Properties.Resources.move;
            this.DeliveredIntransit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DeliveredIntransit.Name = "DeliveredIntransit";
            this.DeliveredIntransit.ReadOnly = true;
            this.DeliveredIntransit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveredIntransit.Width = 5;
            // 
            // DeleteIntransit
            // 
            this.DeleteIntransit.FillWeight = 25F;
            this.DeleteIntransit.HeaderText = "Delete";
            this.DeleteIntransit.Image = global::Clothing_Store.Properties.Resources.delete_icon;
            this.DeleteIntransit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DeleteIntransit.Name = "DeleteIntransit";
            this.DeleteIntransit.ReadOnly = true;
            this.DeleteIntransit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteIntransit.Width = 5;
            // 
            // dataGridViewManageDelivered
            // 
            this.dataGridViewManageDelivered.AllowUserToAddRows = false;
            this.dataGridViewManageDelivered.AllowUserToDeleteRows = false;
            this.dataGridViewManageDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManageDelivered.AutoGenerateColumns = false;
            this.dataGridViewManageDelivered.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManageDelivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageDelivered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageColumn2});
            this.dataGridViewManageDelivered.DataSource = this.deliveryClassBindingSource;
            this.dataGridViewManageDelivered.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewManageDelivered.Name = "dataGridViewManageDelivered";
            this.dataGridViewManageDelivered.ReadOnly = true;
            this.dataGridViewManageDelivered.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewManageDelivered.TabIndex = 42;
            this.dataGridViewManageDelivered.Visible = false;
            this.dataGridViewManageDelivered.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageDelivered_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Delivery_Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Delivery Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Customer_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn9.HeaderText = "Address";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Contact_No";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contact No";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "order_Id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Order Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn12.HeaderText = "Description";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 25F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::Clothing_Store.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 25F;
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = global::Clothing_Store.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.FillWeight = 25F;
            this.dataGridViewImageColumn3.HeaderText = "Intransit";
            this.dataGridViewImageColumn3.Image = global::Clothing_Store.Properties.Resources.move;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 5;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.FillWeight = 25F;
            this.dataGridViewImageColumn4.HeaderText = "Delete";
            this.dataGridViewImageColumn4.Image = global::Clothing_Store.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.Width = 5;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.cbSortby);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridViewManagePending);
            this.Controls.Add(this.dataGridView1Home);
            this.Controls.Add(this.dataGridViewManageDelivered);
            this.Controls.Add(this.dataGridViewManageIntransit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDelivery";
            this.Text = "FrmDelivery";
            this.Load += new System.EventHandler(this.FrmDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagePending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageIntransit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageDelivered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.DataGridView dataGridView1Home;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSortby;
        private System.Windows.Forms.Button btnHomeDelivery;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridViewManagePending;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.BindingSource deliveryClassBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewManageIntransit;
        private System.Windows.Forms.DataGridView dataGridViewManageDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Intransit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn DeliveredIntransit;
        private System.Windows.Forms.DataGridViewImageColumn DeleteIntransit;
        private System.Windows.Forms.Timer timer2;
    }
}