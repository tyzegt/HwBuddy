using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Diagnostics;
using System.Drawing;

namespace HwBuddy.Core
{
    public class Recognizer
    {
        //public static Point FindImageCoordinates(Image<Bgr, byte> template, string sourceFile, double accuracy)
        //{
        //    Image<Bgr, byte> source = new Image<Bgr, byte>(sourceFile); // Image B
        //    using (Image<Gray, float> result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
        //    {
        //        double[] minValues, maxValues;
        //        Point[] minLocations, maxLocations;
        //        result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

        //        // You can try different values of the threshold. I guess somewhere between 0.75 and 0.95 would be good.
        //        if (maxValues[0] > accuracy)
        //        {
        //            // This is a match. Do something with it, for example draw a rectangle around it.
        //            Rectangle match = new Rectangle(maxLocations[0], template.Size);
        //            return new Point(match.X + template.Width / 2, match.Y + template.Height / 2);
        //        }
        //        return Point.Empty;
        //    }
        //}

        //var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        //Image<Bgr, Byte> img1 = bmp.ToImage<Bgr, byte>();

        public static Point FindImageCoordinates(Image<Bgr, byte> template, Bitmap screen, double accuracy)
        {
            //Image<Bgr, byte> source = new Image<Bgr, byte>(sourceFile); // Image B
            Image<Bgr, byte> source = screen.ToImage<Bgr, byte>();
            using (Image<Gray, float> result = source.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
            {
                double[] minValues, maxValues;
                Point[] minLocations, maxLocations;
                result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);

                // You can try different values of the threshold. I guess somewhere between 0.75 and 0.95 would be good.
                if (maxValues[0] > accuracy)
                {
                    // This is a match. Do something with it, for example draw a rectangle around it.
                    Rectangle match = new Rectangle(maxLocations[0], template.Size);
                    return new Point(match.X + template.Width / 2, match.Y + template.Height / 2);
                }
                return Point.Empty;
            }
        }
    }   
}