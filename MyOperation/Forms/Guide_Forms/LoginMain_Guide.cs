/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/31 21:56:10
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Guide_Forms
/// 项目描述    ：
/// 文件名称    ：Login_Guide.cs
/// 类 名 称    ：LoginMain_Guide
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms.Guide_Forms
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
using MyOperation.Forms.Login;
using System;
using System.Windows.Forms;

namespace MyOperation.Forms.Guide_Forms
{
    public class LoginMain_Guide
    {
        private LoginMain_Bean loginMain_Bean;
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginMain_Guide() { }

        public String Init_Guide_Start()
        {
            String LoginMain_Guide_Start_flag = null;
            LogHelper.WriteInfoLog("Instantiated_object method starts executing!");
            //判断Instantiated_object方法执行成功与否，若成功则继续执行
            if (Instantiated_object())
            {
                LogHelper.WriteInfoLog("Start_Run_InitForm method starts executing!");
                LoginMain_Guide_Start_flag = Start_Run_LoginMainForm();
            }
            return LoginMain_Guide_Start_flag;
        }

        /// <summary>
        /// 实例化LoginMain_Bean中申明的对象
        /// </summary>
        /// <returns>返回LoginMain_Bean中申明对象实例化成功与否</returns>
        public Boolean Instantiated_object()
        {
            Boolean Instantiated_flag = false;
            try
            {
                LogHelper.WriteInfoLog("The object declared in the LoginMain_Bean starts to initialize");
                this.loginMain_Bean = new LoginMain_Bean();
                LogHelper.WriteInfoLog("The object declared in the LoginMain_Event starts to initialize");
                this.loginMain_Bean.LoginMain_Event = new LoginMain_Event();
                LogHelper.WriteInfoLog("The object declared in the LoginMain_Method starts to initialize");
                this.loginMain_Bean.LoginMain_Method = new LoginMain_Method();
                Instantiated_flag = true;
            }
            catch (Exception Ex)
            {
                Instantiated_flag = false;
                LogHelper.WriteFatalLog("The Instantiated_object() method run fail!", Ex);
                MessageBox.Show("Instantiated_object() method run fail!");
                throw Ex;
            }    
            return Instantiated_flag;
        }

        /// <summary>
        /// 开始运行LoginMain窗体
        /// </summary>
        /// <returns>返回窗体结束状态值</returns>
        public String Start_Run_LoginMainForm()
        {
            String Start_Run_LoginMainForm_flag = null;
            try
            {
                LogHelper.WriteInfoLog("The Init object declared in the Init_Bean starts to initialize");
                this.loginMain_Bean.LoginMain = new LoginMain(this.loginMain_Bean.LoginMain_Event);
                this.loginMain_Bean.LoginMain_Event.loginMain_Bean = this.loginMain_Bean;
                this.loginMain_Bean.LoginMain_Method.loginMain_Bean = this.loginMain_Bean;
                LogHelper.WriteInfoLog("Init form starts running");
                Application.Run(this.loginMain_Bean.LoginMain);
                Start_Run_LoginMainForm_flag = this.loginMain_Bean.LoginMain.DialogResult.ToString();
            }
            catch (Exception Ex)
            {
                LogHelper.WriteFatalLog("The Start_Run_LoginMainForm() method run fail!", Ex);
                MessageBox.Show("The Start_Run_LoginMainForm() method run fail!");
                throw Ex;
            }
            return Start_Run_LoginMainForm_flag;

        }

    }
}
