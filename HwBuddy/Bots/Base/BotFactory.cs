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

        internal static BaseBot GetEventsBot()
        {
            if (eventsBot == null) eventsBot = new EventsBot();
            return eventsBot;
        }
    }
}
