namespace Clothing_Store
{
    partial class FrmItems
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
            this.datagridItems = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.sidepanelitems = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNumber = new System.Windows.Forms.Label();
            this.btnWomens = new System.Windows.Forms.Button();
            this.btnUnisex = new System.Windows.Forms.Button();
            this.btnMens = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridItems)).BeginInit();
            this.sidepanelitems.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridItems
            // 
            this.datagridItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridItems.Location = new System.Drawing.Point(138, 81);
            this.datagridItems.Name = "datagridItems";
            this.datagridItems.Size = new System.Drawing.Size(617, 431);
            this.datagridItems.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(438, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // sidepanelitems
            // 
            this.sidepanelitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidepanelitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.sidepanelitems.Controls.Add(this.btnHome);
            this.sidepanelitems.Controls.Add(this.panel1);
            this.sidepanelitems.Controls.Add(this.btnWomens);
            this.sidepanelitems.Controls.Add(this.btnUnisex);
            this.sidepanelitems.Controls.Add(this.btnMens);
            this.sidepanelitems.Location = new System.Drawing.Point(12, 81);
            this.sidepanelitems.Name = "sidepanelitems";
            this.sidepanelitems.Size = new System.Drawing.Size(120, 449);
            this.sidepanelitems.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 63);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTotalNumber);
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 74);
            this.panel1.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(4, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 18);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total :";
            // 
            // lblTotalNumber
            // 
            this.lblTotalNumber.AutoSize = true;
            this.lblTotalNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumber.ForeColor = System.Drawing.Color.White;
            this.lblTotalNumber.Location = new System.Drawing.Point(74, 20);
            this.lblTotalNumber.Name = "lblTotalNumber";
            this.lblTotalNumber.Size = new System.Drawing.Size(41, 18);
            this.lblTotalNumber.TabIndex = 11;
            this.lblTotalNumber.Text = "000";
            // 
            // btnWomens
            // 
            this.btnWomens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnWomens.FlatAppearance.BorderSize = 0;
            this.btnWomens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWomens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWomens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWomens.Location = new System.Drawing.Point(3, 141);
            this.btnWomens.Name = "btnWomens";
            this.btnWomens.Size = new System.Drawing.Size(114, 63);
            this.btnWomens.TabIndex = 9;
            this.btnWomens.Text = "Womens";
            this.btnWomens.UseVisualStyleBackColor = false;
            this.btnWomens.Click += new System.EventHandler(this.btnWomens_Click);
            // 
            // btnUnisex
            // 
            this.btnUnisex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnUnisex.FlatAppearance.BorderSize = 0;
            this.btnUnisex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUnisex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnisex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnisex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnisex.Location = new System.Drawing.Point(3, 210);
            this.btnUnisex.Name = "btnUnisex";
            this.btnUnisex.Size = new System.Drawing.Size(114, 63);
            this.btnUnisex.TabIndex = 8;
            this.btnUnisex.Text = "Unisex";
            this.btnUnisex.UseVisualStyleBackColor = false;
            this.btnUnisex.Click += new System.EventHandler(this.btnUnisex_Click);
            // 
            // btnMens
            // 
            this.btnMens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.btnMens.FlatAppearance.BorderSize = 0;
            this.btnMens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMens.Location = new System.Drawing.Point(3, 72);
            this.btnMens.Name = "btnMens";
            this.btnMens.Size = new System.Drawing.Size(114, 63);
            this.btnMens.TabIndex = 7;
            this.btnMens.Text = "Mens";
            this.btnMens.UseVisualStyleBackColor = false;
            this.btnMens.Click += new System.EventHandler(this.btnMens_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 39);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Category\r\n";
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblsearch.Location = new System.Drawing.Point(705, 43);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 11;
            this.lblsearch.Text = "Search";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(681, 40);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(74, 21);
            this.cbFilter.TabIndex = 19;
            this.cbFilter.Text = "Filter";
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.sidepanelitems);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.datagridItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItems";
            this.Text = "FrmItems";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridItems)).EndInit();
            this.sidepanelitems.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel sidepanelitems;
        private System.Windows.Forms.Button btnMens;
        private System.Windows.Forms.Button btnWomens;
        private System.Windows.Forms.Button btnUnisex;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}