/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/28 19:43:32
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Init
/// 项目描述    ：
/// 文件名称    ：Init_Event.cs
/// 类 名 称    ：Init_Event
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
using MyOperation.Beans.Forms_Beans;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyOperation.Forms.Init
{
    public class Init_Event
    {
        public Init_Bean init_Bean;
        #region 构造函数
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Init_Event() { }
        /// <summary>
        /// 有参数构造函数
        /// </summary>
        /// <param name="init_Bean"></param>
        public Init_Event(Init_Bean init_Bean)
        {
            if (init_Bean != null) { this.init_Bean = init_Bean; }
        }
        #endregion
        /// <summary>
        /// Init窗体在绘制过程中加载函数
        /// </summary>
        public void Init_Event_Load()
        {
            String BackgroundImagePath = "";
               BackgroundImagePath = this.init_Bean.Photos_Operation.Get_Index_PhotoPath(this.init_Bean.ImagesDir, "Init_", -1, this.init_Bean.Path_Operation).ToString();
            if (!BackgroundImagePath.Equals(""))
            {
                //设置背景图片
                this.init_Bean.Init.Background.BackgroundImageLayout = ImageLayout.Stretch;
                this.init_Bean.Init.Background.BackgroundImage = Image.FromFile(BackgroundImagePath);
            }
            //启动定时器
            this.init_Bean.Init_Method.Start_TimerOne();
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Background_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.init_Bean != null)
            {
                this.init_Bean.Init_Method.Init_Form_Move(this.init_Bean.Init);
            }
        }
    }
}
