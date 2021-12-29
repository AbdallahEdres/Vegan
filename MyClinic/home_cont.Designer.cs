
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ptnt_count_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.dr_list_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dr_list_panel
            // 
            this.dr_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.dr_list_panel.Controls.Add(this.flowLayoutPanel1);
            this.dr_list_panel.Controls.Add(this.ptnt_count_label);
            this.dr_list_panel.Controls.Add(this.day_label);
            this.dr_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dr_list_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_panel.Location = new System.Drawing.Point(0, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 200;
            this.dr_list_panel.ShadowShift = 10;
            this.dr_list_panel.Size = new System.Drawing.Size(1265, 565);
            this.dr_list_panel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1206, 395);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ptnt_count_label
            // 
            this.ptnt_count_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptnt_count_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_count_label.Location = new System.Drawing.Point(135, 60);
            this.ptnt_count_label.Name = "ptnt_count_label";
            this.ptnt_count_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ptnt_count_label.Size = new System.Drawing.Size(378, 47);
            this.ptnt_count_label.TabIndex = 1;
            // 
            // day_label
            // 
            this.day_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.day_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.day_label.Location = new System.Drawing.Point(716, 60);
            this.day_label.Name = "day_label";
            this.day_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.day_label.Size = new System.Drawing.Size(378, 47);
            this.day_label.TabIndex = 0;
            // 
            // home_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dr_list_panel);
            this.Location = new System.Drawing.Point(0, 117);
            this.Name = "home_cont";
            this.Size = new System.Drawing.Size(1265, 565);
            this.Load += new System.EventHandler(this.home_cont_Load);
            this.dr_list_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel dr_list_panel;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label ptnt_count_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
