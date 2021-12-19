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
    public partial class prev_exam_form : Form
    {
        // implement examination model 
        exam_model_class exam_Model = new exam_model_class();

        // method to fill examinations list 
        void fill_exam_list()
        {
            exam_grid.DataSource = exam_Model.get_exam(search_txt.Text,"", 1);
            exam_grid.Columns[0].HeaderText = "الإسم";
            exam_grid.Columns[0].ReadOnly = true;

            exam_grid.Columns[1].HeaderText = "الهاتف";
            exam_grid.Columns[1].ReadOnly = true;

            exam_grid.Columns[2].HeaderText = "تاريخ الجلسة";
            exam_grid.Columns[2].ReadOnly = true;

            exam_grid.Columns[3].HeaderText = "الساعة";
            exam_grid.Columns[3].ReadOnly = true;

            exam_grid.Columns[4].HeaderText = "نوع الكشف";
            exam_grid.Columns[4].ReadOnly = true;

            exam_grid.Columns[5].HeaderText = "المدفوع";
            exam_grid.Columns[5].ReadOnly = true;

            exam_grid.Columns[6].HeaderText = "حضر";
            exam_grid.Columns[6].ReadOnly = true;

            exam_grid.Columns[7].Visible = false;

        }
        public prev_exam_form()
        {
            InitializeComponent();
            fill_exam_list();

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            fill_exam_list();
        }

        
    }
}
