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
        //sessions model implment
        sess_model_class sess_Model =new sess_model_class();
        //method to fill patients list 
        void fill_ptnt_list()
        {
            ptnt_list_grid.DataSource = sess_Model.get_ptnt_list(search_txt.Text);
            ptnt_list_grid.Columns[0].Visible = false;
            ptnt_list_grid.Columns[1].HeaderText = "الإسم";
            ptnt_list_grid.Columns[2].HeaderText = "الهاتف";
        }
        public sessions_cont()
        {
            InitializeComponent();
            fill_ptnt_list();
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
