using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class HoneyRemovalSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Honey Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of Honey.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("HoneyRemovalSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(mod, "HoneySolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(mod, "HoneySolution"); 
            recipe.AddRecipe();
        }
	}

    public class InfiniteHoneyRemovalSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Honey Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes all traces of Honey. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType<HoneyRemovalSolution>());
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "HoneyRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
