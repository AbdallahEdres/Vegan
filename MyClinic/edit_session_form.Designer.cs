
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
            this.time_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dr_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.ptnt_list_label = new System.Windows.Forms.Label();
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
            this.start_date_bick.Location = new System.Drawing.Point(69, 249);
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
            // time_combo
            // 
            this.time_combo.BackColor = System.Drawing.Color.Transparent;
            this.time_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.time_combo.BorderRadius = 15;
            this.time_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.time_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_combo.FocusedColor = System.Drawing.Color.Empty;
            this.time_combo.FocusedState.Parent = this.time_combo;
            this.time_combo.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.time_combo.FormattingEnabled = true;
            this.time_combo.HoverState.Parent = this.time_combo;
            this.time_combo.ItemHeight = 30;
            this.time_combo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.time_combo.ItemsAppearance.Parent = this.time_combo;
            this.time_combo.Location = new System.Drawing.Point(69, 177);
            this.time_combo.Name = "time_combo";
            this.time_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_combo.ShadowDecoration.Parent = this.time_combo;
            this.time_combo.Size = new System.Drawing.Size(282, 36);
            this.time_combo.TabIndex = 37;
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
            this.done_but.Location = new System.Drawing.Point(445, 357);
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
            this.cansel_but.Location = new System.Drawing.Point(188, 357);
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
            // edit_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 424);
            this.Controls.Add(this.ptnt_list_label);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.start_date_bick);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.dr_label);
            this.Controls.Add(this.time_combo);
            this.Controls.Add(this.dr_combo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_session_form";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit_session_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Date_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_date_bick;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label dr_label;
        private Guna.UI2.WinForms.Guna2ComboBox time_combo;
        private Guna.UI2.WinForms.Guna2ComboBox dr_combo;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
        private System.Windows.Forms.Label ptnt_list_label;
    }
}