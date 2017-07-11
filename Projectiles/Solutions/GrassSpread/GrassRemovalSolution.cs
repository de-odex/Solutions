using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsMod.Projectiles.Solutions.Filling.Block;
using Terraria;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.GrassSpread
{
    public class GrassRemovalSolution : BaseSolution
    {
        
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Grass Spray";
            maxTime = 134;
            dustType = 110;
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
                        if (wall == WallID.Jungle || wall == WallID.JungleUnsafe || wall == WallID.JungleUnsafe1 || wall == WallID.JungleUnsafe2 || wall == WallID.JungleUnsafe3 ||
                            wall == WallID.JungleUnsafe4)
                        {
                            Main.tile[k, l].wall = WallID.MudUnsafe;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (wall == WallID.GrassUnsafe || wall == WallID.CorruptGrassUnsafe || wall == WallID.CrimsonGrassUnsafe || wall == WallID.HallowedGrassUnsafe)
                        {
                            Main.tile[k, l].wall = WallID.DirtUnsafe;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (wall == WallID.Grass)
                        {
                            Main.tile[k, l].wall = WallID.Dirt;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (Main.tile[k, l].active())
                        {
                            if (Main.tile[k, l].type == 60 || Main.tile[k, l].type == 70)
                            {
                                Main.tile[k, l].type = TileID.Mud;
                                WorldGen.SquareTileFrame(k, l, true);
                                NetMessage.SendTileSquare(-1, k, l, 1);
                            }
                            else if (TileID.Sets.Conversion.Grass[type])
                            {
                                Main.tile[k, l].type = TileID.Dirt;
                                WorldGen.SquareTileFrame(k, l, true);
                                NetMessage.SendTileSquare(-1, k, l, 1);
                            }
                        }
                    }
                }
            }
        }
    }
}
