/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/28 19:17:24
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Init
/// 项目描述    ：
/// 文件名称    ：Init_Method.cs
/// 类 名 称    ：Init_Method
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms.Init
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
using System.Timers;
using System.Windows.Forms;
using MyOperation.Beans.Forms_Beans;
using MyOperation.Common_Method.Files_Operation;
using MyOperation.Forms.Init;

namespace MyOperation.Forms.Init
{
    public class Init_Method
    {
        public Init_Bean init_Bean;
        #region 构造函数
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Init_Method() { }
        /// <summary>
        /// 有参数构造函数
        /// </summary>
        /// <param name="init_Bean"></param>
        public Init_Method(Init_Bean init_Bean) { if (init_Bean != null) { this.init_Bean = init_Bean; } }
        #endregion


        /// <summary>
        /// 处理窗体取消边框后的移动问题
        /// </summary>
        /// <param name="form"></param>
        public void Init_Form_Move(Form form)
        {
            //释放当前线程中某个窗口捕获的光标
            Init_Bean.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            Init_Bean.SendMessage(form.Handle, Init_Bean.WM_SYSCOMMAND, Init_Bean.SC_MOVE + Init_Bean.HTCAPTION, 0);
        }

        /// <summary>
        /// 启动定时器1
        /// </summary>
        public void Start_TimerOne()
        {
            //初始化定时器1
            //设置定时器周期执行间隔时间，单位毫秒
            this.init_Bean.TimerOne.Interval = this.init_Bean.TimerOneInterval;
            //指定定时器执行的方法
            this.init_Bean.TimerOne.Elapsed += new ElapsedEventHandler(TimerOne_Method);
            //设置定时器是否周期执行
            this.init_Bean.TimerOne.AutoReset = false;
            //开启定时器1
            this.init_Bean.TimerOne.Enabled = true;
        }
        /// <summary>
        /// 定时器定时执行方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void TimerOne_Method(object source, ElapsedEventArgs e)
        {
            //释放定时器1
            this.init_Bean.TimerOne.Close();
            //由于定时器线程与UI线程不在同一线程之中故需使用委托的方式对UI线程执行操作
            //control.invoke(参数delegate)方法:在拥有此控件的基础窗口句柄的线程上执行指定的委托。
            //control.begininvoke(参数delegate)方法:在创建控件的基础句柄所在线程上异步执行指定委托。
            this.init_Bean.Init.BeginInvoke(new Init_Bean.Init_Close(Init_Form_Close));
        }
        /// <summary>
        /// 由于定时器与窗体不是同一个线程，暂时无法在定时器执行方法中关闭Init窗体，故采用委托的方式关闭窗体
        /// </summary>
        public void Init_Form_Close()
        {
            //设置Init窗体关闭状态
            this.init_Bean.Init.DialogResult = DialogResult.OK;
            //关闭Init窗体
            this.init_Bean.Init.Close();
        }
    }

}
