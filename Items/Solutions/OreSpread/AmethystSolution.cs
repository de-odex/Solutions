using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.OreSpread
{
	public class AmethystSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Amethyst Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Stone into Amethyst.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("AmethystSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 2, 50, 0);
			item.rare = 4;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			/*recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(this, 999);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);*/
			recipe.AddIngredient(ItemID.Amethyst,10);
			recipe.AddIngredient(null,"MineralSolution");
			recipe.SetResult(this, 1);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}

    public class InfiniteAmethystSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Amethyst Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Stone into Amethyst. Infinite.");
        }


        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("AmethystSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystSolution", 999);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MineralSolution", 999);
            recipe.AddIngredient(ItemID.Amethyst, 9990);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
