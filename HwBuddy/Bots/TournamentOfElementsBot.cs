using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class TournamentOfElementsBot : BaseBot
    {
        public TournamentOfElementsBot() : base(StepsFactory.GetToeSteps())
        {
        }
    }
}
