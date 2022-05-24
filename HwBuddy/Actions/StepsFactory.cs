using HwBuddy.Actions.Dungeon;
using HwBuddy.Actions.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions
{
    public static class StepsFactory
    {
        public static List<AbstractStep> GetDungeonSteps()
        {
            List<AbstractStep> steps = new List<AbstractStep>();
            steps.Add(new DungeonBattleReadyStep());
            steps.Add(new InBattleStep());
            steps.Add(new DungeonUseCardStep());
            steps.Add(new DungeonDoorStep());
            steps.Add(new DungeonAttackStep());
            steps.Add(new DungeonVictoryStep());
            return steps;
        }
    }
}
