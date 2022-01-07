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
    public partial class report_cont : UserControl
    {
        // implement report model and dr_report_factory
        report_dr_factory_class dr_Factory_Class = new report_dr_factory_class();
        report_model_class report_Model = new report_model_class();
        // vr declearation 
        DateTime date;
        public report_cont()
        {
            InitializeComponent();
            month_combo.SelectedIndex = DateTime.Now.Month-1;
            year_num.Value = DateTime.Now.Year;
            refresh_report();
        }

       
        private void year_num_ValueChanged(object sender, EventArgs e)
        {
            refresh_report();
        }

        private void month_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_report();
        }
        //method to fill general panel
        void fill_general()
        {
            date = new DateTime(Convert.ToInt32(year_num.Value), month_combo.SelectedIndex + 1, 1);
            m_income_value.Text = report_Model.get_total_money(date) + " $";
            m_ptnt_num_value.Text = report_Model.get_num_ptnt(date);

        }
        // method to fill details panel
        void fill_detais_panel()
        {
            date = new DateTime(Convert.ToInt32(year_num.Value), month_combo.SelectedIndex + 1, 1);
            sess_num_val.Text = report_Model.get_sess_num(date);
            sess_income_val.Text = report_Model.get_sess_incom(date) + " $";
            nut_income_val.Text = report_Model.get_nut_incom(date) + " $";
            phys_income_val.Text = report_Model.get_phys_incom(date) + " $";
            phys_num_val.Text = report_Model.get_phys_num(date);
            nut_num_val.Text = report_Model.get_nut_num(date);
        }
        // method to fill doctors flow layout

        void fill_dr_layout()
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.Controls.AddRange(dr_Factory_Class.creat_dr_reports(date).ToArray());
        }
        // refresh method 
        public void refresh_report()
        {

            fill_general();
            fill_detais_panel();
            fill_dr_layout();
        }
    }
}
