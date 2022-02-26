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
    public partial class navegation_form : Form
    {
        int id = -1;
        public navegation_form(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void done_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_sess_but_Click(object sender, EventArgs e)
        {
            add_sessions_form new_Session = new add_sessions_form(id);
            new_Session.ShowDialog();
            this.Close();
        }

        private void new_exam_but_Click(object sender, EventArgs e)
        {
            add_exam_form add_Exam = new add_exam_form();
            add_Exam.ShowDialog();
            this.Close();
        }
    }
}
