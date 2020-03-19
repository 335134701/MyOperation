
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
               

                this.Form_decoration();
                this.loginMain_Event.LoginMain_Event_Load();
                
            }
        }
        /// <summary>
        /// 窗体修饰，主要处理一些在设计界面上没有的特效处理
        /// </summary>
        public void Form_decoration()
        {
            this.DoubleBuffered = true;//设置本窗体
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            this.SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
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
