﻿using System;
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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Show();
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {
            panelFilter.Hide();
        }
    }
}
