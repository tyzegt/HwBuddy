using HwBuddy.Actions.Dungeon;
using HwBuddy.Common;
using HwBuddy.Core;
using System.Diagnostics;

namespace HwBuddy.Bots
{
    public class DungeonBot : BaseBot
    {
        public DungeonBot(MainForm mainForm) : base(mainForm)
        {
            var s = new DungeonBattleReadyStep();
        }

        public override void Step()
        {
            if (BattleReady())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (InBattle())
            {
                if(ToggleButton())
                {
                    ImageService.DoMouseClick();
                    return;
                }
            }
            if (CanUseCards())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (CanAttackMix())
            {
                ImageService.DoMouseClick();
                return;
            }
            if (CanAttackManually())
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

        bool CanAttackManually()
        {
            return ImageService.CursorToImage(Images.DUNGEON_ATTACK_BUTTON);
        }

        bool CanAttackMix()
        {
            return ImageService.CursorToImage(Images.DUNGEON_ATTACK_MIXFIGHT, 0, 30);
        }

        bool CanUseCards()
        {
            return ImageService.CursorToImage(Images.DUNGEON_USE_CARD);
        }

        bool CanCollectCards()
        {
            return ImageService.CursorToImage(Images.DUNGEON_CARDS_COLLECT);
        }

        bool HaveNewCards()
        {
            return ImageService.CursorToImage(Images.DUNGEON_NEW_CARDS);
        }

        bool InTheHall()
        {
            return ImageService.CheckImagePresent(Images.DUNGEON_BUTTONS) && ImageService.CheckImagePresent(Images.DUNGEON_CARDS_ICON);
        }

        bool BattleReady()
        {
            return ImageService.CursorToImage(Images.DUNGEON_TO_BATTLE);
        }
    }
}
