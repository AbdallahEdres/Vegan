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
    public partial class edit_patient_form : Form
    {
        public edit_patient_form()
        {
            InitializeComponent();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
