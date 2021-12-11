using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinic
{
    public partial class patient_cont : UserControl
    {
        public patient_cont()
        {
            InitializeComponent();
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_patient_form add_Patient = new add_patient_form();
            add_Patient.ShowDialog();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            edit_patient_form edit_Patient = new edit_patient_form();
            edit_Patient.ShowDialog();
        }
    }
}
