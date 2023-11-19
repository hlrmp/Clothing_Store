namespace Clothing_Store
{
    partial class MainForm
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
            this.panel1buttonCollections = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panelLfs = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1buttonCollections.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1buttonCollections
            // 
            this.panel1buttonCollections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1buttonCollections.BackColor = System.Drawing.Color.Teal;
            this.panel1buttonCollections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1buttonCollections.Controls.Add(this.btnlogout);
            this.panel1buttonCollections.Controls.Add(this.btnAccount);
            this.panel1buttonCollections.Controls.Add(this.btnOrders);
            this.panel1buttonCollections.Controls.Add(this.btnCustomers);
            this.panel1buttonCollections.Controls.Add(this.btnStock);
            this.panel1buttonCollections.Controls.Add(this.btnproducts);
            this.panel1buttonCollections.Controls.Add(this.btnHome);
            this.panel1buttonCollections.Location = new System.Drawing.Point(-1, 87);
            this.panel1buttonCollections.Name = "panel1buttonCollections";
            this.panel1buttonCollections.Size = new System.Drawing.Size(1125, 84);
            this.panel1buttonCollections.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 3;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(0, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 85);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnproducts.BackColor = System.Drawing.Color.White;
            this.btnproducts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnproducts.FlatAppearance.BorderSize = 3;
            this.btnproducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnproducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Location = new System.Drawing.Point(198, -2);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(181, 85);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Text = "Products";
            this.btnproducts.UseVisualStyleBackColor = false;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnStock
            // 
            this.btnStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(385, -1);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(196, 85);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stocks";
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(587, -2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(125, 85);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrders.Location = new System.Drawing.Point(718, -1);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(166, 85);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders & Delivery";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccount.Location = new System.Drawing.Point(890, -2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(114, 85);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogout.Location = new System.Drawing.Point(1010, -2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(114, 85);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // panelLfs
            // 
            this.panelLfs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLfs.BackColor = System.Drawing.Color.Teal;
            this.panelLfs.Location = new System.Drawing.Point(2, 183);
            this.panelLfs.Name = "panelLfs";
            this.panelLfs.Size = new System.Drawing.Size(200, 473);
            this.panelLfs.TabIndex = 1;
            this.panelLfs.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(2, 183);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1126, 653);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelLfs);
            this.Controls.Add(this.panel1buttonCollections);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1buttonCollections.ResumeLayout(false);
            this.panel1buttonCollections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1buttonCollections;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panelLfs;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}