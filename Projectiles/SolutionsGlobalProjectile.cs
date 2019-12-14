using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsMod.Dusts.LightlessDust;
using SolutionsMod.Dusts.LightedDust;
using SolutionsMod.Projectiles.Solutions;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles
{
    public class SolutionsGlobalProjectile : GlobalProjectile
    {

        public static Dictionary<int, int> dustToLightless;

        static SolutionsGlobalProjectile()
        {
            Mod mod = ModLoader.GetMod("SolutionsMod");
            dustToLightless = new Dictionary<int, int>();
            dustToLightless.Add(110, mod.DustType("BaseLightlessDust"));
            dustToLightless.Add(111, mod.DustType("LightlessBlueDust"));
            dustToLightless.Add(112, mod.DustType("LightlessPurpleDust"));
            dustToLightless.Add(113, mod.DustType("LightlessDeepBlueDust"));
            dustToLightless.Add(114, mod.DustType("LightlessRedDust"));

            dustToLightless.Add(mod.DustType("ClayDust"), mod.DustType("LightlessClayDust"));
            dustToLightless.Add(mod.DustType("DirtDust"), mod.DustType("LightlessDirtDust"));
            dustToLightless.Add(mod.DustType("GraniteDust"), mod.DustType("LightlessGraniteDust"));
            dustToLightless.Add(mod.DustType("HoneyDust"), mod.DustType("LightlessHoneyDust"));
            dustToLightless.Add(mod.DustType("IceRemoveDust"), mod.DustType("LightlessIceRemoveDust"));
            dustToLightless.Add(mod.DustType("IceSpreadDust"), mod.DustType("LightlessIceSpreadDust"));
            dustToLightless.Add(mod.DustType("JungleDust"), mod.DustType("LightlessJungleDust"));
            dustToLightless.Add(mod.DustType("LavaDust"), mod.DustType("LightlessLavaDust"));
            dustToLightless.Add(mod.DustType("MarbleDust"), mod.DustType("LightlessMarbleDust"));
            dustToLightless.Add(mod.DustType("MineralDust"), mod.DustType("LightlessMineralDust"));
            dustToLightless.Add(mod.DustType("RockDust"), mod.DustType("LightlessRockDust"));
            dustToLightless.Add(mod.DustType("WaterDust"), mod.DustType("LightlessWaterDust"));

        }

        public override bool PreAI(Projectile projectile)
        {
            if (projectile.modProjectile != null && projectile.modProjectile is BaseSolution)
            {
                BaseSolution bs = projectile.modProjectile as BaseSolution;
                if (bs.toChange)
                {
                    SolutionsPlayer p = Main.player[projectile.owner].GetModPlayer<SolutionsPlayer>();
                    if (p.solTimesFour)
                    {
                        bs.maxTime *= 4;
                    }
                    if (p.solTimesTwo)
                    {
                        bs.maxTime *= 2;
                    }
                    if (p.solTimesOneThird)
                    {
                        bs.maxTime /= 3;
                    }
                    if (p.solTimesOneFifth)
                    {
                        bs.maxTime /= 5;
                    }
                    projectile.timeLeft = bs.maxTime;

                    if (p.solRadiusDouble)
                    {
                        bs.radius *= 2;
                    }
                    if (p.solRadiusHalf)
                    {
                        bs.radius /= 2;
                    }

                    if (p.lightless)
                    {
                        bs.dustType = dustToLightless[bs.dustType];
                    }
                    bs.toChange = false;
                }
            }
            return base.PreAI(projectile);
        }

        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.modProjectile != null && projectile.modProjectile is BaseSolution)
            {
                BaseSolution bs = projectile.modProjectile as BaseSolution;
                bs.toChange = true;
            }
        }
    }
}
