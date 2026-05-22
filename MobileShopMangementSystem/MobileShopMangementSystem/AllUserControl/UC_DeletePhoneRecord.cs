using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopMangementSystem.AllUserControl
{
    public partial class UC_DeletePhoneRecord : UserControl
    {
        function fn = new function();
        String query;
        public UC_DeletePhoneRecord()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobile";
            DataSet ds = fn.GetData(query);
            DataGridView12.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where cname like '" + txtSearch.Text + "%' or mname like '" + txtSearch.Text + "%'";
            DataSet ds = fn.GetData(query);
            DataGridView12.DataSource = ds.Tables[0];
        }
        int bid;
        private void DataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView12.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DataGridView12.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from newMobile where mid = "+bid+"";
            if(MessageBox.Show("Deleting Record of" + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.SetData(query);
            }
            else
            {
                MessageBox.Show("You Cancellecd the Opeataion", "BACK <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
