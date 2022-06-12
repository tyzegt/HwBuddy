using HwBuddy.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots.Base
{
    public static class BotFactory
    {
        static BaseBot dunBot;
        static BaseBot towerBot;
        static BaseBot raidBot;
        static BaseBot tournamentBot;
        static BaseBot campaignBot;
        static BaseBot eventsBot;
        static BaseBot expeditionsBot;
        static BaseBot outlandBot;
        static BaseBot questsBot;
        static BaseBot postBot;

        public static BaseBot GetDungeonBot()
        {
            if (dunBot == null) dunBot = new DungeonBot();
            return dunBot;
        }
        public static BaseBot GetTowerBot()
        {
            if (towerBot == null) towerBot = new TowerBot();
            return towerBot;
        }
        public static BaseBot GetRaidBot()
        {
            if (raidBot == null) raidBot = new RaidBot();
            return raidBot;
        }
        public static BaseBot GetToeBot()
        {
            if (tournamentBot == null) tournamentBot = new TournamentOfElementsBot();
            return tournamentBot;
        }

        public static BaseBot GetCampaignBot()
        {
            if (campaignBot == null) campaignBot = new CampaignBot();
            return campaignBot;            
        }

        public static BaseBot GetEventsBot()
        {
            if (eventsBot == null) eventsBot = new EventsBot();
            return eventsBot;
        }
        public static BaseBot GetExpeditionsBot()
        {
            if (expeditionsBot == null) expeditionsBot = new ExpeditionsBot();
            return expeditionsBot;
        }
        public static BaseBot GetOutlandBot()
        {
            if (outlandBot == null) outlandBot = new ZapredBot();
            return outlandBot;
        }

        public static BaseBot GetQuestsBot()
        {
            if (questsBot == null) questsBot = new BaseBot(StepsFactory.GetQuestsSteps());
            return questsBot;
        }

        public static BaseBot GetPostBot()
        {
            if (postBot == null) postBot = new BaseBot(StepsFactory.GetPostSteps());
            return postBot;
        }
    }
}
