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





        private void dgvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvMain.Columns[0].Visible = false;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome frm = new frmWelcome();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) toolAdmin.Visible = true;
            if (frm.DialogResult == DialogResult.Cancel) toolbtnEdit.Visible = false;
        }

        private void автобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.BusTableAdapter ta = new dsTableAdapters.BusTableAdapter();
            ta.Fill(ds.Bus);
            frm.dgvAdmin.DataSource = ds.Bus;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds.Bus);
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.WorkerTableAdapter ta = new dsTableAdapters.WorkerTableAdapter();
            ta.Fill(ds.Worker);
            frm.dgvAdmin.DataSource = ds.Worker;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds.Worker);
        }


        private void label4_Click(object sender, EventArgs e)
        {
            dsTableAdapters.Bus_TrackTableAdapter t = new dsTableAdapters.Bus_TrackTableAdapter();
            t.Fill(ds._Bus_Track);
            dgvMain.DataSource = ds._Bus_Track;
            dgvMain.Update();
        }


        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.VacationTableAdapter ta = new dsTableAdapters.VacationTableAdapter();
            ta.Fill(ds.Vacation);
            frm.dgvAdmin.DataSource = ds.Vacation;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds.Vacation);
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.TrackTableAdapter ta = new dsTableAdapters.TrackTableAdapter();
            ta.Fill(ds.Track);
            frm.dgvAdmin.DataSource = ds.Track;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds.Track);
        }

        private void тОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.ServiceTableAdapter ta = new dsTableAdapters.ServiceTableAdapter();
            ta.Fill(ds.Service);
            frm.dgvAdmin.DataSource = ds.Service;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds.Service);
        }

        private void автобусыМаршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.B_TTableAdapter ta = new dsTableAdapters.B_TTableAdapter();
            ta.Fill(ds._B_T);
            frm.dgvAdmin.DataSource = ds._B_T;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds._B_T);
        }

        private void работникиАвтобусыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.B_WTableAdapter ta = new dsTableAdapters.B_WTableAdapter();
            ta.Fill(ds._B_W);
            frm.dgvAdmin.DataSource = ds._B_W;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds._B_W);
        }

        private void работникиВакансииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            dsTableAdapters.V_WTableAdapter ta = new dsTableAdapters.V_WTableAdapter();
            ta.Fill(ds._V_W);
            frm.dgvAdmin.DataSource = ds._V_W;
            frm.dgvAdmin.Update();
            frm.ShowDialog();

            ta.Update(ds._V_W);
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



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolAdmin.Visible == true)
                MessageBox.Show("Режим администратора выключен", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDescription frm = new frmDescription();
            frm.ShowDialog();
        }



        private void btnBus_Click(object sender, EventArgs e)
        {
            dsTableAdapters.BusTableAdapter taBus = new dsTableAdapters.BusTableAdapter();
            taBus.Fill(ds.Bus);
            dgvMain.DataSource = ds.Bus;

            dgvMain.Columns[1].HeaderText = "Номер";
            dgvMain.Columns[2].HeaderText = "Марка";
            dgvMain.Columns[3].HeaderText = "Экскурсионный";
            dgvMain.Columns[4].HeaderText = "Новый";
            dgvMain.Columns[5].HeaderText = "Кол-во мест";

            dgvMain.Update();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            dsTableAdapters.WorkerTableAdapter taWorker = new dsTableAdapters.WorkerTableAdapter();
            taWorker.Fill(ds.Worker);
            dgvMain.DataSource = ds.Worker;

            dgvMain.Columns[1].HeaderText = "ФИО";
            dgvMain.Columns[2].HeaderText = "Возраст";
            dgvMain.Columns[3].HeaderText = "Стаж";
            dgvMain.Columns[4].HeaderText = "Телефон";
            dgvMain.Columns[5].HeaderText = "Семья";
            dgvMain.Columns[6].HeaderText = "Хобби";
            dgvMain.Columns[7].HeaderText = "Ветеран";
            dgvMain.Columns[8].HeaderText = "Сирота";
            dgvMain.Columns[9].HeaderText = "Инвалид";
            dgvMain.Columns[10].HeaderText = "Многодетная семья";
            dgvMain.Columns[11].HeaderText = "Машина";
            dgvMain.Columns[12].HeaderText = "Примечания";

            dgvMain.Update();
        }

        private void btnVacations_Click(object sender, EventArgs e)
        {
            dsTableAdapters.VacationTableAdapter taVacation = new dsTableAdapters.VacationTableAdapter();
            taVacation.Fill(ds.Vacation);
            dgvMain.DataSource = ds.Vacation;

            dgvMain.Columns[1].HeaderText = "Название";
            dgvMain.Columns[2].HeaderText = "Описание";
            dgvMain.Columns[3].HeaderText = "Требования";
            dgvMain.Columns[4].HeaderText = "Подробное описание";
            dgvMain.Columns[5].HeaderText = "Минимальная з/п";
            dgvMain.Columns[6].HeaderText = "В офисе";

            dgvMain.Update();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            dsTableAdapters.TrackTableAdapter taTrack = new dsTableAdapters.TrackTableAdapter();
            taTrack.Fill(ds.Track);
            dgvMain.DataSource = ds.Track;

            dgvMain.Columns[1].HeaderText = "Название";
            dgvMain.Columns[2].HeaderText = "Остановки";
            dgvMain.Columns[3].HeaderText = "Время в пути";
            dgvMain.Columns[4].HeaderText = "По городу";
            dgvMain.Columns[5].HeaderText = "Дата создания";
            dgvMain.Columns[6].HeaderText = "Одобрен";

            dgvMain.Update();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            dsTableAdapters.All_driversTableAdapter t = new dsTableAdapters.All_driversTableAdapter();
            t.Fill(ds.All_drivers);
            dgvMain.DataSource = ds.All_drivers;

            dgvMain.Columns[1].HeaderText = "ФИО";
            dgvMain.Columns[2].HeaderText = "Номер автобуса";
            dgvMain.Columns[3].HeaderText = "Марка";

            dgvMain.Update();
        }

        private void btnOntheTrack_Click(object sender, EventArgs e)
        {
            dsTableAdapters.Bus_TrackTableAdapter t = new dsTableAdapters.Bus_TrackTableAdapter();
            t.Fill(ds._Bus_Track);
            dgvMain.DataSource = ds._Bus_Track;

            dgvMain.Columns[1].HeaderText = "Номер";
            dgvMain.Columns[2].HeaderText = "Марка";
            dgvMain.Columns[3].HeaderText = "Название маршрута";
            dgvMain.Columns[4].HeaderText = "Остановки";
            dgvMain.Columns[5].HeaderText = "Время в пути";

            dgvMain.Update();
        }

        private void btnVacationTrue_Click(object sender, EventArgs e)
        {
            dsTableAdapters.All_workersTableAdapter t = new dsTableAdapters.All_workersTableAdapter();
            t.Fill(ds.All_workers);
            dgvMain.DataSource = ds.All_workers;

            dgvMain.Columns[1].HeaderText = "ФИО";
            dgvMain.Columns[2].HeaderText = "Возраст";
            dgvMain.Columns[3].HeaderText = "Должность";
            dgvMain.Columns[4].HeaderText = "Описание";
            dgvMain.Columns[5].HeaderText = "Телефон";

            dgvMain.Update();
        }

        private void btnBusAccess_Click(object sender, EventArgs e)
        {
            dsTableAdapters.Bus_ServiceTableAdapter t = new dsTableAdapters.Bus_ServiceTableAdapter();
            t.Fill(ds._Bus_Service);
            dgvMain.DataSource = ds._Bus_Service;

            dgvMain.Columns[1].HeaderText = "Номер";
            dgvMain.Columns[2].HeaderText = "Марка";
            dgvMain.Columns[3].HeaderText = "Описание";
            dgvMain.Columns[4].HeaderText = "Колёса";
            dgvMain.Columns[5].HeaderText = "Управление";
            dgvMain.Columns[6].HeaderText = "Тормоза";
            dgvMain.Columns[7].HeaderText = "Двигатель";
            dgvMain.Columns[8].HeaderText = "Экстерьер";
            dgvMain.Columns[9].HeaderText = "Интерьер";
            dgvMain.Columns[10].HeaderText = "Ржавчина";
            dgvMain.Columns[11].HeaderText = "Max скорость";
            dgvMain.Columns[12].HeaderText = "Дата создания";
            dgvMain.Columns[13].HeaderText = "Допущен";

            dgvMain.Update();
        }

        private void btnTO_Click(object sender, EventArgs e)
        {
            dsTableAdapters.ServiceTableAdapter ta = new dsTableAdapters.ServiceTableAdapter();
            ta.Fill(ds.Service);
            dgvMain.DataSource = ds.Service;

            dgvMain.Columns[1].HeaderText = "Описание";
            dgvMain.Columns[2].HeaderText = "Колёса";
            dgvMain.Columns[3].HeaderText = "Управление";
            dgvMain.Columns[4].HeaderText = "Тормоза";
            dgvMain.Columns[5].HeaderText = "Двигатель";
            dgvMain.Columns[6].HeaderText = "Экстерьер";
            dgvMain.Columns[7].HeaderText = "Интерьер";
            dgvMain.Columns[8].HeaderText = "Ржавчина";
            dgvMain.Columns[9].HeaderText = "Max скорость";
            dgvMain.Columns[10].HeaderText = "Дата создания";
            dgvMain.Columns[11].HeaderText = "Допущен";

            dgvMain.Update();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
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

        private void txtFind_Click(object sender, EventArgs e)
        {
            txtFind.Text = "";
        }

        private void btnTrackAccess_Click(object sender, EventArgs e)
        {
            dsTableAdapters.AllTrackDoneTableAdapter ta = new dsTableAdapters.AllTrackDoneTableAdapter();
            ta.Fill(ds.AllTrackDone);
            dgvMain.DataSource = ds.AllTrackDone;

            dgvMain.Columns[1].HeaderText = "Описание";
            dgvMain.Columns[2].HeaderText = "Остановки";
            dgvMain.Columns[3].HeaderText = "Время в пути";
            dgvMain.Columns[4].HeaderText = "По городу";
            dgvMain.Columns[5].HeaderText = "Дата создания";
            dgvMain.Columns[6].HeaderText = "Одобрено";

            dgvMain.Update();
        }


    }
}
