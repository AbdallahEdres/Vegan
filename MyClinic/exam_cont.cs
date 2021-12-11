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
    public partial class exam_cont : UserControl
    {
        public exam_cont()
        {
            InitializeComponent();
            all_radio.Checked = true;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            add_exam_form add_Exam = new add_exam_form();
            add_Exam.ShowDialog();
        }
    }
}
