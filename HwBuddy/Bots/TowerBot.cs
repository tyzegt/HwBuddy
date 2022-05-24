using HwBuddy.Common;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HwBuddy.Bots
{
    public class TowerBot : BaseBot
    {
        public override void Step()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (ToggleButton())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (CanAttack())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (NextFloor())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (Shrine())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (Chest())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (CanRaid())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (Victory())
            {
                if (OkButton())
                {
                    ImageService.DoMouseClick();
                    return;
                }
            }
            if (CanAttack())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (Powerups())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (OpenChest())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (MoveOn())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (Attack())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (CanAttackManually())
            {
                ImageService.DoMouseClick();
                return;
            }
            sw.Stop();
        }

        bool TowerHall()
        {
            return ImageService.CheckImagePresent(Images.TOWER_HALL);
        }

        bool CanAttackManually()
        {
            return ImageService.CursorToImage(Images.DUNGEON_ATTACK_BUTTON);
        }

        bool OkButton()
        {
            return ImageService.CursorToImage(Images.OK_BUTTON);
        }

        bool Victory()
        {
            return ImageService.CheckImagePresent(Images.VICTORY);
        }

        bool ToggleButton()
        {
            return ImageService.CursorToImage(Images.TOGGLE_BUTTON);
        }

        bool InBattle()
        {
            return ImageService.CheckImagePresent(Images.PAUSE_BUTTON);
        }

        bool Attack()
        {
            return ImageService.CursorToImage(Images.TOWER_ATTACK);
        }

        bool MoveOn()
        {
            return ImageService.CursorToImage(Images.TOWER_CHEST_MOVEON);
        }

        bool OpenChest()
        {
            return ImageService.CursorToImage(Images.TOWER_CHEST_OPEN, 0.9f);
        }

        bool Chest()
        {
            return ImageService.CursorToImage(Images.TOWER_CHEST) || ImageService.CursorToImage(Images.TOWER_CHEST_BIG);
        }

        bool NextFloor()
        {
            return ImageService.CursorToImage(Images.TOWER_NEXT);
        }

        bool BadPowerup()
        {
            if(ImageService.CheckImagePresent(Images.TOWER_BAD_POWERUP))
                return ImageService.CursorToImage(Images.CLOSE_BUTTON);
            return false;
        }

        bool Powerups()
        {
            return ImageService.CheckImagePresent(Images.TOWER_POWERUP_SCREEN) && ImageService.CursorToImage(Images.TOWER_POWERUP_CLOSE);
        }

        bool Shrine()
        {
            return  !ImageService.CheckImagePresent(Images.TOWER_NEXT) && (ImageService.CursorToImage(Images.TOWER_SHRINE) || ImageService.CursorToImage(Images.TOWER_SHRINE_2));
        }

        bool CanRaid()
        {
            return ImageService.CursorToImage(Images.TOWER_RAID);
        }

        bool CanAttack()
        {
            return ImageService.CursorToImage(Images.TOWER_DOOR, 0.8f);
        }
    }
}
