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
    public partial class add_dr_form : Form
    {
        //implement dr_model 
        dr_model_class dr_Model = new dr_model_class();
        // fill  combo boxes method 
        string[] speciality = { "تغذية", "علاج طبيعي","تغذية/علاج طبيعي" };

        void fill_combo()
        {
            string[] days = { "السبت , الإثنين , الأربعاء", "الأحد ,الثلاثاء ,الخميس", "كل يوم" };
            group_combo.Items.AddRange(days);
            spciality_combo.Items.AddRange(speciality);
        }
        
        public add_dr_form()
        {
            InitializeComponent();
            fill_combo();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            if (check_empty())
            {
                dr_Model.add_new_dr(name_txt.Text, phone_txt.Text, group_combo.SelectedIndex, speciality[spciality_combo.SelectedIndex]);
                MessageBox.Show("تم !");
                this.Close();
            }
            else
            {
                MessageBox.Show("برجاء استكمال البيانات");
            }
        }
        // method to check for empty fields 
        bool check_empty()
        {
            bool stat = true;
            if (name_txt.Text == "" || phone_txt.Text == "" || spciality_combo.SelectedIndex < 0 || group_combo.SelectedIndex < 0)
            {
                stat = false;
            }
            return stat;
        }

        private void phone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                toolTip1.Show("رقم الهاتف يجب ان يكون ارقام فقط", phone_txt);
            }
            else
            {
                toolTip1.Hide(phone_txt);
            }
        }
    }
}
