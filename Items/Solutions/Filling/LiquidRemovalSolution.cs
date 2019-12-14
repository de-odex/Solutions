using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class LiquidRemovalSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Liquid Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of any liquid.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("LiquidRemovalSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 1, 50, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "WaterRemovalSolution");
			recipe.AddIngredient(mod, "LavaRemovalSolution");
			recipe.AddIngredient(mod, "HoneyRemovalSolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

    public class InfiniteLiquidRemovalSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Liquid Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of any liquid. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("LiquidRemovalSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LiquidRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
