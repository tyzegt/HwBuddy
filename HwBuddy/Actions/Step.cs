using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions
{
    public class Step : AbstractStep
    {
        public Step(Image<Bgr, byte> image, float accuracy = 0.9f, int offsetX = 0, int offsetY = 0) 
            :base(image, accuracy, offsetX, offsetY)
        {

        }
    }
}
