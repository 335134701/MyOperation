/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/28 19:28:01
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Login
/// 项目描述    ：
/// 文件名称    ：LoginMain_Method.cs
/// 类 名 称    ：LoginMain_Method
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms.Login
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyOperation.Forms.Login
{
    public class LoginMain_Method
    {
        public LoginMain_Bean loginMain_Bean;

        #region 构造函数
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginMain_Method() { }
        /// <summary>
        /// 有参数构造函数
        /// </summary>
        /// <param name="loginMain_Bean"></param>
        public LoginMain_Method(LoginMain_Bean loginMain_Bean) { if (loginMain_Bean != null) { this.loginMain_Bean = loginMain_Bean; } }
        #endregion


        /// <summary>
        /// Login界面中注册/忘记等界面切换操作
        /// </summary>
        /// <param name="new_Panel">切换到新的界面</param>
        /// <param name="old_Panel">切换原有界面</param>
        public void  Panel_Switch(Panel new_Panel, Panel old_Panel)
        {
            this.loginMain_Bean.LoginMain.Background.Controls.Add(new_Panel);
            this.loginMain_Bean.LoginMain.Background.Controls.Remove(old_Panel);
            new_Panel.Visible = true;
        }

        /// <summary>
        /// 处理窗体取消边框后的移动问题
        /// </summary>
        /// <param name="form"></param>
        public void LoginMain_Form_Move(Form form)
        {
            //释放当前线程中某个窗口捕获的光标
            Init_Bean.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            Init_Bean.SendMessage(form.Handle, Init_Bean.WM_SYSCOMMAND, Init_Bean.SC_MOVE + Init_Bean.HTCAPTION, 0);
        }
    }
}
