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
    public partial class frmNewTrack : Form
    {
        public frmNewTrack()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.Fields_Track fields = new DB_functions.Fields_Track();

                fields.f1 = txtDescription.Text;
                fields.f2 = txtStops.Text;
                fields.f3 = int.Parse(txtTime.Text);
                fields.f4 = chbCity.Checked;
                DateTime time = DateTime.Parse(dtpCreate.Value.ToString("dd.MM.yyyy"));
                fields.f5 = time;
                fields.f6 = chbDone.Checked;

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
