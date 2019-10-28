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

using System;
using System.Diagnostics;
using System.Windows.Forms;
using MyOperation.Beans.Forms_Beans;
using MyOperation.Common_Method.Log_Operation;
using MyOperation.Forms.Init;

namespace MyOperation
{
    public class Program_Main
    {
        //申明程序开始处理执行需要定义的类的集合
        private Program_Main_Bean program_Main_Bean;
        /// <summary>
        /// Program_Main构造方法
        /// </summary>
        public Program_Main()
        {
            program_Main_Bean = new Program_Main_Bean();
        }
        /// <summary>
        /// 程序窗体调用处理程序进程
        /// </summary>
        public void Program_Process()
        {

            String Forms_Status = this.Transfer_Init_Form();

            if (!Forms_Status.Equals("OK")) return;

            Forms_Status = this.Transfer_Login_Form();
        }
        /// <summary>
        ///Init窗体执行
        /// </summary>
        public String Transfer_Init_Form()
        {
            try
            {
                this.program_Main_Bean.Init_Bean = new Init_Bean();
                if (this.program_Main_Bean.Init_Bean != null)
                {
                    this.program_Main_Bean.Init_Bean.Init_Method = new Init_Method();
                    Console.WriteLine(this.program_Main_Bean.Init_Bean.Init_Method);
                    //执行实例化Init窗体中所有申明对象
                    //this.program_Main_Bean.Init_Bean.Init_Method.Instantiation_Bean_Object();
                    this.program_Main_Bean.Init_Bean.Init = new Init();
                    //运行Init窗体
                    Application.Run(this.program_Main_Bean.Init_Bean.Init);
                }
                else {
                    MessageBox.Show("窗体运行失败。。。。。。。");
                    //提示错误。。。。。。。。。。。。。。。。。。。
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //返回Init窗体结束状态
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
