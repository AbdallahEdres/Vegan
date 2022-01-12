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
        int selected_row_index = -1;
        #region buttons
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

        private void prev_exam_but_Click(object sender, EventArgs e)
        {
            prev_exam_form prev_Exam_Form = new prev_exam_form();
            prev_Exam_Form.ShowDialog();
        }

       

        private void exam_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                DialogResult dialogResult = MessageBox.Show("في حالة التعديل لا يمكن العوده , هل انت متاكد؟", "هل تريد تعديل الحالة؟", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    exam_Model.edit_stat(exam_grid.Rows[e.RowIndex].Cells[2].Value.ToString(), exam_grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                fill_exam_list();
            }

        }

        private void exam_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==2&& e.RowIndex > -1)
            {
                string old_date = exam_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string time = exam_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult d = MessageBox.Show("هل تريد تغير تاريخ الكشف؟", "تحذير! ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    edit_date_form edit_Date = new edit_date_form(old_date,time);
                    edit_Date.ShowDialog();
                    fill_exam_list();
                }
            }else if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                string old_date = exam_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string time = exam_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                DialogResult d = MessageBox.Show("هل تريد تغير موعد الكشف؟", "تحذير! ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    edit_time_form edit_Time = new edit_time_form(time, old_date);
                    edit_Time.ShowDialog();
                    fill_exam_list();
                }
            }else if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                DialogResult d = MessageBox.Show("هل تريد تغير المبلغ؟", "تحذير! ", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    exam_pay_form exam_Pay = new exam_pay_form(Convert.ToInt32(exam_grid.Rows[e.RowIndex].Cells[7].Value),Convert.ToDateTime(exam_grid.Rows[e.RowIndex].Cells[2].Value));
                    exam_Pay.ShowDialog();
                    fill_exam_list();
                }
            }
        }

        private void delete_but_Click(object sender, EventArgs e)
        {
            if (selected_row_index > -1)
            {
                string date = Convert.ToString(exam_grid.Rows[selected_row_index].Cells[2].Value);
                string time = exam_grid.Rows[selected_row_index].Cells[3].Value.ToString();
                selected_row_index = -1;
                DialogResult d = MessageBox.Show("هل انت متاكد من حذف الموعد؟","رسالة تاكيد ",MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    exam_Model.delete_exam(date, time);
                    fill_exam_list();
                }
            }
            else
            {
                MessageBox.Show("لم يتم اختيار موعد");
            }
          
        }
        #endregion
        #region methods
        private void exam_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row_index = e.RowIndex;
        }
        // method to define the filter condetion
        string define_cond()
        {
            string condetion = "";

            if (days_switch.Checked)
            {
                condetion += "and sess_date='" + DateTime.Now.ToString("yyyy-MM-dd") + "' ";
            }
            if (nutrition_radio.Checked)
            {
                condetion += "and exam_type=N'تغذية' ";
            }
            else if (physical_raadio.Checked)
            {
                condetion += "and exam_type=N'علاج طبيعي' ";
            }
            return condetion;
        }

        // method to fill examinations list 
        void fill_exam_list()
        {
            exam_grid.DataSource = exam_Model.get_exam(search_txt.Text, define_cond(), 0);
            exam_grid.Columns[0].HeaderText = "الإسم";
            exam_grid.Columns[0].ReadOnly = true;

            exam_grid.Columns[1].HeaderText = "الهاتف";
            exam_grid.Columns[1].ReadOnly = true;

            exam_grid.Columns[2].HeaderText = "تاريخ الكشف";
            exam_grid.Columns[2].ReadOnly = true;
            exam_grid.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            exam_grid.Sort(exam_grid.Columns[2], ListSortDirection.Ascending);

            exam_grid.Columns[3].HeaderText = "الساعة";
            exam_grid.Columns[3].ReadOnly = true;

            exam_grid.Columns[4].HeaderText = "نوع الكشف";
            exam_grid.Columns[4].ReadOnly = true;

            exam_grid.Columns[5].HeaderText = "المدفوع";
            exam_grid.Columns[5].ReadOnly = true;

            exam_grid.Columns[6].HeaderText = "حضر";

            exam_grid.Columns[7].Visible = false;

        }

        public void refresh_exam()
        {
            fill_exam_list();
        }
        #endregion
    }
}
