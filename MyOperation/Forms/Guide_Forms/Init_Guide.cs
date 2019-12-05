/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/29 18:55:49
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Guide_Forms
/// 项目描述    ：
/// 文件名称    ：Init_Guide.cs
/// 类 名 称    ：Init_Guide
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
using MyOperation.Common_Method.Files_Operation;
using MyOperation.Common_Method.Log_Operation;
using MyOperation.Forms.Init;
using System;
using System.Windows.Forms;

namespace MyOperation.Forms.Guide_Forms
{
    public class Init_Guide
    {

        private Init_Bean init_Bean;
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Init_Guide() { }
        /// <summary>
        /// 开始执行Init运行流程
        /// </summary>
        /// <returns></returns>
        public String Init_Guide_Start()
        {
            String Init_Guide_Start_flag = "";
            LogHelper.WriteInfoLog("Instantiated_object() method starts executing!");
            //判断Instantiated_object方法执行成功与否，若成功则继续执行
            if (Instantiated_object())
            {
                LogHelper.WriteInfoLog("Start_Run_InitForm() method starts executing!");
                Init_Guide_Start_flag =Start_Run_InitForm();
            }
            return Init_Guide_Start_flag;
        }
        /// <summary>
        /// 实例化Init_Bean中申明的对象
        /// </summary>
        /// <returns>返回Init_Bean中申明对象实例化成功与否</returns>
        public Boolean Instantiated_object()
        {
            Boolean Instantiated_flag = false;
            try
            {
                LogHelper.WriteInfoLog("The object declared in the Init_Bean starts to initialize");
                this.init_Bean = new Init_Bean();     
                LogHelper.WriteInfoLog("The object declared in the Init_Event starts to initialize");
                this.init_Bean.Init_Event = new Init_Event();
                LogHelper.WriteInfoLog("The object declared in the Init_Method starts to initialize");
                this.init_Bean.Init_Method = new Init_Method();
                this.init_Bean.Path_Operation = new Path_Operation();
                this.init_Bean.Photos_Operation = new Photos_Operation();
                this.init_Bean.TimerOne = new System.Timers.Timer();
                Instantiated_flag = true;
            }
            catch (Exception Ex)
            {
                Instantiated_flag = false;
                LogHelper.WriteFatalLog("The Instantiated_object() method run fail!", Ex);
                MessageBox.Show("The Instantiated_object() method run fail!");
                throw Ex;
            }
            return Instantiated_flag;
        }
        /// <summary>
        /// 开始运行Init窗体
        /// </summary>
        /// <returns>返回窗体结束状态值</returns>
        public String Start_Run_InitForm()
        {
            
            String Start_Run_InitForm_flag = "";

            try
            {
                LogHelper.WriteInfoLog("The Init object declared in the Init_Bean starts to initialize");
                this.init_Bean.Init = new Init.Init(this.init_Bean.Init_Event);
                this.init_Bean.Init_Event.init_Bean= this.init_Bean;
                this.init_Bean.Init_Method.init_Bean = this.init_Bean;
                LogHelper.WriteInfoLog("Init form starts running");
                Application.Run(this.init_Bean.Init);
                Start_Run_InitForm_flag = this.init_Bean.Init.DialogResult.ToString();            }
            catch (Exception Ex)
            {
                LogHelper.WriteFatalLog("The Start_Run_InitForm() method run fail!", Ex);
                MessageBox.Show("The Start_Run_InitForm() method run fail!");
                throw Ex;
            }
            return Start_Run_InitForm_flag;
        }
    }
}
