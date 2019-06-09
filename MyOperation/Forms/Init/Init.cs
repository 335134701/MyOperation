using System;

using System.Drawing;
using System.Windows.Forms;
using MyOperation.Beans.Forms_Beans;

namespace MyOperation.Forms.Init
{
    public partial class Init : Form
    {
        private Init_Bean init_Bean;

        #region 窗体绘制
        public Init(Init_Bean init_Bean)
        {
            InitializeComponent();
            //管理对象赋值
            this.init_Bean = init_Bean;
        }
        /******************************
        * 
        * 描述：Init窗体在绘制过程中加载函数
        *       
        * *****************************/
        private void Init_Load(object sender, EventArgs e)
        {
            //设置背景图片
            this.Background.BackgroundImage = Image.FromFile(this.init_Bean.Init_Method.Get_Index_Path().ToString());
        }

        #endregion 
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Background_MouseDown(object sender, MouseEventArgs e)
        {
            //释放当前线程中某个窗口捕获的光标
            Init_Bean.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            Init_Bean.SendMessage(this.Handle, Init_Bean.WM_SYSCOMMAND, Init_Bean.SC_MOVE + Init_Bean.HTCAPTION, 0);
        }
    }
}
