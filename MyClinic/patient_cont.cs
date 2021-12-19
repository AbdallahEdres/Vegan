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
    public partial class patient_cont : UserControl
    {
        //implement patients_model
        ptnt_model ptnt_Model = new ptnt_model();

        // var declearation 
        string name = "", phone = "", adress = "", payment = "", type = "";
        int age = 0, patient_id = 0;
        DateTime date = new DateTime();

        
        //method to fill patient details
        void fill_details()
        {
            name_val_label.Text = name;
            phone_val_label.Text = phone;
            address_val_label.Text = adress;
            pay_val_label.Text = payment;
            type_val_label.Text = type;
            age_val_label.Text = age.ToString();
            date_val_label.Text = date.ToString("yyyy/MM/dd");
        }

        private void ptnt_list_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                patient_id = Convert.ToInt32(ptnt_list_grid.Rows[e.RowIndex].Cells[0].Value
                    );
                get_details();
            }
           
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_patietns_list();
        }

        // method to fill patients list
        void fill_patietns_list()
        {
            ptnt_list_grid.DataSource = ptnt_Model.get_ptnt_list(search_txt.Text);
            ptnt_list_grid.Columns[0].Visible = false;
            ptnt_list_grid.Columns[1].HeaderText = "الإسم";
            ptnt_list_grid.Columns[2].HeaderText = "الهاتف";
        }

        //method to get patient details 
        void get_details()
        {
            ptnt_Model.get_ptnt_details(patient_id, ref name, ref phone, ref adress, ref type, ref payment,ref age,ref date);
            fill_details();
        }
        public patient_cont()
        {
            InitializeComponent();
            fill_details();
            fill_patietns_list();
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_patient_form add_Patient = new add_patient_form();
            add_Patient.ShowDialog();
            fill_patietns_list();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            edit_patient_form edit_Patient = new edit_patient_form(patient_id);
            edit_Patient.ShowDialog();
            fill_patietns_list();
            fill_details();
        }
    }
}
