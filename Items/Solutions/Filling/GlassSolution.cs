using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class GlassSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Glass Filling Solution");
            Tooltip.SetDefault("Used by the Clentaminator, fills empty space with Glass.");
        }
        public override void SetDefaults()
		{

			item.shoot = mod.ProjectileType("GlassSolution") - ProjectileID.PureSpray;
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
            recipe.AddIngredient(mod, "SandSolution", 2);
            recipe.AddIngredient(mod, "LavaSolution", 1);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.Bottles);
			recipe.AddRecipe();
		}
	}

    public class InfiniteGlassSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Glass Filling Solution");
            Tooltip.SetDefault("Used by the Clentaminator, fills empty space with Glass. Infinite.");
        }


        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("GlassSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GlassSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
