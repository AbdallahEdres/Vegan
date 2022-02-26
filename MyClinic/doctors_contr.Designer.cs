
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dr_list_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.edit_but = new Guna.UI2.WinForms.Guna2Button();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.dr_list_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dr_list_label = new System.Windows.Forms.Label();
            this.dr_details_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.no_appoint_label = new System.Windows.Forms.Label();
            this.end_date_bic = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_date_bic = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_date_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.speciality_val_label = new System.Windows.Forms.Label();
            this.days_val_label = new System.Windows.Forms.Label();
            this.phone_val_label = new System.Windows.Forms.Label();
            this.name_val_label = new System.Windows.Forms.Label();
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
            this.dr_list_panel.Location = new System.Drawing.Point(541, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 150;
            this.dr_list_panel.ShadowShift = 8;
            this.dr_list_panel.Size = new System.Drawing.Size(244, 483);
            this.dr_list_panel.TabIndex = 0;
            // 
            // edit_but
            // 
            this.edit_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_but.BorderRadius = 15;
            this.edit_but.CheckedState.Parent = this.edit_but;
            this.edit_but.CustomImages.Parent = this.edit_but;
            this.edit_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.edit_but.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.edit_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.edit_but.HoverState.Parent = this.edit_but;
            this.edit_but.Image = ((System.Drawing.Image)(resources.GetObject("edit_but.Image")));
            this.edit_but.ImageSize = new System.Drawing.Size(30, 30);
            this.edit_but.Location = new System.Drawing.Point(27, 412);
            this.edit_but.Name = "edit_but";
            this.edit_but.ShadowDecoration.Parent = this.edit_but;
            this.edit_but.Size = new System.Drawing.Size(80, 40);
            this.edit_but.TabIndex = 3;
            this.edit_but.Text = "تعديل";
            this.edit_but.Click += new System.EventHandler(this.edit_but_Click);
            // 
            // add_dr_but
            // 
            this.add_dr_but.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_dr_but.BorderRadius = 15;
            this.add_dr_but.CheckedState.Parent = this.add_dr_but;
            this.add_dr_but.CustomImages.Parent = this.add_dr_but;
            this.add_dr_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.add_dr_but.Font = new System.Drawing.Font("Tajawal", 10F, System.Drawing.FontStyle.Bold);
            this.add_dr_but.ForeColor = System.Drawing.Color.White;
            this.add_dr_but.HoverState.Parent = this.add_dr_but;
            this.add_dr_but.Image = ((System.Drawing.Image)(resources.GetObject("add_dr_but.Image")));
            this.add_dr_but.Location = new System.Drawing.Point(134, 412);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(80, 40);
            this.add_dr_but.TabIndex = 2;
            this.add_dr_but.Text = "إضافة";
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
            // 
            // dr_list_grid
            // 
            this.dr_list_grid.AllowUserToAddRows = false;
            this.dr_list_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal Medium", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dr_list_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dr_list_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dr_list_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dr_list_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dr_list_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dr_list_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dr_list_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dr_list_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dr_list_grid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tajawal Medium", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dr_list_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dr_list_grid.EnableHeadersVisualStyles = false;
            this.dr_list_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_list_grid.Location = new System.Drawing.Point(18, 67);
            this.dr_list_grid.Name = "dr_list_grid";
            this.dr_list_grid.ReadOnly = true;
            this.dr_list_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_list_grid.RowHeadersVisible = false;
            this.dr_list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dr_list_grid.Size = new System.Drawing.Size(211, 326);
            this.dr_list_grid.TabIndex = 1;
            this.dr_list_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 10F, System.Drawing.FontStyle.Bold);
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dr_list_grid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_list_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dr_list_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.dr_list_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dr_list_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dr_list_grid.ThemeStyle.HeaderStyle.Height = 50;
            this.dr_list_grid.ThemeStyle.ReadOnly = true;
            this.dr_list_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dr_list_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 10F, System.Drawing.FontStyle.Bold);
            this.dr_list_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_grid.ThemeStyle.RowsStyle.Height = 22;
            this.dr_list_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dr_list_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dr_list_grid_CellMouseClick);
            // 
            // dr_list_label
            // 
            this.dr_list_label.AutoSize = true;
            this.dr_list_label.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.dr_list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_list_label.Location = new System.Drawing.Point(62, 20);
            this.dr_list_label.Name = "dr_list_label";
            this.dr_list_label.Size = new System.Drawing.Size(123, 28);
            this.dr_list_label.TabIndex = 0;
            this.dr_list_label.Text = "قائمة الأطباء";
            // 
            // dr_details_panel
            // 
            this.dr_details_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dr_details_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_details_panel.Controls.Add(this.no_appoint_label);
            this.dr_details_panel.Controls.Add(this.end_date_bic);
            this.dr_details_panel.Controls.Add(this.start_date_bic);
            this.dr_details_panel.Controls.Add(this.end_date_label);
            this.dr_details_panel.Controls.Add(this.start_date_label);
            this.dr_details_panel.Controls.Add(this.flowLayoutPanel1);
            this.dr_details_panel.Controls.Add(this.guna2ShadowPanel1);
            this.dr_details_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_details_panel.Location = new System.Drawing.Point(3, 3);
            this.dr_details_panel.Name = "dr_details_panel";
            this.dr_details_panel.ShadowDecoration.Parent = this.dr_details_panel;
            this.dr_details_panel.Size = new System.Drawing.Size(530, 477);
            this.dr_details_panel.TabIndex = 0;
            // 
            // no_appoint_label
            // 
            this.no_appoint_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.no_appoint_label.AutoSize = true;
            this.no_appoint_label.Font = new System.Drawing.Font("Tajawal", 14F, System.Drawing.FontStyle.Bold);
            this.no_appoint_label.Location = new System.Drawing.Point(103, 216);
            this.no_appoint_label.Name = "no_appoint_label";
            this.no_appoint_label.Size = new System.Drawing.Size(255, 28);
            this.no_appoint_label.TabIndex = 0;
            this.no_appoint_label.Text = "لا يوجد جلسات في هذه الفتره";
            // 
            // end_date_bic
            // 
            this.end_date_bic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.end_date_bic.BorderRadius = 15;
            this.end_date_bic.CheckedState.Parent = this.end_date_bic;
            this.end_date_bic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.end_date_bic.Font = new System.Drawing.Font("Tajawal Medium", 8F, System.Drawing.FontStyle.Bold);
            this.end_date_bic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.end_date_bic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date_bic.HoverState.Parent = this.end_date_bic;
            this.end_date_bic.Location = new System.Drawing.Point(58, 168);
            this.end_date_bic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.end_date_bic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.end_date_bic.Name = "end_date_bic";
            this.end_date_bic.ShadowDecoration.Parent = this.end_date_bic;
            this.end_date_bic.Size = new System.Drawing.Size(129, 36);
            this.end_date_bic.TabIndex = 7;
            this.end_date_bic.Value = new System.DateTime(2021, 12, 11, 15, 39, 0, 336);
            this.end_date_bic.ValueChanged += new System.EventHandler(this.start_date_bic_ValueChanged);
            // 
            // start_date_bic
            // 
            this.start_date_bic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_date_bic.BorderRadius = 15;
            this.start_date_bic.CheckedState.Parent = this.start_date_bic;
            this.start_date_bic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.start_date_bic.Font = new System.Drawing.Font("Tajawal Medium", 8F, System.Drawing.FontStyle.Bold);
            this.start_date_bic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.start_date_bic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_date_bic.HoverState.Parent = this.start_date_bic;
            this.start_date_bic.Location = new System.Drawing.Point(256, 168);
            this.start_date_bic.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.start_date_bic.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.start_date_bic.Name = "start_date_bic";
            this.start_date_bic.ShadowDecoration.Parent = this.start_date_bic;
            this.start_date_bic.Size = new System.Drawing.Size(122, 36);
            this.start_date_bic.TabIndex = 6;
            this.start_date_bic.Value = new System.DateTime(2021, 12, 11, 15, 38, 58, 789);
            this.start_date_bic.ValueChanged += new System.EventHandler(this.start_date_bic_ValueChanged);
            // 
            // end_date_label
            // 
            this.end_date_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.end_date_label.Location = new System.Drawing.Point(196, 174);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.end_date_label.Size = new System.Drawing.Size(29, 18);
            this.end_date_label.TabIndex = 5;
            this.end_date_label.Text = "الي :";
            // 
            // start_date_label
            // 
            this.start_date_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.start_date_label.AutoSize = true;
            this.start_date_label.BackColor = System.Drawing.Color.Transparent;
            this.start_date_label.Font = new System.Drawing.Font("Tajawal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start_date_label.Location = new System.Drawing.Point(384, 174);
            this.start_date_label.Name = "start_date_label";
            this.start_date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.start_date_label.Size = new System.Drawing.Size(30, 18);
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
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 264);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.speciality_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.days_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.phone_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.name_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.EdgeWidth = 2;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2ShadowPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(-3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 150;
            this.guna2ShadowPanel1.ShadowShift = 7;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(530, 159);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // speciality_val_label
            // 
            this.speciality_val_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.speciality_val_label.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold);
            this.speciality_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speciality_val_label.Location = new System.Drawing.Point(26, 82);
            this.speciality_val_label.Name = "speciality_val_label";
            this.speciality_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speciality_val_label.Size = new System.Drawing.Size(137, 51);
            this.speciality_val_label.TabIndex = 7;
            this.speciality_val_label.Text = "علاج طبيعي";
            // 
            // days_val_label
            // 
            this.days_val_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.days_val_label.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold);
            this.days_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.days_val_label.Location = new System.Drawing.Point(26, 33);
            this.days_val_label.Name = "days_val_label";
            this.days_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.days_val_label.Size = new System.Drawing.Size(133, 48);
            this.days_val_label.TabIndex = 6;
            this.days_val_label.Text = "السبت ,الإثنين ,الأربعاء";
            // 
            // phone_val_label
            // 
            this.phone_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_val_label.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold);
            this.phone_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_val_label.Location = new System.Drawing.Point(311, 81);
            this.phone_val_label.Name = "phone_val_label";
            this.phone_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_val_label.Size = new System.Drawing.Size(142, 29);
            this.phone_val_label.TabIndex = 5;
            this.phone_val_label.Text = "01009289565";
            // 
            // name_val_label
            // 
            this.name_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_val_label.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold);
            this.name_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_val_label.Location = new System.Drawing.Point(247, 33);
            this.name_val_label.Name = "name_val_label";
            this.name_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_val_label.Size = new System.Drawing.Size(206, 29);
            this.name_val_label.TabIndex = 4;
            this.name_val_label.Text = "عبد الله احمد ادريس";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(159, 81);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "التخصص :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(159, 33);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "الأيام :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(447, 80);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "الهاتف :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(447, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 24);
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
            this.Size = new System.Drawing.Size(785, 483);
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
        private System.Windows.Forms.Label speciality_val_label;
        private System.Windows.Forms.Label days_val_label;
        private System.Windows.Forms.Label phone_val_label;
        private System.Windows.Forms.Label name_val_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label start_date_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker end_date_bic;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_date_bic;
        private System.Windows.Forms.Label no_appoint_label;
    }
}
