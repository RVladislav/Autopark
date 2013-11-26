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

       

    }
}
