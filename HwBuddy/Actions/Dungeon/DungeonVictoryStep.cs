using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions.Dungeon
{
    public class DungeonVictoryStep : AbstractStep
    {
        AbstractStep additionalStep = new DungeonOkStep();
        public DungeonVictoryStep() : base(Images.VICTORY)
        {
        }

        public override bool IsFound()
        {
            if (base.IsFound())
                return additionalStep.IsFound();
            else
                return false;
        }
    }
}
