using SolutionsMod.Projectiles.Solutions.BiomeChange;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Items
{
    public class SolutionsGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.ammo == AmmoID.Solution)
            {
                if (item.shoot == 0)
                {
                    item.shoot = mod.ProjectileType<GreenSolution>() - ProjectileID.PureSpray;
                }
                else if (item.shoot == 2)
                {
                    item.shoot = mod.ProjectileType<PurpleSolution>() - ProjectileID.PureSpray;
                }
                else if (item.shoot == 1)
                {
                    item.shoot = mod.ProjectileType<BlueSolution>() - ProjectileID.PureSpray;
                }
                else if (item.shoot == 4)
                {
                    item.shoot = mod.ProjectileType<RedSolution>() - ProjectileID.PureSpray;
                }
                else if (item.shoot == 3)
                {
                    item.shoot = mod.ProjectileType<DeepBlueSolution>() - ProjectileID.PureSpray;
                }
            }
        }

        public override bool ConsumeAmmo(Item item, Player player)
        {
            if(item.ammo == AmmoID.Solution)
            {
                if (!item.consumable)
                    return false;

                float consumed = 1.0f;
                SolutionsPlayer p = player.GetModPlayer<SolutionsPlayer>(mod);
                if (p.solTimesFour)
                    consumed *= 4;
                if (p.solTimesTwo)
                    consumed *= 2;

                if (p.solTimesOneThird)
                    consumed /= 3;
                if (p.solTimesOneFifth)
                    consumed /= 5;

                while (consumed > 2)
                {
                    item.stack--;
                    consumed -= 1;
                    if (item.stack == 0)
                        break;
                }

                if (consumed > 1)
                    return true;
                else
                    return (Main.rand.NextDouble() < consumed);
            }
            return true;
        }
    }
}
