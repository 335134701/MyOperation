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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMain));
            this.Border = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.Panel();
            this.TOP = new System.Windows.Forms.Panel();
            this.Bottom = new System.Windows.Forms.Panel();
            this.Center = new System.Windows.Forms.Panel();
            this.Center_Background = new System.Windows.Forms.Panel();
            this.Border.SuspendLayout();
            this.Background.SuspendLayout();
            this.Center.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Gray;
            this.Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border.Controls.Add(this.Background);
            this.Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Padding = new System.Windows.Forms.Padding(2);
            this.Border.Size = new System.Drawing.Size(284, 362);
            this.Border.TabIndex = 0;
            // 
            // Background
            // 
            this.Background.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Background.BackColor = System.Drawing.Color.Red;
            this.Background.Controls.Add(this.Center);
            this.Background.Controls.Add(this.Bottom);
            this.Background.Controls.Add(this.TOP);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(2, 2);
            this.Background.Name = "Background";
            this.Background.Padding = new System.Windows.Forms.Padding(2);
            this.Background.Size = new System.Drawing.Size(278, 356);
            this.Background.TabIndex = 0;
            // 
            // TOP
            // 
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.Location = new System.Drawing.Point(2, 2);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(274, 43);
            this.TOP.TabIndex = 0;
            this.TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_MouseDown);
            // 
            // Bottom
            // 
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(2, 302);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(274, 52);
            this.Bottom.TabIndex = 1;
            this.Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bottom_MouseDown);
            // 
            // Center
            // 
            this.Center.BackColor = System.Drawing.Color.Olive;
            this.Center.Controls.Add(this.Center_Background);
            this.Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center.Location = new System.Drawing.Point(2, 45);
            this.Center.Name = "Center";
            this.Center.Padding = new System.Windows.Forms.Padding(2);
            this.Center.Size = new System.Drawing.Size(274, 257);
            this.Center.TabIndex = 2;
            // 
            // Center_Background
            // 
            this.Center_Background.BackColor = System.Drawing.Color.Blue;
            this.Center_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center_Background.Location = new System.Drawing.Point(2, 2);
            this.Center_Background.Name = "Center_Background";
            this.Center_Background.Size = new System.Drawing.Size(270, 253);
            this.Center_Background.TabIndex = 0;
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMain";
            this.Load += new System.EventHandler(this.LoginMain_Load);
            this.Border.ResumeLayout(false);
            this.Background.ResumeLayout(false);
            this.Center.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Panel TOP;
        private System.Windows.Forms.Panel Center;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel Center_Background;
    }
}