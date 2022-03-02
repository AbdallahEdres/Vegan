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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
/*            db_backup_class.restore();
*/        }

        private void exit_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*MessageBox.Show(System.IO.Directory.GetCurrentDirectory().ToString());*/
            main_form Main = new main_form();
            Main.Show();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_but.PerformClick();
            }else if (e.KeyCode == Keys.Escape)
            {
                exit_but.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
/*            db_backup_class.back_up();
*/            
        }
    }
}
