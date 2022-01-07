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
    public partial class exam_pay_form : Form
    {
        int id = -1;
        DateTime date;
        exam_model_class exam_Model = new exam_model_class();

        public exam_pay_form(int _id ,DateTime _date)
        {
            InitializeComponent();
            id = _id;
            date = _date;
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            exam_Model.pay_exam(id, date,Convert.ToInt32(pay_num.Value));
            this.Close();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
