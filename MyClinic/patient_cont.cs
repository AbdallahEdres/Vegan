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
        string name = "", phone = "", adress = "", type = "";
        int age = 0, patient_id = 1;
        string date = "";

        #region buttons
        public patient_cont()
        {
            InitializeComponent();
            refresh_patient();
        }

        private void ptnt_list_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                patient_id = Convert.ToInt32(ptnt_list_grid.Rows[e.RowIndex].Cells[0].Value );
                get_details();
                fill_sess_grid();
            }
           
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_patietns_list();
        }
        
       

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_patient_form add_Patient = new add_patient_form();
            add_Patient.ShowDialog();
            refresh_patient();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            edit_patient_form edit_Patient = new edit_patient_form(patient_id);
            edit_Patient.ShowDialog();
            refresh_patient();
        }

      

        #endregion

        #region methods

        //method to get patient details 
        void get_details()
        {
            ptnt_Model.get_ptnt_details(patient_id, ref name, ref phone, ref adress, ref type, ref age);
            date = ptnt_Model.get_date(patient_id);
            fill_details();
        }
        // method to fill patients list
        void fill_patietns_list()
        {
            ptnt_list_grid.DataSource = ptnt_Model.get_ptnt_list(search_txt.Text);
            ptnt_list_grid.Columns[0].Visible = false;
            ptnt_list_grid.Columns[1].HeaderText = "الإسم";
            ptnt_list_grid.Columns[2].HeaderText = "الهاتف";
        }
        //method to fill patient details
        void fill_details()
        {
            name_val_label.Text = name;
            phone_val_label.Text = phone;
            address_val_label.Text = adress;
            type_val_label.Text = type;
            age_val_label.Text = age.ToString();
            date_val_label.Text = date;
        }
        public void refresh_patient()
        {
            get_details();
            fill_details();
            fill_patietns_list();
            fill_sess_grid();
        }
        void fill_sess_grid()
        {
            if (sessions_grid.ColumnCount < 6)
            {
                sessions_grid.Columns.Add("day", "اليوم");
            }
            sessions_grid.DataSource = ptnt_Model.get_sess(patient_id);
            sessions_grid.Columns[1].HeaderText = "التاريخ";
            sessions_grid.Columns[1].ReadOnly = true;
            sessions_grid.Columns[0].ReadOnly = true;
            sessions_grid.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            sessions_grid.Sort(sessions_grid.Columns[1], ListSortDirection.Ascending);

            sessions_grid.Columns[2].HeaderText = "الساعه";
            sessions_grid.Columns[2].ReadOnly = true;

            sessions_grid.Columns[3].HeaderText = "الطبيب";
            sessions_grid.Columns[3].ReadOnly = true;

            sessions_grid.Columns[4].HeaderText = "حضر";
            sessions_grid.Columns[4].ReadOnly = false;

            sessions_grid.Columns[5].HeaderText = "المدفوع";
            sessions_grid.Columns[6].Visible = false;
            sessions_grid.Columns[7].Visible = false;

            for (int i = 0; i < sessions_grid.RowCount; i++)
            {

                sessions_grid.Rows[i].Cells[0].Value = convert_day_ar(Convert.ToDateTime(sessions_grid.Rows[i].Cells[1].Value));
            }
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
        #endregion
    }
}
