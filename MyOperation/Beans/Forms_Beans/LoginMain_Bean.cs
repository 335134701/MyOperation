/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/6/10 2:46:47
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Beans.Forms_Beans
/// 项目描述    ：
/// 文件名称    ：LoginMain.cs
/// 类 名 称    ：LoginMain
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Beans.Forms_Beans
/// 机器名称    ：ZC-PC
/// CLR 版本    ：4.0.30319.42000
/// 版 本 号    ：v1.0.0.0
/// =================================
/// 修改者      ：
/// 修改日期    ：
/// 修改内容    ：
/// 修改版本    ：v1.0.0.0
/// =================================
///
/// ***********************************************************************
using MyOperation.Forms.Login;
using System;
using System.Runtime.InteropServices;

namespace MyOperation.Beans.Forms_Beans
{
    public class LoginMain_Bean
    {
        private LoginMain loginMain;
        private LoginMain_Method loginMain_Method;
        private LoginMain_Event loginMain_Event;

        #region 构造方法
        public LoginMain_Bean() { }
        #endregion

        #region 无边框拖动效果参数定义及函数声明
        private const int wM_SYSCOMMAND = 0x0112;
        private const int sC_MOVE = 0xF010;
        private const int hTCAPTION = 0x0002;
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static int WM_SYSCOMMAND => wM_SYSCOMMAND;

        public static int SC_MOVE => sC_MOVE;

        public static int HTCAPTION => hTCAPTION;
        #endregion

        #region 申明变量的GET(),SET()方法
        public LoginMain LoginMain { get => loginMain; set => loginMain = value; }
        public LoginMain_Method LoginMain_Method { get => loginMain_Method; set => loginMain_Method = value; }
        public LoginMain_Event LoginMain_Event { get => loginMain_Event; set => loginMain_Event = value; }
        #endregion
    }
}
