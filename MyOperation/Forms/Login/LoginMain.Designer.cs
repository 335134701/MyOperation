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
            this.LoginMain_Login = new System.Windows.Forms.Panel();
            this.LoginMain_Login_Center = new System.Windows.Forms.Panel();
            this.LoginMain_Login_Center_Center = new System.Windows.Forms.Panel();
            this.LoginMain_Login_Center_LoginButtom = new System.Windows.Forms.Button();
            this.LoginMain_Login_Center_PasswdInput = new System.Windows.Forms.TextBox();
            this.LoginMain_Login_Center_UserInput = new System.Windows.Forms.TextBox();
            this.LoginMain_Login_Center_Right = new System.Windows.Forms.Panel();
            this.LoginMain_Login_Center_Left = new System.Windows.Forms.Panel();
            this.LoginMain_Login_Center_Left_PasswdTittle = new System.Windows.Forms.Label();
            this.LoginMain_Login_Center_Left_UserTittle = new System.Windows.Forms.Label();
            this.LoginMain_Login_Top = new System.Windows.Forms.Panel();
            this.LoginMain_Login_TopTittle = new System.Windows.Forms.Label();
            this.LoginMain_Bottom = new System.Windows.Forms.Panel();
            this.LoginMain_TOP = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Left = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Right = new System.Windows.Forms.Panel();
            this.LoginMain_TOP_Min = new System.Windows.Forms.Button();
            this.LoginMain_TOP_Close = new System.Windows.Forms.Button();
            this.LoginMain_SystemICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.LoginMain_Border.SuspendLayout();
            this.LoginMain_Background.SuspendLayout();
            this.LoginMain_Login.SuspendLayout();
            this.LoginMain_Login_Center.SuspendLayout();
            this.LoginMain_Login_Center_Center.SuspendLayout();
            this.LoginMain_Login_Center_Left.SuspendLayout();
            this.LoginMain_Login_Top.SuspendLayout();
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
            this.LoginMain_Border.Size = new System.Drawing.Size(280, 360);
            this.LoginMain_Border.TabIndex = 0;
            // 
            // LoginMain_Background
            // 
            this.LoginMain_Background.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoginMain_Background.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_Background.BackgroundImage = global::MyOperation.Properties.Resources.LoginMain_02;
            this.LoginMain_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMain_Background.Controls.Add(this.LoginMain_Login);
            this.LoginMain_Background.Controls.Add(this.LoginMain_Bottom);
            this.LoginMain_Background.Controls.Add(this.LoginMain_TOP);
            this.LoginMain_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Background.Location = new System.Drawing.Point(2, 2);
            this.LoginMain_Background.Name = "LoginMain_Background";
            this.LoginMain_Background.Padding = new System.Windows.Forms.Padding(2);
            this.LoginMain_Background.Size = new System.Drawing.Size(274, 354);
            this.LoginMain_Background.TabIndex = 0;
            // 
            // LoginMain_Login
            // 
            this.LoginMain_Login.BackColor = System.Drawing.Color.White;
            this.LoginMain_Login.Controls.Add(this.LoginMain_Login_Center);
            this.LoginMain_Login.Controls.Add(this.LoginMain_Login_Top);
            this.LoginMain_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginMain_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Login.Location = new System.Drawing.Point(2, 45);
            this.LoginMain_Login.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Login.Name = "LoginMain_Login";
            this.LoginMain_Login.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LoginMain_Login.Size = new System.Drawing.Size(270, 255);
            this.LoginMain_Login.TabIndex = 2;
            // 
            // LoginMain_Login_Center
            // 
            this.LoginMain_Login_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LoginMain_Login_Center.Controls.Add(this.LoginMain_Login_Center_Center);
            this.LoginMain_Login_Center.Controls.Add(this.LoginMain_Login_Center_Right);
            this.LoginMain_Login_Center.Controls.Add(this.LoginMain_Login_Center_Left);
            this.LoginMain_Login_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Login_Center.Location = new System.Drawing.Point(0, 75);
            this.LoginMain_Login_Center.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Login_Center.Name = "LoginMain_Login_Center";
            this.LoginMain_Login_Center.Size = new System.Drawing.Size(270, 178);
            this.LoginMain_Login_Center.TabIndex = 1;
           
            // 
            // LoginMain_Login_Center_Center
            // 
            this.LoginMain_Login_Center_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginMain_Login_Center_Center.Controls.Add(this.LoginMain_Login_Center_LoginButtom);
            this.LoginMain_Login_Center_Center.Controls.Add(this.LoginMain_Login_Center_PasswdInput);
            this.LoginMain_Login_Center_Center.Controls.Add(this.LoginMain_Login_Center_UserInput);
            this.LoginMain_Login_Center_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Login_Center_Center.Location = new System.Drawing.Point(70, 0);
            this.LoginMain_Login_Center_Center.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Login_Center_Center.Name = "LoginMain_Login_Center_Center";
            this.LoginMain_Login_Center_Center.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LoginMain_Login_Center_Center.Size = new System.Drawing.Size(130, 178);
            this.LoginMain_Login_Center_Center.TabIndex = 2;
           
            // 
            // LoginMain_Login_Center_LoginButtom
            // 
            this.LoginMain_Login_Center_LoginButtom.Location = new System.Drawing.Point(2, 133);
            this.LoginMain_Login_Center_LoginButtom.Name = "LoginMain_Login_Center_LoginButtom";
            this.LoginMain_Login_Center_LoginButtom.Size = new System.Drawing.Size(126, 41);
            this.LoginMain_Login_Center_LoginButtom.TabIndex = 2;
            this.LoginMain_Login_Center_LoginButtom.Text = "button1";
            this.LoginMain_Login_Center_LoginButtom.UseVisualStyleBackColor = true;
            // 
            // LoginMain_Login_Center_PasswdInput
            // 
            this.LoginMain_Login_Center_PasswdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_Login_Center_PasswdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginMain_Login_Center_PasswdInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginMain_Login_Center_PasswdInput.Location = new System.Drawing.Point(2, 72);
            this.LoginMain_Login_Center_PasswdInput.Margin = new System.Windows.Forms.Padding(10);
            this.LoginMain_Login_Center_PasswdInput.MaxLength = 32;
            this.LoginMain_Login_Center_PasswdInput.Name = "LoginMain_Login_Center_PasswdInput";
            this.LoginMain_Login_Center_PasswdInput.PasswordChar = '*';
            this.LoginMain_Login_Center_PasswdInput.ShortcutsEnabled = false;
            this.LoginMain_Login_Center_PasswdInput.Size = new System.Drawing.Size(126, 34);
            this.LoginMain_Login_Center_PasswdInput.TabIndex = 1;
            this.LoginMain_Login_Center_PasswdInput.TabStop = false;
            this.LoginMain_Login_Center_PasswdInput.UseSystemPasswordChar = true;
            // 
            // LoginMain_Login_Center_UserInput
            // 
            this.LoginMain_Login_Center_UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_Login_Center_UserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginMain_Login_Center_UserInput.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginMain_Login_Center_UserInput.Location = new System.Drawing.Point(2, 32);
            this.LoginMain_Login_Center_UserInput.Margin = new System.Windows.Forms.Padding(10);
            this.LoginMain_Login_Center_UserInput.MaxLength = 10;
            this.LoginMain_Login_Center_UserInput.Name = "LoginMain_Login_Center_UserInput";
            this.LoginMain_Login_Center_UserInput.Size = new System.Drawing.Size(126, 34);
            this.LoginMain_Login_Center_UserInput.TabIndex = 0;
            this.LoginMain_Login_Center_UserInput.TabStop = false;
            // 
            // LoginMain_Login_Center_Right
            // 
            this.LoginMain_Login_Center_Right.BackColor = System.Drawing.Color.Gray;
            this.LoginMain_Login_Center_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMain_Login_Center_Right.Location = new System.Drawing.Point(200, 0);
            this.LoginMain_Login_Center_Right.Name = "LoginMain_Login_Center_Right";
            this.LoginMain_Login_Center_Right.Size = new System.Drawing.Size(70, 178);
            this.LoginMain_Login_Center_Right.TabIndex = 1;
            
            // 
            // LoginMain_Login_Center_Left
            // 
            this.LoginMain_Login_Center_Left.BackColor = System.Drawing.Color.Maroon;
            this.LoginMain_Login_Center_Left.Controls.Add(this.LoginMain_Login_Center_Left_PasswdTittle);
            this.LoginMain_Login_Center_Left.Controls.Add(this.LoginMain_Login_Center_Left_UserTittle);
            this.LoginMain_Login_Center_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginMain_Login_Center_Left.Location = new System.Drawing.Point(0, 0);
            this.LoginMain_Login_Center_Left.Name = "LoginMain_Login_Center_Left";
            this.LoginMain_Login_Center_Left.Size = new System.Drawing.Size(70, 178);
            this.LoginMain_Login_Center_Left.TabIndex = 0;
            
            // 
            // LoginMain_Login_Center_Left_PasswdTittle
            // 
            this.LoginMain_Login_Center_Left_PasswdTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_Login_Center_Left_PasswdTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginMain_Login_Center_Left_PasswdTittle.Location = new System.Drawing.Point(3, 78);
            this.LoginMain_Login_Center_Left_PasswdTittle.Name = "LoginMain_Login_Center_Left_PasswdTittle";
            this.LoginMain_Login_Center_Left_PasswdTittle.Size = new System.Drawing.Size(64, 23);
            this.LoginMain_Login_Center_Left_PasswdTittle.TabIndex = 1;
            this.LoginMain_Login_Center_Left_PasswdTittle.Text = "密  码:";
            this.LoginMain_Login_Center_Left_PasswdTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginMain_Login_Center_Left_UserTittle
            // 
            this.LoginMain_Login_Center_Left_UserTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginMain_Login_Center_Left_UserTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginMain_Login_Center_Left_UserTittle.Location = new System.Drawing.Point(4, 35);
            this.LoginMain_Login_Center_Left_UserTittle.Name = "LoginMain_Login_Center_Left_UserTittle";
            this.LoginMain_Login_Center_Left_UserTittle.Size = new System.Drawing.Size(64, 23);
            this.LoginMain_Login_Center_Left_UserTittle.TabIndex = 0;
            this.LoginMain_Login_Center_Left_UserTittle.Text = "用户名:";
            this.LoginMain_Login_Center_Left_UserTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginMain_Login_Top
            // 
            this.LoginMain_Login_Top.BackColor = System.Drawing.Color.Fuchsia;
            this.LoginMain_Login_Top.Controls.Add(this.LoginMain_Login_TopTittle);
            this.LoginMain_Login_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMain_Login_Top.Location = new System.Drawing.Point(0, 2);
            this.LoginMain_Login_Top.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Login_Top.Name = "LoginMain_Login_Top";
            this.LoginMain_Login_Top.Size = new System.Drawing.Size(270, 73);
            this.LoginMain_Login_Top.TabIndex = 0;
           
            // 
            // LoginMain_Login_TopTittle
            // 
            this.LoginMain_Login_TopTittle.BackColor = System.Drawing.Color.Teal;
            this.LoginMain_Login_TopTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Login_TopTittle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginMain_Login_TopTittle.ForeColor = System.Drawing.Color.Yellow;
            this.LoginMain_Login_TopTittle.Location = new System.Drawing.Point(0, 0);
            this.LoginMain_Login_TopTittle.Name = "LoginMain_Login_TopTittle";
            this.LoginMain_Login_TopTittle.Size = new System.Drawing.Size(270, 73);
            this.LoginMain_Login_TopTittle.TabIndex = 0;
            this.LoginMain_Login_TopTittle.Text = "登  录  界  面";
            this.LoginMain_Login_TopTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // LoginMain_Bottom
            // 
            this.LoginMain_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginMain_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMain_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginMain_Bottom.Location = new System.Drawing.Point(2, 300);
            this.LoginMain_Bottom.Name = "LoginMain_Bottom";
            this.LoginMain_Bottom.Size = new System.Drawing.Size(270, 52);
            this.LoginMain_Bottom.TabIndex = 1;
            // 
            // LoginMain_TOP
            // 
            this.LoginMain_TOP.BackColor = System.Drawing.Color.Yellow;
            this.LoginMain_TOP.Controls.Add(this.LoginMain_TOP_Left);
            this.LoginMain_TOP.Controls.Add(this.LoginMain_TOP_Right);
            this.LoginMain_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginMain_TOP.Location = new System.Drawing.Point(2, 2);
            this.LoginMain_TOP.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_TOP.Name = "LoginMain_TOP";
            this.LoginMain_TOP.Size = new System.Drawing.Size(270, 43);
            this.LoginMain_TOP.TabIndex = 0;
            // 
            // LoginMain_TOP_Left
            // 
            this.LoginMain_TOP_Left.BackColor = System.Drawing.Color.Teal;
            this.LoginMain_TOP_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_TOP_Left.Location = new System.Drawing.Point(0, 0);
            this.LoginMain_TOP_Left.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_TOP_Left.Name = "LoginMain_TOP_Left";
            this.LoginMain_TOP_Left.Size = new System.Drawing.Size(123, 43);
            this.LoginMain_TOP_Left.TabIndex = 5;
            // 
            // LoginMain_TOP_Right
            // 
            this.LoginMain_TOP_Right.BackColor = System.Drawing.Color.Navy;
            this.LoginMain_TOP_Right.Controls.Add(this.LoginMain_TOP_Min);
            this.LoginMain_TOP_Right.Controls.Add(this.LoginMain_TOP_Close);
            this.LoginMain_TOP_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMain_TOP_Right.Location = new System.Drawing.Point(123, 0);
            this.LoginMain_TOP_Right.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_TOP_Right.Name = "LoginMain_TOP_Right";
            this.LoginMain_TOP_Right.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoginMain_TOP_Right.Size = new System.Drawing.Size(147, 43);
            this.LoginMain_TOP_Right.TabIndex = 4;
            // 
            // LoginMain_TOP_Min
            // 
            this.LoginMain_TOP_Min.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMain_TOP_Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginMain_TOP_Min.FlatAppearance.BorderSize = 0;
            this.LoginMain_TOP_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMain_TOP_Min.Image = global::MyOperation.Properties.Resources.LoginMain_01_Min;
            this.LoginMain_TOP_Min.Location = new System.Drawing.Point(75, 3);
            this.LoginMain_TOP_Min.Name = "LoginMain_TOP_Min";
            this.LoginMain_TOP_Min.Size = new System.Drawing.Size(35, 37);
            this.LoginMain_TOP_Min.TabIndex = 1;
            this.LoginMain_TOP_Min.UseVisualStyleBackColor = false;
            // 
            // LoginMain_TOP_Close
            // 
            this.LoginMain_TOP_Close.BackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginMain_TOP_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginMain_TOP_Close.FlatAppearance.BorderSize = 0;
            this.LoginMain_TOP_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginMain_TOP_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginMain_TOP_Close.Image = global::MyOperation.Properties.Resources.LoginMain_01_Close;
            this.LoginMain_TOP_Close.Location = new System.Drawing.Point(110, 3);
            this.LoginMain_TOP_Close.Name = "LoginMain_TOP_Close";
            this.LoginMain_TOP_Close.Size = new System.Drawing.Size(35, 37);
            this.LoginMain_TOP_Close.TabIndex = 0;
            this.LoginMain_TOP_Close.UseVisualStyleBackColor = false;
            // 
            // LoginMain_SystemICON
            // 
            this.LoginMain_SystemICON.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginMain_SystemICON.Icon")));
            this.LoginMain_SystemICON.Text = "MyOperation";
            // 
            // LoginMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 360);
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
            this.LoginMain_Login.ResumeLayout(false);
            this.LoginMain_Login_Center.ResumeLayout(false);
            this.LoginMain_Login_Center_Center.ResumeLayout(false);
            this.LoginMain_Login_Center_Center.PerformLayout();
            this.LoginMain_Login_Center_Left.ResumeLayout(false);
            this.LoginMain_Login_Top.ResumeLayout(false);
            this.LoginMain_TOP.ResumeLayout(false);
            this.LoginMain_TOP_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginMain_Border;
        private System.Windows.Forms.Panel LoginMain_Bottom;
        public System.Windows.Forms.Panel LoginMain_Background;
        protected internal System.Windows.Forms.Button LoginMain_TOP_Min;
        protected internal System.Windows.Forms.NotifyIcon LoginMain_SystemICON;
        protected internal System.Windows.Forms.Panel LoginMain_TOP;
        protected internal System.Windows.Forms.Panel LoginMain_TOP_Left;
        protected internal System.Windows.Forms.Panel LoginMain_TOP_Right;
        protected internal System.Windows.Forms.Button LoginMain_TOP_Close;
        private System.Windows.Forms.Panel LoginMain_Login;
        protected internal System.Windows.Forms.Panel LoginMain_Login_Center;
        protected internal System.Windows.Forms.Panel LoginMain_Login_Top;
        protected internal System.Windows.Forms.Label LoginMain_Login_TopTittle;
        private System.Windows.Forms.Panel LoginMain_Login_Center_Left;
        private System.Windows.Forms.Panel LoginMain_Login_Center_Center;
        private System.Windows.Forms.Panel LoginMain_Login_Center_Right;
        protected internal System.Windows.Forms.Label LoginMain_Login_Center_Left_PasswdTittle;
        protected internal System.Windows.Forms.Label LoginMain_Login_Center_Left_UserTittle;
        protected internal System.Windows.Forms.TextBox LoginMain_Login_Center_UserInput;
        protected internal System.Windows.Forms.TextBox LoginMain_Login_Center_PasswdInput;
        private System.Windows.Forms.Button LoginMain_Login_Center_LoginButtom;
    }
}