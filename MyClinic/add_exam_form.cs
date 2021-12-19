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
    public partial class add_exam_form : Form
    {
        // examination model implement
        exam_model_class exam_Model = new exam_model_class();

        // var declearation
        int ptnt_id=0;
        string[] type = { "تغذية", "علاج طبيعي" };

        // method to fill patient list
        void fill_patietns_list()
        {
            ptnt_list_grid.DataSource = exam_Model.get_ptnt_list(search_txt.Text);
            ptnt_list_grid.Columns[0].Visible = false;
            ptnt_list_grid.Columns[1].HeaderText = "الإسم";
            ptnt_list_grid.Columns[2].HeaderText = "الهاتف";
        }

        // method to fill types combo
        void fill_combo()
        {
            type_combo.Items.AddRange(type);
            am_pm_combo.SelectedIndex = 0;
            
        }
            // method to add new examination
        void add_exam()
        {
            string time = "",hr="",min="";
            min = min_num.Value.ToString();
            if (min.Length == 1)
            {
                min = "0" + min;
            }
           
            if (am_pm_combo.SelectedIndex == 0)
            {
                hr = (12 + hr_num.Value).ToString();
            }else if (am_pm_combo.SelectedIndex == 1)
            {
                hr = hr_num.Value.ToString();
            }
            if (hr.Length == 1)
            {
                hr = "0" + hr;
            }
            time = hr + ":" + min + ":00";
            if(exam_Model.check_date_time(exam_date.Value.ToString("yyyy-MM-dd"), time))
            {
                exam_Model.add_exam(ptnt_id, exam_date.Value, time, Convert.ToInt32(pay_num.Value), type[type_combo.SelectedIndex]);
                MessageBox.Show("تم!");
                this.Close();
            }
            else
            {
                MessageBox.Show("الموعد محجوز مسبقاً");
            }
        }

        public add_exam_form()
        {
            InitializeComponent();
            exam_date.MinDate = DateTime.Now;
            exam_date.Value = DateTime.Now;
            fill_combo();
            fill_patietns_list();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            if (ptnt_id > 0)
            {
                add_exam();
                
            }
            else
            {
                MessageBox.Show("اختر المريض");
            }
          
        }

        private void ptnt_list_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                name_txt.Text = ptnt_list_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                phone_txt.Text = ptnt_list_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                ptnt_id = Convert.ToInt32(ptnt_list_grid.Rows[e.RowIndex].Cells[0].Value);
            }

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_patietns_list();
        }
    }
}
