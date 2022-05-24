using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace HwBuddy.Bots
{
    public class RaidBot : BaseBot
    {
        Point raid;
        Point take;

        public RaidBot(MainForm mainForm) : base(mainForm)
        {
        }

        public override void Reset()
        {
            raid = new Point();
            take = new Point();
        }

        public override void Step()
        {
            if(raid != Point.Empty && take != Point.Empty)
            {
                for (int i = 0; i < 5; i++)
                {
                    ImageService.CursorToPoint(raid);
                    ImageService.DoMouseClick();
                    Thread.Sleep(100);
                    ImageService.CursorToPoint(take);
                    ImageService.DoMouseClick();
                    Thread.Sleep(100);

                }
            }
            RaidButton();
            TakeButton();

            if (Checkout() || Donate() || Level())
            {
                ImageService.DoMouseClick();
                return;
            }
        }

        void RaidButton()
        {
            if (raid != Point.Empty) return;
            var r = ImageService.FindImage(Images.RAID_BUTTON, 0.98, 0,0);
            if (r != Point.Empty)
            {
                raid = r;
                ImageService.CursorToPoint(raid);
            }
            ImageService.DoMouseClick();
        }
        void TakeButton()
        {
            if (take != Point.Empty) return;
            var t = ImageService.FindImage(Images.TAKE_ALL_BUTTON, 0.98, 0,0);
            if (t != Point.Empty)
            {
                take = t;
                ImageService.CursorToPoint(take);
            }
            ImageService.DoMouseClick();
        }
        bool Checkout()
        {
            return ImageService.CursorToImage(Images.CHECKOUT);
        }
        bool Donate()
        {
            if (ImageService.CheckImagePresent(Images.DONATE))
                return ImageService.CursorToImage(Images.CLOSE_BUTTON);
            return false;
        }
        bool Level()
        {
            return ImageService.CursorToImage(Images.OK_BUTTON);
        }
    }
}
