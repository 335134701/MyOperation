using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyOperation.Beans.Class_Beans;
using MyOperation.Forms.Login;


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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //创建Init对象
            Program_Init program_Init = new Program_Init();
            LoginMain loginMain = new LoginMain();
            //loginMain.ShowDialog();
            Application.Run(loginMain);
            if (loginMain.DialogResult == DialogResult.OK)
            {
                //执行其他主程序
                // Application.Run(loginMain);
            }
        }
    }
}
