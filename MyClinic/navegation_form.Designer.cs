
namespace MyClinic
{
    partial class navegation_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.new_exam_but = new Guna.UI2.WinForms.Guna2Button();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.new_sess_but = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(159, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "هل تريد ....؟";
            // 
            // new_exam_but
            // 
            this.new_exam_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.new_exam_but.BorderRadius = 25;
            this.new_exam_but.CheckedState.Parent = this.new_exam_but;
            this.new_exam_but.CustomImages.Parent = this.new_exam_but;
            this.new_exam_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.new_exam_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_exam_but.ForeColor = System.Drawing.Color.White;
            this.new_exam_but.HoverState.Parent = this.new_exam_but;
            this.new_exam_but.Location = new System.Drawing.Point(331, 82);
            this.new_exam_but.Name = "new_exam_but";
            this.new_exam_but.ShadowDecoration.Parent = this.new_exam_but;
            this.new_exam_but.Size = new System.Drawing.Size(148, 55);
            this.new_exam_but.TabIndex = 31;
            this.new_exam_but.Text = "حجز كشف";
            this.new_exam_but.Click += new System.EventHandler(this.new_exam_but_Click);
            // 
            // done_but
            // 
            this.done_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.done_but.BorderRadius = 25;
            this.done_but.CheckedState.Parent = this.done_but;
            this.done_but.CustomImages.Parent = this.done_but;
            this.done_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.done_but.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.done_but.HoverState.Parent = this.done_but;
            this.done_but.ImageSize = new System.Drawing.Size(30, 30);
            this.done_but.Location = new System.Drawing.Point(8, 82);
            this.done_but.Name = "done_but";
            this.done_but.ShadowDecoration.Parent = this.done_but;
            this.done_but.Size = new System.Drawing.Size(148, 55);
            this.done_but.TabIndex = 30;
            this.done_but.Text = "تم";
            this.done_but.Click += new System.EventHandler(this.done_but_Click);
            // 
            // new_sess_but
            // 
            this.new_sess_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.new_sess_but.BorderRadius = 25;
            this.new_sess_but.CheckedState.Parent = this.new_sess_but;
            this.new_sess_but.CustomImages.Parent = this.new_sess_but;
            this.new_sess_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.new_sess_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_sess_but.ForeColor = System.Drawing.Color.White;
            this.new_sess_but.HoverState.Parent = this.new_sess_but;
            this.new_sess_but.Location = new System.Drawing.Point(177, 82);
            this.new_sess_but.Name = "new_sess_but";
            this.new_sess_but.ShadowDecoration.Parent = this.new_sess_but;
            this.new_sess_but.Size = new System.Drawing.Size(148, 55);
            this.new_sess_but.TabIndex = 33;
            this.new_sess_but.Text = "حجز جلسه";
            this.new_sess_but.Click += new System.EventHandler(this.new_sess_but_Click);
            // 
            // navegation_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(480, 161);
            this.Controls.Add(this.new_sess_but);
            this.Controls.Add(this.new_exam_but);
            this.Controls.Add(this.done_but);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "navegation_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "navegation_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button new_exam_but;
        private Guna.UI2.WinForms.Guna2Button done_but;
        private Guna.UI2.WinForms.Guna2Button new_sess_but;
    }
}