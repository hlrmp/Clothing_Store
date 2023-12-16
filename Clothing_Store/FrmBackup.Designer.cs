namespace Clothing_Store
{
    partial class FrmBackup
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackup.BackColor = System.Drawing.Color.Teal;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackup.ImageKey = "(none)";
            this.btnBackup.Location = new System.Drawing.Point(246, 364);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(114, 45);
            this.btnBackup.TabIndex = 14;
            this.btnBackup.Text = "Back-up";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(567, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.lblTitle.Location = new System.Drawing.Point(34, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 39);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Backup Files";
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(81, 127);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(453, 225);
            this.lb2.TabIndex = 41;
            this.lb2.Visible = false;
            this.lb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseClick);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(81, 127);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(453, 225);
            this.lb1.TabIndex = 42;
            this.lb1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(25)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Backup list :";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "los";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label1;
    }
}