using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Accessories
{
    public class LightSuppressor: ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Light Suppressor");
            Tooltip.SetDefault("Makes sprays lightless");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.buyPrice(0, 50, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = 5;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>();
            p.lightless = true;
        }
    }
}
