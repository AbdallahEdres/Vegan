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
        // implement of doctors model class
        dr_model_class dr_Model = new dr_model_class();
        // var declearation 
        int dr_id;
        DateTime start, end;
        List<DateTime> days;

        // panel list creation

        Guna2ShadowPanel day;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6;
        // method that create data grid veiw with patients and time of sessions
        Guna2DataGridView create_grid(int i)
        {
            Guna2DataGridView day_grid;
            dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            day_grid = new Guna2DataGridView();
            day_grid.DataSource = dr_Model.get_sced(days[i], dr_id);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            day_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            day_grid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(203, 229, 78);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            day_grid.DefaultCellStyle = dataGridViewCellStyle6;
            day_grid.EnableHeadersVisualStyles = false;
            day_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            day_grid.Location = new System.Drawing.Point(23, 70);
            day_grid.ReadOnly = true;
            day_grid.RowHeadersVisible = false;
            day_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            day_grid.Size = new System.Drawing.Size(300, 300);
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
            day_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            day_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            day_grid.ThemeStyle.HeaderStyle.Height = 30;
            day_grid.ThemeStyle.ReadOnly = true;
            day_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            day_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            day_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            day_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.RowsStyle.Height = 22;
            day_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(93, 110, 30);
            day_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            day_grid.RightToLeft =System.Windows.Forms.RightToLeft.Yes;
            
            return day_grid;
        }

        // method that create a label woth the day name
        System.Windows.Forms.Label create_day_lable(DateTime date)
        {
            System.Windows.Forms.Label day_name = new System.Windows.Forms.Label();
            day_name.Text = convert_day_ar(date)+"  "+date.ToString("d");
            day_name.AutoSize = true;
            day_name.ForeColor = System.Drawing.Color.FromArgb(250,250,250);
            day_name.Location = new System.Drawing.Point(30, 11);
            day_name.Name = "day_name";
            day_name.Size = new System.Drawing.Size(117, 47);
            day_name.TabIndex = 0;
            
            return day_name;
        }
        // method to form the panel 
        Guna2ShadowPanel form_panel()
        {
            Guna2ShadowPanel day_panel = new Guna2ShadowPanel();
             day_panel.BackColor = System.Drawing.Color.Transparent;
             day_panel.FillColor = System.Drawing.Color.FromArgb(93,110,30);
             day_panel.Location = new System.Drawing.Point(3, 3);
             day_panel.Name = "day_panel";
             day_panel.Radius = 20;
             day_panel.ShadowColor = System.Drawing.Color.Black;
             day_panel.Size = new System.Drawing.Size(350, 400);
             day_panel.TabIndex = 1;
            return day_panel;
        }
        // method that create panel with the grid veiw and the label created before
        public List<Guna2ShadowPanel> creat_days(int _dr_id,DateTime _start, DateTime _end)
        {
            dr_id = _dr_id;
            start = _start;
            end = _end;
            Guna2DataGridView day_grid;
            System.Windows.Forms.Label label_day;
            List<Guna2ShadowPanel> days_panel = new List<Guna2ShadowPanel>();
            days = dr_Model.get_days(dr_id, start, end);
            for (int i = 0; i < days.Count(); i++)
            {
                day_grid = create_grid(i);              
                
                label_day = create_day_lable(days[i]);
                day = form_panel();
                day.Controls.Add(label_day);
                day.Controls.Add(day_grid);

                days_panel.Add(day);
            }
            return days_panel;
        }
        // method to get arabic days
        string convert_day_ar(DateTime date)
        {
            string day = "";
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    day = "السبت";
                    break;
                case DayOfWeek.Sunday:
                    day = "الأحد";
                    break;
                case DayOfWeek.Monday:
                    day = "الإثنين";
                    break;
                case DayOfWeek.Tuesday:
                    day = "الثلاثاء";
                    break;
                case DayOfWeek.Wednesday:
                    day = "اللأربعاء";
                    break;
                case DayOfWeek.Thursday:
                    day = "الخميس";
                    break;
                case DayOfWeek.Friday:
                    day = "الجمعة";
                    break;
            }
            return day;
        }

    }
}
