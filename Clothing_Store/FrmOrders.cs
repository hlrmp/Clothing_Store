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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();

            var editColumn = new DataGridViewButtonColumn
            {
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "Edit",
                DataPropertyName = "Edit"


            };
            dataGridView1.Columns.Add(editColumn);

        }
        FrmAddOrders fao = new FrmAddOrders();
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            fao.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

         

           

            //DataGridViewButtonColumn EditColumn = new DataGridViewButtonColumn();
            //EditColumn.Text = "Edit";
            //EditColumn.Name = "Edit";
            //EditColumn.DataPropertyName = "Edit";
            //dataGridView1.Columns.Add(EditColumn);
            //DataGridViewButtonColumn DelColumn = new DataGridViewButtonColumn();
            //DelColumn.Text = "Delete";
            //DelColumn.Name = "Delete";
            //DelColumn.DataPropertyName = "Delete";
            //dataGridView1.Columns.Add(DelColumn);




            //DataTable dt = new DataTable();

            //dt.Columns.Add(new DataColumn("Edit", typeof(System.Windows.Forms.Button)));

            //dataGridView1.DataSource = dt;
        }
       

    } // class end 
} // name space end
