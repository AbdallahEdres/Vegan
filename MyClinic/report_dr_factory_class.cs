using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace MyClinic
{
    class report_dr_factory_class
    {

        //implementaion of report model
        report_model_class report_Model = new report_model_class();
        List<int> dr_ids;

        //method to create dr name label

        System.Windows.Forms.Label create_name_lable(int id)
        {
            System.Windows.Forms.Label dr_name = new System.Windows.Forms.Label();
            dr_name.Text = "د/ "+report_Model.get_dr_name(id);
            dr_name.AutoSize = true;
            dr_name.ForeColor = System.Drawing.Color.FromArgb(93, 110, 30);
            dr_name.Location = new System.Drawing.Point(100, 11);
            dr_name.Size = new System.Drawing.Size(117, 47);
            dr_name.Font= new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dr_name.TabIndex = 0;

            return dr_name;
        }
        //method to create label for sessions number 
        System.Windows.Forms.Label create_sess_num_lable()
        {
            System.Windows.Forms.Label sess_num_label = new System.Windows.Forms.Label();
            sess_num_label.Text = "عدد الجلسات :";
            sess_num_label.AutoSize = true;
            sess_num_label.ForeColor = System.Drawing.Color.FromArgb(0,0,0);
            sess_num_label.Location = new System.Drawing.Point(180, 100);
            sess_num_label.Size = new System.Drawing.Size(117, 47);
            sess_num_label.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sess_num_label.TabIndex = 0;
            sess_num_label.RightToLeft=System.Windows.Forms.RightToLeft.Yes;

            return sess_num_label;
        }
        //method to create label for sessions number value
        System.Windows.Forms.Label create_sess_val_lable(DateTime date,int id)
        {
            System.Windows.Forms.Label sess_num_label = new System.Windows.Forms.Label();
            sess_num_label.Text = report_Model.get_dr_sess_num(id,date);
            sess_num_label.AutoSize = true;
            sess_num_label.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            sess_num_label.Location = new System.Drawing.Point(130, 100);
            sess_num_label.Size = new System.Drawing.Size(117, 47);
            sess_num_label.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sess_num_label.TabIndex = 0;
            sess_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            return sess_num_label;
        }

        //method to create label for patient number 
        System.Windows.Forms.Label create_ptnt_num_lable()
        {
            System.Windows.Forms.Label ptnt_num_label = new System.Windows.Forms.Label();
            ptnt_num_label.Text = "عدد الحالات :";
            ptnt_num_label.AutoSize = true;
            ptnt_num_label.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            ptnt_num_label.Location = new System.Drawing.Point(180, 150);
            ptnt_num_label.Size = new System.Drawing.Size(117, 47);
            ptnt_num_label.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ptnt_num_label.TabIndex = 0;
            ptnt_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            return ptnt_num_label;
        }
        //method to create label for patient number value
        System.Windows.Forms.Label create_ptnt_val_lable(DateTime date, int id)
        {
            System.Windows.Forms.Label ptnt_num_label = new System.Windows.Forms.Label();
            ptnt_num_label.Text = report_Model.get_ptnt_val(id, date);
            ptnt_num_label.AutoSize = true;
            ptnt_num_label.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            ptnt_num_label.Location = new System.Drawing.Point(130, 150);
            ptnt_num_label.Size = new System.Drawing.Size(117, 47);
            ptnt_num_label.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ptnt_num_label.TabIndex = 0;
            ptnt_num_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

            return ptnt_num_label;
        }
        // method to form the panel 
        Guna2ShadowPanel form_panel()
        {
            Guna2ShadowPanel dr_panel = new Guna2ShadowPanel();
            dr_panel.BackColor = System.Drawing.Color.Transparent;
            dr_panel.FillColor = System.Drawing.Color.FromArgb(250,250,250);
            dr_panel.Location = new System.Drawing.Point(15, 15);
            dr_panel.Name = "dr_panel";
            dr_panel.Radius = 20;
            dr_panel.ShadowColor = System.Drawing.Color.Black;
            dr_panel.Size = new System.Drawing.Size(320, 220);
            dr_panel.TabIndex = 1;
            return dr_panel;
        }
        // method to form the back panel 
        Guna2ShadowPanel form_back_panel()
        {
            Guna2ShadowPanel back_panel = new Guna2ShadowPanel();
            back_panel.BackColor = System.Drawing.Color.Transparent;
            back_panel.FillColor = System.Drawing.Color.FromArgb(93, 110, 30);
            back_panel.Location = new System.Drawing.Point(3, 3);
            back_panel.Name = "back_panel";
            back_panel.Radius = 20;
            back_panel.ShadowColor = System.Drawing.Color.Black;
            back_panel.Size = new System.Drawing.Size(350, 250);
            back_panel.TabIndex = 1;
            return back_panel;
        }
        // method that create panel with the grid veiw and the label created before
        public List<Guna2ShadowPanel> creat_dr_reports(DateTime date)
        {
            dr_ids = report_Model.get_ids();
            List<Guna2ShadowPanel> dr_report_panels = new List<Guna2ShadowPanel>();
            Guna2ShadowPanel dr_report;
            Guna2ShadowPanel back;

            for (int i = 0;i< dr_ids.Count; i++)
            {
                back = form_back_panel();
                
                dr_report = form_panel();
                dr_report.Controls.Add(create_name_lable(dr_ids[i]));
                dr_report.Controls.Add(create_sess_num_lable());
                dr_report.Controls.Add(create_sess_val_lable(date,dr_ids[i]));
                dr_report.Controls.Add(create_ptnt_num_lable());
                dr_report.Controls.Add(create_ptnt_val_lable(date,dr_ids[i]));
                back.Controls.Add(dr_report);
                dr_report_panels.Add(back);

            }

            return dr_report_panels;
        }
    }
}
