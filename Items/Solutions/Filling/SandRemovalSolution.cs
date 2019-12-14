using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class SandRemovalSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Sand Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, rases all Sand, Sandstone and Hardened Sand (pure or otherwise). Better used while aiming down.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("SandRemovalSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(mod, "SandSolution");
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 1);
            recipe.SetResult(mod, "SandSolution");
            recipe.AddRecipe();
        }
	}

    public class InfiniteSandRemovalSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Sand Removal Solution");
            Tooltip.SetDefault("Used by the Clentaminator, rases all Sand, Sandstone and Hardened Sand (pure or otherwise). Better used while aiming down. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("SandRemovalSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SandRemovalSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
