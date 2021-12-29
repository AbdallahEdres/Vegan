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
    public partial class sess_pay_form : Form
    {
        //sessions model implment
        sess_model_class sess_Model = new sess_model_class();
        //var declearation
        string date, time;
        int ptnt_id;
        public sess_pay_form(string _date ,string _time ,int _ptnt_id)
        {
            InitializeComponent();
            date = _date;
            time = _time;
            ptnt_id = _ptnt_id;
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            sess_Model.set_pay(Convert.ToInt32(pay_num.Value), date, time, ptnt_id);
            MessageBox.Show("تم !");
            this.Close();
        }

        private void cansel_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
