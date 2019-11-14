﻿/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/26 18:50:55
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Beans.Forms_Beans
/// 项目描述    ：
/// 文件名称    ：Program_Main_Bean.cs
/// 类 名 称    ：Program_Main_Bean
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
using MyOperation.Forms.Guide_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Beans.Forms_Beans
{
    public class Program_Main_Bean
    {
        //Init初始化窗体引导程序
        private Init_Guide init_Guide;
        private LoginMain_Guide loginMain_Guide;
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Program_Main_Bean() { }

      
        public Init_Guide Init_Guide { get => init_Guide; set => init_Guide = value; }
        public LoginMain_Guide LoginMain_Guide { get => loginMain_Guide; set => loginMain_Guide = value; }
    }
}