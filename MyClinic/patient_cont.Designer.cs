
namespace MyClinic
{
    partial class patient_cont
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_cont));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dr_list_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ptnt_list_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.search_pic = new System.Windows.Forms.PictureBox();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.edit_but = new Guna.UI2.WinForms.Guna2Button();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.ptnt_list_label = new System.Windows.Forms.Label();
            this.dr_details_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.sessions_grid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.date_val_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.pay_val_label = new System.Windows.Forms.Label();
            this.pay_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.type_val_label = new System.Windows.Forms.Label();
            this.age_val_label = new System.Windows.Forms.Label();
            this.address_val_label = new System.Windows.Forms.Label();
            this.phone_val_label = new System.Windows.Forms.Label();
            this.name_val_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dr_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnt_list_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).BeginInit();
            this.dr_details_panel.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessions_grid)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dr_list_panel
            // 
            this.dr_list_panel.BackColor = System.Drawing.Color.Transparent;
            this.dr_list_panel.Controls.Add(this.ptnt_list_grid);
            this.dr_list_panel.Controls.Add(this.search_pic);
            this.dr_list_panel.Controls.Add(this.search_txt);
            this.dr_list_panel.Controls.Add(this.edit_but);
            this.dr_list_panel.Controls.Add(this.add_dr_but);
            this.dr_list_panel.Controls.Add(this.ptnt_list_label);
            this.dr_list_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dr_list_panel.EdgeWidth = -10;
            this.dr_list_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_list_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_list_panel.Location = new System.Drawing.Point(891, 0);
            this.dr_list_panel.Name = "dr_list_panel";
            this.dr_list_panel.Radius = 20;
            this.dr_list_panel.ShadowColor = System.Drawing.Color.Black;
            this.dr_list_panel.ShadowDepth = 150;
            this.dr_list_panel.ShadowShift = 8;
            this.dr_list_panel.Size = new System.Drawing.Size(374, 565);
            this.dr_list_panel.TabIndex = 1;
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
            this.ptnt_list_grid.Size = new System.Drawing.Size(312, 359);
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
            this.edit_but.Location = new System.Drawing.Point(57, 474);
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
            this.add_dr_but.Location = new System.Drawing.Point(217, 474);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(102, 55);
            this.add_dr_but.TabIndex = 2;
            this.add_dr_but.Text = "إضافة";
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
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
            // dr_details_panel
            // 
            this.dr_details_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dr_details_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.dr_details_panel.Controls.Add(this.guna2ShadowPanel2);
            this.dr_details_panel.Controls.Add(this.guna2ShadowPanel1);
            this.dr_details_panel.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dr_details_panel.Location = new System.Drawing.Point(0, 0);
            this.dr_details_panel.Name = "dr_details_panel";
            this.dr_details_panel.ShadowDecoration.Parent = this.dr_details_panel;
            this.dr_details_panel.Size = new System.Drawing.Size(885, 559);
            this.dr_details_panel.TabIndex = 2;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.sessions_grid);
            this.guna2ShadowPanel2.EdgeWidth = 2;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.guna2ShadowPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(27, 274);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 25;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 150;
            this.guna2ShadowPanel2.ShadowShift = 7;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(836, 285);
            this.guna2ShadowPanel2.TabIndex = 1;
            // 
            // sessions_grid
            // 
            this.sessions_grid.AllowUserToAddRows = false;
            this.sessions_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.sessions_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sessions_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessions_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sessions_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sessions_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.sessions_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sessions_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.sessions_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sessions_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sessions_grid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sessions_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.sessions_grid.EnableHeadersVisualStyles = false;
            this.sessions_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sessions_grid.Location = new System.Drawing.Point(37, 21);
            this.sessions_grid.Name = "sessions_grid";
            this.sessions_grid.ReadOnly = true;
            this.sessions_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sessions_grid.RowHeadersVisible = false;
            this.sessions_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessions_grid.Size = new System.Drawing.Size(760, 245);
            this.sessions_grid.TabIndex = 2;
            this.sessions_grid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.sessions_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.sessions_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Tajawal Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessions_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sessions_grid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.sessions_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sessions_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.sessions_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessions_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sessions_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sessions_grid.ThemeStyle.HeaderStyle.Height = 50;
            this.sessions_grid.ThemeStyle.ReadOnly = true;
            this.sessions_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.sessions_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.sessions_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessions_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_grid.ThemeStyle.RowsStyle.Height = 22;
            this.sessions_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.sessions_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.date_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.date_label);
            this.guna2ShadowPanel1.Controls.Add(this.info_label);
            this.guna2ShadowPanel1.Controls.Add(this.pay_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.pay_label);
            this.guna2ShadowPanel1.Controls.Add(this.type_label);
            this.guna2ShadowPanel1.Controls.Add(this.type_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.age_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.address_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.phone_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.name_val_label);
            this.guna2ShadowPanel1.Controls.Add(this.age_label);
            this.guna2ShadowPanel1.Controls.Add(this.adress_label);
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
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(836, 265);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // date_val_label
            // 
            this.date_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date_val_label.Location = new System.Drawing.Point(388, 220);
            this.date_val_label.Name = "date_val_label";
            this.date_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_val_label.Size = new System.Drawing.Size(247, 29);
            this.date_val_label.TabIndex = 17;
            this.date_val_label.Text = "9/12/2021";
            // 
            // date_label
            // 
            this.date_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date_label.Location = new System.Drawing.Point(652, 224);
            this.date_label.Name = "date_label";
            this.date_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date_label.Size = new System.Drawing.Size(144, 31);
            this.date_label.TabIndex = 16;
            this.date_label.Text = "تاريخ الفحص :";
            // 
            // info_label
            // 
            this.info_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.info_label.AutoSize = true;
            this.info_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.info_label.Location = new System.Drawing.Point(557, 19);
            this.info_label.Name = "info_label";
            this.info_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.info_label.Size = new System.Drawing.Size(241, 47);
            this.info_label.TabIndex = 15;
            this.info_label.Text = "بيانات المريض :";
            // 
            // pay_val_label
            // 
            this.pay_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pay_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pay_val_label.Location = new System.Drawing.Point(388, 179);
            this.pay_val_label.Name = "pay_val_label";
            this.pay_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pay_val_label.Size = new System.Drawing.Size(247, 29);
            this.pay_val_label.TabIndex = 14;
            this.pay_val_label.Text = "بالجلسه";
            // 
            // pay_label
            // 
            this.pay_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pay_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pay_label.Location = new System.Drawing.Point(652, 180);
            this.pay_label.Name = "pay_label";
            this.pay_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pay_label.Size = new System.Drawing.Size(136, 31);
            this.pay_label.TabIndex = 13;
            this.pay_label.Text = "طريقة الدفع :";
            // 
            // type_label
            // 
            this.type_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.type_label.Location = new System.Drawing.Point(216, 217);
            this.type_label.Name = "type_label";
            this.type_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_label.Size = new System.Drawing.Size(129, 31);
            this.type_label.TabIndex = 12;
            this.type_label.Text = "نوع الكشف :";
            // 
            // type_val_label
            // 
            this.type_val_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.type_val_label.Location = new System.Drawing.Point(37, 220);
            this.type_val_label.Name = "type_val_label";
            this.type_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_val_label.Size = new System.Drawing.Size(173, 29);
            this.type_val_label.TabIndex = 11;
            this.type_val_label.Text = "علاج طبيعي";
            // 
            // age_val_label
            // 
            this.age_val_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.age_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.age_val_label.Location = new System.Drawing.Point(94, 178);
            this.age_val_label.Name = "age_val_label";
            this.age_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.age_val_label.Size = new System.Drawing.Size(114, 29);
            this.age_val_label.TabIndex = 7;
            this.age_val_label.Text = "22";
            // 
            // address_val_label
            // 
            this.address_val_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address_val_label.Location = new System.Drawing.Point(3, 87);
            this.address_val_label.Name = "address_val_label";
            this.address_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.address_val_label.Size = new System.Drawing.Size(216, 73);
            this.address_val_label.TabIndex = 6;
            this.address_val_label.Text = "المحله,الجمهوريه";
            // 
            // phone_val_label
            // 
            this.phone_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_val_label.Location = new System.Drawing.Point(388, 131);
            this.phone_val_label.Name = "phone_val_label";
            this.phone_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_val_label.Size = new System.Drawing.Size(258, 29);
            this.phone_val_label.TabIndex = 5;
            this.phone_val_label.Text = "01009289565";
            // 
            // name_val_label
            // 
            this.name_val_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_val_label.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_val_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_val_label.Location = new System.Drawing.Point(388, 87);
            this.name_val_label.Name = "name_val_label";
            this.name_val_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_val_label.Size = new System.Drawing.Size(269, 29);
            this.name_val_label.TabIndex = 4;
            this.name_val_label.Text = "عبد الله احمد ادريس";
            // 
            // age_label
            // 
            this.age_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.age_label.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.age_label.Location = new System.Drawing.Point(225, 168);
            this.age_label.Name = "age_label";
            this.age_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.age_label.Size = new System.Drawing.Size(97, 40);
            this.age_label.TabIndex = 3;
            this.age_label.Text = "السن :";
            // 
            // adress_label
            // 
            this.adress_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adress_label.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adress_label.Location = new System.Drawing.Point(225, 79);
            this.adress_label.Name = "adress_label";
            this.adress_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adress_label.Size = new System.Drawing.Size(118, 40);
            this.adress_label.TabIndex = 2;
            this.adress_label.Text = "العنوان :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(652, 129);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "الهاتف :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(652, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(104, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "الإسم :";
            // 
            // patient_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dr_details_panel);
            this.Controls.Add(this.dr_list_panel);
            this.Location = new System.Drawing.Point(0, 117);
            this.Name = "patient_cont";
            this.Size = new System.Drawing.Size(1265, 565);
            this.dr_list_panel.ResumeLayout(false);
            this.dr_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptnt_list_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_pic)).EndInit();
            this.dr_details_panel.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessions_grid)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel dr_list_panel;
        private Guna.UI2.WinForms.Guna2Button edit_but;
        private Guna.UI2.WinForms.Guna2Button add_dr_but;
        private System.Windows.Forms.Label ptnt_list_label;
        private System.Windows.Forms.PictureBox search_pic;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
        private Guna.UI2.WinForms.Guna2Panel dr_details_panel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label pay_val_label;
        private System.Windows.Forms.Label pay_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label type_val_label;
        private System.Windows.Forms.Label age_val_label;
        private System.Windows.Forms.Label address_val_label;
        private System.Windows.Forms.Label phone_val_label;
        private System.Windows.Forms.Label name_val_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label adress_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView ptnt_list_grid;
        private Guna.UI2.WinForms.Guna2DataGridView sessions_grid;
        private System.Windows.Forms.Label date_val_label;
        private System.Windows.Forms.Label date_label;
    }
}
