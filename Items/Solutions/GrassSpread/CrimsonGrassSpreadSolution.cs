using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.GrassSpread
{
	public class CrimsonGrassSpreadSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Crimson Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads crimson grass in Dirt. Converted block must be in contact with air.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("CrimsonGrassSpreadSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 25, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrassSpreadSolution");
            recipe.AddIngredient(ItemID.RedSolution);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}

    public class InfiniteCrimsonGrassSpreadSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Crimson Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads crimson grass in Dirt. Converted block must be in contact with air. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("CrimsonGrassSpreadSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrimsonGrassSpreadSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
