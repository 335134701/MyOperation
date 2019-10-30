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
using MyOperation.Forms.Guide_Forms;

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
            //如果Init窗体执行失败则程序退出
            if (!Transfer_Init_Form()) { return; }

        }
        /// <summary>
        ///Init窗体执行
        /// </summary>
        public Boolean Transfer_Init_Form()
        {
            try
            {
                this.program_Main_Bean.Init_Guide = new Init_Guide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Init_Guide object instantiation failed!");
                throw Ex;
            }
            //返回Init窗体结束状态
            return Judgment_Form_Status(this.program_Main_Bean.Init_Guide.Init_Guide_Start());
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



        /// <summary>
        /// 判断窗体结束后状态值
        /// </summary>
        /// <param name="status">窗体结束返回值</param>
        /// <returns></returns>
        public Boolean Judgment_Form_Status(String Form_Over_Status)
        {
            Boolean flag = false;
            if (Form_Over_Status.Equals("OK"))
            {
                flag = true;
            }
            return flag;
        }
    }
}
