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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.Fields_Worker fields = new DB_functions.Fields_Worker();

                fields.f1 = txtFIO.Text;
                DateTime time = DateTime.Parse(dtpYearsold.Value.ToString("dd.MM.yyyy"));
                fields.f2 = time;
                fields.f3 = int.Parse(txtWorkYears.Text);
                fields.f4 = txtTel.Text;
                fields.f5 = cmbFamily.Text;
                fields.f6 = txtHobbies.Text;
                fields.f7 = chbVeter.Checked;
                fields.f8 = chbOne.Checked;
                fields.f9 = chbDisability.Checked;
                fields.f10 = chbManychildren.Checked;
                fields.f11 = chbCar.Checked;
                fields.f12 = txtOthers.Text;

                fun.Save(fields);
                
                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
