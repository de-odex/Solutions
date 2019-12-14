using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.GrassSpread
{
	public class CorruptGrassSpreadSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Corrupt Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads corrupt grass in Dirt. Converted block must be in contact with air.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("CorruptGrassSpreadSolution") - ProjectileID.PureSpray;
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
            recipe.AddIngredient(ItemID.PurpleSolution);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}

    public class InfiniteCorruptGrassSpreadSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Corrupt Grass Spreading Solution");
            Tooltip.SetDefault("Used by the Clentaminator, spreads corrupt grass in Dirt. Converted block must be in contact with air. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("CorruptGrassSpreadSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CorruptGrassSpreadSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
