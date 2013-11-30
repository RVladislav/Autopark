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
            // TODO: This line of code loads data into the 'ds.All_drivers' table. You can move, or remove it, as needed.
            this.all_driversTableAdapter.Fill(this.ds.All_drivers);
            // TODO: This line of code loads data into the 'ds.All_drivers' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'ds.Track' table. You can move, or remove it, as needed.
            this.trackTableAdapter.Fill(this.ds.Track);
            txtNumber.Select();

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
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.Fields_Bus fields = new DB_functions.Fields_Bus();
                DB_functions.Link_BusTrack bt = new DB_functions.Link_BusTrack();

                fields.f1 = txtNumber.Text;
                fields.f2 = cmbMark.Text;
                fields.f3 = cbTour.Checked;
                fields.f4 = cbNew.Checked;
                fields.f5 = int.Parse(txtSits.Text);

                fun.Save(fields);

                bt.f1 = int.Parse(ds.Bus.Rows[ds.Bus.Rows.Count - 1][0].ToString());
                bt.f2 = int.Parse(cmbTrack.SelectedValue.ToString());

                fun.Save(bt);

                dsTableAdapters.BusTableAdapter taB = new dsTableAdapters.BusTableAdapter();
                dsTableAdapters.B_TTableAdapter taBT = new dsTableAdapters.B_TTableAdapter();
                taB.Update(ds.Bus);
                taBT.Update(ds._B_T);

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewTrack_Click(object sender, EventArgs e)
        {
            frmNewTrack frm = new frmNewTrack();
            frm.ShowDialog();
        }
    }
}