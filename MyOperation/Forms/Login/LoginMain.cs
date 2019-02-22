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
            //释放当前线程中某个窗口捕获的光标
            ReleaseCapture();
            //向Windows发送拖动窗体的消息
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
            //释放当前线程中某个窗口捕获的光标
            ReleaseCapture();
            //向Windows发送拖动窗体的消息
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /******************************
        * 
        * 描述：鼠标按下事件触发执行方法
        *           1.主要用于无边框窗体移动的实现
        * 
        * *****************************/
        private void TOP_Left_MouseDown(object sender, MouseEventArgs e)
        {
            //释放当前线程中某个窗口捕获的光标
            ReleaseCapture();
            //向Windows发送拖动窗体的消息
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        /******************************
        * 
        * 描述：鼠标按下事件触发执行方法
        *           1.主要用于无边框窗体移动的实现
        * 
        * *****************************/
        private void TOP_Right_MouseDown(object sender, MouseEventArgs e)
        {
            //释放当前线程中某个窗口捕获的光标
            ReleaseCapture();
            //向Windows发送拖动窗体的消息
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region  TOP按钮触发事件处理实现
        /******************************
        * 
        * 描述：按钮按下事件触发执行方法
        *           1.主要用于最小化功能的实现
        * 
        * *****************************/
        private void Min_Click(object sender, EventArgs e)
        {
            //改变窗体状态
            this.WindowState = FormWindowState.Minimized;
            //系统托盘图标可见
            this.LoginMain_notifyIcon1.Visible = true;
            //关闭任务栏显示
            this.ShowInTaskbar = false;
        }
        /******************************
        * 
        * 描述：按钮按下事件触发执行方法
        *           1.主要用于关闭窗体功能的实现
        * 
        * *****************************/
        private void Close_Click(object sender, EventArgs e)
        {
            //关闭窗体，返回窗体值
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
        /******************************
        * 
        * 描述：双击系统托盘图标执行方法
        *           1.主要用于窗体还原的实现
        * 
        * *****************************/
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //设置窗体正常显示
            this.WindowState = FormWindowState.Normal;
            //设置系统托盘图标不可见
            this.LoginMain_notifyIcon1.Visible = false;
            //开启任务栏显示
            this.ShowInTaskbar = true;
        }
        /******************************
        * 
        * 描述：按钮移入事件触发执行方法
        *           1.主要用于背景边框改变的实现
        * 
        * *****************************/
        private void Min_MouseEnter(object sender, EventArgs e)
        {
            //鼠标移入最小化按钮，设置背景颜色
            this.LoginMain_TOP_Min.BackColor = Color.Silver;
            //鼠标移入最小化按钮，添加边框大小
            this.LoginMain_TOP_Min.FlatAppearance.BorderSize = 1;
            //鼠标移入最小化按钮，设置边框颜色
            this.LoginMain_TOP_Min.FlatAppearance.BorderColor = Color.Silver;
        }
        /******************************
        * 
        * 描述：按钮移除事件触发执行方法
        *           1.主要用于背景边框改变的实现
        * 
        * *****************************/
        private void Min_MouseLeave(object sender, EventArgs e)
        {
            //鼠标移除最小化按钮，去掉边框大小
            this.LoginMain_TOP_Min.FlatAppearance.BorderSize = 0;
            //鼠标移除最小化按钮，设置背景透明
            this.LoginMain_TOP_Min.BackColor = Color.Transparent;
        }
        /******************************
        * 
        * 描述：按钮移入事件触发执行方法
        *           1.主要用于背景边框改变的实现
        * 
        * *****************************/
        private void Close_MouseEnter(object sender, EventArgs e)
        {
            //鼠标移入关闭按钮，设置背景颜色
            this.LoginMain_TOP_Close.BackColor = Color.Red;
            //鼠标移入关闭按钮，设置边框大小
            this.LoginMain_TOP_Close.FlatAppearance.BorderSize = 1;
            //鼠标移入关闭按钮，设置边框颜色
            this.LoginMain_TOP_Close.FlatAppearance.BorderColor = Color.Silver;
        }
        /******************************
        * 
        * 描述：按钮移除事件触发执行方法
        *           1.主要用于背景边框改变的实现
        * 
        * *****************************/
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            //鼠标移除关闭按钮，去掉背景颜色
            this.LoginMain_TOP_Close.BackColor = Color.Transparent;
            //鼠标移除关闭按钮，去掉边框大小
            this.LoginMain_TOP_Close.FlatAppearance.BorderSize = 0;
        }
        #endregion
    }
}
