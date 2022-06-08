using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class ZapredBot : BaseBot
    {
        public ZapredBot() : base(StepsFactory.GetOutlandSteps())
        {

        }
    }
}
