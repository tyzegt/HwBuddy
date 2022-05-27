using HwBuddy.Actions;
using HwBuddy.Actions.Dungeon;
using HwBuddy.Actions.Shared;
using HwBuddy.Common;
using HwBuddy.Core;
using System.Collections.Generic;
using System.Diagnostics;

namespace HwBuddy.Bots
{
    public class DungeonBot : BaseBot
    {
        public DungeonBot() : base(StepsFactory.GetDungeonSteps())
        {
        }
    }
}
