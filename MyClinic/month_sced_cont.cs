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
    public partial class month_sced_cont : UserControl
    {
        // month sessions model implement 
        month_sced_model_class month_model = new month_sced_model_class();

        // method to fill data grid
        void fill_sess_grid()
        {
            sessions_grid.DataSource = month_model.get_all_sess(search_txt.Text);
            sessions_grid.Columns[0].HeaderText = "التاريخ";
            sessions_grid.Columns[1].HeaderText = "الساعة";
            sessions_grid.Columns[2].HeaderText = "الطبيب";
            sessions_grid.Columns[3].Visible=false;
            sessions_grid.Columns[4].Visible = false;
            sessions_grid.Columns[5].Visible=false;
            sessions_grid.Columns[6].HeaderText = "الحالة";
            sessions_grid.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            sessions_grid.Sort(sessions_grid.Columns[0], ListSortDirection.Ascending);

        }
        public month_sced_cont()
        {
            InitializeComponent();
            fill_sess_grid();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_sess_grid();
        }
    }
}
