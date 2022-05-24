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



        //public static void CaptureScreen()
        //{
        //    Bitmap bmp = new Bitmap(1050, 660);

        //    using (var gr = Graphics.FromImage(bmp))
        //        try
        //        {
        //            //capture screen
        //            //gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
        //                                //0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

        //            gr.CopyFromScreen(
        //                MainForm.Position.X,
        //                MainForm.Position.Y,
        //                0, 0, new Size(500, 330), CopyPixelOperation.SourceCopy);

                    

        //            bmp.Save(Images.SCREEN);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //}

        public static Bitmap CaptureScreen()
        {
            Bitmap bmp = new Bitmap(1050, 660);

            using (var gr = Graphics.FromImage(bmp))
                try
                {
                    //capture screen
                    //gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                    //0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                    gr.CopyFromScreen(
                        MainForm.Position.X,
                        MainForm.Position.Y,
                        0, 0, new Size(1050, 660), CopyPixelOperation.SourceCopy);


                    return bmp;
                    //bmp.Save(Images.SCREEN);
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
            //CaptureScreen();
            //return Recognizer.FindImageCoordinates(image, Images.SCREEN, accuracy) != Point.Empty;
            return Recognizer.FindImageCoordinates(image, CaptureScreen(), accuracy) != Point.Empty;
        }

        public static bool CursorToImage(Image<Bgr, byte> image, double accuracy, int offsetX, int offsetY)
        {
            //CaptureScreen();
            //var result = Recognizer.FindImageCoordinates(image, Images.SCREEN, accuracy);
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
            //CaptureScreen();
            //var result = Recognizer.FindImageCoordinates(image, Images.SCREEN, accuracy);
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
