using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDungeonTools.assets.classes
{
    public class Quests
    {
        /*public object Quest1 { get; set; }
        public object Quest2 { get; set; }*/
        public UpgradeQuest1 upgradeQuest1 { get; set; }
        public UpgradeQuest2 upgradeQuest2 { get; set; }
        public UpgradeQuest3 upgradeQuest3 { get; set; }
        
        public class Quests2
        {
            public RestockQuest RestockQuest { get; set; }
        }
        public class Quests3
        {
            public PricingQuest PricingQuest { get; set; }
            public Quest1 Quest1 { get; set; }
            public Quest2 Quest2 { get; set; }
            public RestockQuest2 RestockQuest { get; set; }
        }
        public class Quests4
        {
            public PricingQuest2 PricingQuest { get; set; }
            public Quest12 Quest1 { get; set; }
            public Quest22 Quest2 { get; set; }
            public Quest3 Quest3 { get; set; }
            public Quest4 Quest4 { get; set; }
            public RestockQuest3 RestockQuest { get; set; }
        }
        public class Quests5
        {
            public PricingQuest3 PricingQuest { get; set; }
            public Quest13 Quest1 { get; set; }
            public Quest23 Quest2 { get; set; }
            public Quest32 Quest3 { get; set; }
            public Quest42 Quest4 { get; set; }
            public RestockQuest4 RestockQuest { get; set; }
        }
        public class Quest1
        {
            public QuestState6 questState { get; set; }
        }
        public class Quest2
        {
            public QuestState7 questState { get; set; }
        }
        public class Quest3
        {
            public QuestState12 questState { get; set; }
        }
        public class Quest4
        {
            public QuestState13 questState { get; set; }
        }


        public class Quest12
        {
            public QuestState10 questState { get; set; }
        }
        public class Quest13
        {
            public QuestState16 questState { get; set; }
        }
        public class Quest22
        {
            public QuestState11 questState { get; set; }
        }
        public class Quest23
        {
            public QuestState17 questState { get; set; }
        }
        public class Quest32
        {
            public QuestState18 questState { get; set; }
        }
        public class Quest42
        {
            public QuestState19 questState { get; set; }
        }
        public class QuestState
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState2
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState3
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState4
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState5
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState6
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState7
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState8
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState9
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState10
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState11
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState12
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState13
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState14
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState15
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState16
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState17
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState18
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState19
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class QuestState20
        {
            public int startedAtCount { get; set; }
            public int targetCount { get; set; }
        }
        public class UpgradeQuest1
        {
            public QuestState questState { get; set; }
        }
        public class UpgradeQuest2
        {
            public QuestState2 questState { get; set; }
        }
        public class UpgradeQuest3
        {
            public QuestState3 questState { get; set; }
        }
        public class RestockQuest
        {
            public QuestState4 questState { get; set; }
        }
        public class RestockQuest2
        {
            public QuestState8 questState { get; set; }
        }
        public class RestockQuest3
        {
            public QuestState14 questState { get; set; }
        }
        public class RestockQuest4
        {
            public QuestState20 questState { get; set; }
        }
        public class PricingQuest
        {
            public QuestState5 questState { get; set; }
        }
        public class PricingQuest2
        {
            public QuestState9 questState { get; set; }
        }
        public class PricingQuest3
        {
            public QuestState15 questState { get; set; }
        }
    }
}
