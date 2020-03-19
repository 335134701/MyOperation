/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/10/28 20:15:57
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms.Login
/// 项目描述    ：
/// 文件名称    ：LoginMain_Event.cs
/// 类 名 称    ：LoginMain_Event
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
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MyOperation.Forms.Login
{
    public class LoginMain_Event
    {
        public LoginMain_Bean loginMain_Bean;
        
        #region 构造函数
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public LoginMain_Event() { }
        /// <summary>
        /// 有参数构造函数
        /// </summary>
        /// <param name="loginMain_Bean"></param>
        public LoginMain_Event(LoginMain_Bean loginMain_Bean) { if (loginMain_Bean != null) { this.loginMain_Bean = loginMain_Bean; } }
        #endregion

        #region 窗体Load执行函数
        /// <summary>
        /// LoginMain窗体加载过程中的初始化函数
        /// </summary>
        public void LoginMain_Event_Load() {
            String BackgroundImagePath = "";
            BackgroundImagePath =  this.loginMain_Bean.Photos_Operation.Get_Index_PhotoPath(this.loginMain_Bean.ImagesDir,"LoginMain_",-1,this.loginMain_Bean.Path_Operation).ToString();
            if (!BackgroundImagePath.Equals(""))
            {
                //设置背景图片
                this.loginMain_Bean.LoginMain.Background.BackgroundImageLayout = ImageLayout.Stretch;
                this.loginMain_Bean.LoginMain.Background.BackgroundImage = Image.FromFile(BackgroundImagePath);
            }
            //添加方法关联
            this.Add_Method();
            //设置用户名输入框体自动调整大小为false
            //this.loginMain_Bean.LoginMain.LoginMain_Login_Center_Left_UserInput.AutoSize = false;
            //设置用户名输入框体高度为30
           // this.loginMain_Bean.LoginMain.LoginMain_Login_Center_Left_UserInput.Height = 30;
        }
        /// <summary>
        /// 指定控件对应的方法
        /// </summary>
        public void Add_Method()
        {
            this.loginMain_Bean.LoginMain.Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bottom_MouseDown);
            this.loginMain_Bean.LoginMain.TOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_MouseDown);
            this.loginMain_Bean.LoginMain.TOP_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_Left_MouseDown);
            this.loginMain_Bean.LoginMain.TOP_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TOP_Right_MouseDown);
            this.loginMain_Bean.LoginMain.TOP_Min.Click += new System.EventHandler(this.Min_Click);
            this.loginMain_Bean.LoginMain.TOP_Min.MouseEnter += new System.EventHandler(this.Min_MouseEnter);
            this.loginMain_Bean.LoginMain.TOP_Min.MouseLeave += new System.EventHandler(this.Min_MouseLeave);
            this.loginMain_Bean.LoginMain.TOP_Close.Click += new System.EventHandler(this.Close_Click);
            this.loginMain_Bean.LoginMain.TOP_Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.loginMain_Bean.LoginMain.TOP_Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.loginMain_Bean.LoginMain.LoginMain_SystemICON.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemICON_MouseDoubleClick);
            this.loginMain_Bean.LoginMain.Login_Center.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Center_MouseDown);
            this.loginMain_Bean.LoginMain.Login_Center_Center.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Center_Center_MouseDown);
            this.loginMain_Bean.LoginMain.Login_Center_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Center_Right_MouseDown);
            this.loginMain_Bean.LoginMain.Login_Center_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Center_Left_MouseDown);
            this.loginMain_Bean.LoginMain.Login_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Top_MouseDown);
            this.loginMain_Bean.LoginMain.Login_TopTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_TopTittle_MouseDown);
            this.loginMain_Bean.LoginMain.Login_RegisterTittle.Click += new System.EventHandler(this.Login_RegisterTittle_Click);
            this.loginMain_Bean.LoginMain.Login_ForgetTittle.Click += new System.EventHandler(this.Login_ForgetTittle_Click);
        }
        #endregion

        #region 窗体移动事件处理函数
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            public void TOP_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Bottom_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TOP_Left_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TOP_Right_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Top_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_TopTittle_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Center_Left_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Center_Center_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Center_Right_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        /// <summary>
        /// 鼠标按下事件触发执行方法
        /// 主要用于无边框窗体移动的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Center_MouseDown(object sender, MouseEventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.LoginMain_Form_Move(this.loginMain_Bean.LoginMain);
        }
        #endregion

        #region  TOP界面触发事件处理实现
        /// <summary>
        /// 按钮按下事件触发执行方法
        /// 主要用于最小化功能的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Min_Click(object sender, EventArgs e)
        {
            //语句执行顺序固定，否则容易导致界面花屏现象
            //改变窗体状态
            this.loginMain_Bean.LoginMain.WindowState = FormWindowState.Minimized;
            //关闭任务栏显示
            this.loginMain_Bean.LoginMain.ShowInTaskbar = false;
            //系统托盘图标可见
            this.loginMain_Bean.LoginMain.LoginMain_SystemICON.Visible = true;
          
        }
        /// <summary>
        /// 按钮按下事件触发执行方法
        /// 主要用于关闭窗体功能的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Close_Click(object sender, EventArgs e)
        {
            //关闭窗体，返回窗体值
            this.loginMain_Bean.LoginMain.DialogResult = DialogResult.OK;
            this.loginMain_Bean.LoginMain.Dispose();
        }


        /// <summary>
        /// 双击系统托盘图标执行方法
        /// 主要用于窗体还原的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SystemICON_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //语句执行顺序固定，否则容易导致界面花屏现象
            //设置系统托盘图标不可见
            this.loginMain_Bean.LoginMain.LoginMain_SystemICON.Visible = false;
            //激活窗体并给予它焦点 
            this.loginMain_Bean.LoginMain.Activate();
            //开启任务栏显示
            this.loginMain_Bean.LoginMain.ShowInTaskbar = true;
            //延时函数作用是减少花屏频率
            Thread.Sleep(200);
            //设置窗体正常显示
            this.loginMain_Bean.LoginMain.WindowState = FormWindowState.Normal;
           

        }
        /// <summary>
        /// 按钮移入事件触发执行方法
        /// 主要用于背景边框改变的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Min_MouseEnter(object sender, EventArgs e)
        {
            //鼠标移入最小化按钮，设置背景颜色
            this.loginMain_Bean.LoginMain.TOP_Min.BackColor = Color.Silver;
            //鼠标移入最小化按钮，添加边框大小
            this.loginMain_Bean.LoginMain.TOP_Min.FlatAppearance.BorderSize = 1;
            //鼠标移入最小化按钮，设置边框颜色
            this.loginMain_Bean.LoginMain.TOP_Min.FlatAppearance.BorderColor = Color.Silver;
        }
        /// <summary>
        /// 按钮移除事件触发执行方法
        /// 主要用于背景边框改变的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Min_MouseLeave(object sender, EventArgs e)
        {
            //鼠标移除最小化按钮，去掉边框大小
            this.loginMain_Bean.LoginMain.TOP_Min.FlatAppearance.BorderSize = 0;
            //鼠标移除最小化按钮，设置背景透明
            this.loginMain_Bean.LoginMain.TOP_Min.BackColor = Color.Transparent;
        }

        /// <summary>
        /// 按钮移入事件触发执行方法
        /// 主要用于背景边框改变的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Close_MouseEnter(object sender, EventArgs e)
        {
            //鼠标移入关闭按钮，设置背景颜色
            this.loginMain_Bean.LoginMain.TOP_Close.BackColor = Color.Red;
            //鼠标移入关闭按钮，设置边框大小
            this.loginMain_Bean.LoginMain.TOP_Close.FlatAppearance.BorderSize = 1;
            //鼠标移入关闭按钮，设置边框颜色
            this.loginMain_Bean.LoginMain.TOP_Close.FlatAppearance.BorderColor = Color.Silver;
        }

        /// <summary>
        /// 按钮移除事件触发执行方法
        /// 主要用于背景边框改变的实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Close_MouseLeave(object sender, EventArgs e)
        {
            //鼠标移除关闭按钮，去掉背景颜色
            this.loginMain_Bean.LoginMain.TOP_Close.BackColor = Color.Transparent;
            //鼠标移除关闭按钮，去掉边框大小
            this.loginMain_Bean.LoginMain.TOP_Close.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region Login界面处理控件方法


        /// <summary>
        /// "注册账号" Label点击触发处理事件
        /// </summary>   
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_RegisterTittle_Click(object sender, EventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.Panel_Switch(this.loginMain_Bean.LoginMain.LoginMain_Register, this.loginMain_Bean.LoginMain.LoginMain_Login);
        }
        /// <summary>
        /// "忘记密码" Label点击触发处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_ForgetTittle_Click(object sender, EventArgs e)
        {
            this.loginMain_Bean.LoginMain_Method.Panel_Switch(this.loginMain_Bean.LoginMain.LoginMain_Forget, this.loginMain_Bean.LoginMain.LoginMain_Login);
        }
        #endregion
    }
}
