using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class FrmLoading : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


    
        public FrmLoading()
        {
            InitializeComponent();

           // this.FormBorderStyle = FormBorderStyle.None;  
           Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            cp.Value = 0;
          
          
        }

        // boder color 
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Red, ButtonBorderStyle.Inset, );

        //}

        protected override void OnPaint(PaintEventArgs e)
        {
          //  base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                      Color.Red, 5, ButtonBorderStyle.Solid,
                                      Color.Red, 5, ButtonBorderStyle.Solid,
                                      Color.Red, 5, ButtonBorderStyle.Solid,
                                      Color.Red, 5, ButtonBorderStyle.Solid);
        }

        // Form_Loading load event
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }


        // timer event  for progress bar 
        private void timer1_Tick(object sender, EventArgs e)

            
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";

                cp.Value += 1;
                cp.Text = cp.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

            }
        }
    }
}
