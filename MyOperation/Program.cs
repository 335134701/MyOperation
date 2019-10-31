﻿using System;
using System.Windows.Forms;
using MyOperation.Common_Method.Log_Operation;


namespace MyOperation
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogHelper.WriteInfoLog("MyOperation program starts running!");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Trace.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ffff")+"：Program_Main创建");
            //创建Program_Main对象
            LogHelper.WriteInfoLog("Program_Main object starts instantiation!");
            Program_Main program_Main = new Program_Main();
            LogHelper.WriteInfoLog("Program_Process method in program_Main starts to call!");
            program_Main.Program_Process();

           
        }
    }
}
