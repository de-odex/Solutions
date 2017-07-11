using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class RockRemovalSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Stone Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, erases all Stone (pure or otherwise). Will not remove Granite or Marble.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("RockRemovalSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(mod, "RockSolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(mod, "RockSolution");
            recipe.AddRecipe();
        }
	}


    public class InfiniteRockRemovalSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Stone Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, erases all Stone (pure or otherwise). Will not remove Granite or Marble. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType<RockRemovalSolution>());
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RockRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
