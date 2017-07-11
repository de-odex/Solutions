using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.GrassSpread
{
	public class GrassRemovalSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Anti-Grass Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes grass from any surface.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("GrassRemovalSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrassSpreadSolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}

    public class InfiniteGrassRemovalSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Anti-Grass Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes grass from any surface. Infinite.");
        }


        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType<GrassRemovalSolution>());
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GrassRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
