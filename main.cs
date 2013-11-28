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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolbtnReport_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            frm.ShowDialog();
        }

        private void toolbtnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frm = new frmHelp();
            frm.ShowDialog();
        }

        private void toolbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolbtnNewBus_Click(object sender, EventArgs e)
        {
            frmNewBus frm = new frmNewBus();
            frm.ShowDialog();
        }


        private void новыйМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTrack frm = new frmNewTrack();
            frm.ShowDialog();
        }

        private void toolbtnWorker_Click(object sender, EventArgs e)
        {
            frmNewWorker frm = new frmNewWorker();
            frm.ShowDialog();
        }

        private void новоеСервисноеОбслуживаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewService frm = new frmNewService();
            frm.ShowDialog();
        }

        private void toolbtnVacation_Click(object sender, EventArgs e)
        {
            frmNewVacation frm = new frmNewVacation();
            frm.ShowDialog();
        }

        private void lblBus_Click(object sender, EventArgs e)
        {
            dsTableAdapters.BusTableAdapter taBus = new dsTableAdapters.BusTableAdapter();
            taBus.Fill(ds.Bus);
            dgvMain.DataSource = ds.Bus;
            dgvMain.Update();
        }


        private void lblWorker_Click(object sender, EventArgs e)
        {
            dsTableAdapters.WorkerTableAdapter taWorker = new dsTableAdapters.WorkerTableAdapter();
            taWorker.Fill(ds.Worker);
            dgvMain.DataSource = ds.Worker;
            dgvMain.Update();
        }

        private void lblVacation_Click(object sender, EventArgs e)
        {
            dsTableAdapters.VacationTableAdapter taVacation = new dsTableAdapters.VacationTableAdapter();
            taVacation.Fill(ds.Vacation);
            dgvMain.DataSource = ds.Vacation;
            dgvMain.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dsTableAdapters.TrackTableAdapter taTrack = new dsTableAdapters.TrackTableAdapter();
            taTrack.Fill(ds.Track);
            dgvMain.DataSource = ds.Track;
            dgvMain.Update();
        }


        private void dgvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMain.Columns[0].Visible = false;
        }


        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int countRows = dgvMain.Rows.Count;
                int countCells = dgvMain.Rows[0].Cells.Count - 1;
                for (int i = 0; i <= countRows - 1; i++)
                {
                    for (int j = 1; j <= countCells; j++)
                    {
                        
                        string findIt = txtFind.Text;
                        //int a = findIt.Count();
                        string find = dgvMain.Rows[i].Cells[j].Value.ToString();
                        //find = find.Remove(a, find.Count() - 1);
                        if (find == findIt)
                        {
                            dgvMain.ClearSelection();
                            dgvMain.Rows[i].Selected = true;
                        }
                    }
                }
            }
            catch (Exception E)
            {
            }
        }

   
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome frm = new frmWelcome();            
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) toolAdmin.Visible = true;
            if (frm.DialogResult == DialogResult.Cancel) Application.Exit();
        }

        private void автобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.BusTableAdapter ta = new dsTableAdapters.BusTableAdapter();
            ta.Fill(ds.Bus);
            frm.dgvAdmin.DataSource = ds.Bus;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void toolAdmin_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Режим администратора выключен", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolAdmin.Visible = false;
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.WorkerTableAdapter ta = new dsTableAdapters.WorkerTableAdapter();
            ta.Fill(ds.Worker);
            frm.dgvAdmin.DataSource = ds.Worker;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dsTableAdapters.All_driversTableAdapter t = new dsTableAdapters.All_driversTableAdapter();
            t.Fill(ds.All_drivers);
            dgvMain.DataSource = ds.All_drivers;
            dgvMain.Update();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            dsTableAdapters.Bus_TrackTableAdapter t = new dsTableAdapters.Bus_TrackTableAdapter();
            t.Fill(ds._Bus_Track);
            dgvMain.DataSource = ds._Bus_Track;
            dgvMain.Update();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            dsTableAdapters.Bus_ServiceTableAdapter t = new dsTableAdapters.Bus_ServiceTableAdapter();
            t.Fill(ds._Bus_Service);
            dgvMain.DataSource = ds._Bus_Service;
            dgvMain.Update();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin(); 
            dsTableAdapters.VacationTableAdapter t = new dsTableAdapters.VacationTableAdapter();
            t.Fill(ds.Vacation);
            frm.dgvAdmin.DataSource = ds.Vacation;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.TrackTableAdapter t = new dsTableAdapters.TrackTableAdapter();
            t.Fill(ds.Track);
            frm.dgvAdmin.DataSource = ds.Track;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void тОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.ServiceTableAdapter t = new dsTableAdapters.ServiceTableAdapter();
            t.Fill(ds.Service);
            frm.dgvAdmin.DataSource = ds.Service;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void автобусыМаршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.Bus_TrackTableAdapter t = new dsTableAdapters.Bus_TrackTableAdapter();
            t.Fill(ds._Bus_Track);
            frm.dgvAdmin.DataSource = ds._Bus_Track;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void работникиАвтобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.B_WTableAdapter t = new dsTableAdapters.B_WTableAdapter();
            t.Fill(ds._B_W);
            frm.dgvAdmin.DataSource = ds._B_W;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void работникиВакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.V_WTableAdapter t = new dsTableAdapters.V_WTableAdapter();
            t.Fill(ds._V_W);
            frm.dgvAdmin.DataSource = ds._V_W;
            frm.dgvAdmin.Update();
            frm.ShowDialog();
        }

        private void назначитьВодителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetDriver frm = new frmSetDriver();
            frm.ShowDialog();
        }

        private void назначитьНаДолжностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetVacantion frm = new frmSetVacantion();
            frm.ShowDialog();
        }
    }
}
