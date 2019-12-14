using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.GrassSpread
{
	public class MushroomGrassSpreadSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mushroom Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads mushroom grass in Mud. Converted block must be in contact with air.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("MushroomGrassSpreadSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(ItemID.DarkBlueSolution);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}

    public class InfiniteMushroomGrassSpreadSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Mushroom Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads mushroom grass in Mud. Converted block must be in contact with air. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("MushroomGrassSpreadSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MushroomGrassSpreadSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
