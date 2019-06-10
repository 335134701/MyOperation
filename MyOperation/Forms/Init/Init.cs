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
            //启动定时器
            this.init_Bean.Init_Method.Start_TimerOne();
        }
        /// <summary>
        /// Init窗体在绘制过程中加载函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.init_Bean.Init_Method.Form_Move(this);
        }

    }
}
