/// ***********************************************************************
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
        /// <summary>
        /// 根据prefixNmae获取相应的图片集合路径
        /// </summary>
        /// <param name="path_Allfile">路径下所有的文件集合</param>
        /// <param name="prefixNmae">寻找文件前缀</param>
        /// <returns>返回集合对象</returns>
        public List<FileInfo> Get_AllPhotos_Path(List<FileInfo> All_Photos, String prefixNmae)
        {
            List<FileInfo> photosFile_List = new List<FileInfo>();
            //获取图片名包含Init图片集合
            foreach (FileInfo fileinfo in All_Photos)
            {
                if (fileinfo.Name.Contains(prefixNmae)) photosFile_List.Add(fileinfo);
            }
            //返回集合对象
            return photosFile_List;
        }

        /// <summary>
        /// 获取指定图像文件的绝对路径
        /// </summary>
        /// <param name="index">图片编号</param>
        /// <param name="photosFile_List">指定图片文件的集合</param>
        /// <returns>返回绝对路径</returns>
        public String Get_Photo_Path(int index, List<FileInfo> photosFile_List)
        {
            String path = "";
            //循环遍历文件，找到对应指定规则的图片
            foreach (FileInfo fileinfo in photosFile_List)
            {
                //截取Init_XX图片中XX进行数字转换，然后和index进行对比，获取相应的图片路径
                //例如Init_01.jpg，进行分解，分为Init，01，jpg长度为3的数组
                if (int.Parse(fileinfo.Name.Split(new char[] { '_', '.' })[1]) == index)
                {
                    path = fileinfo.Directory.ToString() + "\\" + fileinfo.Name;
                }
            }
            //返回绝对路径
            return path;
        }

        /// <summary>
        /// Init窗体中获取背景图片绝对路径处理方法，实现随机显示背景图片
        /// </summary>
        /// <returns></returns>
        public String Get_Index_PhotoPath(String ImagesDir, String message,int index,Path_Operation path_Operation)
        {
            String Photopath = "";
            List<FileInfo> photosFile_List = new List<FileInfo>();
            photosFile_List = this.Get_AllPhotos_Path(this.All_Serch_Photos(path_Operation.Update_Path(1)+ImagesDir, new String[] { "jpg", "jpeg" }),message);
            //判断能否获取到Init图片集合，如果不能获取，则结束函数
            if (photosFile_List.Count < 0) { return Photopath; }
            //生成随机数
            Random rd = new Random();
            if (index < 0)
            {
              
                //获取生成的随机数对应的图片路径
                Photopath = this.Get_Photo_Path(rd.Next(1, photosFile_List.Count + 1), photosFile_List);
            }
            else {
                Photopath = this.Get_Photo_Path(index, photosFile_List);
            }
            Console.WriteLine(Photopath);
            return Photopath;
        }
    }
}
