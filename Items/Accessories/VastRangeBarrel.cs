using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Accessories
{
    public class VastRangeBarrel: ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Vast Range Barrel");
            Tooltip.SetDefault("Quadruples spray distance, but consumes four times as much ammo.");
        }


        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.buyPrice(20, 0, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = 7;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>();
            p.solTimesFour = true;
        }
    }
}
