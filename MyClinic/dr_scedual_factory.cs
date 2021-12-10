using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace MyClinic
{
    // class builds the panels for each doctor's weekly scedual
    class dr_scedual_factory 
    {

        byte dr_group;
        int num_days;
        System.Data.DataTable dt2;


        // constructor

        public dr_scedual_factory(byte _dr_group,int _num_days,System.Data.DataTable dt)
        {
            dr_group = _dr_group;
            num_days = _num_days;
            dt2 = dt;
        }

        // panel list creation

        Guna2ShadowPanel day;
        Guna2DataGridView create_grid(System.Data.DataTable dt)
        {
           
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna2DataGridView day_grid = new Guna2DataGridView();
            day_grid.AllowUserToAddRows = false;
            day_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            day_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            day_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            day_grid.BackgroundColor = System.Drawing.Color.White;
            day_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            day_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            day_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            day_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            day_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            day_grid.DefaultCellStyle = dataGridViewCellStyle6;
            day_grid.EnableHeadersVisualStyles = false;
            day_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            day_grid.Location = new System.Drawing.Point(23, 70);
            day_grid.Name = "day_grid";
            day_grid.ReadOnly = true;
            day_grid.RowHeadersVisible = false;
            day_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            day_grid.Size = new System.Drawing.Size(240, 236);
            day_grid.TabIndex = 1;
            day_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            day_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            day_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            day_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            day_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            day_grid.ThemeStyle.BackColor = System.Drawing.Color.White;
            day_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            day_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            day_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            day_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            day_grid.ThemeStyle.HeaderStyle.Height = 30;
            day_grid.ThemeStyle.ReadOnly = true;
            day_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            day_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            day_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_grid.ThemeStyle.RowsStyle.Height = 22;
            day_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            day_grid.DataSource = dt;
            return day_grid;
        }
        System.Windows.Forms.Label create_day_lable(int i)
        {
            string[] dayname = { "السبت", "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس" };
            System.Windows.Forms.Label day_name = new System.Windows.Forms.Label();
            day_name.Text = dayname[i];
            day_name.AutoSize = true;
            day_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            day_name.Location = new System.Drawing.Point(87, 11);
            day_name.Name = "day_name";
            day_name.Size = new System.Drawing.Size(117, 47);
            day_name.TabIndex = 0;
            
            return day_name;
        }
        public Guna2ShadowPanel[] creat_days()
        {
            Guna2ShadowPanel[] days = new Guna2ShadowPanel[num_days];
            
            for (int i = 0; i < num_days; i++)
            {
                day = new Guna2ShadowPanel();
                day.Height = 330;
                day.Width = 285;
                day.Radius = 25;
                day.FillColor = System.Drawing.Color.FromArgb(200,139, 195, 74);
                day.Controls.Add(create_day_lable(i));
                day.Controls.Add(create_grid(dt2));
                days[i] = day;

            }
            
            return days;
        }

    }
}
