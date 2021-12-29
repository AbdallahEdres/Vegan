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
    public partial class home_cont : UserControl
    {
        //implement of home model and home factory
        home_model_class home_Model = new home_model_class();
        home_factory_class home_Factory = new home_factory_class();
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
        public home_cont()
        {
            InitializeComponent();
        }

        private void home_cont_Load(object sender, EventArgs e)
        {
            day_label.Text =  convert_day_ar(DateTime.Now)+" " + DateTime.Now.ToString("yyyy/MM/dd");
            ptnt_count_label.Text = "عدد حالات اليوم :" + home_Model.get_count_ptnt();
            flowLayoutPanel1.Controls.AddRange(home_Factory.create_panels().ToArray());
        }
    }
}
