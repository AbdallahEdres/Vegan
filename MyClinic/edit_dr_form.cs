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
    public partial class edit_dr_form : Form
    {
        dr_model_class dr_Model = new dr_model_class();
        // var declearation
        string name = "", phone = "", speciality = "", days = "";
        int dr_id = -1;
        // fill  combo boxes method 
        string[] specialitys = { "تغذية", "علاج طبيعي" };

        void fill_combo()
        {
            string[] days = { "السبت , الإثنين , الأربعاء", "الأحد ,الثلاثاء ,الخميس", "كل يوم" };
            group_combo.Items.AddRange(days);
            spciality_combo.Items.AddRange(specialitys);
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            dr_Model.edit_dr(dr_id,name_txt.Text, phone_txt.Text, group_combo.SelectedIndex, specialitys[spciality_combo.SelectedIndex]);
            MessageBox.Show("تم !");
            this.Close();
        }

        // method to fill fields

        void fill()
        {
            name_txt.Text = name;
            phone_txt.Text = phone;
            if(days== "السبت , الإثنين , الأربعاء")
            {
                group_combo.SelectedIndex = 0;
            }
            else if (days== "الأحد ,الثلاثاء ,الخميس")
            {
                group_combo.SelectedIndex = 1;


            }
            else if (days== "كل يوم")
            {
                group_combo.SelectedIndex = 2;

            }
            if (speciality == "تغذية")
            {
                spciality_combo.SelectedIndex = 0;
            }else if(speciality== "علاج طبيعي")
            {
                spciality_combo.SelectedIndex = 1;
            }
        }
        public edit_dr_form(int id)
        {
            InitializeComponent();
            dr_id = id;
            fill_combo();
            dr_Model.get_dr_info(id, ref name, ref phone, ref days, ref speciality);
            fill();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
