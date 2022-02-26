using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace MyClinic
{
    class home_factory_class
    {
        //implement of hom model
        home_model_class home_Model = new home_model_class();
        string[] hrs;
        
        // method that create data grid veiw with patients and time of sessions
        Guna2DataGridView create_grid(int i)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6;
            Guna2DataGridView day_grid;
            dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            day_grid = new Guna2DataGridView();
            day_grid.DataSource = home_Model.get_dr_ptnt(hrs[i]);
            day_grid.AllowUserToAddRows = false;
            day_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            day_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            day_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            day_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            day_grid.BackgroundColor = System.Drawing.Color.White;
            day_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            day_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            day_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            day_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            day_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            day_grid.DefaultCellStyle = dataGridViewCellStyle6;
            day_grid.EnableHeadersVisualStyles = false;
            day_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            day_grid.Location = new System.Drawing.Point(23, 50);
            day_grid.ReadOnly = true;
            day_grid.RowHeadersVisible = false;
            day_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            day_grid.Size = new System.Drawing.Size(150,180);
            day_grid.TabIndex = 1;
            day_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            day_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            day_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            day_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            day_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            day_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            day_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            day_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            day_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            day_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            day_grid.ThemeStyle.HeaderStyle.Height = 30;
            day_grid.ThemeStyle.ReadOnly = true;
            day_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            day_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            day_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.RowsStyle.Height = 22;
            day_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            day_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            return day_grid;
        }
        // method to form the panel 
        Guna2ShadowPanel form_panel()
        {
            Guna2ShadowPanel day_panel = new Guna2ShadowPanel();
            day_panel.BackColor = System.Drawing.Color.Transparent;
            day_panel.FillColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_panel.Location = new System.Drawing.Point(3, 3);
            day_panel.Name = "day_panel";
            day_panel.Radius = 15;
            day_panel.ShadowColor = System.Drawing.Color.Black;
            day_panel.Size = new System.Drawing.Size(200, 250);
            day_panel.TabIndex = 1;
            day_panel.Margin = new System.Windows.Forms.Padding(7);
            return day_panel;
        }
        // method that create a label woth the day name
        System.Windows.Forms.Label create_hr_lable(int i)
        {
            System.Windows.Forms.Label day_name = new System.Windows.Forms.Label();
            day_name.Text = "الساعة : " + hrs[i];
            day_name.Font = new System.Drawing.Font("Tajawal", 14f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_name.AutoSize = true;
            day_name.ForeColor = System.Drawing.Color.FromArgb(250, 250, 250);
            day_name.Location = new System.Drawing.Point(16,15);
            day_name.Name = "day_name";
            day_name.TabIndex = 0;
            day_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            return day_name;
        }
        // method to create every hour panel
        public List<Guna2ShadowPanel> create_panels()
        {
            hrs = home_Model.get_hrs(DateTime.Now).ToArray();
            Guna2ShadowPanel panel;
            List<Guna2ShadowPanel> panels = new List<Guna2ShadowPanel>();
            for(int i = 0; i < hrs.Length; i++)
            {
                panel = form_panel();
                panel.Controls.Add(create_hr_lable(i));
                panel.Controls.Add(create_grid(i));
                panels.Add(panel);
            }
            return panels;

        }
    }
}
