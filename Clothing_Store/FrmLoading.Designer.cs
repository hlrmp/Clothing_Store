namespace Clothing_Store
{
    partial class FrmLoading
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cp = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 235);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 38);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cp
            // 
            this.cp.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.cp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp.AnimationSpeed = 2000;
            this.cp.BackColor = System.Drawing.Color.Transparent;
            this.cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp.ForeColor = System.Drawing.Color.Black;
            this.cp.InnerColor = System.Drawing.Color.Transparent;
            this.cp.InnerMargin = 2;
            this.cp.InnerWidth = -1;
            this.cp.Location = new System.Drawing.Point(12, 30);
            this.cp.MarqueeAnimationSpeed = 1000;
            this.cp.Name = "cp";
            this.cp.OuterColor = System.Drawing.Color.LightSteelBlue;
            this.cp.OuterMargin = -25;
            this.cp.OuterWidth = 26;
            this.cp.ProgressColor = System.Drawing.Color.Blue;
            this.cp.ProgressWidth = 5;
            this.cp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cp.Size = new System.Drawing.Size(185, 174);
            this.cp.StartAngle = 270;
            this.cp.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cp.SubscriptText = "";
            this.cp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp.SuperscriptText = "";
            this.cp.TabIndex = 2;
            this.cp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cp.Value = 68;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "FrmLoading";
            this.Text = "FrmLoading";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar cp;
    }
}