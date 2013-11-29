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
    public partial class frmNewService : Form
    {
        public frmNewService()
        {
            InitializeComponent();
        }

        private void frmNewService_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.ds.Bus);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.Fields_Service fields = new DB_functions.Fields_Service();

                fields.f0 = int.Parse(cmbBus.SelectedValue.ToString());
                fields.f1 = txtDescription.Text;
                fields.f2 = cmbWhells.Checked;
                fields.f3 = cmbControl.Checked;
                fields.f4 = cmbStop.Checked;
                fields.f5 = cmbMotor.Checked;
                fields.f6 = cmbExterier.Checked;
                fields.f7 = cmbInterier.Checked;
                fields.f8 = cmbRust.Checked;
                fields.f9 = int.Parse(txtSpeed.Text);
                DateTime time = DateTime.Parse(dtpCreate.Value.ToString("dd.MM.yyyy"));
                fields.f10 = time;
                fields.f11 = cmbDone.Checked;

                fun.Save(fields);

                dsTableAdapters.ServiceTableAdapter taS = new dsTableAdapters.ServiceTableAdapter();
                taS.Update(ds.Service);

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


     
    }
}
