using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MobileShopMangementSystem.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;

        public UC_Customer()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            SetComboBOX(query, txtCompany);
        }

        private void SetComboBOX(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.GetForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String cname = txtCompany.Text;
            query = "select mname from newMobile where cname ='" + cname + "'";
            SetComboBOX(query, txtModel);
        }

        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from newMobile where mname = '" + txtModel.Text + "'";
            DataSet ds = fn.GetData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtImei.Text != "")
            {
                try
                {
                    String name = txtName.Text;
                    String gender = txtGender.Text;
                    Int64 contact = Int64.Parse(txtContact.Text);
                    String email = txtEmail.Text;
                    String address = txtAddress.Text;
                    String company = txtCompany.Text;
                    String model = txtModel.Text;
                    String imei = txtImei.Text;

                    // Use parameterized query to prevent SQL injection
                    query = "INSERT INTO customerPurchase (cname, gender, contact, email, caddress, company, model, imei) " +
                            "VALUES (@Name, @Gender, @Contact, @Email, @Address, @Company, @Model, @Imei)";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Name", name),
                        new SqlParameter("@Gender", gender),
                        new SqlParameter("@Contact", contact),
                        new SqlParameter("@Email", email),
                        new SqlParameter("@Address", address),
                        new SqlParameter("@Company", company),
                        new SqlParameter("@Model", model),
                        new SqlParameter("@Imei", imei),
                    };

                    fn.SetData(query, parameters);

                    MessageBox.Show("Purchase recorded successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form fields
                    txtName.Clear();
                    txtGender.SelectedIndex = -1;
                    txtContact.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    txtImei.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fn.CloseConnection();  // Close the connection when done
                }
            }
            else
            {
                MessageBox.Show("Fill all the Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
