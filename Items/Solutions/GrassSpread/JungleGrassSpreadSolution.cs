using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.GrassSpread
{
	public class JungleGrassSpreadSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Jungle Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads jungle grass in Mud. Converted block must be in contact with air.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("JungleGrassSpreadSolution") - ProjectileID.PureSpray;
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
            recipe.AddIngredient(mod, "JungleSolution");
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}

    public class InfiniteJungleGrassSpreadSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Jungle Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads jungle grass in Mud. Converted block must be in contact with air. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("JungleGrassSpreadSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "JungleGrassSpreadSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
