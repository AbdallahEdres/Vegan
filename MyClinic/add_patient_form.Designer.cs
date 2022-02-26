
namespace MyClinic
{
    partial class add_patient_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_patient_form));
            this.label1 = new System.Windows.Forms.Label();
            this.add_dr_but = new Guna.UI2.WinForms.Guna2Button();
            this.type_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.phone_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.type_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cansel_but = new Guna.UI2.WinForms.Guna2Button();
            this.age_label = new System.Windows.Forms.Label();
            this.adress_label = new System.Windows.Forms.Label();
            this.adress_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.age_num = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.age_num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "إضافة مريض";
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
            this.add_dr_but.Location = new System.Drawing.Point(338, 382);
            this.add_dr_but.Name = "add_dr_but";
            this.add_dr_but.ShadowDecoration.Parent = this.add_dr_but;
            this.add_dr_but.Size = new System.Drawing.Size(102, 55);
            this.add_dr_but.TabIndex = 27;
            this.add_dr_but.Text = "إضافة";
            this.add_dr_but.Click += new System.EventHandler(this.add_dr_but_Click);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.type_label.Location = new System.Drawing.Point(381, 324);
            this.type_label.Name = "type_label";
            this.type_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_label.Size = new System.Drawing.Size(112, 31);
            this.type_label.TabIndex = 26;
            this.type_label.Text = "نوع الحالة :";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.phone_label.Location = new System.Drawing.Point(381, 135);
            this.phone_label.Name = "phone_label";
            this.phone_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_label.Size = new System.Drawing.Size(88, 31);
            this.phone_label.TabIndex = 24;
            this.phone_label.Text = "الهاتف :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.name_label.Location = new System.Drawing.Point(381, 70);
            this.name_label.Name = "name_label";
            this.name_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_label.Size = new System.Drawing.Size(81, 31);
            this.name_label.TabIndex = 23;
            this.name_label.Text = "الإسم :";
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
            this.phone_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.FocusedState.Parent = this.phone_txt;
            this.phone_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.phone_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_txt.HoverState.Parent = this.phone_txt;
            this.phone_txt.Location = new System.Drawing.Point(29, 129);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(6);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.PasswordChar = '\0';
            this.phone_txt.PlaceholderText = "";
            this.phone_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone_txt.SelectedText = "";
            this.phone_txt.ShadowDecoration.Parent = this.phone_txt;
            this.phone_txt.Size = new System.Drawing.Size(282, 36);
            this.phone_txt.TabIndex = 22;
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_txt_KeyPress);
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
            this.type_combo.Location = new System.Drawing.Point(29, 321);
            this.type_combo.Name = "type_combo";
            this.type_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.type_combo.ShadowDecoration.Parent = this.type_combo;
            this.type_combo.Size = new System.Drawing.Size(282, 36);
            this.type_combo.TabIndex = 20;
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
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.FocusedState.Parent = this.name_txt;
            this.name_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.HoverState.Parent = this.name_txt;
            this.name_txt.Location = new System.Drawing.Point(29, 65);
            this.name_txt.Margin = new System.Windows.Forms.Padding(6);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "";
            this.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_txt.SelectedText = "";
            this.name_txt.ShadowDecoration.Parent = this.name_txt;
            this.name_txt.Size = new System.Drawing.Size(282, 36);
            this.name_txt.TabIndex = 19;
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
            this.cansel_but.Location = new System.Drawing.Point(81, 382);
            this.cansel_but.Name = "cansel_but";
            this.cansel_but.ShadowDecoration.Parent = this.cansel_but;
            this.cansel_but.Size = new System.Drawing.Size(102, 55);
            this.cansel_but.TabIndex = 18;
            this.cansel_but.Text = "الغاء";
            this.cansel_but.Click += new System.EventHandler(this.cansel_but_Click);
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.age_label.Location = new System.Drawing.Point(381, 260);
            this.age_label.Name = "age_label";
            this.age_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.age_label.Size = new System.Drawing.Size(77, 31);
            this.age_label.TabIndex = 32;
            this.age_label.Text = "السن :";
            // 
            // adress_label
            // 
            this.adress_label.AutoSize = true;
            this.adress_label.Font = new System.Drawing.Font("Tajawal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.adress_label.Location = new System.Drawing.Point(381, 200);
            this.adress_label.Name = "adress_label";
            this.adress_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adress_label.Size = new System.Drawing.Size(93, 31);
            this.adress_label.TabIndex = 31;
            this.adress_label.Text = "العنوان :";
            // 
            // adress_txt
            // 
            this.adress_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.adress_txt.BorderRadius = 15;
            this.adress_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adress_txt.DefaultText = "";
            this.adress_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adress_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adress_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress_txt.DisabledState.Parent = this.adress_txt;
            this.adress_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adress_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.FocusedState.Parent = this.adress_txt;
            this.adress_txt.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adress_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.adress_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adress_txt.HoverState.Parent = this.adress_txt;
            this.adress_txt.Location = new System.Drawing.Point(29, 193);
            this.adress_txt.Margin = new System.Windows.Forms.Padding(6);
            this.adress_txt.Name = "adress_txt";
            this.adress_txt.PasswordChar = '\0';
            this.adress_txt.PlaceholderText = "";
            this.adress_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adress_txt.SelectedText = "";
            this.adress_txt.ShadowDecoration.Parent = this.adress_txt;
            this.adress_txt.Size = new System.Drawing.Size(282, 36);
            this.adress_txt.TabIndex = 29;
            // 
            // age_num
            // 
            this.age_num.BackColor = System.Drawing.Color.Transparent;
            this.age_num.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.age_num.BorderRadius = 15;
            this.age_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.age_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.age_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.age_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.age_num.DisabledState.Parent = this.age_num;
            this.age_num.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.age_num.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.age_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.age_num.FocusedState.Parent = this.age_num;
            this.age_num.Font = new System.Drawing.Font("Tajawal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.age_num.Location = new System.Drawing.Point(29, 257);
            this.age_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.age_num.Name = "age_num";
            this.age_num.ShadowDecoration.Parent = this.age_num;
            this.age_num.Size = new System.Drawing.Size(282, 36);
            this.age_num.TabIndex = 33;
            this.age_num.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.age_num.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // add_patient_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 458);
            this.Controls.Add(this.age_num);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.adress_label);
            this.Controls.Add(this.adress_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_dr_but);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.cansel_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_patient_form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "add_patient_form";
            ((System.ComponentModel.ISupportInitialize)(this.age_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button add_dr_but;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label name_label;
        private Guna.UI2.WinForms.Guna2TextBox phone_txt;
        private Guna.UI2.WinForms.Guna2ComboBox type_combo;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2Button cansel_but;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label adress_label;
        private Guna.UI2.WinForms.Guna2TextBox adress_txt;
        private Guna.UI2.WinForms.Guna2NumericUpDown age_num;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}