using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Accessories
{
    public class ConcentratorNozzle: ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Concentrator Nozzle");
            Tooltip.SetDefault("Halves spray radius");
        }

        public override void SetDefaults()
        {          
            item.width = 16;
            item.height = 16;
            item.value = Item.buyPrice(2, 50, 0, 0);
            item.consumable = false;
            item.accessory = true;
            item.rare = 6;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>(mod);
            p.solRadiusHalf = true;
        }
    }
}
