/// ***********************************************************************
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Beans.Forms_Beans
{
    public class Program_Main_Bean
    {

        private Init_Bean init_Bean;
        private LoginMain_Bean loginMain_Bean;
        //程序开始过程中初始化标志位
        private Boolean init_flg= false;

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Program_Main_Bean()
        {

        }

        public Init_Bean Init_Bean { get => init_Bean; set => init_Bean = value; }
        public LoginMain_Bean LoginMain_Bean { get => loginMain_Bean; set => loginMain_Bean = value; }
        public bool Init_flg { get => init_flg; set => init_flg = value; }
    }
}
