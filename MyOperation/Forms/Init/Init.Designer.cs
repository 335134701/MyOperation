namespace MyOperation.Forms.Init
{
    partial class Init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.Border = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.Panel();
            this.Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Gray;
            this.Border.Controls.Add(this.Background);
            this.Border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Padding = new System.Windows.Forms.Padding(3);
            this.Border.Size = new System.Drawing.Size(584, 362);
            this.Border.TabIndex = 0;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.White;
            this.Background.BackgroundImage = global::MyOperation.Properties.Resources.Init_01;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(3, 3);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(578, 356);
            this.Background.TabIndex = 0;
            //this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Init";
            this.TopMost = true;
            //this.Load += new System.EventHandler(this.Init_Load);
            this.Border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Panel Background;
    }
}