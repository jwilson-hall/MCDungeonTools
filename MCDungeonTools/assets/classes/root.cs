using MCDungeonTools.assets.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDungeonTools.assets.classes
{
    class root
    {
        public List<object> bonus_prerequisites { get; set; }
        public bool clone { get; set; }
        public List<object> cosmetics { get; set; }
        public List<object> cosmeticsEverEquipped { get; set; }
        public string creationDate { get; set; }
        public List<Currency> currency { get; set; }
        public bool customized { get; set; }
        public Difficulties difficulties { get; set; }
        public FinishedObjectiveTags finishedObjectiveTags { get; set; }
        public List<Item> items { get; set; }
        public List<string> itemsFound { get; set; }
        public object lobbychest_progress { get; set; }
        public MapUIState mapUIState { get; set; }
        public MerchantData merchantData { get; set; }
        public MobKills mob_kills { get; set; }
        public string name { get; set; }
        public object pendingRewardItem { get; set; }
        public string playerId { get; set; }
        public Progress progress { get; set; }
        public ProgressStatCounters progressStatCounters { get; set; }
        public List<object> progressionKeys { get; set; }
        public string skin { get; set; }
        public ThreatLevels threatLevels { get; set; }
        public int timestamp { get; set; }
        public int totalGearPower { get; set; }
        public List<object> trialsCompleted { get; set; }
        public List<UiHintsExpired> uiHintsExpired { get; set; }
        public int version { get; set; }
        public int xp { get; set; }
    }
}
