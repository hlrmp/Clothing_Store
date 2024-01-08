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
            this.dataGridViewManage = new System.Windows.Forms.DataGridView();
            this.deliveryClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pending = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Intransit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Home)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryClassBindingSource)).BeginInit();
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
            // dataGridViewManage
            // 
            this.dataGridViewManage.AllowUserToAddRows = false;
            this.dataGridViewManage.AllowUserToDeleteRows = false;
            this.dataGridViewManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewManage.AutoGenerateColumns = false;
            this.dataGridViewManage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIdDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Pending,
            this.Intransit,
            this.Delivered,
            this.Delete});
            this.dataGridViewManage.DataSource = this.deliveryClassBindingSource;
            this.dataGridViewManage.Location = new System.Drawing.Point(138, 81);
            this.dataGridViewManage.Name = "dataGridViewManage";
            this.dataGridViewManage.ReadOnly = true;
            this.dataGridViewManage.Size = new System.Drawing.Size(617, 431);
            this.dataGridViewManage.TabIndex = 40;
            this.dataGridViewManage.Visible = false;
            // 
            // deliveryClassBindingSource
            // 
            this.deliveryClassBindingSource.DataSource = typeof(Clothing_Store.classes.deliveryClass);
            // 
            // deliveryIdDataGridViewTextBoxColumn
            // 
            this.deliveryIdDataGridViewTextBoxColumn.DataPropertyName = "Delivery_Id";
            this.deliveryIdDataGridViewTextBoxColumn.HeaderText = "Delivery_Id";
            this.deliveryIdDataGridViewTextBoxColumn.Name = "deliveryIdDataGridViewTextBoxColumn";
            this.deliveryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "Customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "Customer_name";
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
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "order_Id";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "order_Id";
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
            // Pending
            // 
            this.Pending.HeaderText = "Pending";
            this.Pending.Name = "Pending";
            this.Pending.ReadOnly = true;
            // 
            // Intransit
            // 
            this.Intransit.HeaderText = "Intransit";
            this.Intransit.Name = "Intransit";
            this.Intransit.ReadOnly = true;
            // 
            // Delivered
            // 
            this.Delivered.HeaderText = "Delivered";
            this.Delivered.Name = "Delivered";
            this.Delivered.ReadOnly = true;
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
            // FrmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dataGridViewManage);
            this.Controls.Add(this.cbSortby);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDelivery";
            this.Text = "FrmDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryClassBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewManage;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.BindingSource deliveryClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pending;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Intransit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delivered;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}