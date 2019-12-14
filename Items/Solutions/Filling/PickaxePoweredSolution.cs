using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class PickaxePoweredSolution : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Pickaxe Power Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes any tile your most powerful pickaxe/drill/claw could mine.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("PickaxeBlockRemovalSolution") - ProjectileID.PureSpray;

            item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 3;
			item.maxStack = 999;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DirtSolution");
			recipe.AddIngredient(null, "WaterSolution");
			recipe.AddTile(13);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();*/
		}
	}

    public class InfinitePickaxePoweredSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Pickaxe Power Solution");
            Tooltip.SetDefault("Used by the Clentaminator, removes any tile your most powerful pickaxe/drill/claw could mine. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("PickaxePoweredSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PickaxePoweredSolution", 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
