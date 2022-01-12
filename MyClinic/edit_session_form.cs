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
    public partial class edit_session_form : Form
    { 
        // implement of sessions model
        sess_model_class sess_Model = new sess_model_class();

        //var declearation
        List<List<string>> dr_details = new List<List<string>>();
        DateTime old_date;
        string old_time;
        // method to fill combo boxes 
        void fill_combo()
        {
            dr_details = sess_Model.get_dr_list("");
            dr_combo.Items.AddRange(dr_details[1].ToArray());

        }
        public edit_session_form(DateTime date, string time, string dr_name)
        {
            InitializeComponent();
            start_date_bick.Value = date;
            old_date = date;
            old_time = time;
            fill_combo();
            dr_combo.SelectedIndex = dr_details[1].IndexOf(dr_name);
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            if (chck_empty())
            {
                sess_Model.edit_sess(old_date, old_time, Convert.ToInt32(dr_details[0][dr_combo.SelectedIndex]), start_date_bick.Value, set_time());
                MessageBox.Show("تم!");
                this.Close();
            }
            else
            {
                MessageBox.Show("برجاء استكمال باقي البيانات");
            }
        }
        //method to set the time
        string set_time()
        {
            string time = "", hr = "";
         
            hr= hr_num.Value.ToString();

            if (hr.Length == 1)
            {
                hr = "0" + hr;
            }
            time = hr + ":" + "00" + " " + am_pm_combo.Items[am_pm_combo.SelectedIndex];
            return time;
        }

      //method to check for empty fields
      bool chck_empty()
        {
            bool stat = true;
            if (dr_combo.SelectedIndex<0||am_pm_combo.SelectedIndex<0)
            {
                stat = false;
            }
            return stat;
        }
    }
}
