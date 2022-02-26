
namespace MyClinic
{
    partial class home_cont
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dr_list_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.no_sess_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pay_label = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.day_label = new System.Windows.Forms.Label();
            this.ptnt_count_label = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dr_list_panel.SuspendLayout();
            this.no_sess_panel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dr_list_panel
            // 
            this.dr_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.dr_list_panel.Controls.Add(this.no_sess_panel);
            this.dr_list_panel.Controls.Add(this.guna2ShadowPanel1);
            this.dr_list_panel.Controls.Add(this.guna2ShadowPanel2);
            this.dr_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dr_list_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_panel.Location = new System.Drawing.Point(0, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 200;
            this.dr_list_panel.ShadowShift = 10;
            this.dr_list_panel.Size = new System.Drawing.Size(785, 483);
            this.dr_list_panel.TabIndex = 2;
            // 
            // no_sess_panel
            // 
            this.no_sess_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.no_sess_panel.BackColor = System.Drawing.Color.Transparent;
            this.no_sess_panel.Controls.Add(this.pay_label);
            this.no_sess_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.no_sess_panel.Location = new System.Drawing.Point(17, 126);
            this.no_sess_panel.Name = "no_sess_panel";
            this.no_sess_panel.Radius = 20;
            this.no_sess_panel.ShadowColor = System.Drawing.Color.Black;
            this.no_sess_panel.ShadowDepth = 200;
            this.no_sess_panel.ShadowShift = 15;
            this.no_sess_panel.Size = new System.Drawing.Size(751, 344);
            this.no_sess_panel.TabIndex = 5;
            // 
            // pay_label
            // 
            this.pay_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pay_label.AutoSize = true;
            this.pay_label.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.pay_label.Location = new System.Drawing.Point(243, 161);
            this.pay_label.Name = "pay_label";
            this.pay_label.Size = new System.Drawing.Size(295, 36);
            this.pay_label.TabIndex = 14;
            this.pay_label.Text = "لا يوجد جلسات قادمة اليوم";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.day_label);
            this.guna2ShadowPanel1.Controls.Add(this.ptnt_count_label);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(63, 23);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(667, 100);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // day_label
            // 
            this.day_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.day_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.day_label.Location = new System.Drawing.Point(339, 25);
            this.day_label.Name = "day_label";
            this.day_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.day_label.Size = new System.Drawing.Size(293, 47);
            this.day_label.TabIndex = 0;
            // 
            // ptnt_count_label
            // 
            this.ptnt_count_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptnt_count_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnt_count_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_count_label.Location = new System.Drawing.Point(25, 25);
            this.ptnt_count_label.Name = "ptnt_count_label";
            this.ptnt_count_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ptnt_count_label.Size = new System.Drawing.Size(293, 47);
            this.ptnt_count_label.TabIndex = 1;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.flowLayoutPanel1);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(20, 129);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 20;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 200;
            this.guna2ShadowPanel2.ShadowShift = 15;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(751, 344);
            this.guna2ShadowPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(667, 297);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // home_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dr_list_panel);
            this.Location = new System.Drawing.Point(0, 117);
            this.Name = "home_cont";
            this.Size = new System.Drawing.Size(785, 483);
            this.Load += new System.EventHandler(this.home_cont_Load);
            this.dr_list_panel.ResumeLayout(false);
            this.no_sess_panel.ResumeLayout(false);
            this.no_sess_panel.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel dr_list_panel;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label ptnt_count_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel no_sess_panel;
        private System.Windows.Forms.Label pay_label;
    }
}
