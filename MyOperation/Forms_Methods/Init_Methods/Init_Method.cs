/// ***********************************************************************
///
/// =================================
/// 创 建 者    ：congz
/// 创建日期    ：2019/6/9 11:37:49
/// 邮箱        ：335134701@qq.com
/// =================================
/// 项目名称    ：MyOperation.Forms_Methods.Init_Methods
/// 项目描述    ：
/// 文件名称    ：Init_Method.cs
/// 类 名 称    ：Init_Method
/// 类 描 述    ：Init窗体界面中普通处理方法
/// 所在的域    ：ZC-PC
/// 命名空间    ：MyOperation.Forms_Methods.Init_Methods
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
using MyOperation.Beans.Forms_Beans;

namespace MyOperation.Forms_Methods.Init_Methods
{
    public class Init_Method
    {
        private Init_Bean init_Bean;


        public Init_Method(Init_Bean init_Bean)
        {
            this.init_Bean = init_Bean;
        }

        /// <summary>
        /// Init窗体中获取背景图片绝对路径处理方法，实现随机显示背景图片
        /// </summary>
        /// <returns></returns>
        public String Get_Index_Path()
        {

            this.init_Bean.All_Init_Photos = this.init_Bean.Photo_Method.Get_AllPhotos_Path(
                this.init_Bean.Photos_Operation.All_Serch_Photos(
                    this.init_Bean.Path_Operation.Update_Path(1) + this.init_Bean.ImagesDir, new String[] { "jpg", "jpeg" })
                    , "Init_");
            //生成随机数
            Random rd = new Random();
            //获取生成的随机数对应的图片路径
            String path = this.init_Bean.Photo_Method.Get_Photo_Path(rd.Next(1, this.init_Bean.All_Init_Photos.Count), this.init_Bean.All_Init_Photos);
            return path;
        }
    }
}
