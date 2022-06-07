using Emgu.CV;
using Emgu.CV.Structure;
using HwBuddy.Common;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace HwBuddy
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var imgPath = "raid.png";
            //var imgPath = textBox1.Text;
            var percent = 90;
            //var percent = Convert.ToInt32(textBox2.Text);
            var img = new Bitmap($"Images/{imgPath}");
            pictureBox1.Image = resizeImage(img, percent);

            var scr = ImageService.CaptureScreen(1980, 1080, 0, 0);
            var img2 = img.ToImage<Bgr, byte>();
            //var coord = Recognizer.FindImageCoordinates(img2, scr, 0.7f);

            ImageService.CursorToImage(img2, 0.7f);
        }


        private Bitmap resizeImage(Image imgToResize, int percent)
        {
            var size = new Size((int)(imgToResize.Width * (percent * 0.01f)), (int)(imgToResize.Height * (percent * 0.01f)));
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;
        }
    }
}
