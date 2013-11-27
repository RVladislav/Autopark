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
    public partial class frmNewWorker : Form
    {
        public frmNewWorker()
        {
            InitializeComponent();
        }

        private void frmNewWorker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Vacation' table. You can move, or remove it, as needed.
            this.vacationTableAdapter.Fill(this.ds.Vacation);

        }

        private void btnNewVacation_Click(object sender, EventArgs e)
        {
            frmNewVacation frm = new frmNewVacation();
            frm.ShowDialog();
        }
    }
}
