using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDungeonTools.assets.classes
{
    class Slots
    {
        public Slot1 slot1 { get; set; }
        public Slot2 slot2 { get; set; }
        public Slot3 slot3 { get; set; }
        public class Armorproperty2
        {
            public string id { get; set; }
            public string rarity { get; set; }
        }
        public class Armorproperty3
        {
            public string id { get; set; }
            public string rarity { get; set; }
        }
        public class Enchantment2
        {
            public string id { get; set; }
            public int level { get; set; }
        }
        public class Enchantment3
        {
            public string id { get; set; }
            public int level { get; set; }
        }
        public class Enchantment4
        {
            public string id { get; set; }
            public int level { get; set; }
        }
        public class Enchantment5
        {
            public string id { get; set; }
            public int level { get; set; }
        }
        public class Enchantment6
        {
            public string id { get; set; }
            public int level { get; set; }
        }
        public class Item2
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item3
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item4
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item5
        {
            public List<Armorproperty2> armorproperties { get; set; }
            public List<Enchantment2> enchantments { get; set; }
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item6
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item7
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item8
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item9
        {
            public List<Enchantment3> enchantments { get; set; }
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item10
        {
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item11
        {
            public List<Enchantment4> enchantments { get; set; }
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item12
        {
            public List<Enchantment5> enchantments { get; set; }
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Item13
        {
            public List<Armorproperty3> armorproperties { get; set; }
            public List<Enchantment6> enchantments { get; set; }
            public double power { get; set; }
            public string rarity { get; set; }
            public string type { get; set; }
        }
        public class Slot1
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot2
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot3
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot12
        {
            public Item2 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot13
        {
            public Item3 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot14
        {
            public Item6 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot15
        {
            public Item9 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot22
        {
            public Item4 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot23
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot32
        {
            public Item5 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot34
        {
            public Item11 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot24
        {
            public Item10 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot33
        {
            public Item7 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot42
        {
            public Item12 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot52
        {
            public Item13 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot62
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slots2
        {
            public Slot12 Slot1 { get; set; }
        }
        public class Slots3
        {
            public Slot13 Slot1 { get; set; }
            public Slot22 Slot2 { get; set; }
            public Slot32 Slot3 { get; set; }
        }
        public class Slots4
        {
            public Slot14 Slot1 { get; set; }
            public Slot23 Slot2 { get; set; }
            public Slot33 Slot3 { get; set; }
            public Slot4 Slot4 { get; set; }
            public Slot5 Slot5 { get; set; }
            public Slot6 Slot6 { get; set; }
        }
        public class Slots5
        {
            public Slot15 Slot1 { get; set; }
            public Slot24 Slot2 { get; set; }
            public Slot34 Slot3 { get; set; }
            public Slot42 Slot4 { get; set; }
            public Slot52 Slot5 { get; set; }
            public Slot62 Slot6 { get; set; }
        }
        public class Slot4
        {
            public Item8 item { get; set; }
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot5
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
        public class Slot6
        {
            public double priceMultiplier { get; set; }
            public double rebateFraction { get; set; }
            public bool reserved { get; set; }
        }
    }
}
