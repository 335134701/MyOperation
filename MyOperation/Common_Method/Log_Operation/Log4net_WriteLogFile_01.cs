/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/22 19:57:02
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.Log_Operation
/// 项目描述    ：
/// 文件名称    ：Log4net_WriteLogFile_01.cs
/// 类 名 称    ：Log4net_WriteLogFile_01
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
    public class Log4net_WriteLogFile_01
    {
        /*写入日志文件配置,第一种方式*/
        public static readonly ILog infoLog_Write = LogManager.GetLogger("Info_Write");
        public static readonly ILog warnLog_Write = LogManager.GetLogger("Warn_Write");
        public static readonly ILog errorLog_Write = LogManager.GetLogger("Error_Write");
        public static readonly ILog debugLog_Write = LogManager.GetLogger("Debug_Write");
        public static readonly ILog fatalLog_Write = LogManager.GetLogger("Fatal_Write");
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Log4net_WriteLogFile_01()
        {
            this.Demo("1111111111111111");
        }
        /// <summary>
        /// 测试案例
        /// </summary>
        /// <param name="text"></param>
        public void Demo(String text)
        {
            Log4net_WriteLogFile_01.WriteInfoLog(text);
            Log4net_WriteLogFile_01.WriteWarnLog(text);
            Log4net_WriteLogFile_01.WriteDebugLog(text);
            Log4net_WriteLogFile_01.WriteErrorLog(text);
            Log4net_WriteLogFile_01.WriteFatalLog(text);
        }
        /// <summary>
        /// 正常日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteInfoLog(string message, params object[] args)
        {
            if (infoLog_Write.IsInfoEnabled)
            {
                infoLog_Write.InfoFormat(message, args);
            }
        }
        /// <summary>
        /// 警告日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteWarnLog(string message, params object[] args)
        {
            if (warnLog_Write.IsWarnEnabled)
            {
                warnLog_Write.WarnFormat(message, args);
            }
        }
        /// <summary>
        /// 错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteErrorLog(string message, params object[] args)
        {
            if (errorLog_Write.IsErrorEnabled)
            {
                errorLog_Write.ErrorFormat(message, args);
            }
        }
        /// <summary>
        /// 调试日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteDebugLog(string message, params object[] args)
        {
            if (debugLog_Write.IsDebugEnabled)
            {
                debugLog_Write.DebugFormat(message, args);
            }
        }
        /// <summary>
        /// 严重错误日志输出写入文本方法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void WriteFatalLog(string message, params object[] args)
        {
            if (fatalLog_Write.IsFatalEnabled)
            {
                fatalLog_Write.FatalFormat(message, args);
            }
        }
    }
}
