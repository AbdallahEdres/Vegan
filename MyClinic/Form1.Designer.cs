
namespace MyClinic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start_but = new Guna.UI2.WinForms.Guna2Button();
            this.exit_but = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // start_but
            // 
            this.start_but.BackColor = System.Drawing.Color.Transparent;
            this.start_but.BorderRadius = 20;
            this.start_but.CheckedState.Parent = this.start_but;
            this.start_but.CustomImages.Parent = this.start_but;
            this.start_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.start_but.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_but.ForeColor = System.Drawing.Color.White;
            this.start_but.HoverState.Parent = this.start_but;
            this.start_but.Location = new System.Drawing.Point(481, 417);
            this.start_but.Name = "start_but";
            this.start_but.ShadowDecoration.Parent = this.start_but;
            this.start_but.Size = new System.Drawing.Size(195, 100);
            this.start_but.TabIndex = 0;
            this.start_but.Text = "بداية";
            this.start_but.Click += new System.EventHandler(this.start_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.Color.Transparent;
            this.exit_but.BorderRadius = 25;
            this.exit_but.CheckedState.Parent = this.exit_but;
            this.exit_but.CustomImages.Parent = this.exit_but;
            this.exit_but.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.exit_but.Font = new System.Drawing.Font("Tajawal", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(110)))), ((int)(((byte)(30)))));
            this.exit_but.HoverState.Parent = this.exit_but;
            this.exit_but.Location = new System.Drawing.Point(149, 417);
            this.exit_but.Name = "exit_but";
            this.exit_but.ShadowDecoration.Parent = this.exit_but;
            this.exit_but.Size = new System.Drawing.Size(195, 100);
            this.exit_but.TabIndex = 1;
            this.exit_but.Text = "خروج";
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.start_but);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tajawal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "البداية";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button start_but;
        private Guna.UI2.WinForms.Guna2Button exit_but;
    }
}

