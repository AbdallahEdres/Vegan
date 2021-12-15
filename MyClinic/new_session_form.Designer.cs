
namespace MyClinic
{
    partial class new_session_form
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
            this.new_sessions_label = new System.Windows.Forms.Label();
            this.dr_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dr_label = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_Date_label = new System.Windows.Forms.Label();
            this.time_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.time_label = new System.Windows.Forms.Label();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // new_sessions_label
            // 
            this.new_sessions_label.AutoSize = true;
            this.new_sessions_label.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_sessions_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.new_sessions_label.Location = new System.Drawing.Point(827, 9);
            this.new_sessions_label.Name = "new_sessions_label";
            this.new_sessions_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.new_sessions_label.Size = new System.Drawing.Size(239, 47);
            this.new_sessions_label.TabIndex = 29;
            this.new_sessions_label.Text = "تحديد الجلسات";
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
            this.dr_combo.Location = new System.Drawing.Point(637, 74);
            this.dr_combo.Name = "dr_combo";
            this.dr_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_combo.ShadowDecoration.Parent = this.dr_combo;
            this.dr_combo.Size = new System.Drawing.Size(282, 36);
            this.dr_combo.TabIndex = 30;
            // 
            // dr_label
            // 
            this.dr_label.AutoSize = true;
            this.dr_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_label.Location = new System.Drawing.Point(1088, 79);
            this.dr_label.Name = "dr_label";
            this.dr_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_label.Size = new System.Drawing.Size(131, 31);
            this.dr_label.TabIndex = 32;
            this.dr_label.Text = "اختر الطبيب :";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2DateTimePicker2.BorderRadius = 15;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(637, 217);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(282, 36);
            this.guna2DateTimePicker2.TabIndex = 34;
            this.guna2DateTimePicker2.Value = new System.DateTime(2021, 12, 11, 15, 39, 0, 336);
            // 
            // start_Date_label
            // 
            this.start_Date_label.AutoSize = true;
            this.start_Date_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.start_Date_label.Location = new System.Drawing.Point(1088, 222);
            this.start_Date_label.Name = "start_Date_label";
            this.start_Date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_Date_label.Size = new System.Drawing.Size(113, 31);
            this.start_Date_label.TabIndex = 35;
            this.start_Date_label.Text = "تاريخ البدأ :";
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
            this.time_combo.ItemsAppearance.Parent = this.time_combo;
            this.time_combo.Location = new System.Drawing.Point(637, 143);
            this.time_combo.Name = "time_combo";
            this.time_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_combo.ShadowDecoration.Parent = this.time_combo;
            this.time_combo.Size = new System.Drawing.Size(282, 36);
            this.time_combo.TabIndex = 31;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.time_label.Location = new System.Drawing.Point(1088, 146);
            this.time_label.Name = "time_label";
            this.time_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_label.Size = new System.Drawing.Size(130, 31);
            this.time_label.TabIndex = 33;
            this.time_label.Text = "اختر الساعه :";
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
            this.done_but.Location = new System.Drawing.Point(691, 464);
            this.done_but.Name = "done_but";
            this.done_but.ShadowDecoration.Parent = this.done_but;
            this.done_but.Size = new System.Drawing.Size(153, 55);
            this.done_but.TabIndex = 39;
            this.done_but.Text = "تم";
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
            this.cansel_but.Location = new System.Drawing.Point(434, 464);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(153, 55);
            this.cansel_but.TabIndex = 36;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // new_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 565);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.start_Date_label);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.dr_label);
            this.Controls.Add(this.time_combo);
            this.Controls.Add(this.dr_combo);
            this.Controls.Add(this.new_sessions_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_session_form";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "new_session_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_sessions_label;
        private Guna.UI2.WinForms.Guna2ComboBox dr_combo;
        private System.Windows.Forms.Label dr_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label start_Date_label;
        private Guna.UI2.WinForms.Guna2ComboBox time_combo;
        private System.Windows.Forms.Label time_label;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
    }
}