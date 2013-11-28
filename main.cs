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
            frmReport frm = new frmReport();
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

        private void label2_Click(object sender, EventArgs e)
        {
            dsTableAdapters.ServiceTableAdapter taService = new dsTableAdapters.ServiceTableAdapter();
            taService.Fill(ds.Service);
            dgvMain.DataSource = ds.Service;
            dgvMain.Update();
        }

        private void dgvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMain.Columns[0].Visible = false;
        }

        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void правкаЭлементовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверить!!!
            if (dgvMain.ReadOnly == true)
            {
                dgvMain.ReadOnly = false;
                tooDGVEdit.Text = "♦ Правка элементов ♦";
            }
            else
            {
                dgvMain.ReadOnly = true;
                tooDGVEdit.Text = "Правка элементов";
            }

            dgvMain.Update();
        }
    }
}
