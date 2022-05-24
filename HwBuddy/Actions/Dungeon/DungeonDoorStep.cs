using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions.Dungeon
{
    public class DungeonDoorStep : AbstractStep
    {
        public DungeonDoorStep() : base(Images.DUNGEON_ATTACK_MIXFIGHT, 0.9f, 0, 30)
        {
        }
    }
}
