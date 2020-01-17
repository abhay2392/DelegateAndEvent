using System;
using System.Collections.Generic;
using System.Text;

namespace PictureStudio
{
    public class PhotoProcessor
    {

        public delegate void photoProcessorHandler(Photo photo);
       
       

        public void ProcessPhoto(Photo photo,photoProcessorHandler processorHandler)
        {
            Console.WriteLine("Start Processing");

            processorHandler(photo);
        }

    }
}
