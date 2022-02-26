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
    public partial class add_sessions_form : Form
    {
        // implement of sessions model
        sess_model_class sess_Model = new sess_model_class();

        //var declearation
        List<List<string>> dr_details;
        int row_index = -1;
        int ptnt_id;
        public add_sessions_form(int _ptnt_id)
        {
            InitializeComponent();
            ptnt_id = _ptnt_id;
            DataGridViewComboBoxColumn d = new DataGridViewComboBoxColumn();
            fill_combo();
            edit_switch.Enabled = false;
            start_date_bick.Value = DateTime.Now;

        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //method to check for empty fields
        bool check()
        {
            bool stat = false;
            if (dr_combo.SelectedIndex < 0 || pay_combo.SelectedIndex < 0 || wekly_sess_combo.SelectedIndex < 0)
            {
                stat = false;
            }
            else
            {
                stat = true;
            }
            return stat;
        }
        // method to fill combo boxes 
        void fill_combo()
        {
            dr_details = new List<List<string>>();
            dr_combo.Items.Clear();
            if (get_group() != -1)
            {
                dr_details = sess_Model.get_dr_list(" and dr_group =" + get_group() + " or dr_group=2");
                dr_combo.Items.AddRange(dr_details[1].ToArray());
            }

        }
        //method to get doctor group 
        int get_group()
        {
            int group = -1;
            if (start_date_bick.Value.DayOfWeek == DayOfWeek.Monday || start_date_bick.Value.DayOfWeek == DayOfWeek.Saturday || start_date_bick.Value.DayOfWeek == DayOfWeek.Wednesday)
            {
                group = 0;
            }
            else if (start_date_bick.Value.DayOfWeek == DayOfWeek.Sunday || start_date_bick.Value.DayOfWeek == DayOfWeek.Tuesday || start_date_bick.Value.DayOfWeek == DayOfWeek.Thursday)
            {
                group = 1;
            }
            return group;
        }

        private void pay_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pay_combo.SelectedIndex == 0)
            {
                pay_val_num.Enabled = false;
            }
            else
            {
                pay_val_num.Enabled = true;
                pay_val_num.Value = 240;
                sessions_num.Value = 6;
            }
        }

        private void generate_but_Click(object sender, EventArgs e)
        {
            if (check())
            {
                generate_sess();
                start_date_bick.Enabled = false;
                pay_combo.Enabled = false;
                sessions_num.Enabled = false;
                pay_val_num.Enabled = false;
                wekly_sess_combo.Enabled = false;
                edit_switch.Enabled = true;
                done_but.Enabled = true;
            }
            else
            {
                MessageBox.Show("برجاء اكمال البيانات");
            }
        }
        // method to set & check sessions
        void generate_sess()
        {
            DateTime date = start_date_bick.Value;
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                MessageBox.Show("اختر يوم غير الجمعه");
            } 
            else
            {
               
                for (int i = 0; i < Convert.ToInt32(sessions_num.Value); i++)
                {
                    if (wekly_sess_combo.SelectedIndex == 1)
                    {
                        if (date.DayOfWeek == DayOfWeek.Tuesday || date.DayOfWeek == DayOfWeek.Monday)
                        {
                            MessageBox.Show("اختر يوم السبت/الاربعاء او الاحد/الخميس");
                            break;
                        }
                    }
                    string note = "لا يوجد ملاحظات";
                   
                    string[] row = { convert_day_ar(date), date.ToString("yyyy-MM-dd"), time_combo.SelectedItem.ToString(), dr_details[1][dr_combo.SelectedIndex], note };
                    sessions_grid.Rows.Add(row);
                   
                    if (wekly_sess_combo.SelectedIndex == 0)
                    {
                        date = date.AddDays(7);

                    }
                    else if (wekly_sess_combo.SelectedIndex == 1)
                    {
                        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            date = date.AddDays(4);

                        }
                        else if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                        {
                            date = date.AddDays(3);
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("اختر يوم السبت/الاحد/الربعاء/الخميس");
                        }
                    }
                    else if (wekly_sess_combo.SelectedIndex == 2)
                    {
                        if (date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday)
                        {
                            date = date.AddDays(3);
                        }
                        else
                        {
                            date = date.AddDays(2);
                        }
                    }
                }
            }
            if (sessions_grid.Rows.Count > 0)
            {
                generate_but.Enabled = false;
            }
            check_overlap();
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

        private void start_date_bick_ValueChanged(object sender, EventArgs e)
        {
            fill_combo();
        }

        private void dr_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sessions_grid.Rows.Count > 0 && !edit_switch.Checked)
            {
                sessions_grid.Rows[row_index].Cells[3].Value = dr_combo.SelectedItem.ToString();
            } else if (sessions_grid.Rows.Count > 0 && edit_switch.Checked)
            {
                for (int i = 0; i < sessions_grid.RowCount; i++)
                {
                    sessions_grid.Rows[i].Cells[3].Value = dr_combo.SelectedItem.ToString();
                }
            }
            check_overlap();

        }
        // method to check for appointment overlap
        bool  check_overlap()
        {
            bool status = true;

            if (sessions_grid.Rows.Count > 0)
            {
                string note;
                int ptnt_num = 0;
;                for (int i = 0; i < sessions_grid.Rows.Count; i++)
                {
                    int stat = sess_Model.check_free_appoint(sessions_grid.Rows[i].Cells[1].Value.ToString(), sessions_grid.Rows[i].Cells[2].Value.ToString(), Convert.ToInt32(dr_details[0][ dr_details[1].IndexOf(sessions_grid.Rows[i].Cells[3].Value.ToString())]),ref ptnt_num) ;
                    if (stat == 0)
                    {

                        note = "يوجد "+ptnt_num.ToString()+" حالات في هذا الموعد";
                        sessions_grid.Rows[i].Cells[4].Value = note;
                        sessions_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        sessions_grid.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                        sessions_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        status = false;

                    }
                    else if (stat == 1)
                    {
                        note = "هذا الطبيب غير متاح";
                        sessions_grid.Rows[i].Cells[4].Value = note;
                        sessions_grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        sessions_grid.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        sessions_grid.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                        status = false;

                    }
                    else
                    {
                        note = "لا يوجد ملحوظات";
                        sessions_grid.Rows[i].Cells[4].Value = note;
                        sessions_grid.Rows[i].DefaultCellStyle.BackColor =sessions_grid.DefaultCellStyle.BackColor;
                        sessions_grid.Rows[i].DefaultCellStyle.ForeColor = sessions_grid.DefaultCellStyle.ForeColor;
                        sessions_grid.Rows[i].DefaultCellStyle.SelectionBackColor = sessions_grid.DefaultCellStyle.SelectionBackColor;

                    }

                }
            }
            return status;
        }

        private void sessions_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;
        }

        private void time_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sessions_grid.Rows.Count > 0 && !edit_switch.Checked)
            {
                sessions_grid.Rows[row_index].Cells[2].Value = time_combo.SelectedItem.ToString();
            }
            else if (sessions_grid.Rows.Count > 0 && edit_switch.Checked)
            {
                for (int i = 0; i < sessions_grid.RowCount; i++)
                {
                    sessions_grid.Rows[i].Cells[2].Value = time_combo.SelectedItem.ToString();
                }
            }
            check_overlap();
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            if (check_overlap())
            {
                for(int i=0;i< sessions_grid.RowCount; i++)
                {
                    sess_Model.set_sessions(ptnt_id, Convert.ToInt32(dr_details[0][dr_details[1].IndexOf(sessions_grid.Rows[i].Cells[3].Value.ToString())]), sessions_grid.Rows[i].Cells[1].Value.ToString(), sessions_grid.Rows[i].Cells[2].Value.ToString(), pay());
                }
                MessageBox.Show("تم !");
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("هناك تعارض بالمواعيد", "هل انت متأكد؟!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < sessions_grid.RowCount; i++)
                    {
                        sess_Model.set_sessions(ptnt_id, Convert.ToInt32(dr_details[0][dr_details[1].IndexOf(sessions_grid.Rows[i].Cells[3].Value.ToString())]), sessions_grid.Rows[i].Cells[1].Value.ToString(), sessions_grid.Rows[i].Cells[2].Value.ToString(), pay());
                    }
                    MessageBox.Show("تم !");
                    this.Close();
                }
            }
        }

        //method to provid payment 
        int pay()
        {
            int payment=0;
            if (pay_combo.SelectedIndex == 1)
            {
                payment =Convert.ToInt32( pay_val_num.Value / 6);
            }
            return payment;
        }
    }
}
