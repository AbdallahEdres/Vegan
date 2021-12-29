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
            sessions_but.Checked = false;
            exam_but.Checked = false;

            //check selected button
            button.Checked = true;
        }

        void hid_controlers()
        {
            doctors_contr1.Hide();
            patient_cont1.Hide();
            attendance_cont1.Hide();
            exam_cont1.Hide();
            sessions_cont1.Hide();
            month_sced_cont1.Hide();
            home_cont1.Hide();
        }

        #endregion

        
        #region buttons 
        public main_form()
        {
            InitializeComponent();
            hid_controlers();
            home_cont1.Show();
            butt_select(home_but);

        }

        private void reports_but_Click(object sender, EventArgs e)
        {
            butt_select(reports_but);
        }


        private void scedual_but_Click(object sender, EventArgs e)
        {
            butt_select(scedual_but);
            hid_controlers();
            month_sced_cont1.Show();
        }

        private void doctors_but_Click(object sender, EventArgs e)
        {
            butt_select(doctors_but);
            hid_controlers();
            doctors_contr1.Show();
        }

        private void sessions_but_Click(object sender, EventArgs e)
        {
            butt_select(sessions_but);
            hid_controlers();
            sessions_cont1.Show();
        }

        private void exam_but_Click(object sender, EventArgs e)
        {
            butt_select(exam_but);
            hid_controlers();
            exam_cont1.Show();
        }

        private void patient_but_Click(object sender, EventArgs e)
        {
            butt_select(patient_but);
            hid_controlers();
            patient_cont1.Show();
        }

        private void home_but_Click(object sender, EventArgs e)
        {
            butt_select(home_but);
            hid_controlers();
            home_cont1.Show();
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        #endregion

     
    }
}
