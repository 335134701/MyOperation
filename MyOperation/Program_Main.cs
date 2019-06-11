/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/6/10 16:03:47
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation
/// 项目描述    ：
/// 文件名称    ：Program_Main.cs
/// 类 名 称    ：Program_Main
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation
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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyOperation
{
    public class Program_Main
    {
        private Init_Bean init_Bean;
        public Program_Main()
        {

        }
        /// <summary>
        /// 程序窗体调用处理程序进程
        /// </summary>
        public void Program_Process()
        {
            this.Transfer_Init_Form();
        }
        /// <summary>
        /// 启动初始化界面
        /// </summary>
        public String Transfer_Init_Form()
        {
            init_Bean = new Init_Bean();
            Application.Run(init_Bean.Init);
            return null;
        }
    }
}
