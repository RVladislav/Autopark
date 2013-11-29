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
    public partial class frmNewVacation : Form
    {
        public frmNewVacation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB_functions fun = new DB_functions();
                DB_functions.Fields_Vacation fields = new DB_functions.Fields_Vacation();

                fields.f1 = txtName.Text;
                fields.f2 = txtDescription.Text;
                fields.f3 = txtDescriptionFull.Text;
                fields.f4 = txtRequriments.Text;
                fields.f5 = int.Parse(txtMoney.Text);
                fields.f6 = chbOffice.Checked;

                fun.Save(fields);

                dsTableAdapters.VacationTableAdapter taV = new dsTableAdapters.VacationTableAdapter();
                taV.Update(ds.Vacation);

                this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Невозможно сохранить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
