using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MyOperation.Beans.Class_Beans;

namespace MyOperation.Forms.Init
{
    public partial class Init : Form
    {
        #region 局部常亮
        public static String imagesDir = "\\Images\\";
        #endregion
        private Program_Init program_Init;

        #region 窗体绘制
        public Init(Program_Init program_Init)
        {
            InitializeComponent();
            //管理对象赋值
            this.program_Init = program_Init;
        }
        /******************************
        * 
        * 描述：Init窗体在绘制过程中加载函数
        *       
        * *****************************/
        private void Init_Load(object sender, EventArgs e)
        {
            //获取前缀为 Init_ 的图片集合
            this.program_Init.GetAll_Photos_Path(this.program_Init.Photos_Operation.All_Serch_Photos(this.program_Init.Path_Operation.Update_Path(1) +imagesDir));
            //生成随机数
            Random rd = new Random();
            //获取生成的随机数对应的图片路径
            String path = this.program_Init.Get_Photo_Path(rd.Next(1, this.program_Init.File_List.Count));
            //设置背景图片
            this.Background.BackgroundImage = Image.FromFile(path);
        }

        #endregion

        #region 无边框拖动效果代码实现
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        /******************************
        * 
        * 描述：鼠标按下事件触发执行方法
        *           1.主要用于无边框窗体移动的实现
        * 
        * *****************************/
        private void Background_MouseDown(object sender, MouseEventArgs e)
        {
            //释放当前线程中某个窗口捕获的光标
            ReleaseCapture();
            //向Windows发送拖动窗体的消息
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
    }
}
