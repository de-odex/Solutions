using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Clentaminator
{
	public class OneShotClentaminator : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("One Shot Clentaminator");
        }

        public override void SetDefaults()
		{
			item.CloneDefaults(779);
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.autoReuse = false;
			item.useTime = 12;
			item.useAnimation = 12;
		
		}
	}
}
