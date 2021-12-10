using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace MyClinic
{
    public partial class main_form : Form
    {
        // methods region
        #region methods
        // button select method
        private void butt_select(Guna2Button button)
        {
            // uncheck all other buttons
            home_but.Checked = false;
            patient_but.Checked = false;
            doctors_but.Checked = false;
            scedual_but.Checked = false;
            reports_but.Checked = false;
            attendance_but.Checked = false;
            sessions_but.Checked = false;
            exam_but.Checked = false;

            //check selected button
            button.Checked = true;
        }

        #endregion

        
        #region buttons 
        public main_form()
        {
            InitializeComponent();

        }

        private void reports_but_Click(object sender, EventArgs e)
        {
            butt_select(reports_but);
        }

        private void attendance_but_Click(object sender, EventArgs e)
        {
            butt_select(attendance_but);
        }

        private void scedual_but_Click(object sender, EventArgs e)
        {
            butt_select(scedual_but);
        }

        private void doctors_but_Click(object sender, EventArgs e)
        {
            butt_select(doctors_but);
        }

        private void sessions_but_Click(object sender, EventArgs e)
        {
            butt_select(sessions_but);
        }

        private void exam_but_Click(object sender, EventArgs e)
        {
            butt_select(exam_but);
        }

        private void patient_but_Click(object sender, EventArgs e)
        {
            butt_select(patient_but);
        }

        private void home_but_Click(object sender, EventArgs e)
        {
            butt_select(home_but);
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
        #endregion

       
    }
}
