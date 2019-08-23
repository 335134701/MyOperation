/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/22 19:58:16
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
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Common_Method.Log_Operation
{
    public class LogHelper
    {
        public static readonly ILog log = LogManager.GetLogger("Log");

        /// <summary>
        /// 正常日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteInfoLog(string message, params object[] args)
        {
            if (log.IsInfoEnabled)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    message = message + "\n" + "             " + args[i];
                }
                log.Info(message);
            }
        }
        /// <summary>
        /// 警告日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteWarnLog(string message, params object[] args)
        {
            if (log.IsWarnEnabled)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    message = message + "\n" + "             " + args[i];
                }
                log.Warn(message);
            }
        }
        /// <summary>
        /// 错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteErrorLog(string message, Exception ex)
        {
            if (log.IsErrorEnabled)
            {

                log.Error(message, ex);
            }
        }
        /// <summary>
        /// 调试日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteDebugLog(string message, params object[] args)
        {
            if (log.IsDebugEnabled)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    message = message + "\n" + "             " + args[i];
                }
                log.Debug(message);
            }
        }
        /// <summary>
        /// 严重错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteFatalLog(string message, Exception ex)
        {
            if (log.IsFatalEnabled)
            {
                log.Fatal(message, ex);
            }
        }
    }
}
