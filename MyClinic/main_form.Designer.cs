
namespace MyClinic
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.back_panel = new System.Windows.Forms.Panel();
            this.top_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.reports_but = new Guna.UI2.WinForms.Guna2Button();
            this.doctors_but = new Guna.UI2.WinForms.Guna2Button();
            this.scedual_but = new Guna.UI2.WinForms.Guna2Button();
            this.sessions_but = new Guna.UI2.WinForms.Guna2Button();
            this.exam_but = new Guna.UI2.WinForms.Guna2Button();
            this.patient_but = new Guna.UI2.WinForms.Guna2Button();
            this.home_but = new Guna.UI2.WinForms.Guna2Button();
            this.sessions_cont1 = new MyClinic.sessions_cont();
            this.report_cont1 = new MyClinic.report_cont();
            this.patient_cont1 = new MyClinic.patient_cont();
            this.month_sced_cont1 = new MyClinic.month_sced_cont();
            this.home_cont1 = new MyClinic.home_cont();
            this.exam_cont1 = new MyClinic.exam_cont();
            this.doctors_contr1 = new MyClinic.doctors_contr();
            this.back_panel.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_panel
            // 
            this.back_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_panel.AutoScroll = true;
            this.back_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.back_panel.Controls.Add(this.sessions_cont1);
            this.back_panel.Controls.Add(this.report_cont1);
            this.back_panel.Controls.Add(this.patient_cont1);
            this.back_panel.Controls.Add(this.month_sced_cont1);
            this.back_panel.Controls.Add(this.home_cont1);
            this.back_panel.Controls.Add(this.exam_cont1);
            this.back_panel.Controls.Add(this.doctors_contr1);
            this.back_panel.Location = new System.Drawing.Point(0, 78);
            this.back_panel.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.back_panel.Name = "back_panel";
            this.back_panel.Size = new System.Drawing.Size(785, 483);
            this.back_panel.TabIndex = 0;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Transparent;
            this.top_panel.BorderRadius = 20;
            this.top_panel.Controls.Add(this.reports_but);
            this.top_panel.Controls.Add(this.doctors_but);
            this.top_panel.Controls.Add(this.scedual_but);
            this.top_panel.Controls.Add(this.sessions_but);
            this.top_panel.Controls.Add(this.exam_but);
            this.top_panel.Controls.Add(this.patient_but);
            this.top_panel.Controls.Add(this.home_but);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.top_panel.Font = new System.Drawing.Font("Tajawal", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Padding = new System.Windows.Forms.Padding(4);
            this.top_panel.ShadowDecoration.Parent = this.top_panel;
            this.top_panel.Size = new System.Drawing.Size(784, 82);
            this.top_panel.TabIndex = 0;
            // 
            // reports_but
            // 
            this.reports_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reports_but.BorderColor = System.Drawing.Color.White;
            this.reports_but.BorderRadius = 15;
            this.reports_but.BorderThickness = 5;
            this.reports_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.reports_but.CheckedState.Parent = this.reports_but;
            this.reports_but.CustomImages.Parent = this.reports_but;
            this.reports_but.FillColor = System.Drawing.Color.White;
            this.reports_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.reports_but.HoverState.Parent = this.reports_but;
            this.reports_but.Image = ((System.Drawing.Image)(resources.GetObject("reports_but.Image")));
            this.reports_but.ImageOffset = new System.Drawing.Point(11, -10);
            this.reports_but.ImageSize = new System.Drawing.Size(40, 40);
            this.reports_but.Location = new System.Drawing.Point(17, 2);
            this.reports_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.reports_but.Name = "reports_but";
            this.reports_but.Padding = new System.Windows.Forms.Padding(10);
            this.reports_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reports_but.ShadowDecoration.Parent = this.reports_but;
            this.reports_but.Size = new System.Drawing.Size(94, 75);
            this.reports_but.TabIndex = 7;
            this.reports_but.Text = "تقارير";
            this.reports_but.TextOffset = new System.Drawing.Point(-13, 20);
            this.reports_but.Click += new System.EventHandler(this.reports_but_Click);
            // 
            // doctors_but
            // 
            this.doctors_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctors_but.BorderColor = System.Drawing.Color.White;
            this.doctors_but.BorderRadius = 15;
            this.doctors_but.BorderThickness = 5;
            this.doctors_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.doctors_but.CheckedState.Parent = this.doctors_but;
            this.doctors_but.CustomImages.Parent = this.doctors_but;
            this.doctors_but.FillColor = System.Drawing.Color.White;
            this.doctors_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctors_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.doctors_but.HoverState.Parent = this.doctors_but;
            this.doctors_but.Image = ((System.Drawing.Image)(resources.GetObject("doctors_but.Image")));
            this.doctors_but.ImageOffset = new System.Drawing.Point(14, -10);
            this.doctors_but.ImageSize = new System.Drawing.Size(40, 40);
            this.doctors_but.Location = new System.Drawing.Point(126, 2);
            this.doctors_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.doctors_but.Name = "doctors_but";
            this.doctors_but.Padding = new System.Windows.Forms.Padding(10);
            this.doctors_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctors_but.ShadowDecoration.Parent = this.doctors_but;
            this.doctors_but.Size = new System.Drawing.Size(94, 75);
            this.doctors_but.TabIndex = 5;
            this.doctors_but.Text = "الأطباء";
            this.doctors_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.doctors_but.Click += new System.EventHandler(this.doctors_but_Click);
            // 
            // scedual_but
            // 
            this.scedual_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scedual_but.BorderColor = System.Drawing.Color.White;
            this.scedual_but.BorderRadius = 15;
            this.scedual_but.BorderThickness = 5;
            this.scedual_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.scedual_but.CheckedState.Parent = this.scedual_but;
            this.scedual_but.CustomImages.Parent = this.scedual_but;
            this.scedual_but.FillColor = System.Drawing.Color.White;
            this.scedual_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scedual_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.scedual_but.HoverState.Parent = this.scedual_but;
            this.scedual_but.Image = ((System.Drawing.Image)(resources.GetObject("scedual_but.Image")));
            this.scedual_but.ImageOffset = new System.Drawing.Point(14, -10);
            this.scedual_but.ImageSize = new System.Drawing.Size(40, 40);
            this.scedual_but.Location = new System.Drawing.Point(235, 2);
            this.scedual_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.scedual_but.Name = "scedual_but";
            this.scedual_but.Padding = new System.Windows.Forms.Padding(10);
            this.scedual_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scedual_but.ShadowDecoration.Parent = this.scedual_but;
            this.scedual_but.Size = new System.Drawing.Size(94, 75);
            this.scedual_but.TabIndex = 4;
            this.scedual_but.Text = "جداول";
            this.scedual_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.scedual_but.Click += new System.EventHandler(this.scedual_but_Click);
            // 
            // sessions_but
            // 
            this.sessions_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sessions_but.BorderColor = System.Drawing.Color.White;
            this.sessions_but.BorderRadius = 15;
            this.sessions_but.BorderThickness = 5;
            this.sessions_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.sessions_but.CheckedState.Parent = this.sessions_but;
            this.sessions_but.CustomImages.Parent = this.sessions_but;
            this.sessions_but.FillColor = System.Drawing.Color.White;
            this.sessions_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessions_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_but.HoverState.Parent = this.sessions_but;
            this.sessions_but.Image = ((System.Drawing.Image)(resources.GetObject("sessions_but.Image")));
            this.sessions_but.ImageOffset = new System.Drawing.Point(16, -10);
            this.sessions_but.ImageSize = new System.Drawing.Size(40, 40);
            this.sessions_but.Location = new System.Drawing.Point(344, 2);
            this.sessions_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.sessions_but.Name = "sessions_but";
            this.sessions_but.Padding = new System.Windows.Forms.Padding(10);
            this.sessions_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sessions_but.ShadowDecoration.Parent = this.sessions_but;
            this.sessions_but.Size = new System.Drawing.Size(94, 75);
            this.sessions_but.TabIndex = 3;
            this.sessions_but.Text = "الجلسات";
            this.sessions_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.sessions_but.Click += new System.EventHandler(this.sessions_but_Click);
            // 
            // exam_but
            // 
            this.exam_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exam_but.BorderColor = System.Drawing.Color.White;
            this.exam_but.BorderRadius = 15;
            this.exam_but.BorderThickness = 5;
            this.exam_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.exam_but.CheckedState.Parent = this.exam_but;
            this.exam_but.CustomImages.Parent = this.exam_but;
            this.exam_but.FillColor = System.Drawing.Color.White;
            this.exam_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_but.HoverState.Parent = this.exam_but;
            this.exam_but.Image = ((System.Drawing.Image)(resources.GetObject("exam_but.Image")));
            this.exam_but.ImageOffset = new System.Drawing.Point(14, -10);
            this.exam_but.ImageSize = new System.Drawing.Size(40, 40);
            this.exam_but.Location = new System.Drawing.Point(453, 2);
            this.exam_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.exam_but.Name = "exam_but";
            this.exam_but.Padding = new System.Windows.Forms.Padding(10);
            this.exam_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exam_but.ShadowDecoration.Parent = this.exam_but;
            this.exam_but.Size = new System.Drawing.Size(94, 75);
            this.exam_but.TabIndex = 2;
            this.exam_but.Text = "الكشف";
            this.exam_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.exam_but.Click += new System.EventHandler(this.exam_but_Click);
            // 
            // patient_but
            // 
            this.patient_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patient_but.BorderColor = System.Drawing.Color.White;
            this.patient_but.BorderRadius = 15;
            this.patient_but.BorderThickness = 5;
            this.patient_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.patient_but.CheckedState.Parent = this.patient_but;
            this.patient_but.CustomImages.Parent = this.patient_but;
            this.patient_but.FillColor = System.Drawing.Color.White;
            this.patient_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.patient_but.HoverState.Parent = this.patient_but;
            this.patient_but.Image = ((System.Drawing.Image)(resources.GetObject("patient_but.Image")));
            this.patient_but.ImageOffset = new System.Drawing.Point(16, -10);
            this.patient_but.ImageSize = new System.Drawing.Size(40, 40);
            this.patient_but.Location = new System.Drawing.Point(562, 2);
            this.patient_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.patient_but.Name = "patient_but";
            this.patient_but.Padding = new System.Windows.Forms.Padding(10);
            this.patient_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patient_but.ShadowDecoration.Parent = this.patient_but;
            this.patient_but.Size = new System.Drawing.Size(94, 75);
            this.patient_but.TabIndex = 1;
            this.patient_but.Text = "المرضى";
            this.patient_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.patient_but.Click += new System.EventHandler(this.patient_but_Click);
            // 
            // home_but
            // 
            this.home_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_but.BorderColor = System.Drawing.Color.White;
            this.home_but.BorderRadius = 15;
            this.home_but.BorderThickness = 5;
            this.home_but.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.home_but.CheckedState.Parent = this.home_but;
            this.home_but.CustomImages.Parent = this.home_but;
            this.home_but.FillColor = System.Drawing.Color.White;
            this.home_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.home_but.HoverState.Parent = this.home_but;
            this.home_but.Image = ((System.Drawing.Image)(resources.GetObject("home_but.Image")));
            this.home_but.ImageOffset = new System.Drawing.Point(10, -10);
            this.home_but.ImageSize = new System.Drawing.Size(40, 40);
            this.home_but.Location = new System.Drawing.Point(671, 2);
            this.home_but.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.home_but.Name = "home_but";
            this.home_but.Padding = new System.Windows.Forms.Padding(10);
            this.home_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.home_but.ShadowDecoration.Parent = this.home_but;
            this.home_but.Size = new System.Drawing.Size(94, 75);
            this.home_but.TabIndex = 0;
            this.home_but.Text = "بداية";
            this.home_but.TextOffset = new System.Drawing.Point(-12, 20);
            this.home_but.Click += new System.EventHandler(this.home_but_Click);
            // 
            // sessions_cont1
            // 
            this.sessions_cont1.AutoScroll = true;
            this.sessions_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessions_cont1.Location = new System.Drawing.Point(0, 0);
            this.sessions_cont1.Name = "sessions_cont1";
            this.sessions_cont1.Size = new System.Drawing.Size(785, 483);
            this.sessions_cont1.TabIndex = 6;
            // 
            // report_cont1
            // 
            this.report_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_cont1.Location = new System.Drawing.Point(0, 0);
            this.report_cont1.Name = "report_cont1";
            this.report_cont1.Size = new System.Drawing.Size(785, 483);
            this.report_cont1.TabIndex = 5;
            // 
            // patient_cont1
            // 
            this.patient_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patient_cont1.Location = new System.Drawing.Point(0, 0);
            this.patient_cont1.Name = "patient_cont1";
            this.patient_cont1.Size = new System.Drawing.Size(785, 483);
            this.patient_cont1.TabIndex = 4;
            // 
            // month_sced_cont1
            // 
            this.month_sced_cont1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.month_sced_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.month_sced_cont1.Location = new System.Drawing.Point(0, 0);
            this.month_sced_cont1.Name = "month_sced_cont1";
            this.month_sced_cont1.Size = new System.Drawing.Size(785, 483);
            this.month_sced_cont1.TabIndex = 3;
            // 
            // home_cont1
            // 
            this.home_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_cont1.Location = new System.Drawing.Point(0, 0);
            this.home_cont1.Name = "home_cont1";
            this.home_cont1.Size = new System.Drawing.Size(785, 483);
            this.home_cont1.TabIndex = 2;
            // 
            // exam_cont1
            // 
            this.exam_cont1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exam_cont1.Location = new System.Drawing.Point(0, 0);
            this.exam_cont1.Name = "exam_cont1";
            this.exam_cont1.Size = new System.Drawing.Size(785, 483);
            this.exam_cont1.TabIndex = 1;
            // 
            // doctors_contr1
            // 
            this.doctors_contr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctors_contr1.Location = new System.Drawing.Point(0, 0);
            this.doctors_contr1.Name = "doctors_contr1";
            this.doctors_contr1.Size = new System.Drawing.Size(785, 483);
            this.doctors_contr1.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.back_panel);
            this.Name = "main_form";
            this.Text = "main_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_FormClosed);
            this.back_panel.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back_panel;
        private Guna.UI2.WinForms.Guna2Panel top_panel;
        private Guna.UI2.WinForms.Guna2Button home_but;
        private Guna.UI2.WinForms.Guna2Button patient_but;
        private Guna.UI2.WinForms.Guna2Button reports_but;
        private Guna.UI2.WinForms.Guna2Button doctors_but;
        private Guna.UI2.WinForms.Guna2Button scedual_but;
        private Guna.UI2.WinForms.Guna2Button sessions_but;
        private Guna.UI2.WinForms.Guna2Button exam_but;
        private sessions_cont sessions_cont1;
        private report_cont report_cont1;
        private patient_cont patient_cont1;
        private month_sced_cont month_sced_cont1;
        private home_cont home_cont1;
        private exam_cont exam_cont1;
        private doctors_contr doctors_contr1;
    }
}