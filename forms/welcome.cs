using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Autopark
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (login == "admin" && password == "admin")
            {
                this.DialogResult = DialogResult.OK; 
                this.Close();              
            }
            if (login == "user" && password == "user")
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

    }
}
