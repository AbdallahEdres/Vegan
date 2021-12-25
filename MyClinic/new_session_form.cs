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
    public partial class new_session_form : Form
    {
        // implement of sessions model
        sess_model_class sess_Model = new sess_model_class();

        //var declearation
        List<List<string>> dr_details = new List<List<string>>();
        // method to fill combo boxes 
        void fill_combo()
        {
            dr_details = sess_Model.get_dr_list();
            dr_combo.Items.AddRange(dr_details[1].ToArray());

        }
        // method to fill dr_appoint grid 
        void fill_dr_appoints()
        {
            if (dr_appoints_grid.ColumnCount < 3)
            {
                dr_appoints_grid.Columns.Add("day", "اليوم");
            }
            dr_appoints_grid.DataSource = sess_Model.get_dr_pre_appoints(dr_details[0][dr_combo.SelectedIndex]);
            dr_appoints_grid.Columns[1].HeaderText = "التاريخ";
            dr_appoints_grid.Columns[2].HeaderText = "الساعه";
            dr_appoints_grid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dr_appoints_grid.Sort(dr_appoints_grid.Columns[1], ListSortDirection.Ascending);
            for (int i = 0; i < dr_appoints_grid.RowCount; i++)
            {

                dr_appoints_grid.Rows[i].Cells[0].Value =convert_day_ar( Convert.ToDateTime(dr_appoints_grid.Rows[i].Cells[1].Value));
            }

        }

        // method to convert days to arabic
        string convert_day_ar(DateTime date)
        {
            string day = "";
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    day = "السبت";
                    break;
                case DayOfWeek.Sunday:
                    day = "الأحد";
                    break;
                case DayOfWeek.Monday:
                    day = "الإثنين";
                    break;
                case DayOfWeek.Tuesday:
                    day = "الثلاثاء";
                    break;
                case DayOfWeek.Wednesday:
                    day = "اللأربعاء";
                    break;
                case DayOfWeek.Thursday:
                    day = "الخميس";
                    break;
                case DayOfWeek.Friday:
                    day = "الجمعة";
                    break;
            }
            return day;
        }

        // method to insert sessions in data base 
        int insert_sessions()
        {
           return sess_Model.set_sessions(1,Convert.ToInt32( dr_details[0][dr_combo.SelectedIndex]), start_date_bick.Value, time_combo.SelectedItem.ToString(),Convert.ToInt32(pay_val_num.Value) , pay_combo.SelectedIndex, Convert.ToInt32(sessions_num.Value), Convert.ToInt32(wekly_sess_combo.SelectedItem));
        }
        public new_session_form()
        {
            InitializeComponent();
            fill_combo();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dr_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_dr_appoints();
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            if(insert_sessions() == -1)
            {
                MessageBox.Show("تم!");
                this.Close();
            }else if(insert_sessions() == 0)
            {
                MessageBox.Show("هذا الموعد مكتمل");
            }else if(insert_sessions() == 1)
            {
                MessageBox.Show("الطبيب المختار مشغل في هذا الموعد");
            }
           
        }

        private void dr_appoints_grid_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dr_appoints_grid.RowCount; i++)
            {

                dr_appoints_grid.Rows[i].Cells[0].Value = convert_day_ar(Convert.ToDateTime(dr_appoints_grid.Rows[i].Cells[1].Value));
            }
        }
    }
}
