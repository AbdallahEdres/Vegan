
namespace MyClinic
{
    partial class add_exam_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_exam_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_exam_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.type_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.date_label = new System.Windows.Forms.Label();
            this.exam_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.time_label = new System.Windows.Forms.Label();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.pay_label = new System.Windows.Forms.Label();
            this.pay_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.am_pm_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.hr_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.min_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.dr_list_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptnt_list_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.search_pic = new System.Windows.Forms.PictureBox();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptnt_list_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pay_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_num)).BeginInit();
            this.dr_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnt_list_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // add_exam_label
            // 
            this.add_exam_label.AutoSize = true;
            this.add_exam_label.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_exam_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.add_exam_label.Location = new System.Drawing.Point(232, 19);
            this.add_exam_label.Name = "add_exam_label";
            this.add_exam_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_exam_label.Size = new System.Drawing.Size(176, 47);
            this.add_exam_label.TabIndex = 29;
            this.add_exam_label.Text = "كشف جديد";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.type_label.Location = new System.Drawing.Point(520, 237);
            this.type_label.Name = "type_label";
            this.type_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_label.Size = new System.Drawing.Size(129, 31);
            this.type_label.TabIndex = 34;
            this.type_label.Text = "نوع الكشف :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.name_label.Location = new System.Drawing.Point(520, 95);
            this.name_label.Name = "name_label";
            this.name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_label.Size = new System.Drawing.Size(81, 31);
            this.name_label.TabIndex = 32;
            this.name_label.Text = "الإسم :";
            // 
            // type_combo
            // 
            this.type_combo.BackColor = System.Drawing.Color.Transparent;
            this.type_combo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.type_combo.BorderRadius = 15;
            this.type_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combo.FocusedColor = System.Drawing.Color.Empty;
            this.type_combo.FocusedState.Parent = this.type_combo;
            this.type_combo.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.type_combo.FormattingEnabled = true;
            this.type_combo.HoverState.Parent = this.type_combo;
            this.type_combo.ItemHeight = 30;
            this.type_combo.ItemsAppearance.Parent = this.type_combo;
            this.type_combo.Location = new System.Drawing.Point(71, 234);
            this.type_combo.Name = "type_combo";
            this.type_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_combo.ShadowDecoration.Parent = this.type_combo;
            this.type_combo.Size = new System.Drawing.Size(355, 36);
            this.type_combo.TabIndex = 30;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.date_label.Location = new System.Drawing.Point(520, 298);
            this.date_label.Name = "date_label";
            this.date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_label.Size = new System.Drawing.Size(84, 31);
            this.date_label.TabIndex = 37;
            this.date_label.Text = "التاريخ :";
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
            this.exam_date.Location = new System.Drawing.Point(71, 298);
            this.exam_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.exam_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.exam_date.Name = "exam_date";
            this.exam_date.ShadowDecoration.Parent = this.exam_date;
            this.exam_date.Size = new System.Drawing.Size(355, 36);
            this.exam_date.TabIndex = 38;
            this.exam_date.Value = new System.DateTime(2021, 12, 11, 15, 38, 58, 789);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.time_label.Location = new System.Drawing.Point(520, 366);
            this.time_label.Name = "time_label";
            this.time_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time_label.Size = new System.Drawing.Size(91, 31);
            this.time_label.TabIndex = 39;
            this.time_label.Text = "الساعه :";
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
            this.add_dr_but.Location = new System.Drawing.Point(328, 522);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(102, 55);
            this.add_dr_but.TabIndex = 41;
            this.add_dr_but.Text = "إضافة";
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
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
            this.cansel_but.Location = new System.Drawing.Point(71, 522);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(102, 55);
            this.cansel_but.TabIndex = 40;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // pay_label
            // 
            this.pay_label.AutoSize = true;
            this.pay_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.pay_label.Location = new System.Drawing.Point(520, 437);
            this.pay_label.Name = "pay_label";
            this.pay_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pay_label.Size = new System.Drawing.Size(75, 31);
            this.pay_label.TabIndex = 42;
            this.pay_label.Text = "الدفع :";
            // 
            // pay_num
            // 
            this.pay_num.BackColor = System.Drawing.Color.Transparent;
            this.pay_num.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.pay_num.BorderRadius = 15;
            this.pay_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pay_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pay_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pay_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pay_num.DisabledState.Parent = this.pay_num;
            this.pay_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.pay_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pay_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pay_num.FocusedState.Parent = this.pay_num;
            this.pay_num.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.pay_num.Location = new System.Drawing.Point(71, 437);
            this.pay_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pay_num.Name = "pay_num";
            this.pay_num.ShadowDecoration.Parent = this.pay_num;
            this.pay_num.Size = new System.Drawing.Size(355, 36);
            this.pay_num.TabIndex = 43;
            this.pay_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.pay_num.UpDownButtonForeColor = System.Drawing.Color.Black;
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
            this.am_pm_combo.Location = new System.Drawing.Point(355, 366);
            this.am_pm_combo.Name = "am_pm_combo";
            this.am_pm_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.am_pm_combo.ShadowDecoration.Parent = this.am_pm_combo;
            this.am_pm_combo.Size = new System.Drawing.Size(71, 36);
            this.am_pm_combo.TabIndex = 46;
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
            this.hr_num.Location = new System.Drawing.Point(71, 366);
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
            this.hr_num.TabIndex = 47;
            this.hr_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.hr_num.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.hr_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.min_num.Location = new System.Drawing.Point(214, 366);
            this.min_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.min_num.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.min_num.Name = "min_num";
            this.min_num.ShadowDecoration.Parent = this.min_num;
            this.min_num.Size = new System.Drawing.Size(73, 36);
            this.min_num.TabIndex = 48;
            this.min_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.min_num.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(286, 373);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "دقيقه:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(147, 373);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "ساعه :";
            // 
            // phone_txt
            // 
            this.phone_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.phone_txt.BorderRadius = 15;
            this.phone_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_txt.DefaultText = "";
            this.phone_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_txt.DisabledState.Parent = this.phone_txt;
            this.phone_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_txt.Enabled = false;
            this.phone_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.FocusedState.Parent = this.phone_txt;
            this.phone_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.phone_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.HoverState.Parent = this.phone_txt;
            this.phone_txt.Location = new System.Drawing.Point(71, 159);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(6);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.PasswordChar = '\0';
            this.phone_txt.PlaceholderText = "";
            this.phone_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_txt.SelectedText = "";
            this.phone_txt.ShadowDecoration.Parent = this.phone_txt;
            this.phone_txt.Size = new System.Drawing.Size(355, 36);
            this.phone_txt.TabIndex = 31;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.phone_label.Location = new System.Drawing.Point(520, 162);
            this.phone_label.Name = "phone_label";
            this.phone_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_label.Size = new System.Drawing.Size(88, 31);
            this.phone_label.TabIndex = 33;
            this.phone_label.Text = "الهاتف :";
            // 
            // name_txt
            // 
            this.name_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.name_txt.BorderRadius = 15;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.Parent = this.name_txt;
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.Enabled = false;
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.FocusedState.Parent = this.name_txt;
            this.name_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.HoverState.Parent = this.name_txt;
            this.name_txt.Location = new System.Drawing.Point(71, 95);
            this.name_txt.Margin = new System.Windows.Forms.Padding(6);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.SelectedText = "";
            this.name_txt.ShadowDecoration.Parent = this.name_txt;
            this.name_txt.Size = new System.Drawing.Size(355, 36);
            this.name_txt.TabIndex = 51;
            // 
            // dr_list_panel
            // 
            this.dr_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.dr_list_panel.Controls.Add(this.ptnt_list_grid);
            this.dr_list_panel.Controls.Add(this.search_pic);
            this.dr_list_panel.Controls.Add(this.search_txt);
            this.dr_list_panel.Controls.Add(this.ptnt_list_label);
            this.dr_list_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dr_list_panel.EdgeWidth = -10;
            this.dr_list_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_panel.Location = new System.Drawing.Point(710, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 150;
            this.dr_list_panel.ShadowShift = 8;
            this.dr_list_panel.Size = new System.Drawing.Size(374, 589);
            this.dr_list_panel.TabIndex = 52;
            // 
            // ptnt_list_grid
            // 
            this.ptnt_list_grid.AllowUserToAddRows = false;
            this.ptnt_list_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ptnt_list_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ptnt_list_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ptnt_list_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ptnt_list_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ptnt_list_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ptnt_list_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ptnt_list_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ptnt_list_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ptnt_list_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ptnt_list_grid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ptnt_list_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ptnt_list_grid.EnableHeadersVisualStyles = false;
            this.ptnt_list_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ptnt_list_grid.Location = new System.Drawing.Point(31, 109);
            this.ptnt_list_grid.Name = "ptnt_list_grid";
            this.ptnt_list_grid.ReadOnly = true;
            this.ptnt_list_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ptnt_list_grid.RowHeadersVisible = false;
            this.ptnt_list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ptnt_list_grid.Size = new System.Drawing.Size(312, 442);
            this.ptnt_list_grid.TabIndex = 6;
            this.ptnt_list_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ptnt_list_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.ptnt_list_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnt_list_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ptnt_list_grid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ptnt_list_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ptnt_list_grid.ThemeStyle.HeaderStyle.Height = 50;
            this.ptnt_list_grid.ThemeStyle.ReadOnly = true;
            this.ptnt_list_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.ptnt_list_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ptnt_list_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnt_list_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_grid.ThemeStyle.RowsStyle.Height = 22;
            this.ptnt_list_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ptnt_list_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ptnt_list_grid_CellClick);
            // 
            // search_pic
            // 
            this.search_pic.Image = ((System.Drawing.Image)(resources.GetObject("search_pic.Image")));
            this.search_pic.Location = new System.Drawing.Point(33, 66);
            this.search_pic.Name = "search_pic";
            this.search_pic.Size = new System.Drawing.Size(23, 22);
            this.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_pic.TabIndex = 5;
            this.search_pic.TabStop = false;
            // 
            // search_txt
            // 
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
            this.search_txt.Location = new System.Drawing.Point(65, 59);
            this.search_txt.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "";
            this.search_txt.SelectedText = "";
            this.search_txt.ShadowDecoration.Parent = this.search_txt;
            this.search_txt.Size = new System.Drawing.Size(278, 36);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // ptnt_list_label
            // 
            this.ptnt_list_label.AutoSize = true;
            this.ptnt_list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.ptnt_list_label.Location = new System.Drawing.Point(81, 3);
            this.ptnt_list_label.Name = "ptnt_list_label";
            this.ptnt_list_label.Size = new System.Drawing.Size(215, 47);
            this.ptnt_list_label.TabIndex = 0;
            this.ptnt_list_label.Text = "قائمة المرضى";
            // 
            // add_exam_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 589);
            this.Controls.Add(this.dr_list_panel);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min_num);
            this.Controls.Add(this.hr_num);
            this.Controls.Add(this.am_pm_combo);
            this.Controls.Add(this.pay_num);
            this.Controls.Add(this.pay_label);
            this.Controls.Add(this.add_dr_but);
            this.Controls.Add(this.cansel_but);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.exam_date);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.add_exam_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_exam_form";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_exam_form";
            ((System.ComponentModel.ISupportInitialize)(this.pay_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hr_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_num)).EndInit();
            this.dr_list_panel.ResumeLayout(false);
            this.dr_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnt_list_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_exam_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label name_label;
        private Guna.UI2.WinForms.Guna2ComboBox type_combo;
        private System.Windows.Forms.Label date_label;
        private Guna.UI2.WinForms.Guna2DateTimePicker exam_date;
        private System.Windows.Forms.Label time_label;
        private Guna.UI2.WinForms.Guna2Button add_dr_but;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
        private System.Windows.Forms.Label pay_label;
        private Guna.UI2.WinForms.Guna2NumericUpDown pay_num;
        private Guna.UI2.WinForms.Guna2ComboBox am_pm_combo;
        private Guna.UI2.WinForms.Guna2NumericUpDown hr_num;
        private Guna.UI2.WinForms.Guna2NumericUpDown min_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox phone_txt;
        private System.Windows.Forms.Label phone_label;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2ShadowPanel dr_list_panel;
        private Guna.UI2.WinForms.Guna2DataGridView ptnt_list_grid;
        private System.Windows.Forms.PictureBox search_pic;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private System.Windows.Forms.Label ptnt_list_label;
    }
}