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
    public partial class edit_patient_form : Form
    {
        //implement patient_model 
        ptnt_model ptnt_Model = new ptnt_model();

        //var declearation
        string name = "", phone = "", adress = "", payment = "", type = "";
        int age = 0, patient_id = 0;
        DateTime date = new DateTime();
        string[] types = { "تغذية", "علاج طبيعي" };
        string[] payments = { "بالجلسة", "باقة " };

       
      
        public edit_patient_form(int _id)
        {
            InitializeComponent();
            fill_combo();
            patient_id = _id;
            get_details();
        }
        private void done_but_Click(object sender, EventArgs e)
        {
            if (check_empty())
            {
                ptnt_Model.edit_ptnt_info(patient_id, name_txt.Text, phone_txt.Text, adress_txt.Text, types[type_combo.SelectedIndex], Convert.ToInt32(age_num.Value), date);
                MessageBox.Show("تم!");
                this.Close();
            }
            else
            {
                MessageBox.Show("برجاء استكمال البيانات");
            }
        }


        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // method tocheck for empty fields 
        bool check_empty()
        {
            bool stat = true;
            if (name_txt.Text == "" || phone_txt.Text == "" || adress_txt.Text == "" || age_num.Value == 0 || type_combo.SelectedIndex < 0)
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

        //meyhod to fill combo boxes 
        void fill_combo()
        {
            type_combo.Items.AddRange(types);
        }

        //method to get patient details 
        void get_details()
        {
            ptnt_Model.get_ptnt_details(patient_id, ref name, ref phone, ref adress, ref type, ref age, ref date);
            fill_fields();
        }

        // method to fill fields 
        void fill_fields()
        {
            name_txt.Text = name;
            phone_txt.Text = phone;
            adress_txt.Text = adress;
            age_num.Value = age;
            if (type == "تغذية")
            {
                type_combo.SelectedIndex = 0;
            }
            else if (type == "علاج طبيعي")
            {
                type_combo.SelectedIndex = 1;
            }

        }
    }
}
