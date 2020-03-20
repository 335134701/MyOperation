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
            this.Border = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.Panel();
            this.LoginMain_Login = new System.Windows.Forms.Panel();
            this.Login_Center = new System.Windows.Forms.Panel();
            this.Login_Center_Center = new System.Windows.Forms.Panel();
            this.Login_LoginButtom = new System.Windows.Forms.Button();
            this.Login_PasswdInput = new System.Windows.Forms.TextBox();
            this.Login_UserInput = new System.Windows.Forms.TextBox();
            this.Login_Center_Right = new System.Windows.Forms.Panel();
            this.Login_ForgetTittle = new System.Windows.Forms.Label();
            this.Login_RegisterTittle = new System.Windows.Forms.Label();
            this.Login_Center_Left = new System.Windows.Forms.Panel();
            this.Login_PasswdTittle = new System.Windows.Forms.Label();
            this.Login_UserTittle = new System.Windows.Forms.Label();
            this.Login_Top = new System.Windows.Forms.Panel();
            this.Login_TopTittle = new System.Windows.Forms.Label();
            this.Bottom = new System.Windows.Forms.Panel();
            this.TOP = new System.Windows.Forms.Panel();
            this.TOP_Left = new System.Windows.Forms.Panel();
            this.TOP_Right = new System.Windows.Forms.Panel();
            this.TOP_Min = new System.Windows.Forms.Button();
            this.TOP_Close = new System.Windows.Forms.Button();
            this.LoginMain_Forget = new System.Windows.Forms.Panel();
            this.Forget_Center = new System.Windows.Forms.Panel();
            this.Forget_Center_Center = new System.Windows.Forms.Panel();
            this.Forget_ForgetButtom = new System.Windows.Forms.Button();
            this.Forget_Center_Right = new System.Windows.Forms.Panel();
            this.Forget_Center_Left = new System.Windows.Forms.Panel();
            this.Forget_NPasswdTittle = new System.Windows.Forms.Label();
            this.Forget_VCodeTittle = new System.Windows.Forms.Label();
            this.Forget_UserTittle = new System.Windows.Forms.Label();
            this.Forget_Top = new System.Windows.Forms.Panel();
            this.Forget_TopTittle = new System.Windows.Forms.Label();
            this.LoginMain_Register = new System.Windows.Forms.Panel();
            this.Register_Center = new System.Windows.Forms.Panel();
            this.Register_Center_Center = new System.Windows.Forms.Panel();
            this.Register_Center_Right = new System.Windows.Forms.Panel();
            this.Register_Center_Left = new System.Windows.Forms.Panel();
            this.Register_Top = new System.Windows.Forms.Panel();
            this.LoginMain_SystemICON = new System.Windows.Forms.NotifyIcon(this.components);
            this.Border.SuspendLayout();
            this.Background.SuspendLayout();
            this.LoginMain_Login.SuspendLayout();
            this.Login_Center.SuspendLayout();
            this.Login_Center_Center.SuspendLayout();
            this.Login_Center_Right.SuspendLayout();
            this.Login_Center_Left.SuspendLayout();
            this.Login_Top.SuspendLayout();
            this.TOP.SuspendLayout();
            this.TOP_Right.SuspendLayout();
            this.LoginMain_Forget.SuspendLayout();
            this.Forget_Center.SuspendLayout();
            this.Forget_Center_Center.SuspendLayout();
            this.Forget_Center_Left.SuspendLayout();
            this.Forget_Top.SuspendLayout();
            this.LoginMain_Register.SuspendLayout();
            this.Register_Center.SuspendLayout();
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
            this.Border.Size = new System.Drawing.Size(280, 360);
            this.Border.TabIndex = 0;
            // 
            // Background
            // 
            this.Background.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.BackgroundImage = global::MyOperation.Properties.Resources.LoginMain_02;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Controls.Add(this.LoginMain_Login);
            this.Background.Controls.Add(this.Bottom);
            this.Background.Controls.Add(this.TOP);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(2, 2);
            this.Background.Name = "Background";
            this.Background.Padding = new System.Windows.Forms.Padding(2);
            this.Background.Size = new System.Drawing.Size(274, 354);
            this.Background.TabIndex = 0;
            // 
            // LoginMain_Login
            // 
            this.LoginMain_Login.BackColor = System.Drawing.Color.White;
            this.LoginMain_Login.Controls.Add(this.Login_Center);
            this.LoginMain_Login.Controls.Add(this.Login_Top);
            this.LoginMain_Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginMain_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Login.Location = new System.Drawing.Point(2, 45);
            this.LoginMain_Login.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Login.Name = "LoginMain_Login";
            this.LoginMain_Login.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LoginMain_Login.Size = new System.Drawing.Size(270, 255);
            this.LoginMain_Login.TabIndex = 2;
            // 
            // Login_Center
            // 
            this.Login_Center.BackColor = System.Drawing.Color.Transparent;
            this.Login_Center.Controls.Add(this.Login_Center_Center);
            this.Login_Center.Controls.Add(this.Login_Center_Right);
            this.Login_Center.Controls.Add(this.Login_Center_Left);
            this.Login_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Center.Location = new System.Drawing.Point(0, 75);
            this.Login_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Center.Name = "Login_Center";
            this.Login_Center.Size = new System.Drawing.Size(270, 178);
            this.Login_Center.TabIndex = 1;
            // 
            // Login_Center_Center
            // 
            this.Login_Center_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login_Center_Center.Controls.Add(this.Login_LoginButtom);
            this.Login_Center_Center.Controls.Add(this.Login_PasswdInput);
            this.Login_Center_Center.Controls.Add(this.Login_UserInput);
            this.Login_Center_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Center_Center.Location = new System.Drawing.Point(70, 0);
            this.Login_Center_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Center_Center.Name = "Login_Center_Center";
            this.Login_Center_Center.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Login_Center_Center.Size = new System.Drawing.Size(130, 178);
            this.Login_Center_Center.TabIndex = 2;
            // 
            // Login_LoginButtom
            // 
            this.Login_LoginButtom.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_LoginButtom.Location = new System.Drawing.Point(2, 125);
            this.Login_LoginButtom.Name = "Login_LoginButtom";
            this.Login_LoginButtom.Size = new System.Drawing.Size(126, 41);
            this.Login_LoginButtom.TabIndex = 2;
            this.Login_LoginButtom.Text = "登    陆";
            this.Login_LoginButtom.UseVisualStyleBackColor = true;
            // 
            // Login_PasswdInput
            // 
            this.Login_PasswdInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_PasswdInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_PasswdInput.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_PasswdInput.Location = new System.Drawing.Point(2, 78);
            this.Login_PasswdInput.Margin = new System.Windows.Forms.Padding(10);
            this.Login_PasswdInput.MaxLength = 32;
            this.Login_PasswdInput.Name = "Login_PasswdInput";
            this.Login_PasswdInput.PasswordChar = '*';
            this.Login_PasswdInput.ShortcutsEnabled = false;
            this.Login_PasswdInput.Size = new System.Drawing.Size(126, 22);
            this.Login_PasswdInput.TabIndex = 1;
            this.Login_PasswdInput.TabStop = false;
            this.Login_PasswdInput.UseSystemPasswordChar = true;
            // 
            // Login_UserInput
            // 
            this.Login_UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_UserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_UserInput.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_UserInput.Location = new System.Drawing.Point(2, 33);
            this.Login_UserInput.Margin = new System.Windows.Forms.Padding(10);
            this.Login_UserInput.MaxLength = 32;
            this.Login_UserInput.Name = "Login_UserInput";
            this.Login_UserInput.Size = new System.Drawing.Size(126, 22);
            this.Login_UserInput.TabIndex = 0;
            this.Login_UserInput.TabStop = false;
            // 
            // Login_Center_Right
            // 
            this.Login_Center_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Login_Center_Right.Controls.Add(this.Login_ForgetTittle);
            this.Login_Center_Right.Controls.Add(this.Login_RegisterTittle);
            this.Login_Center_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Login_Center_Right.Location = new System.Drawing.Point(200, 0);
            this.Login_Center_Right.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Center_Right.Name = "Login_Center_Right";
            this.Login_Center_Right.Size = new System.Drawing.Size(70, 178);
            this.Login_Center_Right.TabIndex = 1;
            // 
            // Login_ForgetTittle
            // 
            this.Login_ForgetTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_ForgetTittle.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_ForgetTittle.Location = new System.Drawing.Point(3, 80);
            this.Login_ForgetTittle.Name = "Login_ForgetTittle";
            this.Login_ForgetTittle.Size = new System.Drawing.Size(65, 23);
            this.Login_ForgetTittle.TabIndex = 2;
            this.Login_ForgetTittle.Text = "忘记密码";
            this.Login_ForgetTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_RegisterTittle
            // 
            this.Login_RegisterTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_RegisterTittle.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_RegisterTittle.Location = new System.Drawing.Point(3, 33);
            this.Login_RegisterTittle.Name = "Login_RegisterTittle";
            this.Login_RegisterTittle.Size = new System.Drawing.Size(64, 23);
            this.Login_RegisterTittle.TabIndex = 1;
            this.Login_RegisterTittle.Text = "注册账号";
            this.Login_RegisterTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Center_Left
            // 
            this.Login_Center_Left.BackColor = System.Drawing.Color.Maroon;
            this.Login_Center_Left.Controls.Add(this.Login_PasswdTittle);
            this.Login_Center_Left.Controls.Add(this.Login_UserTittle);
            this.Login_Center_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_Center_Left.Location = new System.Drawing.Point(0, 0);
            this.Login_Center_Left.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Center_Left.Name = "Login_Center_Left";
            this.Login_Center_Left.Size = new System.Drawing.Size(70, 178);
            this.Login_Center_Left.TabIndex = 0;
            // 
            // Login_PasswdTittle
            // 
            this.Login_PasswdTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_PasswdTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_PasswdTittle.Location = new System.Drawing.Point(1, 80);
            this.Login_PasswdTittle.Name = "Login_PasswdTittle";
            this.Login_PasswdTittle.Size = new System.Drawing.Size(69, 23);
            this.Login_PasswdTittle.TabIndex = 1;
            this.Login_PasswdTittle.Text = "密  码:";
            this.Login_PasswdTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_UserTittle
            // 
            this.Login_UserTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_UserTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_UserTittle.Location = new System.Drawing.Point(4, 35);
            this.Login_UserTittle.Name = "Login_UserTittle";
            this.Login_UserTittle.Size = new System.Drawing.Size(66, 23);
            this.Login_UserTittle.TabIndex = 0;
            this.Login_UserTittle.Text = "账  号:";
            this.Login_UserTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_Top
            // 
            this.Login_Top.BackColor = System.Drawing.Color.Fuchsia;
            this.Login_Top.Controls.Add(this.Login_TopTittle);
            this.Login_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login_Top.Location = new System.Drawing.Point(0, 2);
            this.Login_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Login_Top.Name = "Login_Top";
            this.Login_Top.Size = new System.Drawing.Size(270, 73);
            this.Login_Top.TabIndex = 0;
            // 
            // Login_TopTittle
            // 
            this.Login_TopTittle.BackColor = System.Drawing.Color.Teal;
            this.Login_TopTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_TopTittle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_TopTittle.ForeColor = System.Drawing.Color.Yellow;
            this.Login_TopTittle.Location = new System.Drawing.Point(0, 0);
            this.Login_TopTittle.Name = "Login_TopTittle";
            this.Login_TopTittle.Size = new System.Drawing.Size(270, 73);
            this.Login_TopTittle.TabIndex = 0;
            this.Login_TopTittle.Text = "登  录  界  面";
            this.Login_TopTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bottom
            // 
            this.Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(2, 300);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(270, 52);
            this.Bottom.TabIndex = 1;
            // 
            // TOP
            // 
            this.TOP.BackColor = System.Drawing.Color.Yellow;
            this.TOP.Controls.Add(this.TOP_Left);
            this.TOP.Controls.Add(this.TOP_Right);
            this.TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.TOP.Location = new System.Drawing.Point(2, 2);
            this.TOP.Margin = new System.Windows.Forms.Padding(0);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(270, 43);
            this.TOP.TabIndex = 0;
            // 
            // TOP_Left
            // 
            this.TOP_Left.BackColor = System.Drawing.Color.Teal;
            this.TOP_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TOP_Left.Location = new System.Drawing.Point(0, 0);
            this.TOP_Left.Margin = new System.Windows.Forms.Padding(0);
            this.TOP_Left.Name = "TOP_Left";
            this.TOP_Left.Size = new System.Drawing.Size(123, 43);
            this.TOP_Left.TabIndex = 5;
            // 
            // TOP_Right
            // 
            this.TOP_Right.BackColor = System.Drawing.Color.Navy;
            this.TOP_Right.Controls.Add(this.TOP_Min);
            this.TOP_Right.Controls.Add(this.TOP_Close);
            this.TOP_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.TOP_Right.Location = new System.Drawing.Point(123, 0);
            this.TOP_Right.Margin = new System.Windows.Forms.Padding(0);
            this.TOP_Right.Name = "TOP_Right";
            this.TOP_Right.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TOP_Right.Size = new System.Drawing.Size(147, 43);
            this.TOP_Right.TabIndex = 4;
            // 
            // TOP_Min
            // 
            this.TOP_Min.BackColor = System.Drawing.Color.Transparent;
            this.TOP_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.TOP_Min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TOP_Min.FlatAppearance.BorderSize = 0;
            this.TOP_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TOP_Min.Image = global::MyOperation.Properties.Resources.LoginMain_01_Min;
            this.TOP_Min.Location = new System.Drawing.Point(75, 3);
            this.TOP_Min.Name = "TOP_Min";
            this.TOP_Min.Size = new System.Drawing.Size(35, 37);
            this.TOP_Min.TabIndex = 1;
            this.TOP_Min.UseVisualStyleBackColor = false;
            // 
            // TOP_Close
            // 
            this.TOP_Close.BackColor = System.Drawing.Color.Transparent;
            this.TOP_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.TOP_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TOP_Close.FlatAppearance.BorderSize = 0;
            this.TOP_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TOP_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TOP_Close.Image = global::MyOperation.Properties.Resources.LoginMain_01_Close;
            this.TOP_Close.Location = new System.Drawing.Point(110, 3);
            this.TOP_Close.Name = "TOP_Close";
            this.TOP_Close.Size = new System.Drawing.Size(35, 37);
            this.TOP_Close.TabIndex = 0;
            this.TOP_Close.UseVisualStyleBackColor = false;
            // 
            // LoginMain_Forget
            // 
            this.LoginMain_Forget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginMain_Forget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginMain_Forget.Controls.Add(this.Forget_Center);
            this.LoginMain_Forget.Controls.Add(this.Forget_Top);
            this.LoginMain_Forget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Forget.Location = new System.Drawing.Point(2, 45);
            this.LoginMain_Forget.Margin = new System.Windows.Forms.Padding(0);
            this.LoginMain_Forget.Name = "LoginMain_Forget";
            this.LoginMain_Forget.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LoginMain_Forget.Size = new System.Drawing.Size(270, 255);
            this.LoginMain_Forget.TabIndex = 2;
            this.LoginMain_Forget.Visible = false;
            // 
            // Forget_Center
            // 
            this.Forget_Center.BackColor = System.Drawing.Color.Transparent;
            this.Forget_Center.Controls.Add(this.Forget_Center_Center);
            this.Forget_Center.Controls.Add(this.Forget_Center_Right);
            this.Forget_Center.Controls.Add(this.Forget_Center_Left);
            this.Forget_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Forget_Center.Location = new System.Drawing.Point(0, 75);
            this.Forget_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_Center.Name = "Forget_Center";
            this.Forget_Center.Size = new System.Drawing.Size(270, 178);
            this.Forget_Center.TabIndex = 1;
            // 
            // Forget_Center_Center
            // 
            this.Forget_Center_Center.Controls.Add(this.Forget_ForgetButtom);
            this.Forget_Center_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Forget_Center_Center.Location = new System.Drawing.Point(70, 0);
            this.Forget_Center_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_Center_Center.Name = "Forget_Center_Center";
            this.Forget_Center_Center.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Forget_Center_Center.Size = new System.Drawing.Size(130, 178);
            this.Forget_Center_Center.TabIndex = 2;
            // 
            // Forget_ForgetButtom
            // 
            this.Forget_ForgetButtom.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Forget_ForgetButtom.Location = new System.Drawing.Point(2, 125);
            this.Forget_ForgetButtom.Name = "Forget_ForgetButtom";
            this.Forget_ForgetButtom.Size = new System.Drawing.Size(126, 41);
            this.Forget_ForgetButtom.TabIndex = 3;
            this.Forget_ForgetButtom.Text = "提    交";
            this.Forget_ForgetButtom.UseVisualStyleBackColor = true;
            // 
            // Forget_Center_Right
            // 
            this.Forget_Center_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Forget_Center_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Forget_Center_Right.Location = new System.Drawing.Point(200, 0);
            this.Forget_Center_Right.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_Center_Right.Name = "Forget_Center_Right";
            this.Forget_Center_Right.Size = new System.Drawing.Size(70, 178);
            this.Forget_Center_Right.TabIndex = 1;
            // 
            // Forget_Center_Left
            // 
            this.Forget_Center_Left.BackColor = System.Drawing.Color.Lime;
            this.Forget_Center_Left.Controls.Add(this.Forget_NPasswdTittle);
            this.Forget_Center_Left.Controls.Add(this.Forget_VCodeTittle);
            this.Forget_Center_Left.Controls.Add(this.Forget_UserTittle);
            this.Forget_Center_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Forget_Center_Left.Location = new System.Drawing.Point(0, 0);
            this.Forget_Center_Left.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_Center_Left.Name = "Forget_Center_Left";
            this.Forget_Center_Left.Size = new System.Drawing.Size(70, 178);
            this.Forget_Center_Left.TabIndex = 0;
            // 
            // Forget_NPasswdTittle
            // 
            this.Forget_NPasswdTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Forget_NPasswdTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Forget_NPasswdTittle.Location = new System.Drawing.Point(3, 90);
            this.Forget_NPasswdTittle.Name = "Forget_NPasswdTittle";
            this.Forget_NPasswdTittle.Size = new System.Drawing.Size(64, 23);
            this.Forget_NPasswdTittle.TabIndex = 3;
            this.Forget_NPasswdTittle.Text = "新密码:";
            this.Forget_NPasswdTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forget_VCodeTittle
            // 
            this.Forget_VCodeTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Forget_VCodeTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Forget_VCodeTittle.Location = new System.Drawing.Point(4, 55);
            this.Forget_VCodeTittle.Name = "Forget_VCodeTittle";
            this.Forget_VCodeTittle.Size = new System.Drawing.Size(64, 23);
            this.Forget_VCodeTittle.TabIndex = 2;
            this.Forget_VCodeTittle.Text = "验证码:";
            this.Forget_VCodeTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forget_UserTittle
            // 
            this.Forget_UserTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Forget_UserTittle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Forget_UserTittle.Location = new System.Drawing.Point(3, 20);
            this.Forget_UserTittle.Name = "Forget_UserTittle";
            this.Forget_UserTittle.Size = new System.Drawing.Size(64, 23);
            this.Forget_UserTittle.TabIndex = 1;
            this.Forget_UserTittle.Text = "账  号:";
            this.Forget_UserTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forget_Top
            // 
            this.Forget_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Forget_Top.Controls.Add(this.Forget_TopTittle);
            this.Forget_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Forget_Top.Location = new System.Drawing.Point(0, 2);
            this.Forget_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_Top.Name = "Forget_Top";
            this.Forget_Top.Size = new System.Drawing.Size(270, 73);
            this.Forget_Top.TabIndex = 0;
            // 
            // Forget_TopTittle
            // 
            this.Forget_TopTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Forget_TopTittle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Forget_TopTittle.Location = new System.Drawing.Point(0, 0);
            this.Forget_TopTittle.Margin = new System.Windows.Forms.Padding(0);
            this.Forget_TopTittle.Name = "Forget_TopTittle";
            this.Forget_TopTittle.Size = new System.Drawing.Size(270, 73);
            this.Forget_TopTittle.TabIndex = 0;
            this.Forget_TopTittle.Text = "忘  记  密  码";
            this.Forget_TopTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginMain_Register
            // 
            this.LoginMain_Register.BackColor = System.Drawing.Color.Aqua;
            this.LoginMain_Register.Controls.Add(this.Register_Center);
            this.LoginMain_Register.Controls.Add(this.Register_Top);
            this.LoginMain_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMain_Register.Location = new System.Drawing.Point(2, 45);
            this.LoginMain_Register.Name = "LoginMain_Register";
            this.LoginMain_Register.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.LoginMain_Register.Size = new System.Drawing.Size(270, 255);
            this.LoginMain_Register.TabIndex = 2;
            // 
            // Register_Center
            // 
            this.Register_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Register_Center.Controls.Add(this.Register_Center_Center);
            this.Register_Center.Controls.Add(this.Register_Center_Right);
            this.Register_Center.Controls.Add(this.Register_Center_Left);
            this.Register_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register_Center.Location = new System.Drawing.Point(0, 75);
            this.Register_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Register_Center.Name = "Register_Center";
            this.Register_Center.Size = new System.Drawing.Size(270, 178);
            this.Register_Center.TabIndex = 1;
            // 
            // Register_Center_Center
            // 
            this.Register_Center_Center.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Register_Center_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register_Center_Center.Location = new System.Drawing.Point(70, 0);
            this.Register_Center_Center.Margin = new System.Windows.Forms.Padding(0);
            this.Register_Center_Center.Name = "Register_Center_Center";
            this.Register_Center_Center.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Register_Center_Center.Size = new System.Drawing.Size(130, 178);
            this.Register_Center_Center.TabIndex = 2;
            // 
            // Register_Center_Right
            // 
            this.Register_Center_Right.BackColor = System.Drawing.Color.Maroon;
            this.Register_Center_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Register_Center_Right.Location = new System.Drawing.Point(200, 0);
            this.Register_Center_Right.Margin = new System.Windows.Forms.Padding(0);
            this.Register_Center_Right.Name = "Register_Center_Right";
            this.Register_Center_Right.Size = new System.Drawing.Size(70, 178);
            this.Register_Center_Right.TabIndex = 1;
            // 
            // Register_Center_Left
            // 
            this.Register_Center_Left.BackColor = System.Drawing.Color.Purple;
            this.Register_Center_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Register_Center_Left.Location = new System.Drawing.Point(0, 0);
            this.Register_Center_Left.Margin = new System.Windows.Forms.Padding(0);
            this.Register_Center_Left.Name = "Register_Center_Left";
            this.Register_Center_Left.Size = new System.Drawing.Size(70, 178);
            this.Register_Center_Left.TabIndex = 0;
            // 
            // Register_Top
            // 
            this.Register_Top.BackColor = System.Drawing.Color.Yellow;
            this.Register_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Register_Top.Location = new System.Drawing.Point(0, 2);
            this.Register_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Register_Top.Name = "Register_Top";
            this.Register_Top.Size = new System.Drawing.Size(270, 73);
            this.Register_Top.TabIndex = 0;
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
            this.LoginMain_Login.ResumeLayout(false);
            this.Login_Center.ResumeLayout(false);
            this.Login_Center_Center.ResumeLayout(false);
            this.Login_Center_Center.PerformLayout();
            this.Login_Center_Right.ResumeLayout(false);
            this.Login_Center_Left.ResumeLayout(false);
            this.Login_Top.ResumeLayout(false);
            this.TOP.ResumeLayout(false);
            this.TOP_Right.ResumeLayout(false);
            this.LoginMain_Forget.ResumeLayout(false);
            this.Forget_Center.ResumeLayout(false);
            this.Forget_Center_Center.ResumeLayout(false);
            this.Forget_Center_Left.ResumeLayout(false);
            this.Forget_Top.ResumeLayout(false);
            this.LoginMain_Register.ResumeLayout(false);
            this.Register_Center.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        public System.Windows.Forms.Panel Background;
        protected internal System.Windows.Forms.Button TOP_Min;
        protected internal System.Windows.Forms.NotifyIcon LoginMain_SystemICON;
        protected internal System.Windows.Forms.Panel TOP;
        protected internal System.Windows.Forms.Panel TOP_Left;
        protected internal System.Windows.Forms.Panel TOP_Right;
        protected internal System.Windows.Forms.Button TOP_Close;
        protected internal System.Windows.Forms.Panel Login_Center;
        protected internal System.Windows.Forms.Panel Login_Top;
        protected internal System.Windows.Forms.Label Login_TopTittle;
        protected internal System.Windows.Forms.Label Login_PasswdTittle;
        protected internal System.Windows.Forms.Label Login_UserTittle;
        protected internal System.Windows.Forms.TextBox Login_UserInput;
        protected internal System.Windows.Forms.TextBox Login_PasswdInput;
        protected internal System.Windows.Forms.Panel Bottom;
        protected internal System.Windows.Forms.Panel Login_Center_Left;
        protected internal System.Windows.Forms.Panel Login_Center_Center;
        protected internal System.Windows.Forms.Panel Login_Center_Right;
        protected internal System.Windows.Forms.Button Login_LoginButtom;
        protected internal System.Windows.Forms.Label Login_ForgetTittle;
        protected internal System.Windows.Forms.Label Login_RegisterTittle;
        protected internal System.Windows.Forms.Panel LoginMain_Login;
        protected internal System.Windows.Forms.Panel LoginMain_Register;
        protected internal System.Windows.Forms.Panel LoginMain_Forget;
        protected internal System.Windows.Forms.Panel Forget_Top;
        protected internal System.Windows.Forms.Panel Forget_Center;
        protected internal System.Windows.Forms.Panel Forget_Center_Left;
        protected internal System.Windows.Forms.Panel Forget_Center_Center;
        protected internal System.Windows.Forms.Panel Forget_Center_Right;
        protected internal System.Windows.Forms.Panel Register_Center;
        private System.Windows.Forms.Panel Register_Center_Center;
        protected internal System.Windows.Forms.Panel Register_Center_Right;
        protected internal System.Windows.Forms.Panel Register_Center_Left;
        protected internal System.Windows.Forms.Panel Register_Top;
        protected internal System.Windows.Forms.Label Forget_TopTittle;
        protected internal System.Windows.Forms.Label Forget_NPasswdTittle;
        protected internal System.Windows.Forms.Label Forget_VCodeTittle;
        protected internal System.Windows.Forms.Label Forget_UserTittle;
        protected internal System.Windows.Forms.Button Forget_ForgetButtom;
    }
}