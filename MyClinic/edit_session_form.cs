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
            dr_details = sess_Model.get_dr_list();
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
            time_combo.SelectedIndex = time_combo.Items.IndexOf(time.ToString());
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            sess_Model.edit_sess(old_date, old_time, Convert.ToInt32(dr_details[0][dr_combo.SelectedIndex]), start_date_bick.Value, time_combo.SelectedItem.ToString());
            MessageBox.Show("تم!");
            this.Close();
        }
    }
}
