/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/22 19:55:37
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.Log_Operation
/// 项目描述    ：
/// 文件名称    ：Log4net_Console_02.cs
/// 类 名 称    ：Log4net_Console_02
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Common_Method.Log_Operation
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
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Common_Method.Log_Operation
{
    public class Log4net_Console_02
    {
        public static readonly ILog console_Log = LogManager.GetLogger("Console_Log");
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Log4net_Console_02()
        {
            //输出测试
            this.Deme("111111111111111111");

        }
        /// <summary>
        /// 测试日志输出
        /// </summary>
        /// <param name="text">输出内容</param>
        public void Deme(String text)
        {
            console_Log.InfoFormat(text);
            console_Log.WarnFormat(text);
            console_Log.ErrorFormat(text);
            console_Log.DebugFormat(text);
            console_Log.FatalFormat(text);
        }
    }
}
