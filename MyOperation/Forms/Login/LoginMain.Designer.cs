namespace MyOperation.Forms.Login
{
    partial class LoginMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.LoginMain_Border = new System.Windows.Forms.Panel();
            this.LoginMain_Background = new System.Windows.Forms.Panel();
            this.LoginMain_Center = new System.Windows.Forms.Panel();
            this.LoginMain_Center_Background = new System.Windows.Forms.Panel();
            this.LoginMain_Bottom = new System.Windows.Forms.Panel();
            this.LoginMain_TOP = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Left = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Right = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Min = new System.Windows.Forms.Button();
            this.LoginMain_TOP_Close = new System.Windows.Forms.Button();
            this.LoginMain_notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LoginMain_Border.SuspendLayout();
            this.LoginMain_Background.SuspendLayout();
            this.LoginMain_Center.SuspendLayout();
            this.LoginMain_TOP.SuspendLayout();
            this.LoginMain_TOP_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginMain_Border
            // 
            this.LoginMain_Border.BackColor = System.Drawing.Color.Gray;
            this.LoginMain_Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginMain_Border.Controls.Add(this.LoginMain_Background);
            this.LoginMain_Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Border.Location = new System.Drawing.Point(0, 0);
            this.LoginMain_Border.Name = "LoginMain_Border";
            this.LoginMain_Border.Padding = new System.Windows.Forms.Padding(2);
            this.LoginMain_Border.Size = new System.Drawing.Size(284, 362);
            this.LoginMain_Border.TabIndex = 0;
            // 
            // LoginMain_Background
            // 
            this.LoginMain_Background.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoginMain_Background.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_Background.BackgroundImage = global::MyOperation.Properties.Resources.LoginMain_02;
            this.LoginMain_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMain_Background.Controls.Add(this.LoginMain_Center);
            this.LoginMain_Background.Controls.Add(this.LoginMain_Bottom);
            this.LoginMain_Background.Controls.Add(this.LoginMain_TOP);
            this.LoginMain_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Background.Location = new System.Drawing.Point(2, 2);
            this.LoginMain_Background.Name = "LoginMain_Background";
            this.LoginMain_Background.Padding = new System.Windows.Forms.Padding(2);
            this.LoginMain_Background.Size = new System.Drawing.Size(278, 356);
            this.LoginMain_Background.TabIndex = 0;
            // 
            // LoginMain_Center
            // 
            this.LoginMain_Center.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_Center.Controls.Add(this.LoginMain_Center_Background);
            this.LoginMain_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Center.Location = new System.Drawing.Point(2, 45);
            this.LoginMain_Center.Name = "LoginMain_Center";
            this.LoginMain_Center.Padding = new System.Windows.Forms.Padding(2);
            this.LoginMain_Center.Size = new System.Drawing.Size(274, 257);
            this.LoginMain_Center.TabIndex = 2;
            // 
            // LoginMain_Center_Background
            // 
            this.LoginMain_Center_Background.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_Center_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Center_Background.Location = new System.Drawing.Point(2, 2);
            this.LoginMain_Center_Background.Name = "LoginMain_Center_Background";
            this.LoginMain_Center_Background.Size = new System.Drawing.Size(270, 253);
            this.LoginMain_Center_Background.TabIndex = 0;
            // 
            // LoginMain_Bottom
            // 
            this.LoginMain_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginMain_Bottom.Location = new System.Drawing.Point(2, 302);
            this.LoginMain_Bottom.Name = "LoginMain_Bottom";
            this.LoginMain_Bottom.Size = new System.Drawing.Size(274, 52);
            this.LoginMain_Bottom.TabIndex = 1;
            this.LoginMain_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bottom_MouseDown);
            // 
            // LoginMain_TOP
            // 
            this.LoginMain_TOP.Controls.Add(this.LoginMain_TOP_Left);
            this.LoginMain_TOP.Controls.Add(this.LoginMain_TOP_Right);
            this.LoginMain_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMain_TOP.Location = new System.Drawing.Point(2, 2);
            this.LoginMain_TOP.Name = "LoginMain_TOP";
            this.LoginMain_TOP.Size = new System.Drawing.Size(274, 43);
            this.LoginMain_TOP.TabIndex = 0;
            this.LoginMain_TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_MouseDown);
            // 
            // LoginMain_TOP_Left
            // 
            this.LoginMain_TOP_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_TOP_Left.Location = new System.Drawing.Point(0, 0);
            this.LoginMain_TOP_Left.Name = "LoginMain_TOP_Left";
            this.LoginMain_TOP_Left.Size = new System.Drawing.Size(127, 43);
            this.LoginMain_TOP_Left.TabIndex = 5;
            this.LoginMain_TOP_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_Left_MouseDown);
            // 
            // LoginMain_TOP_Right
            // 
            this.LoginMain_TOP_Right.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Right.Controls.Add(this.LoginMain_TOP_Min);
            this.LoginMain_TOP_Right.Controls.Add(this.LoginMain_TOP_Close);
            this.LoginMain_TOP_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMain_TOP_Right.Location = new System.Drawing.Point(127, 0);
            this.LoginMain_TOP_Right.Name = "LoginMain_TOP_Right";
            this.LoginMain_TOP_Right.Padding = new System.Windows.Forms.Padding(2);
            this.LoginMain_TOP_Right.Size = new System.Drawing.Size(147, 43);
            this.LoginMain_TOP_Right.TabIndex = 4;
            this.LoginMain_TOP_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_Right_MouseDown);
            // 
            // LoginMain_TOP_Min
            // 
            this.LoginMain_TOP_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_TOP_Min.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginMain_TOP_Min.FlatAppearance.BorderSize = 0;
            this.LoginMain_TOP_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMain_TOP_Min.Image = global::MyOperation.Properties.Resources.LoginMain_01_Min;
            this.LoginMain_TOP_Min.Location = new System.Drawing.Point(70, 3);
            this.LoginMain_TOP_Min.Name = "LoginMain_TOP_Min";
            this.LoginMain_TOP_Min.Size = new System.Drawing.Size(35, 35);
            this.LoginMain_TOP_Min.TabIndex = 1;
            this.LoginMain_TOP_Min.UseVisualStyleBackColor = false;
            this.LoginMain_TOP_Min.Click += new System.EventHandler(this.Min_Click);
            this.LoginMain_TOP_Min.MouseEnter += new System.EventHandler(this.Min_MouseEnter);
            this.LoginMain_TOP_Min.MouseLeave += new System.EventHandler(this.Min_MouseLeave);
            // 
            // LoginMain_TOP_Close
            // 
            this.LoginMain_TOP_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_TOP_Close.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginMain_TOP_Close.FlatAppearance.BorderSize = 0;
            this.LoginMain_TOP_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMain_TOP_Close.Image = global::MyOperation.Properties.Resources.LoginMain_01_Close;
            this.LoginMain_TOP_Close.Location = new System.Drawing.Point(108, 3);
            this.LoginMain_TOP_Close.Name = "LoginMain_TOP_Close";
            this.LoginMain_TOP_Close.Size = new System.Drawing.Size(35, 35);
            this.LoginMain_TOP_Close.TabIndex = 0;
            this.LoginMain_TOP_Close.UseVisualStyleBackColor = false;
            this.LoginMain_TOP_Close.Click += new System.EventHandler(this.Close_Click);
            this.LoginMain_TOP_Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.LoginMain_TOP_Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // LoginMain_notifyIcon1
            // 
            this.LoginMain_notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginMain_notifyIcon1.Icon")));
            this.LoginMain_notifyIcon1.Text = "notifyIcon1";
            this.LoginMain_notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.LoginMain_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMain";
            this.Load += new System.EventHandler(this.LoginMain_Load);
            this.LoginMain_Border.ResumeLayout(false);
            this.LoginMain_Background.ResumeLayout(false);
            this.LoginMain_Center.ResumeLayout(false);
            this.LoginMain_TOP.ResumeLayout(false);
            this.LoginMain_TOP_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginMain_Border;
        private System.Windows.Forms.Panel LoginMain_Background;
        private System.Windows.Forms.Panel LoginMain_TOP;
        private System.Windows.Forms.Panel LoginMain_Center;
        private System.Windows.Forms.Panel LoginMain_Bottom;
        private System.Windows.Forms.Panel LoginMain_Center_Background;
        private System.Windows.Forms.Panel LoginMain_TOP_Left;
        private System.Windows.Forms.Panel LoginMain_TOP_Right;
        private System.Windows.Forms.Button LoginMain_TOP_Close;
        private System.Windows.Forms.Button LoginMain_TOP_Min;
        private System.Windows.Forms.NotifyIcon LoginMain_notifyIcon1;
    }
}