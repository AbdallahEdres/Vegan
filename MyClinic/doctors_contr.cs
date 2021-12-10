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
        DataTable d = new DataTable();

        dr_scedual_factory sec;
        public doctors_contr()
        {
            InitializeComponent();
            d.Columns.Add("الساعه");
            d.Columns.Add("الحاله");



            string[] names = { "محمد احمد", "محمد احمد", "محمد احمد", "محمد احمد", "محمد احمد", "محمد احمد", "محمد احمد" };
            int[] ti = { 3, 4, 5, 6, 7, 8, 9 };
            sec = new dr_scedual_factory(1, 6, d);
            for (int i = 0; i < ti.Length; i++)
            {
                d.Rows.Add(ti[i], names[i]);
            }
            flowLayoutPanel1.Controls.AddRange(sec.creat_days());


        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
