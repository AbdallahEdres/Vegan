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
    public partial class sessions_cont : UserControl
    {
        //sessions model implment
        sess_model_class sess_Model = new sess_model_class();
        //var decleartion
        int selected_ptnt_id = 1;


        public sessions_cont()
        {
            InitializeComponent();
            fill_ptnt_list();
        }
        #region buttons
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            pre_panel.Height =( dr_details_panel.Height / 2)-6;
            comming_panel.Location = new Point(0, (dr_details_panel.Height / 2) + 3);
            comming_panel.Height= (dr_details_panel.Height / 2) - 6;
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            if (selected_ptnt_id != -1)
            {
                new_session_form new_Session = new new_session_form(selected_ptnt_id);
                new_Session.ShowDialog();
                fill_comming();
                selected_ptnt_id = -1;
            }
            else
            {
                MessageBox.Show("اختر اسم الحاله");
            }
            
        }

        private void ptnt_list_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                selected_ptnt_id = Convert.ToInt32(ptnt_list_grid.Rows[e.RowIndex].Cells[0].Value);
                fill_comming();
                fill_prev();
            }
        }

        private void next_sess_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 4)
            {
                DialogResult d = MessageBox.Show("هل ترغب في التعديل على هذه الجلسه؟", "رسالة تاكيد", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    DateTime date = Convert.ToDateTime(next_sess_grid.Rows[e.RowIndex].Cells[1].Value);
                    string t = next_sess_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    edit_session_form edit_Session = new edit_session_form(date, t.ToString(), next_sess_grid.Rows[e.RowIndex].Cells[3].Value.ToString());
                    edit_Session.ShowDialog();
                    fill_comming();
                    fill_prev();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                sess_pay_form pay_Form = new sess_pay_form(next_sess_grid.Rows[e.RowIndex].Cells[1].Value.ToString(), next_sess_grid.Rows[e.RowIndex].Cells[2].Value.ToString(), Convert.ToInt32(next_sess_grid.Rows[e.RowIndex].Cells[6].Value));
                pay_Form.ShowDialog();
                fill_comming();
                fill_prev();
            }

        }        

        private void next_sess_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult d = MessageBox.Show("هل انت متأكد؟", "رسالة تأكيد", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    if (e.ColumnIndex == 4)
                    {
                        sess_Model.change_stat(next_sess_grid.Rows[e.RowIndex].Cells[1].Value.ToString(), next_sess_grid.Rows[e.RowIndex].Cells[2].Value.ToString(), Convert.ToInt32(next_sess_grid.Rows[e.RowIndex].Cells[6].Value));
                    }

                }
                fill_prev();
                fill_comming();
            }
                      
        }
        #endregion
        #region methods 

        //method to fill patients list 
        void fill_ptnt_list()
        {
            ptnt_list_grid.DataSource = sess_Model.get_ptnt_list(search_txt.Text);
            ptnt_list_grid.Columns[0].Visible = false;
            ptnt_list_grid.Columns[1].HeaderText = "الإسم";
            ptnt_list_grid.Columns[2].HeaderText = "الهاتف";
        }
        //method to fill patient's comming sessions
        void fill_comming()
        {
            if (next_sess_grid.ColumnCount < 6)
            {
                next_sess_grid.Columns.Add("day", "اليوم");
            }
            next_sess_grid.DataSource = sess_Model.get_comming(selected_ptnt_id);
            next_sess_grid.Columns[1].HeaderText = "التاريخ";
            next_sess_grid.Columns[1].ReadOnly = true;
            next_sess_grid.Columns[0].ReadOnly = true;
            next_sess_grid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            next_sess_grid.Sort(next_sess_grid.Columns[1], ListSortDirection.Ascending);

            next_sess_grid.Columns[2].HeaderText = "الساعه";
            next_sess_grid.Columns[2].ReadOnly = true;

            next_sess_grid.Columns[3].HeaderText = "الطبيب";
            next_sess_grid.Columns[3].ReadOnly = true;

            next_sess_grid.Columns[4].HeaderText = "حضر";
            next_sess_grid.Columns[4].ReadOnly = false;

            next_sess_grid.Columns[5].HeaderText = "المدفوع";
            next_sess_grid.Columns[6].Visible = false;
            next_sess_grid.Columns[7].Visible = false;

            for (int i = 0; i < next_sess_grid.RowCount; i++)
            {

                next_sess_grid.Rows[i].Cells[0].Value = convert_day_ar(Convert.ToDateTime(next_sess_grid.Rows[i].Cells[1].Value));
            }
        }
        //method to fill patient's previous sessions 
        void fill_prev()
        {
            if (prev_sessions_grid.ColumnCount < 6)
            {
                prev_sessions_grid.Columns.Add("day", "اليوم");
            }
            prev_sessions_grid.DataSource = sess_Model.get_prev(selected_ptnt_id);
            prev_sessions_grid.Columns[1].HeaderText = "التاريخ";
            prev_sessions_grid.Columns[1].ReadOnly = true;
            prev_sessions_grid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            prev_sessions_grid.Sort(prev_sessions_grid.Columns[1], ListSortDirection.Descending);

            prev_sessions_grid.Columns[2].HeaderText = "الساعه";
            prev_sessions_grid.Columns[2].ReadOnly = true;

            prev_sessions_grid.Columns[3].HeaderText = "الطبيب";
            prev_sessions_grid.Columns[3].ReadOnly = true;

            prev_sessions_grid.Columns[4].HeaderText = "حضر";
            prev_sessions_grid.Columns[4].ReadOnly = true;

            prev_sessions_grid.Columns[5].HeaderText = "المدفوع";
            prev_sessions_grid.Columns[6].Visible = false;
            prev_sessions_grid.Columns[7].Visible = false;

            for (int i = 0; i < prev_sessions_grid.RowCount; i++)
            {

                prev_sessions_grid.Rows[i].Cells[0].Value = convert_day_ar(Convert.ToDateTime(prev_sessions_grid.Rows[i].Cells[1].Value));
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
        public void refresh_sess()
        {
            fill_ptnt_list();
            selected_ptnt_id = 1;
            fill_prev();
            fill_comming();
        }
        #endregion
    }
}
