using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_NguyenQuangVinh
{
    public partial class Login : Form
    {
        IConfiguration configuration;
        public Login()
        {
            InitializeComponent();
            var path = Directory.GetCurrentDirectory();
            this.configuration =  new ConfigurationBuilder()
                    .SetBasePath(path)
                    .AddJsonFile("appsettings.json", true, true).Build();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string emailin = email.Text;
            string passwordin = password.Text;
            if(CheckAdminLogin(emailin, passwordin))
            {
                frmTT a = new frmTT();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }


        private bool CheckAdminLogin(string username, string password)
        { 
            var un = configuration["admin-account:username"];
            var pass = configuration["admin-account:password"];
            if (un.Equals(username) && pass.Equals(password)) return true;
            return false;
        }
    }
}
