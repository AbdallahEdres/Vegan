
namespace MyClinic
{
    partial class edit_time_form
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
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.time_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.min_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.hr_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.am_pm_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.min_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).BeginInit();
            this.SuspendLayout();
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
            this.cansel_but.Location = new System.Drawing.Point(71, 133);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(102, 55);
            this.cansel_but.TabIndex = 5;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
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
            this.done_but.Location = new System.Drawing.Point(226, 133);
            this.done_but.Name = "done_but";
            this.done_but.ShadowDecoration.Parent = this.done_but;
            this.done_but.Size = new System.Drawing.Size(102, 55);
            this.done_but.TabIndex = 4;
            this.done_but.Text = " تم";
            this.done_but.Click += new System.EventHandler(this.done_but_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.time_label.Location = new System.Drawing.Point(111, 9);
            this.time_label.Name = "time_label";
            this.time_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_label.Size = new System.Drawing.Size(175, 31);
            this.time_label.TabIndex = 44;
            this.time_label.Text = "اختر االوقت الجديد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(100, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "ساعه :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(239, 83);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "دقيقه:";
            // 
            // min_num
            // 
            this.min_num.BackColor = System.Drawing.Color.Transparent;
            this.min_num.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.min_num.BorderRadius = 15;
            this.min_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.min_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.min_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.min_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.min_num.DisabledState.Parent = this.min_num;
            this.min_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.min_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.min_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.min_num.FocusedState.Parent = this.min_num;
            this.min_num.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.min_num.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.min_num.Location = new System.Drawing.Point(167, 76);
            this.min_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.min_num.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.min_num.Name = "min_num";
            this.min_num.ShadowDecoration.Parent = this.min_num;
            this.min_num.Size = new System.Drawing.Size(73, 36);
            this.min_num.TabIndex = 2;
            this.min_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.min_num.UpDownButtonForeColor = System.Drawing.Color.Black;
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
            this.hr_num.Location = new System.Drawing.Point(24, 76);
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
            this.hr_num.TabIndex = 1;
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
            this.am_pm_combo.Location = new System.Drawing.Point(308, 76);
            this.am_pm_combo.Name = "am_pm_combo";
            this.am_pm_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.am_pm_combo.ShadowDecoration.Parent = this.am_pm_combo;
            this.am_pm_combo.Size = new System.Drawing.Size(71, 36);
            this.am_pm_combo.TabIndex = 3;
            // 
            // edit_time_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min_num);
            this.Controls.Add(this.hr_num);
            this.Controls.Add(this.am_pm_combo);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.time_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_time_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit_time_form";
            ((System.ComponentModel.ISupportInitialize)(this.min_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button cansel_but;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown min_num;
        private Guna.UI2.WinForms.Guna2NumericUpDown hr_num;
        private Guna.UI2.WinForms.Guna2ComboBox am_pm_combo;
    }
}