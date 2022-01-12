
namespace MyClinic
{
    partial class edit_session_form
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
            this.Date_label = new System.Windows.Forms.Label();
            this.start_date_bick = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.time_label = new System.Windows.Forms.Label();
            this.dr_label = new System.Windows.Forms.Label();
            this.dr_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.ptnt_list_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hr_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.am_pm_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).BeginInit();
            this.SuspendLayout();
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.Date_label.Location = new System.Drawing.Point(455, 246);
            this.Date_label.Name = "Date_label";
            this.Date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_label.Size = new System.Drawing.Size(145, 31);
            this.Date_label.TabIndex = 41;
            this.Date_label.Text = "تعديل التاريخ :";
            // 
            // start_date_bick
            // 
            this.start_date_bick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_date_bick.BorderRadius = 15;
            this.start_date_bick.CheckedState.Parent = this.start_date_bick;
            this.start_date_bick.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.start_date_bick.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_bick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.start_date_bick.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.start_date_bick.HoverState.Parent = this.start_date_bick;
            this.start_date_bick.Location = new System.Drawing.Point(69, 246);
            this.start_date_bick.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.start_date_bick.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.start_date_bick.Name = "start_date_bick";
            this.start_date_bick.ShadowDecoration.Parent = this.start_date_bick;
            this.start_date_bick.Size = new System.Drawing.Size(282, 36);
            this.start_date_bick.TabIndex = 40;
            this.start_date_bick.Value = new System.DateTime(2021, 12, 11, 15, 39, 0, 336);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.time_label.Location = new System.Drawing.Point(455, 177);
            this.time_label.Name = "time_label";
            this.time_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_label.Size = new System.Drawing.Size(152, 31);
            this.time_label.TabIndex = 39;
            this.time_label.Text = "تعديل الساعه :";
            // 
            // dr_label
            // 
            this.dr_label.AutoSize = true;
            this.dr_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_label.Location = new System.Drawing.Point(455, 108);
            this.dr_label.Name = "dr_label";
            this.dr_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_label.Size = new System.Drawing.Size(153, 31);
            this.dr_label.TabIndex = 38;
            this.dr_label.Text = "تعديل الطبيب :";
            // 
            // dr_combo
            // 
            this.dr_combo.BackColor = System.Drawing.Color.Transparent;
            this.dr_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.dr_combo.BorderRadius = 15;
            this.dr_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dr_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dr_combo.FocusedColor = System.Drawing.Color.Empty;
            this.dr_combo.FocusedState.Parent = this.dr_combo;
            this.dr_combo.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_combo.FormattingEnabled = true;
            this.dr_combo.HoverState.Parent = this.dr_combo;
            this.dr_combo.ItemHeight = 30;
            this.dr_combo.ItemsAppearance.Parent = this.dr_combo;
            this.dr_combo.Location = new System.Drawing.Point(69, 108);
            this.dr_combo.Name = "dr_combo";
            this.dr_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_combo.ShadowDecoration.Parent = this.dr_combo;
            this.dr_combo.Size = new System.Drawing.Size(282, 36);
            this.dr_combo.TabIndex = 36;
            // 
            // done_but
            // 
            this.done_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.done_but.BorderRadius = 25;
            this.done_but.CheckedState.Parent = this.done_but;
            this.done_but.CustomImages.Parent = this.done_but;
            this.done_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.done_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_but.ForeColor = System.Drawing.Color.White;
            this.done_but.HoverState.Parent = this.done_but;
            this.done_but.Location = new System.Drawing.Point(409, 357);
            this.done_but.Name = "done_but";
            this.done_but.ShadowDecoration.Parent = this.done_but;
            this.done_but.Size = new System.Drawing.Size(153, 55);
            this.done_but.TabIndex = 43;
            this.done_but.Text = "تم";
            this.done_but.Click += new System.EventHandler(this.done_but_Click);
            // 
            // cansel_but
            // 
            this.cansel_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cansel_but.BorderRadius = 25;
            this.cansel_but.CheckedState.Parent = this.cansel_but;
            this.cansel_but.CustomImages.Parent = this.cansel_but;
            this.cansel_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.cansel_but.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cansel_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.cansel_but.HoverState.Parent = this.cansel_but;
            this.cansel_but.ImageSize = new System.Drawing.Size(30, 30);
            this.cansel_but.Location = new System.Drawing.Point(152, 357);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(153, 55);
            this.cansel_but.TabIndex = 42;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // ptnt_list_label
            // 
            this.ptnt_list_label.AutoSize = true;
            this.ptnt_list_label.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnt_list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_label.Location = new System.Drawing.Point(273, 9);
            this.ptnt_list_label.Name = "ptnt_list_label";
            this.ptnt_list_label.Size = new System.Drawing.Size(185, 40);
            this.ptnt_list_label.TabIndex = 44;
            this.ptnt_list_label.Text = "تعديل الجلسه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(181, 182);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "ساعه :";
            // 
            // hr_num
            // 
            this.hr_num.BackColor = System.Drawing.Color.Transparent;
            this.hr_num.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.hr_num.BorderRadius = 15;
            this.hr_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hr_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hr_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hr_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hr_num.DisabledState.Parent = this.hr_num;
            this.hr_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.hr_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.hr_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hr_num.FocusedState.Parent = this.hr_num;
            this.hr_num.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hr_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.hr_num.Location = new System.Drawing.Point(66, 176);
            this.hr_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hr_num.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hr_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hr_num.Name = "hr_num";
            this.hr_num.ShadowDecoration.Parent = this.hr_num;
            this.hr_num.Size = new System.Drawing.Size(76, 36);
            this.hr_num.TabIndex = 72;
            this.hr_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.hr_num.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.hr_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // am_pm_combo
            // 
            this.am_pm_combo.BackColor = System.Drawing.Color.Transparent;
            this.am_pm_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.am_pm_combo.BorderRadius = 15;
            this.am_pm_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.am_pm_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.am_pm_combo.FocusedColor = System.Drawing.Color.Empty;
            this.am_pm_combo.FocusedState.Parent = this.am_pm_combo;
            this.am_pm_combo.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.am_pm_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.am_pm_combo.FormattingEnabled = true;
            this.am_pm_combo.HoverState.Parent = this.am_pm_combo;
            this.am_pm_combo.ItemHeight = 30;
            this.am_pm_combo.Items.AddRange(new object[] {
            "PM",
            "AM"});
            this.am_pm_combo.ItemsAppearance.Parent = this.am_pm_combo;
            this.am_pm_combo.Location = new System.Drawing.Point(279, 176);
            this.am_pm_combo.Name = "am_pm_combo";
            this.am_pm_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.am_pm_combo.ShadowDecoration.Parent = this.am_pm_combo;
            this.am_pm_combo.Size = new System.Drawing.Size(71, 36);
            this.am_pm_combo.TabIndex = 71;
            // 
            // edit_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hr_num);
            this.Controls.Add(this.am_pm_combo);
            this.Controls.Add(this.ptnt_list_label);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.start_date_bick);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.dr_label);
            this.Controls.Add(this.dr_combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_session_form";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit_session_form";
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_date_bick;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label dr_label;
        private Guna.UI2.WinForms.Guna2ComboBox dr_combo;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
        private System.Windows.Forms.Label ptnt_list_label;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown hr_num;
        private Guna.UI2.WinForms.Guna2ComboBox am_pm_combo;
    }
}