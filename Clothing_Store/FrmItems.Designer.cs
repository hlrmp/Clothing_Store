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
            this.btnWomens = new System.Windows.Forms.Button();
            this.btnUnisex = new System.Windows.Forms.Button();
            this.btnMens = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridItems)).BeginInit();
            this.sidepanelitems.SuspendLayout();
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
            this.txtSearch.Location = new System.Drawing.Point(482, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search ";
            // 
            // sidepanelitems
            // 
            this.sidepanelitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidepanelitems.BackColor = System.Drawing.Color.Teal;
            this.sidepanelitems.Controls.Add(this.btnWomens);
            this.sidepanelitems.Controls.Add(this.btnUnisex);
            this.sidepanelitems.Controls.Add(this.btnMens);
            this.sidepanelitems.Location = new System.Drawing.Point(12, 81);
            this.sidepanelitems.Name = "sidepanelitems";
            this.sidepanelitems.Size = new System.Drawing.Size(120, 431);
            this.sidepanelitems.TabIndex = 2;
            // 
            // btnWomens
            // 
            this.btnWomens.FlatAppearance.BorderSize = 0;
            this.btnWomens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWomens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWomens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWomens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWomens.Location = new System.Drawing.Point(3, 85);
            this.btnWomens.Name = "btnWomens";
            this.btnWomens.Size = new System.Drawing.Size(114, 63);
            this.btnWomens.TabIndex = 9;
            this.btnWomens.Text = "Womens";
            this.btnWomens.UseVisualStyleBackColor = true;
            // 
            // btnUnisex
            // 
            this.btnUnisex.FlatAppearance.BorderSize = 0;
            this.btnUnisex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUnisex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnisex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnisex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnisex.Location = new System.Drawing.Point(3, 163);
            this.btnUnisex.Name = "btnUnisex";
            this.btnUnisex.Size = new System.Drawing.Size(114, 63);
            this.btnUnisex.TabIndex = 8;
            this.btnUnisex.Text = "Unisex";
            this.btnUnisex.UseVisualStyleBackColor = true;
            // 
            // btnMens
            // 
            this.btnMens.FlatAppearance.BorderSize = 0;
            this.btnMens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMens.Location = new System.Drawing.Point(3, 16);
            this.btnMens.Name = "btnMens";
            this.btnMens.Size = new System.Drawing.Size(114, 63);
            this.btnMens.TabIndex = 7;
            this.btnMens.Text = "Mens";
            this.btnMens.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.Control;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(23, 54);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 24);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoScrollMinSize = new System.Drawing.Size(3, 3);
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.sidepanelitems);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.datagridItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItems";
            this.Text = "FrmItems";
            ((System.ComponentModel.ISupportInitialize)(this.datagridItems)).EndInit();
            this.sidepanelitems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel sidepanelitems;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnMens;
        private System.Windows.Forms.Button btnWomens;
        private System.Windows.Forms.Button btnUnisex;
    }
}