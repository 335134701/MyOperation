/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/2/19 11:59:31 
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Class_Beans
/// 项目描述    ：本类主要作用：Program.cs跳转到Init.cs中需要调用的对象集合类
/// 文件名称    ：Program_Init.cs
/// 类 名 称    ：Program_Init
/// 类 描 述    ：Init窗体界面中所有需要的Bean对象类
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Class_Beans
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

using System;
using System.Collections.Generic;
using System.IO;
using MyOperation.Forms.Init;
using MyOperation.Common_Method.Files_Operation;
using MyOperation.Forms_Methods.Init_Methods;
using MyOperation.Forms_Methods.Form_Common_Methods;
using System.Runtime.InteropServices;
using System.Timers;

namespace MyOperation.Beans.Forms_Beans
{
    public class Init_Bean
    {
        //图片相对路径前缀
        private String imagesDir = "\\Images\\";
        private List<FileInfo> all_Init_Photos;
        private Photos_Operation photos_Operation;
        private Path_Operation path_Operation;
        private Photo_Method photo_Method;
        private Init_Method init_Method;
        private Init init;
        //申明定时器对象
        private Timer timerOne;
        private int timerOneInterval = 2500;
        //申明委托事件，处理定时器关闭窗体事件
        public delegate void Init_Close();



        public Init_Bean()
        {
            //TimerOne对象在Init_Method中使用，因此需要先实例化TimerOne，再实例化Init_Method
            TimerOne = new Timer();
            Photos_Operation = new Photos_Operation();
            path_Operation = new Path_Operation();
            Photo_Method = new Photo_Method();
            if (TimerOne != null) Init_Method = new Init_Method(this);
            else { TimerOne = new Timer(); Init_Method = new Init_Method(this); }
            All_Init_Photos = new List<FileInfo>();
            Init = new Init(this);
        }

        #region 无边框拖动效果参数定义及函数声明
        private const int wM_SYSCOMMAND = 0x0112;
        private const int sC_MOVE = 0xF010;
        private const int hTCAPTION = 0x0002;

        public static int WM_SYSCOMMAND => wM_SYSCOMMAND;

        public static int SC_MOVE => sC_MOVE;

        public static int HTCAPTION => hTCAPTION;

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        #endregion
        
        /// <summary>
        /// init对象的GET(),SET()方法
        /// </summary>
        public Init Init { get => init; set => init = value; }
        public Photos_Operation Photos_Operation { get => photos_Operation; set => photos_Operation = value; }
        public Path_Operation Path_Operation { get => path_Operation; set => path_Operation = value; }
        public string ImagesDir { get => imagesDir; set => imagesDir = value; }
        public Photo_Method Photo_Method { get => photo_Method; set => photo_Method = value; }
        public Init_Method Init_Method { get => init_Method; set => init_Method = value; }
        public List<FileInfo> All_Init_Photos { get => all_Init_Photos; set => all_Init_Photos = value; }
        public Timer TimerOne { get => timerOne; set => timerOne = value; }
        public int TimerOneInterval { get => timerOneInterval; set => timerOneInterval = value; }

    }
}
