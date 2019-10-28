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
using MyOperation.Common_Method.Log_Operation;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyOperation
{
    public class Program_Main
    {
        
        private Program_Main_Bean program_Main_Bean;
        public Program_Main()
        {
            program_Main_Bean = new Program_Main_Bean();
        }
        /// <summary>
        /// 程序窗体调用处理程序进程
        /// </summary>
        public void Program_Process()
        {
          
            String Forms_Status=this.Transfer_Init_Form();
            if (!Forms_Status.Equals("OK")) return;
            Forms_Status = this.Transfer_Login_Form();
        }
        /// <summary>
        ///Init窗体执行
        /// </summary>
        public String Transfer_Init_Form()
        {

            program_Main_Bean.Init_Bean = new Init_Bean();
           
            Application.Run(program_Main_Bean.Init_Bean.Init);

            return program_Main_Bean.Init_Bean.Init.DialogResult.ToString();
        }
        /// <summary>
        /// Login窗体逻辑执行
        /// </summary>
        /// <returns></returns>
        public String Transfer_Login_Form()
        {

            program_Main_Bean.LoginMain_Bean = new LoginMain_Bean();
          
            Application.Run(program_Main_Bean.LoginMain_Bean.LoginMain);
           
            return program_Main_Bean.LoginMain_Bean.LoginMain.DialogResult.ToString();
        }
    }
}
