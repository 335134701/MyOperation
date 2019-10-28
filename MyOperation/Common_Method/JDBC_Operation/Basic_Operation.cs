/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/23 21:43:42
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.JDBC_Operation
/// 项目描述    ：
/// 文件名称    ：ConnectDatabase.cs
/// 类 名 称    ：ConnectDatabase
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Common_Method.JDBC_Operation
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
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Common_Method.JDBC_Operation
{
    public class Basic_Operation
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Basic_Operation()
        {}
        /// <summary>
        /// 测试数据库是否可连接
        /// </summary>
        /// <param name="jDBC_Information">连接数据库需要的相关参数</param>
        /// <returns></returns>
        public String IsConnection(JDBC_Information jDBC_Information)
        {
            String connetStr = "server="+jDBC_Information.Server+";port="+jDBC_Information.Port+";user="+jDBC_Information.Username+";password="+jDBC_Information.Password+";database="+jDBC_Information.Database+";";
            String result = "Fail";
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                result = "Success";
            }
            catch (MySqlException ex)
            {
                result = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
