using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class RockNormalizerSolution : BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Rock Spray";
            maxTime = 134;
            dustType = mod.DustType("RockDust");
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        int type = (int)Main.tile[k, l].type;
                        int wall = (int)Main.tile[k, l].wall;
                        if (wall == 178 || wall == 180)
                        {
                            Main.tile[k, l].wall = 54;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 367 || type == 368)
                        {
                            Main.tile[k, l].type = 1;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }



                    }
                }
            }
        }
    }
}
