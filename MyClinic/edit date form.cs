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
    public partial class edit_date_form : Form
    {
        // examination model implement
        exam_model_class exam_Model = new exam_model_class();

        //var declearation
        string old_date = "",time="";
        public edit_date_form(string _old_date,string _time)
        {
            InitializeComponent();
            old_date = _old_date;
            time = _time;
            exam_date.MinDate = DateTime.Now;
            exam_date.Value = Convert.ToDateTime(_old_date);
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void done_but_Click(object sender, EventArgs e)
        {
            exam_Model.edit_date(exam_date.Value.ToString("yyyy-MM-dd"), old_date, time);
            MessageBox.Show("نم التعديل");
            this.Close();
        }
    }
}
