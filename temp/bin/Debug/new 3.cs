// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Currency    {
        public int count { get; set; } 
        public string type { get; set; } 
    }

    public class Difficulties    {
        public string selected { get; set; } 
        public string unlocked { get; set; } 
    }

    public class FinishedObjectiveTags    {
        public int Objective_RescuedVillager { get; set; } 
    }

    public class Enchantment    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Armorproperty    {
        public string id { get; set; } 
        public string rarity { get; set; } 
    }

    public class Item    {
        public List<Enchantment> enchantments { get; set; } 
        public string equipmentSlot { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
        public bool upgraded { get; set; } 
        public List<Armorproperty> armorproperties { get; set; } 
        public int? inventoryIndex { get; set; } 
        public bool? markedNew { get; set; } 
    }

    public class PanPosition    {
        public string x { get; set; } 
        public string y { get; set; } 
    }

    public class MapUIState    {
        public PanPosition panPosition { get; set; } 
        public string selectedDifficulty { get; set; } 
        public string selectedMission { get; set; } 
        public string selectedRealm { get; set; } 
        public string selectedThreatLevel { get; set; } 
    }

    public class MerchantData    {
    }

    public class MobKills    {
        public int cow { get; set; } 
        public int creeper { get; set; } 
        public int enchanter { get; set; } 
        public int piggybank { get; set; } 
        public int sheep { get; set; } 
        public int skeletonvariant0 { get; set; } 
        public int skeletonvariant1 { get; set; } 
        public int skeletonvariant2 { get; set; } 
        public int spider { get; set; } 
        public int vindicatorvariant0 { get; set; } 
        public int vindicatorvariant1 { get; set; } 
        public int vindicatorvariant2 { get; set; } 
        public int zombievariant0 { get; set; } 
        public int zombievariant1 { get; set; } 
        public int zombievariant2 { get; set; } 
    }

    public class Creeperwoods    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Squidcoast    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Progress    {
        public Creeperwoods creeperwoods { get; set; } 
        public Squidcoast squidcoast { get; set; } 
    }

    public class ProgressStatCounters    {
        public int WIN_MISSIONS { get; set; } 
    }

    public class ThreatLevels    {
        public string unlocked { get; set; } 
    }

    public class UiHintsExpired    {
        public string hintType { get; set; } 
    }

    public class Root    {
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

