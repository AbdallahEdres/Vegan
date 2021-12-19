
namespace MyClinic
{
    partial class exam_cont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exam_cont));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.everyday_label = new System.Windows.Forms.Label();
            this.today_label = new System.Windows.Forms.Label();
            this.days_switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.nutrition_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.physical_raadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.all_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.search_pic = new System.Windows.Forms.PictureBox();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.exam_label = new System.Windows.Forms.Label();
            this.exam_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.exam_grid);
            this.guna2ShadowPanel1.Controls.Add(this.add_dr_but);
            this.guna2ShadowPanel1.Controls.Add(this.everyday_label);
            this.guna2ShadowPanel1.Controls.Add(this.today_label);
            this.guna2ShadowPanel1.Controls.Add(this.days_switch);
            this.guna2ShadowPanel1.Controls.Add(this.nutrition_radio);
            this.guna2ShadowPanel1.Controls.Add(this.physical_raadio);
            this.guna2ShadowPanel1.Controls.Add(this.all_radio);
            this.guna2ShadowPanel1.Controls.Add(this.search_pic);
            this.guna2ShadowPanel1.Controls.Add(this.search_txt);
            this.guna2ShadowPanel1.Controls.Add(this.exam_label);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2ShadowPanel1.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 150;
            this.guna2ShadowPanel1.ShadowShift = 8;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1265, 565);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // add_dr_but
            // 
            this.add_dr_but.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_dr_but.BorderRadius = 25;
            this.add_dr_but.CheckedState.Parent = this.add_dr_but;
            this.add_dr_but.CustomImages.Parent = this.add_dr_but;
            this.add_dr_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.add_dr_but.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_dr_but.ForeColor = System.Drawing.Color.White;
            this.add_dr_but.HoverState.Parent = this.add_dr_but;
            this.add_dr_but.Image = ((System.Drawing.Image)(resources.GetObject("add_dr_but.Image")));
            this.add_dr_but.ImageOffset = new System.Drawing.Point(33, 28);
            this.add_dr_but.ImageSize = new System.Drawing.Size(30, 30);
            this.add_dr_but.Location = new System.Drawing.Point(1088, 59);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(147, 121);
            this.add_dr_but.TabIndex = 17;
            this.add_dr_but.Text = "كشف جديد";
            this.add_dr_but.TextOffset = new System.Drawing.Point(-7, -10);
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
            // 
            // everyday_label
            // 
            this.everyday_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.everyday_label.AutoSize = true;
            this.everyday_label.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everyday_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.everyday_label.Location = new System.Drawing.Point(503, 134);
            this.everyday_label.Name = "everyday_label";
            this.everyday_label.Size = new System.Drawing.Size(107, 36);
            this.everyday_label.TabIndex = 13;
            this.everyday_label.Text = "كل الأيام";
            // 
            // today_label
            // 
            this.today_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.today_label.AutoSize = true;
            this.today_label.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.today_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.today_label.Location = new System.Drawing.Point(756, 134);
            this.today_label.Name = "today_label";
            this.today_label.Size = new System.Drawing.Size(67, 36);
            this.today_label.TabIndex = 12;
            this.today_label.Text = "اليوم";
            // 
            // days_switch
            // 
            this.days_switch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.days_switch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.days_switch.CheckedState.BorderRadius = 15;
            this.days_switch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.days_switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.days_switch.CheckedState.InnerBorderRadius = 10;
            this.days_switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.days_switch.CheckedState.Parent = this.days_switch;
            this.days_switch.Location = new System.Drawing.Point(636, 141);
            this.days_switch.Name = "days_switch";
            this.days_switch.ShadowDecoration.Parent = this.days_switch;
            this.days_switch.Size = new System.Drawing.Size(85, 29);
            this.days_switch.TabIndex = 11;
            this.days_switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.days_switch.UncheckedState.BorderRadius = 15;
            this.days_switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(180)))), ((int)(((byte)(71)))));
            this.days_switch.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(180)))), ((int)(((byte)(71)))));
            this.days_switch.UncheckedState.InnerBorderRadius = 10;
            this.days_switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.days_switch.UncheckedState.Parent = this.days_switch;
            this.days_switch.CheckedChanged += new System.EventHandler(this.days_switch_CheckedChanged);
            // 
            // nutrition_radio
            // 
            this.nutrition_radio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nutrition_radio.AutoSize = true;
            this.nutrition_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.nutrition_radio.CheckedState.BorderThickness = 0;
            this.nutrition_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.nutrition_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.nutrition_radio.CheckedState.InnerOffset = -4;
            this.nutrition_radio.Font = new System.Drawing.Font("Tajawal Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutrition_radio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.nutrition_radio.Location = new System.Drawing.Point(63, 69);
            this.nutrition_radio.Name = "nutrition_radio";
            this.nutrition_radio.Size = new System.Drawing.Size(95, 37);
            this.nutrition_radio.TabIndex = 10;
            this.nutrition_radio.Text = "تغذية";
            this.nutrition_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nutrition_radio.UncheckedState.BorderThickness = 0;
            this.nutrition_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.nutrition_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.nutrition_radio.UseVisualStyleBackColor = true;
            this.nutrition_radio.CheckedChanged += new System.EventHandler(this.nutrition_radio_CheckedChanged);
            // 
            // physical_raadio
            // 
            this.physical_raadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.physical_raadio.AutoSize = true;
            this.physical_raadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.physical_raadio.CheckedState.BorderThickness = 0;
            this.physical_raadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.physical_raadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.physical_raadio.CheckedState.InnerOffset = -4;
            this.physical_raadio.Font = new System.Drawing.Font("Tajawal Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physical_raadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.physical_raadio.Location = new System.Drawing.Point(395, 69);
            this.physical_raadio.Name = "physical_raadio";
            this.physical_raadio.Size = new System.Drawing.Size(161, 37);
            this.physical_raadio.TabIndex = 9;
            this.physical_raadio.Text = "علاج طبيعي";
            this.physical_raadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.physical_raadio.UncheckedState.BorderThickness = 0;
            this.physical_raadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.physical_raadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.physical_raadio.UseVisualStyleBackColor = true;
            this.physical_raadio.CheckedChanged += new System.EventHandler(this.nutrition_radio_CheckedChanged);
            // 
            // all_radio
            // 
            this.all_radio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_radio.AutoSize = true;
            this.all_radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.all_radio.CheckedState.BorderThickness = 0;
            this.all_radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.all_radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.all_radio.CheckedState.InnerOffset = -4;
            this.all_radio.Font = new System.Drawing.Font("Tajawal Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_radio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.all_radio.Location = new System.Drawing.Point(723, 69);
            this.all_radio.Name = "all_radio";
            this.all_radio.Size = new System.Drawing.Size(81, 37);
            this.all_radio.TabIndex = 8;
            this.all_radio.Text = "الكل";
            this.all_radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.all_radio.UncheckedState.BorderThickness = 0;
            this.all_radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.all_radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.all_radio.UseVisualStyleBackColor = true;
            this.all_radio.CheckedChanged += new System.EventHandler(this.nutrition_radio_CheckedChanged);
            // 
            // search_pic
            // 
            this.search_pic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_pic.Image = ((System.Drawing.Image)(resources.GetObject("search_pic.Image")));
            this.search_pic.Location = new System.Drawing.Point(40, 138);
            this.search_pic.Name = "search_pic";
            this.search_pic.Size = new System.Drawing.Size(50, 29);
            this.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_pic.TabIndex = 7;
            this.search_pic.TabStop = false;
            // 
            // search_txt
            // 
            this.search_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search_txt.BorderRadius = 15;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultText = "";
            this.search_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.DisabledState.Parent = this.search_txt;
            this.search_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.FocusedState.Parent = this.search_txt;
            this.search_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.search_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.HoverState.Parent = this.search_txt;
            this.search_txt.Location = new System.Drawing.Point(102, 134);
            this.search_txt.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.ShadowDecoration.Parent = this.search_txt;
            this.search_txt.Size = new System.Drawing.Size(344, 36);
            this.search_txt.TabIndex = 6;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // exam_label
            // 
            this.exam_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exam_label.AutoSize = true;
            this.exam_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_label.Location = new System.Drawing.Point(539, 8);
            this.exam_label.Name = "exam_label";
            this.exam_label.Size = new System.Drawing.Size(169, 47);
            this.exam_label.TabIndex = 1;
            this.exam_label.Text = "الكشوفات";
            // 
            // exam_grid
            // 
            this.exam_grid.AllowUserToAddRows = false;
            this.exam_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.exam_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.exam_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exam_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exam_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.exam_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.exam_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exam_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.exam_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exam_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.exam_grid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.exam_grid.DefaultCellStyle = dataGridViewCellStyle12;
            this.exam_grid.EnableHeadersVisualStyles = false;
            this.exam_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.exam_grid.Location = new System.Drawing.Point(29, 208);
            this.exam_grid.Name = "exam_grid";
            this.exam_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exam_grid.RowHeadersVisible = false;
            this.exam_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exam_grid.Size = new System.Drawing.Size(1206, 327);
            this.exam_grid.TabIndex = 18;
            this.exam_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.exam_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.exam_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.exam_grid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.exam_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.exam_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.exam_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.exam_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.exam_grid.ThemeStyle.HeaderStyle.Height = 50;
            this.exam_grid.ThemeStyle.ReadOnly = false;
            this.exam_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.exam_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.exam_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_grid.ThemeStyle.RowsStyle.Height = 22;
            this.exam_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exam_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // exam_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "exam_cont";
            this.Size = new System.Drawing.Size(1265, 565);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label exam_label;
        private System.Windows.Forms.PictureBox search_pic;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.Label everyday_label;
        private System.Windows.Forms.Label today_label;
        private Guna.UI2.WinForms.Guna2ToggleSwitch days_switch;
        private Guna.UI2.WinForms.Guna2RadioButton nutrition_radio;
        private Guna.UI2.WinForms.Guna2RadioButton physical_raadio;
        private Guna.UI2.WinForms.Guna2RadioButton all_radio;
        private Guna.UI2.WinForms.Guna2Button add_dr_but;
        private Guna.UI2.WinForms.Guna2DataGridView exam_grid;
    }
}
