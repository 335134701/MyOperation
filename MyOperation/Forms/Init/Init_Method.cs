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
        private Init_Bean init_Bean;
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Init_Method() { }
        public Init_Method(Init_Bean init_Bean) { this.init_Bean = init_Bean; }
        public Init_Bean Init_Bean { get => init_Bean; set => init_Bean = value; }

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
        /// Init窗体中获取背景图片绝对路径处理方法，实现随机显示背景图片
        /// </summary>
        /// <returns></returns>
        public String Get_Index_PhotoPath()
        {
            String Init_background_Photopath = null;
            this.Init_Bean.All_Init_Photos = this.Init_Bean.Photos_Operation.Get_AllPhotos_Path(
                this.Init_Bean.Photos_Operation.All_Serch_Photos(
                    this.Init_Bean.Path_Operation.Update_Path(1) + this.Init_Bean.ImagesDir, new String[] { "jpg", "jpeg" })
                    , "Init_");
            //生成随机数
            Random rd = new Random();
            //判断能否获取到Init图片集合，如果不能获取，则结束函数
            if (this.Init_Bean.All_Init_Photos.Count < 0) { return Init_background_Photopath; }
            //获取生成的随机数对应的图片路径
            Init_background_Photopath = this.Init_Bean.Photos_Operation.Get_Photo_Path(rd.Next(1, this.Init_Bean.All_Init_Photos.Count+1), this.Init_Bean.All_Init_Photos);
            return Init_background_Photopath;
        }

        /// <summary>
        /// 启动定时器1
        /// </summary>
        public void Start_TimerOne()
        {
            //初始化定时器1
            //设置定时器周期执行间隔时间，单位毫秒
            this.Init_Bean.TimerOne.Interval = this.Init_Bean.TimerOneInterval;
            //指定定时器执行的方法
            this.Init_Bean.TimerOne.Elapsed += new ElapsedEventHandler(TimerOne_Method);
            //设置定时器是否周期执行
            this.Init_Bean.TimerOne.AutoReset = false;
            //开启定时器1
            this.Init_Bean.TimerOne.Enabled = true;
        }
        /// <summary>
        /// 定时器定时执行方法
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void TimerOne_Method(object source, ElapsedEventArgs e)
        {
            //释放定时器1
            this.Init_Bean.TimerOne.Close();
            //由于定时器线程与UI线程不在同一线程之中故需使用委托的方式对UI线程执行操作
            //control.invoke(参数delegate)方法:在拥有此控件的基础窗口句柄的线程上执行指定的委托。
            //control.begininvoke(参数delegate)方法:在创建控件的基础句柄所在线程上异步执行指定委托。
            this.Init_Bean.Init.BeginInvoke(new Init_Bean.Init_Close(Init_Form_Close));
        }
        /// <summary>
        /// 由于定时器与窗体不是同一个线程，暂时无法在定时器执行方法中关闭Init窗体，故采用委托的方式关闭窗体
        /// </summary>
        public void Init_Form_Close()
        {
            //设置Init窗体关闭状态
            this.Init_Bean.Init.DialogResult = DialogResult.OK;
            //关闭Init窗体
            this.Init_Bean.Init.Close();
        }
    }

}
