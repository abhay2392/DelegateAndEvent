using System;
using System.Collections.Generic;
using System.Text;

namespace PictureStudio
{
    class Massenger
    {
        public void sendMessage(Photo photo)
        {
            Console.WriteLine("Sending massege, following image processed " + photo.PictureName);
        }
    }
}
