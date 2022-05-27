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
        static List<AbstractStep> dungeonSteps = null;
        static List<AbstractStep> toeSteps = null;


        public static List<AbstractStep> GetDungeonSteps()
        {
            if (dungeonSteps == null)
            {
                dungeonSteps = new List<AbstractStep>();
                dungeonSteps.Add(new DungeonBattleReadyStep());
                dungeonSteps.Add(new DungeonUseCardStep());
                dungeonSteps.Add(new DungeonDoorStep());
                dungeonSteps.Add(new InBattleStep());
                dungeonSteps.Add(new DungeonAttackStep());
                dungeonSteps.Add(new DungeonVictoryStep());
            }
            return dungeonSteps;
        }

        public static List<AbstractStep> GetToeSteps()
        {
            if (toeSteps == null)
            {
                toeSteps = new List<AbstractStep>();
                toeSteps.Add(new ToeRaidStep());
                toeSteps.Add(new ToeCollectStep());
                toeSteps.Add(new ToeCloseStep());
                toeSteps.Add(new ToeChestStep());
                toeSteps.Add(new ToeCollectAllStep());
                toeSteps.Add(new ToeCollect2Step());
            }
            return toeSteps;
        }
    }
}
