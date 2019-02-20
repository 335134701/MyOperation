/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/2/19 11:59:31 
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Class_Beans
/// 项目描述    ：本类主要作用：Program.cs跳转到Init.cs中需要调用的对象集合类
/// 文件名称    ：Program_Init.cs
/// 类 名 称    ：Program_Init
/// 类 描 述    ：
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Class_Beans
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
using MyOperation.Forms.Init;
using MyOperation.Common_Method.Files_Operation;
using System.IO;

namespace MyOperation.Beans.Class_Beans
{
    public class Program_Init
    {
        private Init init;
        private Photos_Operation photos_Operation;
        private Path_Operation path_Operation;
        //主题图片路径集合
        private List<FileInfo> file_List;

        public Program_Init()
        {
            Init = new Init(this);
            Photos_Operation = new Photos_Operation();
            path_Operation = new Path_Operation();
            File_List = new List<FileInfo>();
        }

        /******************************
         * 
         * 描述：init对象的GET(),SET()方法
         * 
         * *****************************/
        public Init Init { get => init; set => init = value; }
        public Photos_Operation Photos_Operation { get => photos_Operation; set => photos_Operation = value; }
        public Path_Operation Path_Operation { get => path_Operation; set => path_Operation = value; }
        public List<FileInfo> File_List { get => file_List; set => file_List = value; }

        public List<FileInfo> GetAll_Photos_Path(List<FileInfo> paths)
        {
            //获取图片名包含Init图片集合
            foreach (FileInfo fileinfo in paths) {
                if (fileinfo.Name.Contains("Init_")) File_List.Add(fileinfo);
            }
            //返回集合对象
            return File_List;
        }

        public String Get_Photo_Path(int index) {
            String path = "";
            foreach (FileInfo fileinfo in File_List) {
                if (int.Parse(fileinfo.Name.Substring(fileinfo.Name.IndexOf("_"), fileinfo.Name.Length)) == index)
                {
                    path = fileinfo.Directory.ToString();
                }
            }
            return path;
        }
    }
}
