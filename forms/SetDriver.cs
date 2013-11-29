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
    public partial class frmSetDriver : Form
    {
        public frmSetDriver()
        {
            InitializeComponent();
        }

        private void frmSetDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this.ds.Worker);
            // TODO: This line of code loads data into the 'ds.Bus' table. You can move, or remove it, as needed.
            this.busTableAdapter.Fill(this.ds.Bus);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.LinkDrtiverBus driver = new DB_functions.LinkDrtiverBus();

                driver.f1 = int.Parse(cmbDriver.SelectedValue.ToString());
                driver.f2 = int.Parse(cmbBus.SelectedValue.ToString());

                fun.Save(driver);

                dsTableAdapters.B_WTableAdapter taWV = new dsTableAdapters.B_WTableAdapter();
                taWV.Update(ds._B_W);

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
