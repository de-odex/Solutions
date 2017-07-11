using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.BiomeChange
{
    public class InfiniteBlueSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Blue Solution");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.BlueSolution);
            item.SetNameOverride("Infinite " + Language.GetTextValue("ItemName.BlueSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlueSolution, 999*4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

    public class InfiniteDarkBlueSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Dark Blue Solution");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.DarkBlueSolution);
            item.SetNameOverride("Infinite " + Language.GetTextValue("ItemName.DarkBlueSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DarkBlueSolution, 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

    public class InfiniteGreenSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Green Solution");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GreenSolution);
            item.SetNameOverride("Infinite " + Language.GetTextValue("ItemName.GreenSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenSolution, 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

    public class InfinitePurpleSolution : ModItem
    {

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Purple Solution");
        }


        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.PurpleSolution);
            item.SetNameOverride("Infinite " + Language.GetTextValue("ItemName.PurpleSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PurpleSolution, 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }

    public class InfiniteRedSolution : ModItem
    {


        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Red Solution");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.RedSolution);
            item.SetNameOverride("Infinite " + Language.GetTextValue("ItemName.RedSolution"));
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RedSolution, 999 * 4);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}