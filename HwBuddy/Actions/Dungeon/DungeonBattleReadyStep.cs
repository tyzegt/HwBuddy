using Emgu.CV;
using Emgu.CV.Structure;
using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions.Dungeon
{
    public class DungeonBattleReadyStep : AbstractStep
    {
        public DungeonBattleReadyStep() : base(Images.DUNGEON_TO_BATTLE)
        {
        }
    }
}
