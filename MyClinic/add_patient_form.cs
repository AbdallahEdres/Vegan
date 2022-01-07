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
    public partial class add_patient_form : Form
    {
        //implementation of patient model
        ptnt_model ptnt_Model = new ptnt_model();
        string[] type = { "تغذية", "علاج طبيعي" };

        //meyhod to fill combo boxes 
        void fill_combo()
        {
            type_combo.Items.AddRange(type);
        }
        
        public add_patient_form()
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
                ptnt_Model.add_patient(name_txt.Text, phone_txt.Text, adress_txt.Text, Convert.ToInt32(age_num.Value), type[type_combo.SelectedIndex]);
                navegation_form nav = new navegation_form(ptnt_Model.get_new_ptnt_id(name_txt.Text, phone_txt.Text));
                nav.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("برجاء استكمال البيانات");
            }
          
        }

        // method tocheck for empty fields 
        bool check_empty()
        {
            bool stat = true;
            if (name_txt.Text == ""||phone_txt.Text==""||adress_txt.Text==""||age_num.Value==0||type_combo.SelectedIndex<0)
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
                toolTip1.Show("رقم الهاتف يجب ان يكون ارقام فقط",phone_txt);
            }
            else
            {
                toolTip1.Hide(phone_txt) ;
            }
        }

       
    }
}
