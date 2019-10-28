/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/8/23 21:50:25
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.JDBC_Operation
/// 项目描述    ：
/// 文件名称    ：JDBCInformation.cs
/// 类 名 称    ：JDBCInformation
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyOperation.Common_Method.JDBC_Operation
{
    public class JDBC_Information
    {
        //数据库服务地址，例如：127.0.0.1/localhost
        private String server;
        //数据库服务端口号
        private String port;
        //数据库名称
        private String database;
        //数据库用户名
        private String username;
        //数据库密码
        private String password;

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public JDBC_Information()
        {

        }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="server"></param>
        /// <param name="port"></param>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public JDBC_Information(String server, String port, String database, String username, String password)
        {
            this.Server = server;
            this.Port = port;
            this.Database = database;
            this.Username = username;
            this.Password = password;
        }

        public string Server { get => server; set => server = value; }
        public string Port { get => port; set => port = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
