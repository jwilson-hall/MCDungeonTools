//using MCDungeonTools.assets.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDungeonTools.assets.classes
{
    class MerchantData
    {
        public DefaultBlacksmithMerchantDef Default__BlacksmithMerchantDef { get; set; }
        public DefaultGiftWrapperMerchantDef Default__GiftWrapperMerchantDef { get; set; }
        public DefaultLuxuryMerchantDef Default__LuxuryMerchantDef { get; set; }
        public DefaultMysteryMerchantDef Default__MysteryMerchantDef { get; set; }
        public DefaultVillageMerchantDef Default__VillageMerchantDef { get; set; }

        public class DefaultVillageMerchantDef
        {
            public bool everInteracted { get; set; }
            public Pricing.Pricing5 pricing { get; set; }
            public Quests.Quests5 quests { get; set; }
            public Slots.Slots5 slots { get; set; }
        }
        public class DefaultBlacksmithMerchantDef
        {
            public bool everInteracted { get; set; }
            public Pricing pricing { get; set; }
            public Quests quests { get; set; }
            public Slots slots { get; set; }
        }
        public class DefaultGiftWrapperMerchantDef
        {
            public bool everInteracted { get; set; }
            public Pricing.Pricing2 pricing { get; set; }
            public Quests.Quests2 quests { get; set; }
            public Slots.Slots2 slots { get; set; }
        }
        public class DefaultLuxuryMerchantDef
        {
            public bool everInteracted { get; set; }
            public Pricing.Pricing3 pricing { get; set; }
            public Quests.Quests3 quests { get; set; }
            public Slots.Slots3 slots { get; set; }
        }
        public class DefaultMysteryMerchantDef
        {
            public bool everInteracted { get; set; }
            public Pricing.Pricing4 pricing { get; set; }
            public Quests.Quests4 quests { get; set; }
            public Slots.Slots4 slots { get; set; }
        }
    }
}
