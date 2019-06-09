/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/6/9 11:58:21
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms_Methods.Form_Common_Methods
/// 项目描述    ：
/// 文件名称    ：Photo_Method.cs
/// 类 名 称    ：Photo_Method
/// 类 描 述    ：图形界面中关于图形文件的处理方法
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms_Methods.Form_Common_Methods
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


namespace MyOperation.Forms_Methods.Form_Common_Methods
{
    public class Photo_Method
    {
        /// <summary>
        /// 根据prefixNmae获取相应的图片集合路径
        /// </summary>
        /// <param name="path_Allfile">路径下所有的文件集合</param>
        /// <param name="prefixNmae">寻找文件前缀</param>
        /// <returns>返回集合对象</returns>
        public List<FileInfo> Get_AllPhotos_Path(List<FileInfo> All_Init_Photos, String prefixNmae)
        {
            List<FileInfo> photosFile_List = new List<FileInfo>();
            //获取图片名包含Init图片集合
            foreach (FileInfo fileinfo in All_Init_Photos)
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

    }
}
