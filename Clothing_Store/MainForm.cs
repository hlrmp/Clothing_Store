using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
                btnHome.BackColor = Color.Salmon;
                btnproducts.BackColor = Color.White;
                btnStock.BackColor = Color.White;

            mainpanel.Hide();
            i.Hide();

            panelRSide.Show();
            monthCalendar1.Show();
          


        }

        FrmItems i = new FrmItems();
        private void btnproducts_Click(object sender, EventArgs e)
        {
            btnproducts.BackColor = Color.Salmon;
            btnHome.BackColor = Color.White;
            btnStock.BackColor = Color.White;



            mainpanel.Controls.Clear();
            i.FormBorderStyle = FormBorderStyle.None;
            i.TopLevel = false;
            i.AutoScroll = true;
            i.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(i);

            mainpanel.Show();
            i.Show();

            panelRSide.Hide();
            monthCalendar1.Hide();
          
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackColor = Color.Salmon;
            btnproducts.BackColor = Color.White;
            btnHome.BackColor = Color.White;
        }
    }
}
