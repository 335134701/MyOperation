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
/// 类 描 述    ：
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
using System.Linq;
using System.Text;
using MyOperation.Forms.Init;

namespace MyOperation.Beans.Class_Beans
{
    class Program_Init
    {
        private Init init;

        public Program_Init()
        {
            Init = new Init();
        }

        /******************************
         * 
         * 描述：init对象的GET(),SET()方法
         * 
         * *****************************/
        public Init Init { get => init; set => init = value; }
    }
}
