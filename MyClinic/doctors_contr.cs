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
    public partial class doctors_contr : UserControl
    {
        //implementaion of doctors model and factory
        dr_scedual_factory sced = new dr_scedual_factory();
        dr_model_class dr_Model = new dr_model_class();

        // var declearation
        string name = "", phone = "", speciality = "",days="";
        int id = 1;
       
        
        public doctors_contr()
        {
            InitializeComponent();
            refresh_doctors();
        }
        #region buttons
        private void start_date_bic_ValueChanged(object sender, EventArgs e)
        {
            end_date_bic.MinDate = start_date_bic.Value;
            fill_folow();

        }

        private void dr_list_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id = Convert.ToInt32(dr_list_grid.Rows[e.RowIndex].Cells[0].Value);
                fill_dr_info();
                fill_folow();
            }

        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_dr_form add_form = new add_dr_form();
            add_form.ShowDialog();
            fill_dr_list();
        }

        private void edit_but_Click(object sender, EventArgs e)
        {
            edit_dr_form edit_form = new edit_dr_form(id);
            edit_form.ShowDialog();
            fill_dr_list();
        }
        #endregion
        #region methods
        // method to fill dr_info
        void fill_dr_info()
        {
            dr_Model.get_dr_info(id, ref name, ref phone, ref days, ref speciality);
            name_val_label.Text = name;
            phone_val_label.Text = phone;
            days_val_label.Text = days;
            speciality_val_label.Text = speciality;
        }
        // method to fill dr_list 
        void fill_dr_list()
        {
            dr_list_grid.DataSource = dr_Model.get_dr_list();
            dr_list_grid.Columns[0].Visible = false;
            dr_list_grid.Columns[1].HeaderText = "الإسم";
            dr_list_grid.Columns[2].HeaderText = "الهاتف";

        }
        // method to fill flow layout
        void fill_folow()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(sced.creat_days(id, start_date_bic.Value, end_date_bic.Value).ToArray());
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                no_appoint_label.Visible = false;
            }
            else
            {
                no_appoint_label.Visible = true;
            }
        }

        //refresh_doctors method
        public void refresh_doctors()
        {
            id = 1;
            fill_dr_list();
            fill_dr_info();
            start_date_bic.Value = DateTime.Today;
            end_date_bic.Value = start_date_bic.Value.AddDays(7);
            start_date_bic.MinDate = DateTime.Today;
            end_date_bic.MinDate = start_date_bic.Value;
            fill_folow();
        }
        #endregion
    }
}
