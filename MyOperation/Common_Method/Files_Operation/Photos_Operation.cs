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
using System.IO;
using System.Text.RegularExpressions;

namespace MyOperation.Common_Method.Files_Operation
{
    public class Photos_Operation
    {
        /// <summary>
        /// 校验路径的合法性方法，若不合法，则自动默认赋初值
        /// </summary>
        /// <param name="path">路径参数</param>
        /// <returns>返回路径</returns>
        public String CheckPath(String path)
        {
            //正则表达式判断路径的合法性，绝对路径
            Regex regex = new Regex(@"^(?<fpath>([a-zA-Z]:\\)([\s\.\-\w]+\\)*)(?<fname>[\w]+.[\w]+)");
            Match m = regex.Match(path);
            //判断路径是否合法，如果路径不合法则自动赋初值
            if (path.Equals("") || (!m.Success) || (!Directory.Exists(path)))  path = "";  //绝对路径
            return path;
        }

        /// <summary>
        /// 根据suffixNames数组，查询需要的图像文件格式，返回路径集合
        /// </summary>
        /// <param name="path">相对路径</param>
        /// <param name="suffixNames">需要查询的格式数组</param>
        /// <returns>返回图像集合类</returns>
        public List<FileInfo> All_Serch_Photos(String path,String[] suffixNames)
        {
            //文件集合对象
            List<FileInfo> photos_files = new List<FileInfo>();
            //校验路径的合法性
            if (this.CheckPath(path).Equals("")) return photos_files;
            //DirectoryInfo类是System.IO命名空间的一部分。它用于创建，删除和移动目录。
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileInfo = dir.GetFiles();
            foreach (FileInfo item in fileInfo)
            {
                //根据文件后缀选取文件
                foreach (String suffixName in suffixNames)
                {
                    if (item.Name.ToString().Contains(suffixName) )
                    {
                        photos_files.Add(item);
                        break;
                    }
                }
            }
            return photos_files;
        }
    }
}
