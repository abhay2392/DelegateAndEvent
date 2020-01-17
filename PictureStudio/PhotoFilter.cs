using System;
using System.Collections.Generic;
using System.Text;

namespace PictureStudio
{
    class PhotoFilter
    {
        public void AddBlur(Photo photo)
        {
            photo.PictureName = "Blurred";
            Console.Write("Added Blur");
        }
        public void AddBrightess(Photo photo)
        {
            photo.PictureName += " Bright";
            Console.Write("Added Brightness");
        }
        public void AddSharpness(Photo photo)
        {
            photo.PictureName += " sharp";
            Console.Write("Added Sharpness");
        }
    }
}
