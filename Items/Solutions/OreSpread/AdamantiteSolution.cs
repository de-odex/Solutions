using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.OreSpread
{
	public class AdamantiteSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Adamantite Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Stone into Adamantite.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("AdamantiteSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(ItemID.AdamantiteOre,10);
			recipe.AddIngredient(null,"MineralSolution");
			recipe.SetResult(this, 1);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}

    public class InfiniteAdamantiteSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Adamantite Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Stone into Adamantite. Infinite");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("AdamantiteSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AdamantiteSolution", 999);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MineralSolution", 999);
            recipe.AddIngredient(ItemID.AdamantiteOre, 9990);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
