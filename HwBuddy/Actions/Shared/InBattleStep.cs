using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions.Shared
{
    internal class InBattleStep : AbstractStep
    {
        AbstractStep additionalStep = new ToggleButtonStep();
        public InBattleStep() : base(Images.PAUSE_BUTTON)
        {
        }

        public override bool IsFound()
        {
            if(base.IsFound())
                return additionalStep.IsFound();
            else 
                return false;
        }
    }
}
