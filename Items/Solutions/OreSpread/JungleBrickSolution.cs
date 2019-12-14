using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.OreSpread
{
	public class JungleBrickSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Lihzahrd Brick Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Mud into Lihzahrd Bricks.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("JungleBrickSolution") - ProjectileID.PureSpray;
			item.ammo = ItemID.GreenSolution;
			item.width = 10;
			item.height = 12;
			item.value = Item.buyPrice(0, 5, 0, 0);
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
			recipe.AddIngredient(ItemID.LihzahrdBrick,10);
			recipe.AddIngredient(null,"MineralSolution");
			recipe.SetResult(this, 1);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}
	}

    public class InfiniteJungleBrickSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Lihzahrd Brick Solution");
            Tooltip.SetDefault("Used by the Clentaminator, transmutes Mud into Lihzahrd Bricks. Infinite.");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType("JungleBrickSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "JungleBrickSolution", 999);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MineralSolution", 999);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 9990);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
