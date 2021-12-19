
namespace MyClinic
{
    partial class edit_date_form
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
            this.exam_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_label = new System.Windows.Forms.Label();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // exam_date
            // 
            this.exam_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exam_date.BorderRadius = 15;
            this.exam_date.CheckedState.Parent = this.exam_date;
            this.exam_date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_date.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.exam_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.exam_date.HoverState.Parent = this.exam_date;
            this.exam_date.Location = new System.Drawing.Point(26, 64);
            this.exam_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.exam_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.exam_date.Name = "exam_date";
            this.exam_date.ShadowDecoration.Parent = this.exam_date;
            this.exam_date.Size = new System.Drawing.Size(355, 36);
            this.exam_date.TabIndex = 40;
            this.exam_date.Value = new System.DateTime(2021, 12, 11, 15, 38, 58, 789);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.date_label.Location = new System.Drawing.Point(109, 9);
            this.date_label.Name = "date_label";
            this.date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_label.Size = new System.Drawing.Size(173, 31);
            this.date_label.TabIndex = 39;
            this.date_label.Text = "اختر التاريخ الجديد";
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
            this.done_but.Location = new System.Drawing.Point(218, 122);
            this.done_but.Name = "done_but";
            this.done_but.ShadowDecoration.Parent = this.done_but;
            this.done_but.Size = new System.Drawing.Size(102, 55);
            this.done_but.TabIndex = 42;
            this.done_but.Text = " تم";
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
            this.cansel_but.Location = new System.Drawing.Point(63, 122);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(102, 55);
            this.cansel_but.TabIndex = 43;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // edit_date_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 189);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.exam_date);
            this.Controls.Add(this.date_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_date_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "edit_date_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker exam_date;
        private System.Windows.Forms.Label date_label;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
    }
}