using System;

namespace PictureStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo objPicture = new Photo();
            
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilter Filter = new PhotoFilter();
            Emailer mailClient = new Emailer();
            Massenger massesngerClient = new Massenger();
            PhotoProcessor.photoProcessorHandler processorHandler = Filter.AddBlur;
            objPicture.photoProcessorEventHandler += mailClient.sendEmail;
            objPicture.photoProcessorEventHandler += massesngerClient.sendMessage;
            processorHandler += Filter.AddBrightess;
            processorHandler += Filter.AddSharpness;
            processor.ProcessPhoto(objPicture, processorHandler);


         
            Console.WriteLine("Hello World!");
        }
    }
}
