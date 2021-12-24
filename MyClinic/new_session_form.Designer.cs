
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.new_sessions_label = new System.Windows.Forms.Label();
            this.dr_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dr_label = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_Date_label = new System.Windows.Forms.Label();
            this.time_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.time_label = new System.Windows.Forms.Label();
            this.done_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.sess_num = new System.Windows.Forms.Label();
            this.guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.add_exam_label = new System.Windows.Forms.Label();
            this.dr_appoints_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dr_appoints_grid)).BeginInit();
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
            this.dr_combo.SelectedIndexChanged += new System.EventHandler(this.dr_combo_SelectedIndexChanged);
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
            this.done_but.Location = new System.Drawing.Point(992, 477);
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
            this.cansel_but.Location = new System.Drawing.Point(735, 477);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(153, 55);
            this.cansel_but.TabIndex = 36;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // sess_num
            // 
            this.sess_num.AutoSize = true;
            this.sess_num.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sess_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sess_num.Location = new System.Drawing.Point(1088, 288);
            this.sess_num.Name = "sess_num";
            this.sess_num.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sess_num.Size = new System.Drawing.Size(147, 31);
            this.sess_num.TabIndex = 40;
            this.sess_num.Text = "عدد الجلسات :";
            // 
            // guna2NumericUpDown1
            // 
            this.guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.guna2NumericUpDown1.BorderRadius = 15;
            this.guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDown1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2NumericUpDown1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2NumericUpDown1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2NumericUpDown1.DisabledState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.guna2NumericUpDown1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.guna2NumericUpDown1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2NumericUpDown1.FocusedState.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.guna2NumericUpDown1.Location = new System.Drawing.Point(637, 288);
            this.guna2NumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2NumericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guna2NumericUpDown1.Name = "guna2NumericUpDown1";
            this.guna2NumericUpDown1.ShadowDecoration.Parent = this.guna2NumericUpDown1;
            this.guna2NumericUpDown1.Size = new System.Drawing.Size(282, 36);
            this.guna2NumericUpDown1.TabIndex = 57;
            this.guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.guna2NumericUpDown1.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.guna2NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_exam_label
            // 
            this.add_exam_label.AutoSize = true;
            this.add_exam_label.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_exam_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.add_exam_label.Location = new System.Drawing.Point(94, 9);
            this.add_exam_label.Name = "add_exam_label";
            this.add_exam_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_exam_label.Size = new System.Drawing.Size(389, 47);
            this.add_exam_label.TabIndex = 58;
            this.add_exam_label.Text = "المواعيد المحجوزه مسبقاً";
            // 
            // dr_appoints_grid
            // 
            this.dr_appoints_grid.AllowUserToAddRows = false;
            this.dr_appoints_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dr_appoints_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dr_appoints_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dr_appoints_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dr_appoints_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dr_appoints_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dr_appoints_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dr_appoints_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dr_appoints_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dr_appoints_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dr_appoints_grid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dr_appoints_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.dr_appoints_grid.EnableHeadersVisualStyles = false;
            this.dr_appoints_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_appoints_grid.Location = new System.Drawing.Point(12, 74);
            this.dr_appoints_grid.Name = "dr_appoints_grid";
            this.dr_appoints_grid.ReadOnly = true;
            this.dr_appoints_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dr_appoints_grid.RowHeadersVisible = false;
            this.dr_appoints_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dr_appoints_grid.Size = new System.Drawing.Size(618, 479);
            this.dr_appoints_grid.TabIndex = 59;
            this.dr_appoints_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dr_appoints_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.dr_appoints_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_appoints_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_appoints_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_appoints_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dr_appoints_grid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dr_appoints_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dr_appoints_grid.ThemeStyle.HeaderStyle.Height = 50;
            this.dr_appoints_grid.ThemeStyle.ReadOnly = true;
            this.dr_appoints_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_appoints_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dr_appoints_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold);
            this.dr_appoints_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_appoints_grid.ThemeStyle.RowsStyle.Height = 22;
            this.dr_appoints_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.dr_appoints_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // new_session_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 565);
            this.Controls.Add(this.dr_appoints_grid);
            this.Controls.Add(this.add_exam_label);
            this.Controls.Add(this.guna2NumericUpDown1);
            this.Controls.Add(this.sess_num);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dr_appoints_grid)).EndInit();
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
        private System.Windows.Forms.Label sess_num;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private System.Windows.Forms.Label add_exam_label;
        private Guna.UI2.WinForms.Guna2DataGridView dr_appoints_grid;
    }
}