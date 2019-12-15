
using System;
using System.Windows.Forms;

namespace MyOperation.Forms.Login
{
    public partial class LoginMain : Form
    {
        private LoginMain_Event loginMain_Event;

        #region 窗体绘制
        public LoginMain()
        {
            InitializeComponent();
        }
        public LoginMain(LoginMain_Event loginMain_Event)
        {
            InitializeComponent();
            if (loginMain_Event != null) { this.loginMain_Event = loginMain_Event;}
        }

        /// <summary>
        /// LoginMain窗体在绘制过程中加载函数        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginMain_Load(object sender, EventArgs e)
        {
            if (this.loginMain_Event != null)
            {
               
                this.LoginMain_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.Bottom_MouseDown);
                this.LoginMain_TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.TOP_MouseDown);
                this.LoginMain_TOP_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.TOP_Left_MouseDown);
                this.LoginMain_TOP_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.TOP_Right_MouseDown);
                this.LoginMain_TOP_Min.Click += new System.EventHandler(this.loginMain_Event.Min_Click);
                this.LoginMain_TOP_Min.MouseEnter += new System.EventHandler(this.loginMain_Event.Min_MouseEnter);
                this.LoginMain_TOP_Min.MouseLeave += new System.EventHandler(this.loginMain_Event.Min_MouseLeave);
                this.LoginMain_TOP_Close.Click += new System.EventHandler(this.loginMain_Event.Close_Click);
                this.LoginMain_TOP_Close.MouseEnter += new System.EventHandler(this.loginMain_Event.Close_MouseEnter);
                this.LoginMain_TOP_Close.MouseLeave += new System.EventHandler(this.loginMain_Event.Close_MouseLeave);
                this.LoginMain_SystemICON.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.SystemICON_MouseDoubleClick);
                this.LoginMain_Login_Center_UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginMain_Event.LoginMain_Login_Center_UserInput_KeyPress);
                this.LoginMain_Login_Center.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_Center_MouseDown);
                this.LoginMain_Login_Center_Center.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_Center_Center_MouseDown);
                this.LoginMain_Login_Center_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_Center_Right_MouseDown);
                this.LoginMain_Login_Center_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_Center_Left_MouseDown);
                this.LoginMain_Login_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_Top_MouseDown);
                this.LoginMain_Login_TopTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginMain_Event.LoginMain_Login_TopTittle_MouseDown);
                this.Form_decoration();
                this.loginMain_Event.LoginMain_Event_Load();
                
            }
        }
        /// <summary>
        /// 窗体修饰，主要处理一些在设计界面上没有的特效处理
        /// </summary>
        public void Form_decoration()
        {



        }
        /// <summary>
        ///  窗体闪烁问题解决
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

    }
}
