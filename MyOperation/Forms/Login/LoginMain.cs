using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyOperation.Forms.Login
{
    public partial class LoginMain : Form
    {
        #region 窗体绘制
        public LoginMain()
        {
            InitializeComponent();
        }
        /******************************
        * 
        * 描述：Init窗体在绘制过程中加载函数
        *       
        * *****************************/
        private void LoginMain_Load(object sender, EventArgs e)
        {

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
        private void TOP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /******************************
        * 
        * 描述：鼠标按下事件触发执行方法
        *           1.主要用于无边框窗体移动的实现
        * 
        * *****************************/
        private void Bottom_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        #endregion


    }
}
