using SolutionsMod.Items.Clentaminator;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items.Solutions.Filling
{
	public class ActuatorPlacingSolution : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Actuator Placing Solution");
            Tooltip.SetDefault("Used by the Clentaminator, places actuators under all solid tiles with wires running through.");
        }

        public override void SetDefaults()
		{
			item.shoot = mod.ProjectileType("ActuatorPlacingSolution") - ProjectileID.PureSpray;
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
			recipe.AddIngredient(mod, "MineralSolution");
            recipe.AddIngredient(ItemID.Actuator, 10);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player)
        {
            base.UpdateInventory(player);
            if (player.InfoAccMechShowWires) return;
            if(player.inventory[player.selectedItem].useAmmo == AmmoID.Solution)
            {
                for(int i = 54; i<58; i++)
                {
                    if(player.inventory[i].ammo == ItemID.GreenSolution)
                    {
                        if(player.inventory[i].type == this.item.type)
                        {
                            player.InfoAccMechShowWires = true;
                        }
                        return;
                    }
                }
                for(int i = 0; i < 50; i++)
                {
                    if (player.inventory[i].ammo == ItemID.GreenSolution)
                    {
                        if (player.inventory[i].type == this.item.type)
                        {
                            player.InfoAccMechShowWires = true;
                        }
                        return;
                    }
                }
            }
        }
    }

    public class InfiniteActuatorPlacingSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Infinite Actuator Placing Solution");
            Tooltip.SetDefault("Used by the Clentaminator, places actuators under all solid tiles with wires running through. Infinite");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(mod.ItemType<ActuatorPlacingSolution>());
            item.consumable = false;
            item.maxStack = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ActuatorPlacingSolution", 999);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player)
        {
            base.UpdateInventory(player);
            if (player.InfoAccMechShowWires) return;
            if (player.inventory[player.selectedItem].useAmmo == AmmoID.Solution)
            {
                for (int i = 54; i < 58; i++)
                {
                    if (player.inventory[i].ammo == ItemID.GreenSolution)
                    {
                        if (player.inventory[i].type == this.item.type)
                        {
                            player.InfoAccMechShowWires = true;
                        }
                        return;
                    }
                }
                for (int i = 0; i < 50; i++)
                {
                    if (player.inventory[i].ammo == ItemID.GreenSolution)
                    {
                        if (player.inventory[i].type == this.item.type)
                        {
                            player.InfoAccMechShowWires = true;
                        }
                        return;
                    }
                }
            }
        }

    }
}
