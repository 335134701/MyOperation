using System;
using System.Drawing;
using System.Windows.Forms;


namespace MyOperation.Forms.Init
{
    public partial class Init : Form
    {
        private Init_Event init_Event;

        #region 窗体绘制
        public Init() { InitializeComponent(); }
        public Init(Init_Event init_Event)
        {
            InitializeComponent();
            if (init_Event != null)
            {
                this.init_Event = init_Event;
            }
        }
        /// <summary>
        /// Init窗体在绘制过程中加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Init_Load(object sender, EventArgs e)
        {
            if (init_Event != null)
            {
                this.Form_decoration();
                //调用Init_Event_Load方法执行Init_Load操作
                this.init_Event.Init_Event_Load();
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
