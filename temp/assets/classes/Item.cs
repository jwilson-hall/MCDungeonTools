using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDungeonTools.assets
{
    public class Item
    {
        public List<Enchantment> enchantments { get; set; }
        public string? equipmentSlot { get; set; }
        public double power { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public bool upgraded { get; set; }
        public List<Armorproperty> armorproperties { get; set; }
        public int? inventoryIndex { get; set; }
        public bool? markedNew { get; set; }
    }
}
