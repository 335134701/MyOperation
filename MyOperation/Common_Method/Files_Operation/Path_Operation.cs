/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/2/20 20:21:32 
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.Files_Operation
/// 项目描述    ：
/// 文件名称    ：Path_Operation.cs
/// 类 名 称    ：Path_Operation
/// 类 描 述    ：项目中关于路径方法的处理类
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Common_Method.Files_Operation
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


namespace MyOperation.Common_Method.Files_Operation
{
    public class Path_Operation
    {
        #region 常量表示区域
        //错误表示数组
        public String[] Error = { "Path_Error" };

        #endregion
        //当前项目绝对路径对象
        private String path;
        /// <summary>
        /// 类构造方法，获取当前程序的绝对路径
        /// </summary>
        public Path_Operation()
        {
            //当前项目路径赋值
            path = System.IO.Directory.GetCurrentDirectory();
        }

        /// <summary>
        /// 根据需要进行路径截取
        /// </summary>
        /// <param name="Level"> Level参数表示从右往左第Level个  \   截取
        ///                       Substring(0, path.LastIndexOf("\\"))；</param>
        /// <returns></returns>
        public String Update_Path(int Level)
        {
            for (int i = 0; i <= Level; i++)
            {
                path = path.Substring(0, path.LastIndexOf("\\"));
            }
            //没有路径或路径全被截取完
            if (path.Equals(null)) path = Error[0];
            return path;
        }
    }
}
