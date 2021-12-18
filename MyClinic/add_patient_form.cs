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
        string[] payment = { "بالجلسة", "باقة " };

        //meyhod to fill combo boxes 
        void fill_combo()
        {
            type_combo.Items.AddRange(type);
            pay_combo.Items.AddRange(payment);
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
            ptnt_Model.add_patient(name_txt.Text, phone_txt.Text, adress_txt.Text,Convert.ToInt32( age_num.Value), type[type_combo.SelectedIndex], payment[pay_combo.SelectedIndex]);
            MessageBox.Show("تم!");
            this.Close();
        }
    }
}
