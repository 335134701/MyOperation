using System;

using System.Drawing;
using System.Windows.Forms;
using MyOperation.Beans.Forms_Beans;

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
                this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.init_Event.Background_MouseDown);
            }
        }
        /// <summary>
        /// Init窗体在绘制过程中加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Init_Load(object sender, EventArgs e)
        {
            //设置背景图片
            //this.Background.BackgroundImage = Image.FromFile(this.init_Bean.Init_Method.Get_Index_PhotoPath().ToString());
            //启动定时器
            //this.init_Bean.Init_Method.Start_TimerOne();
        }
        #endregion
    }
}
