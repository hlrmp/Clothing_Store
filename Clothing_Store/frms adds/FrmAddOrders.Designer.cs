namespace Clothing_Store
{
    partial class FrmAddOrders
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(23, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 39);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Add New Order";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(30, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.Color.Teal;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(180, 353);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(114, 36);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(49, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(99, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(131, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Item :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(105, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(132, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Size :";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(182, 141);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 21);
            this.cbCategory.TabIndex = 26;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(182, 269);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(208, 21);
            this.cbSize.TabIndex = 27;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(182, 230);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(208, 20);
            this.numericQuantity.TabIndex = 29;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(182, 183);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(208, 21);
            this.cbItem.TabIndex = 30;
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(48, 53);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(227, 277);
            this.lbItems.TabIndex = 31;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(182, 309);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(208, 21);
            this.cbColor.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label6.Location = new System.Drawing.Point(132, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Color :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label7.Location = new System.Drawing.Point(32, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 39);
            this.label7.TabIndex = 34;
            this.label7.Text = "item list";
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(182, 107);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(208, 21);
            this.cbCustomerName.TabIndex = 35;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(128, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 36);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(41, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 331);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Cancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lbItems);
            this.panel2.Location = new System.Drawing.Point(454, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 414);
            this.panel2.TabIndex = 38;
            // 
            // FrmAddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 463);
            this.Controls.Add(this.cbCustomerName);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrders";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}