﻿/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/2/20 15:20:59 
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Common_Method.FilesOperation
/// 项目描述    ：
/// 文件名称    ：SerchPhotos.cs
/// 类 名 称    ：SerchPhotos
/// 类 描 述    ：查找照片方法类
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Common_Method.FilesOperation
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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyOperation.Common_Method.FilesOperation
{
    class PhotosOperation
    {
        /******************************
        * 
        * 描述：校验路径的合法性方法，若不合法，则自动默认赋初值
        * 
        * *****************************/
        public String CheckPath(String path)
        {
            //正则表达式判断路径的合法性
            Regex regex = new Regex(@"^([a-zA-Z]:\\)?[^\/\:\*\?\""\<\>\|\,]*$");
            Match m = regex.Match(path);
            //判断路径是否有值，如果路径不合法则自动赋初值
            if (path.Equals(null) || m.Success)
            {
                //相对路径
                //path=;
            }
            return path;
        }
        /******************************
        * 
        * 描述：查询所有JPG或者JEPG格式图片，返回路径集合
        * 
        * *****************************/
        public List<String> All_Serch_Photos(String path)
        {
            //文件集合对象
            List<string> fileNames = new List<string>();
            //DirectoryInfo类是System.IO命名空间的一部分。它用于创建，删除和移动目录。
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileInfo = dir.GetFiles();
            foreach (FileInfo item in fileInfo)
            {
                Trace.WriteLine(item);
                //判断文件的后缀名是否包含.jpg或者.jpeg
                if (item.Name.ToString().Contains(".jpg") || item.Name.ToString().Contains(".jpeg"))
                {
                    fileNames.Add(item.Name);
                }
            }
            return fileNames;
        }
    }
}
