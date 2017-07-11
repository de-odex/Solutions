using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class JungleSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Jungle Spray";
            maxTime = 134;
            dustType = mod.DustType<JungleDust>();
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
                        if(wall == 2)
                        {
                            Main.tile[k, l].wall = 15;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (wall == 63)
                        {
                            Main.tile[k, l].wall = 64;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 0 && Main.tile[k, l].active())
                        {
                            Main.tile[k, l].type = 59;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        else if (type == 2)
                        {
                            Main.tile[k, l].type = 60;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 3)
                        {
                            Main.tile[k, l].type = 61;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 52)
                        {
                            Main.tile[k, l].type = 62;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 73)
                        {
                            Main.tile[k, l].type = 74;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }



                    }
                }
            }
        }
    }
}
