using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Accessories
{
    public class TriReductorBarrel: ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Tri Reductor Barrel");
            Tooltip.SetDefault("Reduces spray distance to one third, but has one in three chances to consume ammo.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.buyPrice(5, 0, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = 6;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>();
            p.solTimesOneThird = true;
        }
    }
}
