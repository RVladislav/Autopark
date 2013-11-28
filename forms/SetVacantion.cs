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
    public partial class frmSetVacantion : Form
    {
        public frmSetVacantion()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DB_functions fun = new DB_functions();
            //    DB_functions.LinkVacantion lv=new DB_functions.LinkVacantion();

            //    lv.f1 = int.Parse(cmbWorker.SelectedValue.ToString());
            //    lv.f2 = int.Parse(cmbVacantions.SelectedValue.ToString());

            //    fun.Save(lv);

            //    this.Close();
            //}
            //catch (Exception E)
            //{
            //    MessageBox.Show("Ошибка чтения/записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void frmSetVacantion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Vacation' table. You can move, or remove it, as needed.
            this.vacationTableAdapter.Fill(this.ds.Vacation);
            // TODO: This line of code loads data into the 'ds.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.ds.Worker);

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DB_functions fun = new DB_functions();
            //    DB_functions.LinkVacantion lv = new DB_functions.LinkVacantion();

            //    lv.f1 = int.Parse(cmbWorker.SelectedValue.ToString());
            //    lv.f2 = int.Parse(cmbVacantions.SelectedValue.ToString());

            //    fun.Save(lv);

            //    this.Close();
            //}
            //catch (Exception E)
            //{
            //    MessageBox.Show("Ошибка чтения/записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
