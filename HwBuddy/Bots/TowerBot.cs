using HwBuddy.Actions;
using HwBuddy.Bots.Base;
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
        int ToggleButtonc = 0;
        int CanAttackc = 0;
        int NextFloorc = 0;
        int Shrinec = 0;
        int Chestc = 0;
        int CanRaidc = 0;
        int Victoryc = 0;
        int Powerupsc = 0;
        int OpenChestc = 0;
        int MoveOnc = 0;
        int Attackc = 0;
        int CanAttackManuallyc = 0;
        int OkButtonc = 0;

        public TowerBot() : base(null)
        {
        }

        public override void Step()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (ToggleButton())
            {
                ImageService.DoMouseClick();
                ToggleButtonc++;
                return;
            }
            if (CanAttack())
            {
                ImageService.DoMouseClick();
                CanAttackc++;
                return;
            }
            if (Attack())
            {
                ImageService.DoMouseClick();
                Attackc++;
                return;
            }
            if (Victory())
            {
                Victoryc++;
                if (OkButton())
                {
                    ImageService.DoMouseClick();
                    OkButtonc++;
                    return;
                }
            }
            if (NextFloor())
            {
                ImageService.DoMouseClick();
                NextFloorc++;
                return;
            }
            if (Chest())
            {
                ImageService.DoMouseClick();
                Chestc++;
                return;
            }
            if (MoveOn())
            {
                ImageService.DoMouseClick();
                MoveOnc++;
                return;
            }
            if (OpenChest())
            {
                ImageService.DoMouseClick();
                OpenChestc++;
                return;
            }
            if (Shrine())
            {
                ImageService.DoMouseClick();
                Shrinec++;
                return;
            }
            if (Powerups())
            {
                ImageService.DoMouseClick();
                Powerupsc++;
                return;
            }
            if (CanRaid())
            {
                ImageService.DoMouseClick();
                CanRaidc++;
                return;
            }
            if (CanAttackManually())
            {
                ImageService.DoMouseClick();
                CanAttackc++;
                return;
            }
            sw.Stop();
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
