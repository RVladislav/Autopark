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
    public partial class frmNewService : Form
    {
        DB_functions autopark = new DB_functions();
        public frmNewService()
        {
            InitializeComponent();
        }

        private void frmNewService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.ds.Bus);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

     
    }
}
