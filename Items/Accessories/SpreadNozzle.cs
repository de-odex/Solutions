using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Accessories
{
    public class SpreadNozzle: ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Spread Nozzle");
            Tooltip.SetDefault("Doubles spray radius");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;           
            item.value = Item.buyPrice(10, 0, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = 6;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>(mod);
            p.solRadiusDouble = true;
        }
    }
}
