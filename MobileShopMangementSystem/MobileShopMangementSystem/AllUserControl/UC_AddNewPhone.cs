using Microsoft.Data.SqlClient;
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
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();

        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {
                try
                {
                    String company = txtCompany.Text;
                    String model = txtModel.Text;
                    String ram = txtRam.Text;
                    String internalMemory = txtInternal.Text;
                    String expandable = txtExpandable.Text;
                    String display = txtDisplay.Text;
                    String rear = txtRear.Text;
                    String front = txtFront.Text;
                    String fingerprint = txtFingerprint.Text;
                    String sim = txtSim.Text;
                    String network = txtNetwork.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);

                    // Use parameterized query to prevent SQL injection
                    string query = "INSERT INTO newMobile (cname, mname, ram, internal, expandable, display, rear, front, finger, sim, network, price) " +
                                   "VALUES (@Company, @Model, @Ram, @InternalMemory, @Expandable, @Display, @Rear, @Front, @Fingerprint, @Sim, @Network, @Price)";

                    fn.SetData(query, new[]
                    {
                        new SqlParameter("@Company", company),
                        new SqlParameter("@Model", model),
                        new SqlParameter("@Ram", ram),
                        new SqlParameter("@InternalMemory", internalMemory),
                        new SqlParameter("@Expandable", expandable),
                        new SqlParameter("@Display", display),
                        new SqlParameter("@Rear", rear),
                        new SqlParameter("@Front", front),
                        new SqlParameter("@Fingerprint", fingerprint),
                        new SqlParameter("@Sim", sim),
                        new SqlParameter("@Network", network),
                        new SqlParameter("@Price", price),
                    });

                    MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.StartIndex = -1;
            txtInternal.StartIndex = -1;
            txtExpandable.StartIndex = -1;
            txtDisplay.StartIndex = -1;
            txtRear.StartIndex = -1;
            txtFront.StartIndex = -1;
            txtFingerprint.StartIndex = -1;
            txtSim.StartIndex = -1;
            txtNetwork.StartIndex = -1;
            txtPrice.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void UC_AddNewPhone_Load(object sender, EventArgs e)
        {
        }
    }
}