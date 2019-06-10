/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/6/10 20:38:47
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms_Methods.Login
/// 项目描述    ：
/// 文件名称    ：LoginMain_Method.cs
/// 类 名 称    ：LoginMain_Method
/// 类 描 述    ：处理LoginMain窗体中的操作方法
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms_Methods.Login
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
using System.Windows.Forms;

namespace MyOperation.Forms_Methods.Login
{
    public class LoginMain_Method
    {
        private LoginMain_Bean loginMain_Bean;
        public LoginMain_Method(LoginMain_Bean loginMain_Bean)
        {
            this.loginMain_Bean = loginMain_Bean;
        }


        /// <summary>
        /// 处理窗体取消边框后的移动问题
        /// </summary>
        /// <param name="form"></param>
        public void Form_Move(Form form)
        {
            //释放当前线程中某个窗口捕获的光标
            Init_Bean.ReleaseCapture();
            //向Windows发送拖动窗体的消息
            Init_Bean.SendMessage(form.Handle, Init_Bean.WM_SYSCOMMAND, Init_Bean.SC_MOVE + Init_Bean.HTCAPTION, 0);
        }
    }
}
