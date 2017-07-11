using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class IceSpreadSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Ice Spray";
            maxTime = 134;
            dustType = mod.DustType<IceSpreadDust>();
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
                        if (wall == 2 || wall == 63 || wall == 65)
                        {
                            Main.tile[k, l].wall = 40;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 0 && Main.tile[k, l].active() || type == 2 || type == 23 || type == 109 || type == 199)
                        {
                            Main.tile[k, l].type = 147;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        else if (type == 1)
                        {
                            Main.tile[k, l].type = 161;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 25)
                        {
                            Main.tile[k, l].type = 163;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 117)
                        {
                            Main.tile[k, l].type = 164;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        else if (type == 203)
                        {
                            Main.tile[k, l].type = 200;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }


                    }
                }
            }
        }
    }
}
