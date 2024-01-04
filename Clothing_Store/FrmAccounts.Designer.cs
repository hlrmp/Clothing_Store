namespace Clothing_Store
{
    partial class FrmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccounts));
            this.sidepanelAdmin = new System.Windows.Forms.Panel();
            this.btnArchives = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.btnActivitylog = new System.Windows.Forms.Button();
            this.btnUserStaffs = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnHomeAccounts = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewStaff = new System.Windows.Forms.Button();
            this.dataGridViewStaffs = new System.Windows.Forms.DataGridView();
            this.Staff_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelStafAndUser = new System.Windows.Forms.Panel();
            this.btnStaffs = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.sidepanelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffs)).BeginInit();
            this.PanelStafAndUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanelAdmin
            // 
            this.sidepanelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidepanelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.sidepanelAdmin.Controls.Add(this.btnArchives);
            this.sidepanelAdmin.Controls.Add(this.btnRecovery);
            this.sidepanelAdmin.Controls.Add(this.btnActivitylog);
            this.sidepanelAdmin.Controls.Add(this.btnUserStaffs);
            this.sidepanelAdmin.Controls.Add(this.btnCreate);
            this.sidepanelAdmin.Controls.Add(this.btnHomeAccounts);
            this.sidepanelAdmin.Location = new System.Drawing.Point(12, 81);
            this.sidepanelAdmin.Name = "sidepanelAdmin";
            this.sidepanelAdmin.Size = new System.Drawing.Size(120, 431);
            this.sidepanelAdmin.TabIndex = 6;
            // 
            // btnArchives
            // 
            this.btnArchives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnArchives.FlatAppearance.BorderSize = 0;
            this.btnArchives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArchives.Location = new System.Drawing.Point(3, 348);
            this.btnArchives.Name = "btnArchives";
            this.btnArchives.Size = new System.Drawing.Size(114, 63);
            this.btnArchives.TabIndex = 14;
            this.btnArchives.Text = "Archives Collection";
            this.btnArchives.UseVisualStyleBackColor = false;
            this.btnArchives.Click += new System.EventHandler(this.btnArchives_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnRecovery.FlatAppearance.BorderSize = 0;
            this.btnRecovery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecovery.Location = new System.Drawing.Point(3, 279);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(114, 63);
            this.btnRecovery.TabIndex = 12;
            this.btnRecovery.Text = "Backup and Recovery";
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnActivitylog
            // 
            this.btnActivitylog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnActivitylog.FlatAppearance.BorderSize = 0;
            this.btnActivitylog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActivitylog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivitylog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitylog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActivitylog.Location = new System.Drawing.Point(3, 210);
            this.btnActivitylog.Name = "btnActivitylog";
            this.btnActivitylog.Size = new System.Drawing.Size(114, 63);
            this.btnActivitylog.TabIndex = 10;
            this.btnActivitylog.Text = "Activity log\r\n";
            this.btnActivitylog.UseVisualStyleBackColor = false;
            this.btnActivitylog.Click += new System.EventHandler(this.btnActivitylog_Click);
            // 
            // btnUserStaffs
            // 
            this.btnUserStaffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnUserStaffs.FlatAppearance.BorderSize = 0;
            this.btnUserStaffs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUserStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserStaffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserStaffs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserStaffs.Location = new System.Drawing.Point(3, 141);
            this.btnUserStaffs.Name = "btnUserStaffs";
            this.btnUserStaffs.Size = new System.Drawing.Size(114, 63);
            this.btnUserStaffs.TabIndex = 9;
            this.btnUserStaffs.Text = "Staffs and Users";
            this.btnUserStaffs.UseVisualStyleBackColor = false;
            this.btnUserStaffs.Click += new System.EventHandler(this.btnUserStaffs_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(3, 72);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 63);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Add new";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnHomeAccounts
            // 
            this.btnHomeAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnHomeAccounts.FlatAppearance.BorderSize = 0;
            this.btnHomeAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHomeAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeAccounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHomeAccounts.ImageKey = "(none)";
            this.btnHomeAccounts.Location = new System.Drawing.Point(3, 3);
            this.btnHomeAccounts.Name = "btnHomeAccounts";
            this.btnHomeAccounts.Size = new System.Drawing.Size(114, 63);
            this.btnHomeAccounts.TabIndex = 13;
            this.btnHomeAccounts.Text = "Home";
            this.btnHomeAccounts.UseVisualStyleBackColor = false;
            this.btnHomeAccounts.Click += new System.EventHandler(this.btnHomeAccounts_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 39);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Accounts Settings ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 428);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.panelAdd.Controls.Add(this.button1);
            this.panelAdd.Controls.Add(this.btnAddNewStaff);
            this.panelAdd.Location = new System.Drawing.Point(138, 134);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(185, 107);
            this.panelAdd.TabIndex = 0;
            this.panelAdd.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 53);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add New Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewStaff
            // 
            this.btnAddNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnAddNewStaff.FlatAppearance.BorderSize = 0;
            this.btnAddNewStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewStaff.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewStaff.Name = "btnAddNewStaff";
            this.btnAddNewStaff.Size = new System.Drawing.Size(179, 45);
            this.btnAddNewStaff.TabIndex = 33;
            this.btnAddNewStaff.Text = "Add New Staff";
            this.btnAddNewStaff.UseVisualStyleBackColor = false;
            this.btnAddNewStaff.Click += new System.EventHandler(this.btnAddNewStaff_Click);
            // 
            // dataGridViewStaffs
            // 
            this.dataGridViewStaffs.AllowUserToAddRows = false;
            this.dataGridViewStaffs.AllowUserToDeleteRows = false;
            this.dataGridViewStaffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStaffs.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staff_Id,
            this.First_Name,
            this.Last_Name,
            this.Contact_No,
            this.Email,
            this.Address,
            this.Position,
            this.Edit,
            this.Delete});
            this.dataGridViewStaffs.Location = new System.Drawing.Point(138, 84);
            this.dataGridViewStaffs.Name = "dataGridViewStaffs";
            this.dataGridViewStaffs.ReadOnly = true;
            this.dataGridViewStaffs.Size = new System.Drawing.Size(617, 428);
            this.dataGridViewStaffs.TabIndex = 65;
            this.dataGridViewStaffs.Visible = false;
            this.dataGridViewStaffs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffs_CellContentClick);
            // 
            // Staff_Id
            // 
            this.Staff_Id.DataPropertyName = "Staff_Id";
            this.Staff_Id.HeaderText = "#";
            this.Staff_Id.Name = "Staff_Id";
            this.Staff_Id.ReadOnly = true;
            // 
            // First_Name
            // 
            this.First_Name.DataPropertyName = "First_Name";
            this.First_Name.HeaderText = "First Name";
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            // 
            // Last_Name
            // 
            this.Last_Name.DataPropertyName = "Last_Name";
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            // 
            // Contact_No
            // 
            this.Contact_No.DataPropertyName = "Contact_No";
            this.Contact_No.HeaderText = "Contact no";
            this.Contact_No.Name = "Contact_No";
            this.Contact_No.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 30;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::Clothing_Store.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 30;
            // 
            // PanelStafAndUser
            // 
            this.PanelStafAndUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.PanelStafAndUser.Controls.Add(this.btnStaffs);
            this.PanelStafAndUser.Controls.Add(this.btnUsers);
            this.PanelStafAndUser.Location = new System.Drawing.Point(138, 237);
            this.PanelStafAndUser.Name = "PanelStafAndUser";
            this.PanelStafAndUser.Size = new System.Drawing.Size(185, 107);
            this.PanelStafAndUser.TabIndex = 35;
            this.PanelStafAndUser.Visible = false;
            // 
            // btnStaffs
            // 
            this.btnStaffs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnStaffs.FlatAppearance.BorderSize = 0;
            this.btnStaffs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStaffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaffs.Location = new System.Drawing.Point(3, 54);
            this.btnStaffs.Name = "btnStaffs";
            this.btnStaffs.Size = new System.Drawing.Size(179, 53);
            this.btnStaffs.TabIndex = 34;
            this.btnStaffs.Text = "Manage Staffs";
            this.btnStaffs.UseVisualStyleBackColor = false;
            this.btnStaffs.Click += new System.EventHandler(this.btnStaffs_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(179, 45);
            this.btnUsers.TabIndex = 33;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(138, 84);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.Size = new System.Drawing.Size(617, 428);
            this.dataGridViewHome.TabIndex = 66;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.BackColor = System.Drawing.Color.White;
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(682, 40);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(74, 21);
            this.cbFilter.TabIndex = 51;
            this.cbFilter.Text = "Filter";
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblsearch.Location = new System.Drawing.Point(644, 43);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 50;
            this.lblsearch.Text = "Search";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(442, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.PanelStafAndUser);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.sidepanelAdmin);
            this.Controls.Add(this.dataGridViewStaffs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAccounts";
            this.Text = "FrmAccounts";
            this.Load += new System.EventHandler(this.FrmAccounts_Load);
            this.sidepanelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffs)).EndInit();
            this.PanelStafAndUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanelAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHomeAccounts;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Button btnActivitylog;
        private System.Windows.Forms.Button btnUserStaffs;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNewStaff;
        private System.Windows.Forms.Button btnArchives;
        private System.Windows.Forms.DataGridView dataGridViewStaffs;
        private System.Windows.Forms.Panel PanelStafAndUser;
        private System.Windows.Forms.Button btnStaffs;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}