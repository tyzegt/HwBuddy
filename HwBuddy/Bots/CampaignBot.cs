using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    internal class CampaignBot : BaseBot
    {
        public CampaignBot() : base(StepsFactory.GetCampaignSteps())
        {
        }
    }
}
