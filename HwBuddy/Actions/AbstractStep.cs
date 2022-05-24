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

        public AbstractStep(Image<Bgr, byte> image)
        {
            _image = image;
        }

        public void Click()
        {
            ImageService.DoMouseClick();
        }

        public bool IsFound()
        {
            return ImageService.CursorToImage(Images.DUNGEON_TO_BATTLE);
        }
    }
}
