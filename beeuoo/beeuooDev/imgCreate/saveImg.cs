
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace beeuooDev
{
    public class saveImg
    {
        public static void imgSave() {
            string imgPath = "../image/bg.jpg";
            Image bg = Image.FromFile(imgPath);
            Image wordbtp = wordImg.CreateImage("word", true, 40);
            Bitmap bmp = combinImg.CombinImage(bg, wordbtp);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
        }

    }


}