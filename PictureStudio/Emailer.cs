using System;
using System.Collections.Generic;
using System.Text;

namespace PictureStudio
{
    class Emailer
    {
        public void sendEmail(Photo photo)
        {
            Console.WriteLine("Sending email, following image processed " + photo.PictureName);
        }
    }
}
