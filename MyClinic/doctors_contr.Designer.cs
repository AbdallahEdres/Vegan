
namespace MyClinic
{
    partial class doctors_contr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctors_contr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dr_list_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.edit_but = new Guna.UI2.WinForms.Guna2Button();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.dr_list_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dr_list_label = new System.Windows.Forms.Label();
            this.dr_details_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dr_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_list_grid)).BeginInit();
            this.dr_details_panel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dr_list_panel
            // 
            this.dr_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.dr_list_panel.Controls.Add(this.edit_but);
            this.dr_list_panel.Controls.Add(this.add_dr_but);
            this.dr_list_panel.Controls.Add(this.dr_list_grid);
            this.dr_list_panel.Controls.Add(this.dr_list_label);
            this.dr_list_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dr_list_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_panel.Location = new System.Drawing.Point(912, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 150;
            this.dr_list_panel.ShadowShift = 8;
            this.dr_list_panel.Size = new System.Drawing.Size(353, 565);
            this.dr_list_panel.TabIndex = 0;
            // 
            // edit_but
            // 
            this.edit_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_but.BorderRadius = 25;
            this.edit_but.CheckedState.Parent = this.edit_but;
            this.edit_but.CustomImages.Parent = this.edit_but;
            this.edit_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.edit_but.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.edit_but.HoverState.Parent = this.edit_but;
            this.edit_but.Image = ((System.Drawing.Image)(resources.GetObject("edit_but.Image")));
            this.edit_but.ImageSize = new System.Drawing.Size(30, 30);
            this.edit_but.Location = new System.Drawing.Point(52, 474);
            this.edit_but.Name = "edit_but";
            this.edit_but.ShadowDecoration.Parent = this.edit_but;
            this.edit_but.Size = new System.Drawing.Size(102, 55);
            this.edit_but.TabIndex = 3;
            this.edit_but.Text = "تعديل";
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // add_dr_but
            // 
            this.add_dr_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_dr_but.BorderRadius = 25;
            this.add_dr_but.CheckedState.Parent = this.add_dr_but;
            this.add_dr_but.CustomImages.Parent = this.add_dr_but;
            this.add_dr_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.add_dr_but.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_dr_but.ForeColor = System.Drawing.Color.White;
            this.add_dr_but.HoverState.Parent = this.add_dr_but;
            this.add_dr_but.Image = ((System.Drawing.Image)(resources.GetObject("add_dr_but.Image")));
            this.add_dr_but.Location = new System.Drawing.Point(212, 474);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(102, 55);
            this.add_dr_but.TabIndex = 2;
            this.add_dr_but.Text = "إضافة";
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
            // 
            // dr_list_grid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dr_list_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dr_list_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dr_list_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dr_list_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dr_list_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dr_list_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dr_list_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dr_list_grid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dr_list_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dr_list_grid.EnableHeadersVisualStyles = false;
            this.dr_list_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_list_grid.Location = new System.Drawing.Point(21, 67);
            this.dr_list_grid.Name = "dr_list_grid";
            this.dr_list_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_list_grid.RowHeadersVisible = false;
            this.dr_list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dr_list_grid.Size = new System.Drawing.Size(312, 393);
            this.dr_list_grid.TabIndex = 1;
            this.dr_list_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dr_list_grid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_list_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dr_list_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dr_list_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dr_list_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dr_list_grid.ThemeStyle.HeaderStyle.Height = 4;
            this.dr_list_grid.ThemeStyle.ReadOnly = false;
            this.dr_list_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dr_list_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dr_list_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dr_list_grid.ThemeStyle.RowsStyle.Height = 22;
            this.dr_list_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_list_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dr_list_label
            // 
            this.dr_list_label.AutoSize = true;
            this.dr_list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_label.Location = new System.Drawing.Point(79, 8);
            this.dr_list_label.Name = "dr_list_label";
            this.dr_list_label.Size = new System.Drawing.Size(205, 47);
            this.dr_list_label.TabIndex = 0;
            this.dr_list_label.Text = "قائمة الأطباء";
            // 
            // dr_details_panel
            // 
            this.dr_details_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dr_details_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_details_panel.Controls.Add(this.guna2DateTimePicker2);
            this.dr_details_panel.Controls.Add(this.guna2DateTimePicker1);
            this.dr_details_panel.Controls.Add(this.end_date_label);
            this.dr_details_panel.Controls.Add(this.start_date_label);
            this.dr_details_panel.Controls.Add(this.flowLayoutPanel1);
            this.dr_details_panel.Controls.Add(this.guna2ShadowPanel1);
            this.dr_details_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_details_panel.Location = new System.Drawing.Point(3, 3);
            this.dr_details_panel.Name = "dr_details_panel";
            this.dr_details_panel.ShadowDecoration.Parent = this.dr_details_panel;
            this.dr_details_panel.Size = new System.Drawing.Size(903, 559);
            this.dr_details_panel.TabIndex = 0;
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
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(472, 233);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(262, 36);
            this.guna2DateTimePicker2.TabIndex = 7;
            this.guna2DateTimePicker2.Value = new System.DateTime(2021, 12, 11, 15, 39, 0, 336);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2DateTimePicker1.BorderRadius = 15;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(59, 233);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(262, 36);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 12, 11, 15, 38, 58, 789);
            // 
            // end_date_label
            // 
            this.end_date_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(342, 236);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_label.Size = new System.Drawing.Size(49, 26);
            this.end_date_label.TabIndex = 5;
            this.end_date_label.Text = "الي :";
            // 
            // start_date_label
            // 
            this.start_date_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_date_label.AutoSize = true;
            this.start_date_label.BackColor = System.Drawing.Color.Transparent;
            this.start_date_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_date_label.Location = new System.Drawing.Point(759, 233);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_label.Size = new System.Drawing.Size(54, 29);
            this.start_date_label.TabIndex = 4;
            this.start_date_label.Text = "من :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 263);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.EdgeWidth = 2;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2ShadowPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(27, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 25;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 150;
            this.guna2ShadowPanel1.ShadowShift = 7;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(854, 208);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(107, 136);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "علاج طبيعي";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 31);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(235, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "السبت ,الإثنين ,الأربعاء";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(570, 136);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "01009289565";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(508, 31);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "عبد الله احمد ادريس";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(240, 128);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "التخصص :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(240, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(93, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "الأيام :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(709, 128);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "الهاتف :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(709, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "الإسم :";
            // 
            // doctors_contr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dr_details_panel);
            this.Controls.Add(this.dr_list_panel);
            this.Location = new System.Drawing.Point(0, 117);
            this.Name = "doctors_contr";
            this.Size = new System.Drawing.Size(1265, 565);
            this.dr_list_panel.ResumeLayout(false);
            this.dr_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_list_grid)).EndInit();
            this.dr_details_panel.ResumeLayout(false);
            this.dr_details_panel.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel dr_list_panel;
        private Guna.UI2.WinForms.Guna2Panel dr_details_panel;
        private Guna.UI2.WinForms.Guna2Button edit_but;
        private Guna.UI2.WinForms.Guna2Button add_dr_but;
        private Guna.UI2.WinForms.Guna2DataGridView dr_list_grid;
        private System.Windows.Forms.Label dr_list_label;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label start_date_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}
