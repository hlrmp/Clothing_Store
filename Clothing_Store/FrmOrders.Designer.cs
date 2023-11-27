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
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sidepanelitems = new System.Windows.Forms.Panel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidepanelitems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsearch.Location = new System.Drawing.Point(705, 43);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 17;
            this.lblsearch.Text = "Search";
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(482, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 15;
            // 
            // sidepanelitems
            // 
            this.sidepanelitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidepanelitems.BackColor = System.Drawing.Color.Teal;
            this.sidepanelitems.Controls.Add(this.btnAddStock);
            this.sidepanelitems.Location = new System.Drawing.Point(12, 81);
            this.sidepanelitems.Name = "sidepanelitems";
            this.sidepanelitems.Size = new System.Drawing.Size(120, 431);
            this.sidepanelitems.TabIndex = 14;
            // 
            // btnAddStock
            // 
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStock.Location = new System.Drawing.Point(3, 3);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(114, 63);
            this.btnAddStock.TabIndex = 11;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 431);
            this.dataGridView1.TabIndex = 13;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sidepanelitems);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.sidepanelitems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel sidepanelitems;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}