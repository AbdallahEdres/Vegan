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
    public partial class edit_time_form : Form
    {
        // examination model implement
        exam_model_class exam_Model = new exam_model_class();

        // var dexlearation
        string date = "";
        string old_time = "";
        public edit_time_form(string _old_time, string _date)
        {
            InitializeComponent();
            date = _date;
            old_time = _old_time;
            am_pm_combo.SelectedIndex = 0;
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            string time = "", hr = "", min = "";
            min = min_num.Value.ToString();
            if (min.Length == 1)
            {
                min = "0" + min;
            }

            hr = hr_num.Value.ToString();

            if (hr.Length == 1)
            {
                hr = "0" + hr;
            }
            time = hr + ":" + min + " " + am_pm_combo.Items[am_pm_combo.SelectedIndex];
            if (exam_Model.check_date_time(date, time))
            {
                exam_Model.edit_time(time, date, old_time);
                MessageBox.Show("تم!");
                this.Close();
            }
            else
            {
                MessageBox.Show("الموعد محجوز مسبقاً");
            }
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
