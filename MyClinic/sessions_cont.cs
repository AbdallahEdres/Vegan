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
    public partial class sessions_cont : UserControl
    {
        public sessions_cont()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            pre_panel.Height =( dr_details_panel.Height / 2)-6;
            comming_panel.Location = new Point(0, (dr_details_panel.Height / 2) + 3);
            comming_panel.Height= (dr_details_panel.Height / 2) - 6;
        }

        private void add_dr_but_Click(object sender, EventArgs e)
        {
            new_session_form new_Session = new new_session_form();
            new_Session.ShowDialog();
        }
    }
}
