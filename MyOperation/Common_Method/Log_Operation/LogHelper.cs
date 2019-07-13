/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/7/13 14:38:07
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.Log_Operation
/// 项目描述    ：
/// 文件名称    ：LogHelper.cs
/// 类 名 称    ：LogHelper
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Common_Method.Log_Operation
{
    class LogHelper
    {
        public static log4net.ILog infoLog = log4net.LogManager.GetLogger("Info");
        public static log4net.ILog warnLog = log4net.LogManager.GetLogger("Warn");
        public static log4net.ILog errorLog = log4net.LogManager.GetLogger("Error");
        public static log4net.ILog debugLog = log4net.LogManager.GetLogger("Debug");
        public static log4net.ILog fatalLog = log4net.LogManager.GetLogger("Fatal");

        /// <summary>
        /// 正常日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteInfoLog(string message,params object[] args)
        {
            if (infoLog.IsInfoEnabled)
            {
                infoLog.InfoFormat(message,args);
            }
        }
        /// <summary>
        /// 警告日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteWarnLog(string message, params object[] args)
        {
            if (warnLog.IsWarnEnabled)
            {
                warnLog.WarnFormat(message,args);
            }
        }
        /// <summary>
        /// 错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteErrorLog(string message, params object[] args)
        {
            if (errorLog.IsErrorEnabled)
            {
                errorLog.ErrorFormat(message, args);
            }
        }
        /// <summary>
        /// 调试日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteDebugLog(string message, params object[] args)
        {
            if (debugLog.IsDebugEnabled)
            {
                debugLog.DebugFormat(message, args);
            }
        }
        /// <summary>
        /// 严重错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteFatalLog(string message, params object[] args)
        {
            if (fatalLog.IsFatalEnabled)
            {
                fatalLog.FatalFormat(message, args);
            }
        }

    }
}
