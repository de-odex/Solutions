using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class IceRemoveSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Ice Spray";
            maxTime = 134;
            dustType = mod.DustType("IceRemoveDust");
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

                        if (wall == 40)
                        {
                            Main.tile[k, l].wall = 2;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 147)
                        {
                            if ((WorldGen.InWorld(k, l - 1, 1) && (int)Main.tile[k, l - 1].type == 5) ||
                                (WorldGen.InWorld(k, l + 1, 1) && (int)Main.tile[k, l + 1].type == 5))
                            {
                                Main.tile[k, l].type = 2;
                            }
                            else
                            {
                                Main.tile[k, l].type = 0;
                            }
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        else if (type == 161)
                        {
                            Main.tile[k, l].type = 1;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 163)
                        {
                            Main.tile[k, l].type = 25;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (type == 164)
                        {
                            Main.tile[k, l].type = 117;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        else if (type == 200)
                        {
                            Main.tile[k, l].type = 203;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }


                    }
                }
            }
        }
    }
}
