using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class EventsBot : BaseBot
    {
        public EventsBot() : base(StepsFactory.GetEventsSteps())
        {
        }
    }
}
