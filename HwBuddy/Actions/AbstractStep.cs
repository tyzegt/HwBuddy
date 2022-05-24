using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using HwBuddy.Common;

namespace HwBuddy.Actions
{
    public abstract class AbstractStep
    {
        public Image<Bgr, byte> _image;
        float _accuracy;
        int _offsetX;
        int _offsetY;

        public AbstractStep(Image<Bgr, byte> image, float accuracy = 0.9f, int offsetX = 0, int offsetY = 0)
        {
            _image = image;
            _accuracy = accuracy;
            _offsetX = offsetX;
            _offsetY = offsetY;
        }

        public virtual bool IsFound()
        {
            return ImageService.CursorToImage(_image, _accuracy, _offsetX, _offsetY);
        }
    }
}
