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
    public partial class UC_Login : UserControl
    {
        private Dictionary<string, string> validUserCredentials;

        public UC_Login()
        {
            InitializeComponent();
            ToShowlabel.Visible = false;
            InitializeUserCredentials();
        }

        private void InitializeUserCredentials()
        {
            validUserCredentials = new Dictionary<string, string>
            {
                {"rafi7814", "rafi"},
                {"shadman7814", "shadman"},
                {"rezaun7814", "rezaun"}
            };
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }

        int abc = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if (abc == 10)
            {
                abc = 0;

                string enteredUsername = guna2TextBox1.Text.Trim();
                string enteredPassword = txtPassword.Text.Trim();

                if (IsValidCredentials(enteredUsername, enteredPassword))
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    ToShowlabel.Visible = true;
                    timer1.Stop();
                }
            }
        }

        private bool IsValidCredentials(string username, string password)
        {
            return validUserCredentials.ContainsKey(username) && validUserCredentials[username] == password;
        }

        
    }
}
