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
    public partial class frmNewBus : Form
    {
        public frmNewBus()
        {
            InitializeComponent();
        }

        private void frmNewBus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.ds.Bus);
            // TODO: This line of code loads data into the 'ds.Track' table. You can move, or remove it, as needed.
            this.trackTableAdapter.Fill(this.ds.Track);
            // TODO: This line of code loads data into the 'ds.All_drivers' table. You can move, or remove it, as needed.
            this.all_driversTableAdapter.Fill(this.ds.All_drivers);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNewWorker frm = new frmNewWorker();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewService frm = new frmNewService();
            frm.ShowDialog();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DB_functions fun = new DB_functions();
            //DB_functions.Fields_Bus f = new DB_functions.Fields_Bus();

            //f.f1 = txtNumber.Text;
            //f.f2 = cmbMark.Text;
            //f.f3 = cbTour.Checked;
            //f.f4 = cbNew.Checked;
            //f.f5 = int.Parse(txtSits.Text);

            //fun.Save(f);
        }

        private void btnNewTrack_Click(object sender, EventArgs e)
        {
            frmNewTrack frm = new frmNewTrack();
            frm.ShowDialog();
        }

   


    }
}
