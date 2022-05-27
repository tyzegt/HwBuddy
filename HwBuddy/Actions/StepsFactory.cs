using HwBuddy.Actions.Dungeon;
using HwBuddy.Actions.Shared;
using HwBuddy.Actions.TournamentOfElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions
{
    public static class StepsFactory
    {
        public static List<AbstractStep> GetDungeonSteps() // todo: singletonize
        {
            List<AbstractStep> steps = new List<AbstractStep>();
            steps.Add(new DungeonBattleReadyStep());
            steps.Add(new DungeonUseCardStep());
            steps.Add(new DungeonDoorStep());
            steps.Add(new InBattleStep());
            steps.Add(new DungeonAttackStep());
            steps.Add(new DungeonVictoryStep());
            return steps;
        }

        public static List<AbstractStep> GetToeSteps() // todo: singletonize
        {
            List<AbstractStep> steps = new List<AbstractStep>();
            steps.Add(new ToeRaidStep());
            steps.Add(new ToeCollectStep());
            steps.Add(new ToeCloseStep());
            steps.Add(new ToeChestStep());
            steps.Add(new ToeCollectAllStep());
            steps.Add(new ToeCollect2Step());
            return steps;
        }
    }
}
