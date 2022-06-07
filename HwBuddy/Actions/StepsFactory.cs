using HwBuddy.Actions.Campaign;
using HwBuddy.Actions.Dungeon;
using HwBuddy.Actions.Events;
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
        static List<AbstractStep> campaignSteps = null;
        static List<AbstractStep> eventsSteps = null;


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

        public static List<AbstractStep> GetCampaignSteps()
        {
            if (campaignSteps == null)
            {
                campaignSteps = new List<AbstractStep>();
                campaignSteps.Add(new CampaignValkiryStep());
                campaignSteps.Add(new CampaignAttackStep());
                campaignSteps.Add(new DungeonAttackStep());
                campaignSteps.Add(new CampaignVictoryStep());
                campaignSteps.Add(new InBattleStep());
                campaignSteps.Add(new CampaignMissionStep());

            }
            return campaignSteps;
        }

        public static List<AbstractStep> GetEventsSteps()
        {
            if (eventsSteps == null)
            {
                eventsSteps = new List<AbstractStep>();
                eventsSteps.Add(new EventButtonStep());
                eventsSteps.Add(new EventCompleteButtonStep());
                eventsSteps.Add(new EventActiveTabStep());
                eventsSteps.Add(new EventDailyRewardStep());
                eventsSteps.Add(new EventTakeDailyStep());
                eventsSteps.Add(new EventRedDotStep());
            }
            return eventsSteps;
        }
    }
}
