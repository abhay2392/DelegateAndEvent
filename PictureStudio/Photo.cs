using System;
using System.Collections.Generic;
using System.Text;

namespace PictureStudio
{
    public class Photo
    {
        public delegate void photoProcessorHandler(Photo photo);
        public event photoProcessorHandler photoProcessorEventHandler;
        private string _pictureName;

        public string PictureName
        {
            get
            {
                return _pictureName;
            }
            set
            {
                _pictureName = value;
                propertyChanged();

            }
        }

        private void propertyChanged()
        {
           if(photoProcessorEventHandler!=null)
            {
                photoProcessorEventHandler(this);
            }
        }
    }
}
