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
    public partial class exam_cont : UserControl
    {

        // implement examination model 
        exam_model_class exam_Model = new exam_model_class();

        // var declearation

        // method to define the filter condetion
        string define_cond()
        {
            string condetion = "";

            if (days_switch.Checked )
            {
                condetion += "and sess_date='" + DateTime.Now.ToString("yyyy-MM-dd")+"' ";
            }
            if (nutrition_radio.Checked)
            {
                condetion += "and exam_type=N'تغذية' ";
            }else if (physical_raadio.Checked)
            {
                condetion += "and exam_type=N'علاج طبيعي' ";
            }
            return condetion;
        }

        // method to fill examinations list 
        void fill_exam_list()
        {
            exam_grid.DataSource = exam_Model.get_exam(search_txt.Text, define_cond());
            exam_grid.Columns[0].HeaderText = "الإسم";
            exam_grid.Columns[0].ReadOnly = true;

            exam_grid.Columns[1].HeaderText = "الهاتف";
            exam_grid.Columns[1].ReadOnly = true;

            exam_grid.Columns[2].HeaderText = "تاريخ الجلسة";
            exam_grid.Columns[2].ReadOnly = true;

            exam_grid.Columns[3].HeaderText = "الساعة";
            exam_grid.Columns[3].ReadOnly = true;

            exam_grid.Columns[4].HeaderText = "نوع الكشف";
            exam_grid.Columns[4].ReadOnly = true;

            exam_grid.Columns[5].HeaderText = "المدفوع";
            exam_grid.Columns[5].ReadOnly = true;

            exam_grid.Columns[6].HeaderText = "حضر";

            exam_grid.Columns[7].Visible = false;

        }
        public exam_cont()
        {
            InitializeComponent();
            all_radio.Checked = true;
            fill_exam_list();
        }

       

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_exam_form add_Exam = new add_exam_form();
            add_Exam.ShowDialog();
            fill_exam_list();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_exam_list();
        }

        private void days_switch_CheckedChanged(object sender, EventArgs e)
        {
            fill_exam_list();
        }

        private void nutrition_radio_CheckedChanged(object sender, EventArgs e)
        {
            fill_exam_list();
        }
    }
}
