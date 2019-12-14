using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class WaterRemovalSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Water Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of Water.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("WaterRemovalSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 50, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "WaterSolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(mod, "WaterSolution");
            recipe.AddRecipe();
        }
	}

    public class InfiniteWaterRemovalSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Water Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of Water. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("WaterRemovalSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "WaterRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
