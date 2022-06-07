using Emgu.CV;
using Emgu.CV.Structure;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HwBuddy.Common
{
    public class ImageService
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static Bitmap CaptureScreen()
        {
            return CaptureScreen(1050, 650, MainForm.Position.X, MainForm.Position.Y);            
        }

        public static Bitmap CaptureScreen(int width, int height, int X, int Y)
        {
            Bitmap bmp = new Bitmap(width, height);

            using (var gr = Graphics.FromImage(bmp))
                try
                {
                    gr.CopyFromScreen(X, Y, 0, 0, new Size(1050, 660), CopyPixelOperation.SourceCopy);
                    return bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
        }

        public static void DoMouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        public static bool CheckImagePresent(Image<Bgr, byte> image)
        {
            return CheckImagePresent(image, 0.9);
        }

        public static bool CheckImagePresent(Image<Bgr, byte> image, double accuracy)
        {
            return Recognizer.FindImageCoordinates(image, CaptureScreen(), accuracy) != Point.Empty;
        }

        public static bool CursorToImage(Image<Bgr, byte> image, double accuracy, int offsetX, int offsetY)
        {
            var result = Recognizer.FindImageCoordinates(image, CaptureScreen(), accuracy);
            if (result != Point.Empty)
            {
                Cursor.Position = new Point(result.X + MainForm.Position.X + offsetX, result.Y + MainForm.Position.Y + offsetY);
                return true;
            }
            return false;
        }

        public static Point FindImage(Image<Bgr, byte> image, double accuracy, int offsetX, int offsetY)
        {
            var result = Recognizer.FindImageCoordinates(image, CaptureScreen(), accuracy);
            if (result != Point.Empty)
            {
                return new Point(result.X + MainForm.Position.X + offsetX, result.Y + MainForm.Position.Y + offsetY);
            }
            return new Point();
        }

        public static void CursorToPoint(Point point)
        {
            Cursor.Position = point;
        }

        public static bool CursorToImage(Image<Bgr, byte> image)
        {
            return CursorToImage(image, 0.9, 0, 0);
        }

        public static bool CursorToImage(Image<Bgr, byte> image, int offsetX, int offsetY)
        {
            return CursorToImage(image, 0.9, offsetX, offsetY);
        }

        public static bool CursorToImage(Image<Bgr, byte> image, double accuracy)
        {
            return CursorToImage(image, accuracy, 0, 0);
        }
    }
}
