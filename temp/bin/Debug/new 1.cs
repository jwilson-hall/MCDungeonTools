// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Cosmetic    {
        public string id { get; set; } 
        public string type { get; set; } 
    }

    public class Currency    {
        public int count { get; set; } 
        public string type { get; set; } 
    }

    public class Difficulties    {
        public string announced { get; set; } 
        public string selected { get; set; } 
        public string unlocked { get; set; } 
    }

    public class FinishedObjectiveTags    {
        public int Objective_RescuedVillager { get; set; } 
        public int cannot-attach-projectiles { get; set; } 
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

    public class 1    {
        public int unlockedTimes { get; set; } 
    }

    public class 2    {
        public int unlockedTimes { get; set; } 
    }

    public class 3    {
        public int unlockedTimes { get; set; } 
    }

    public class 4    {
        public int unlockedTimes { get; set; } 
    }

    public class 5    {
        public int unlockedTimes { get; set; } 
    }

    public class 6    {
        public int unlockedTimes { get; set; } 
    }

    public class 7    {
        public int unlockedTimes { get; set; } 
    }

    public class 8    {
        public int unlockedTimes { get; set; } 
    }

    public class 9    {
        public int unlockedTimes { get; set; } 
    }

    public class LobbychestProgress    {
        public 1 1 { get; set; } 
        public 2 2 { get; set; } 
        public 3 3 { get; set; } 
        public 4 4 { get; set; } 
        public 5 5 { get; set; } 
        public 6 6 { get; set; } 
        public 7 7 { get; set; } 
        public 8 8 { get; set; } 
        public 9 9 { get; set; } 
    }

    public class PanPosition    {
        public string x { get; set; } 
        public string y { get; set; } 
    }

    public class MapUIState    {
        public PanPosition panPosition { get; set; } 
        public string selectedDifficulty { get; set; } 
        public string selectedRealm { get; set; } 
        public string selectedThreatLevel { get; set; } 
    }

    public class Pricing    {
        public int timesRestocked { get; set; } 
    }

    public class QuestState    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class UpgradeQuest1    {
        public QuestState questState { get; set; } 
    }

    public class QuestState2    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class UpgradeQuest2    {
        public QuestState2 questState { get; set; } 
    }

    public class QuestState3    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class UpgradeQuest3    {
        public QuestState3 questState { get; set; } 
    }

    public class Quests    {
        public object Quest1 { get; set; } 
        public object Quest2 { get; set; } 
        public UpgradeQuest1 UpgradeQuest1 { get; set; } 
        public UpgradeQuest2 UpgradeQuest2 { get; set; } 
        public UpgradeQuest3 UpgradeQuest3 { get; set; } 
    }

    public class Slot1    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot2    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot3    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slots    {
        public Slot1 Slot1 { get; set; } 
        public Slot2 Slot2 { get; set; } 
        public Slot3 Slot3 { get; set; } 
    }

    public class DefaultBlacksmithMerchantDef    {
        public bool everInteracted { get; set; } 
        public Pricing pricing { get; set; } 
        public Quests quests { get; set; } 
        public Slots slots { get; set; } 
    }

    public class Pricing2    {
        public int timesRestocked { get; set; } 
    }

    public class QuestState4    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class RestockQuest    {
        public QuestState4 questState { get; set; } 
    }

    public class Quests2    {
        public RestockQuest RestockQuest { get; set; } 
    }

    public class Item2    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot12    {
        public Item2 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slots2    {
        public Slot12 Slot1 { get; set; } 
    }

    public class DefaultGiftWrapperMerchantDef    {
        public bool everInteracted { get; set; } 
        public Pricing2 pricing { get; set; } 
        public Quests2 quests { get; set; } 
        public Slots2 slots { get; set; } 
    }

    public class Pricing3    {
        public int timesRestocked { get; set; } 
    }

    public class QuestState5    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class PricingQuest    {
        public QuestState5 questState { get; set; } 
    }

    public class QuestState6    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest1    {
        public QuestState6 questState { get; set; } 
    }

    public class QuestState7    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest2    {
        public QuestState7 questState { get; set; } 
    }

    public class QuestState8    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class RestockQuest2    {
        public QuestState8 questState { get; set; } 
    }

    public class Quests3    {
        public PricingQuest PricingQuest { get; set; } 
        public Quest1 Quest1 { get; set; } 
        public Quest2 Quest2 { get; set; } 
        public RestockQuest2 RestockQuest { get; set; } 
    }

    public class Item3    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot13    {
        public Item3 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Item4    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot22    {
        public Item4 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Armorproperty2    {
        public string id { get; set; } 
        public string rarity { get; set; } 
    }

    public class Enchantment2    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Item5    {
        public List<Armorproperty2> armorproperties { get; set; } 
        public List<Enchantment2> enchantments { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot32    {
        public Item5 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slots3    {
        public Slot13 Slot1 { get; set; } 
        public Slot22 Slot2 { get; set; } 
        public Slot32 Slot3 { get; set; } 
    }

    public class DefaultLuxuryMerchantDef    {
        public bool everInteracted { get; set; } 
        public Pricing3 pricing { get; set; } 
        public Quests3 quests { get; set; } 
        public Slots3 slots { get; set; } 
    }

    public class Pricing4    {
        public int timesRestocked { get; set; } 
    }

    public class QuestState9    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class PricingQuest2    {
        public QuestState9 questState { get; set; } 
    }

    public class QuestState10    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest12    {
        public QuestState10 questState { get; set; } 
    }

    public class QuestState11    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest22    {
        public QuestState11 questState { get; set; } 
    }

    public class QuestState12    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest3    {
        public QuestState12 questState { get; set; } 
    }

    public class QuestState13    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest4    {
        public QuestState13 questState { get; set; } 
    }

    public class QuestState14    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class RestockQuest3    {
        public QuestState14 questState { get; set; } 
    }

    public class Quests4    {
        public PricingQuest2 PricingQuest { get; set; } 
        public Quest12 Quest1 { get; set; } 
        public Quest22 Quest2 { get; set; } 
        public Quest3 Quest3 { get; set; } 
        public Quest4 Quest4 { get; set; } 
        public RestockQuest3 RestockQuest { get; set; } 
    }

    public class Item6    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot14    {
        public Item6 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot23    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Item7    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot33    {
        public Item7 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Item8    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot4    {
        public Item8 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot5    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot6    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slots4    {
        public Slot14 Slot1 { get; set; } 
        public Slot23 Slot2 { get; set; } 
        public Slot33 Slot3 { get; set; } 
        public Slot4 Slot4 { get; set; } 
        public Slot5 Slot5 { get; set; } 
        public Slot6 Slot6 { get; set; } 
    }

    public class DefaultMysteryMerchantDef    {
        public bool everInteracted { get; set; } 
        public Pricing4 pricing { get; set; } 
        public Quests4 quests { get; set; } 
        public Slots4 slots { get; set; } 
    }

    public class Pricing5    {
        public int timesRestocked { get; set; } 
    }

    public class QuestState15    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class PricingQuest3    {
        public QuestState15 questState { get; set; } 
    }

    public class QuestState16    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest13    {
        public QuestState16 questState { get; set; } 
    }

    public class QuestState17    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest23    {
        public QuestState17 questState { get; set; } 
    }

    public class QuestState18    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest32    {
        public QuestState18 questState { get; set; } 
    }

    public class QuestState19    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class Quest42    {
        public QuestState19 questState { get; set; } 
    }

    public class QuestState20    {
        public int startedAtCount { get; set; } 
        public int targetCount { get; set; } 
    }

    public class RestockQuest4    {
        public QuestState20 questState { get; set; } 
    }

    public class Quests5    {
        public PricingQuest3 PricingQuest { get; set; } 
        public Quest13 Quest1 { get; set; } 
        public Quest23 Quest2 { get; set; } 
        public Quest32 Quest3 { get; set; } 
        public Quest42 Quest4 { get; set; } 
        public RestockQuest4 RestockQuest { get; set; } 
    }

    public class Enchantment3    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Item9    {
        public List<Enchantment3> enchantments { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot15    {
        public Item9 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Item10    {
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot24    {
        public Item10 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Enchantment4    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Item11    {
        public List<Enchantment4> enchantments { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot34    {
        public Item11 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Enchantment5    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Item12    {
        public List<Enchantment5> enchantments { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot42    {
        public Item12 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Armorproperty3    {
        public string id { get; set; } 
        public string rarity { get; set; } 
    }

    public class Enchantment6    {
        public string id { get; set; } 
        public int level { get; set; } 
    }

    public class Item13    {
        public List<Armorproperty3> armorproperties { get; set; } 
        public List<Enchantment6> enchantments { get; set; } 
        public double power { get; set; } 
        public string rarity { get; set; } 
        public string type { get; set; } 
    }

    public class Slot52    {
        public Item13 item { get; set; } 
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slot62    {
        public double priceMultiplier { get; set; } 
        public double rebateFraction { get; set; } 
        public bool reserved { get; set; } 
    }

    public class Slots5    {
        public Slot15 Slot1 { get; set; } 
        public Slot24 Slot2 { get; set; } 
        public Slot34 Slot3 { get; set; } 
        public Slot42 Slot4 { get; set; } 
        public Slot52 Slot5 { get; set; } 
        public Slot62 Slot6 { get; set; } 
    }

    public class DefaultVillageMerchantDef    {
        public bool everInteracted { get; set; } 
        public Pricing5 pricing { get; set; } 
        public Quests5 quests { get; set; } 
        public Slots5 slots { get; set; } 
    }

    public class MerchantData    {
        public DefaultBlacksmithMerchantDef Default__BlacksmithMerchantDef { get; set; } 
        public DefaultGiftWrapperMerchantDef Default__GiftWrapperMerchantDef { get; set; } 
        public DefaultLuxuryMerchantDef Default__LuxuryMerchantDef { get; set; } 
        public DefaultMysteryMerchantDef Default__MysteryMerchantDef { get; set; } 
        public DefaultVillageMerchantDef Default__VillageMerchantDef { get; set; } 
    }

    public class MobKills    {
        public int archillager { get; set; } 
        public int archvessel { get; set; } 
        public int babypanda { get; set; } 
        public int babyzombie { get; set; } 
        public int bee { get; set; } 
        public int cauldronboss { get; set; } 
        public int cave_spider { get; set; } 
        public int chickenjockey { get; set; } 
        public int chickenjockeytower { get; set; } 
        public int chillager { get; set; } 
        public int cow { get; set; } 
        public int creeper { get; set; } 
        public int enchanter { get; set; } 
        public int enderman { get; set; } 
        public int evoker { get; set; } 
        public int falseking { get; set; } 
        public int frozenzombie { get; set; } 
        public int geomancer { get; set; } 
        public int goldbabykey { get; set; } 
        public int husk { get; set; } 
        public int icycreeper { get; set; } 
        public int illusioner { get; set; } 
        public int illusionerclone { get; set; } 
        public int jungleabomination { get; set; } 
        public int junglezombie { get; set; } 
        public int lazypanda { get; set; } 
        public int leaper { get; set; } 
        public int mobspawner { get; set; } 
        public int mossyskeleton { get; set; } 
        public int namelessking { get; set; } 
        public int necromancer { get; set; } 
        public int ocelot { get; set; } 
        public int piggybank { get; set; } 
        public int pillagervariant0 { get; set; } 
        public int pillagervariant1 { get; set; } 
        public int pillagervariant2 { get; set; } 
        public int playfulpanda { get; set; } 
        public int poisonquillvine { get; set; } 
        public int poisonquillvinesimple { get; set; } 
        public int polarbear { get; set; } 
        public int quickgrowingvine { get; set; } 
        public int quickgrowingvinesimple { get; set; } 
        public int rabbit { get; set; } 
        public int redstonecube { get; set; } 
        public int redstonegolem { get; set; } 
        public int redstonemonstrosity { get; set; } 
        public int royalguard { get; set; } 
        public int sheep { get; set; } 
        public int silverbabykey { get; set; } 
        public int skeletonhorseman { get; set; } 
        public int skeletonvanguard { get; set; } 
        public int skeletonvariant0 { get; set; } 
        public int skeletonvariant1 { get; set; } 
        public int skeletonvariant2 { get; set; } 
        public int slimecauldron { get; set; } 
        public int slimelarge { get; set; } 
        public int slimemedium { get; set; } 
        public int slimesmall { get; set; } 
        public int spider { get; set; } 
        public int stray { get; set; } 
        public int vex { get; set; } 
        public int vindicator-chef { get; set; } 
        public int vindicatorvariant0 { get; set; } 
        public int vindicatorvariant1 { get; set; } 
        public int vindicatorvariant2 { get; set; } 
        public int whisperer { get; set; } 
        public int wickedwraith { get; set; } 
        public int witch { get; set; } 
        public int wraith { get; set; } 
        public int zombievariant0 { get; set; } 
        public int zombievariant1 { get; set; } 
        public int zombievariant2 { get; set; } 
    }

    public class Archhaven    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Bamboobluff    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Cacticanyon    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Creeperwoods    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Creepycrypt    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Deserttemple    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Dingyjungle    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Fieryforge    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Frozenfjord    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Highblockhalls    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Lonelyfortress    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Lowertemple    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Mooncorecaverns    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Obsidianpinnacle    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Overgrowntemple    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Pumpkinpastures    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Soggycave    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Soggyswamp    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Squidcoast    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Underhalls    {
        public string completedDifficulty { get; set; } 
        public string completedThreatLevel { get; set; } 
    }

    public class Progress    {
        public Archhaven archhaven { get; set; } 
        public Bamboobluff bamboobluff { get; set; } 
        public Cacticanyon cacticanyon { get; set; } 
        public Creeperwoods creeperwoods { get; set; } 
        public Creepycrypt creepycrypt { get; set; } 
        public Deserttemple deserttemple { get; set; } 
        public Dingyjungle dingyjungle { get; set; } 
        public Fieryforge fieryforge { get; set; } 
        public Frozenfjord frozenfjord { get; set; } 
        public Highblockhalls highblockhalls { get; set; } 
        public Lonelyfortress lonelyfortress { get; set; } 
        public Lowertemple lowertemple { get; set; } 
        public Mooncorecaverns mooncorecaverns { get; set; } 
        public Obsidianpinnacle obsidianpinnacle { get; set; } 
        public Overgrowntemple overgrowntemple { get; set; } 
        public Pumpkinpastures pumpkinpastures { get; set; } 
        public Soggycave soggycave { get; set; } 
        public Soggyswamp soggyswamp { get; set; } 
        public Squidcoast squidcoast { get; set; } 
        public Underhalls underhalls { get; set; } 
    }

    public class ProgressStatCounters    {
        public int DEFEAT_ENCHANTED_MOBS { get; set; } 
        public int DEFEAT_EVENT_MOBS { get; set; } 
        public int WIN_MISSIONS { get; set; } 
    }

    public class ThreatLevels    {
        public string unlocked { get; set; } 
    }

    public class UiHintsExpired    {
        public string hintType { get; set; } 
    }

    public class Root    {
        public List<string> bonus_prerequisites { get; set; } 
        public bool clone { get; set; } 
        public List<Cosmetic> cosmetics { get; set; } 
        public List<string> cosmeticsEverEquipped { get; set; } 
        public string creationDate { get; set; } 
        public List<Currency> currency { get; set; } 
        public bool customized { get; set; } 
        public Difficulties difficulties { get; set; } 
        public FinishedObjectiveTags finishedObjectiveTags { get; set; } 
        public List<Item> items { get; set; } 
        public List<string> itemsFound { get; set; } 
        public LobbychestProgress lobbychest_progress { get; set; } 
        public MapUIState mapUIState { get; set; } 
        public MerchantData merchantData { get; set; } 
        public MobKills mob_kills { get; set; } 
        public string name { get; set; } 
        public object pendingRewardItem { get; set; } 
        public string playerId { get; set; } 
        public Progress progress { get; set; } 
        public ProgressStatCounters progressStatCounters { get; set; } 
        public List<string> progressionKeys { get; set; } 
        public string skin { get; set; } 
        public ThreatLevels threatLevels { get; set; } 
        public int timestamp { get; set; } 
        public int totalGearPower { get; set; } 
        public List<object> trialsCompleted { get; set; } 
        public List<UiHintsExpired> uiHintsExpired { get; set; } 
        public int version { get; set; } 
        public int xp { get; set; } 
    }

