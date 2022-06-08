using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class ExpeditionsBot : BaseBot
    {
        public ExpeditionsBot() : base(StepsFactory.GetExpeditionsSteps())
        {

        }
    }
}
