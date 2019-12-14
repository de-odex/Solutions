using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class JungleSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Jungle Spray";
            maxTime = 134;
            dustType = mod.DustType("JungleDust");
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
                        else if (wall == 63)
                        {
                            Main.tile[k, l].wall = 64;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (WallID.Sets.Conversion.Stone[wall] && wall != WallID.Stone)
                        {
                            Main.tile[k, l].wall = WallID.Stone;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (WallID.Sets.Conversion.HardenedSand[wall] && wall != WallID.HardenedSand)
                        {
                            Main.tile[k, l].wall = WallID.HardenedSand;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (WallID.Sets.Conversion.Sandstone[wall] && wall != WallID.Sandstone)
                        {
                            Main.tile[k, l].wall = WallID.Sandstone;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }

                        if (type == 0 && Main.tile[k, l].active())
                        {
                            Main.tile[k, l].type = TileID.Mud;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }else if (TileID.Sets.Conversion.Sand[type] && type != TileID.Sand)
                        {
                            Main.tile[k, l].type = TileID.Sand;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }else if (TileID.Sets.Conversion.HardenedSand[type] && type != TileID.HardenedSand)
                        {
                            Main.tile[k, l].type = TileID.HardenedSand;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (TileID.Sets.Conversion.Sandstone[type] && type != TileID.Sandstone)
                        {
                            Main.tile[k, l].type = TileID.Sandstone;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (TileID.Sets.Grass[type] || type == TileID.MushroomGrass)
                        {
                            Main.tile[k, l].type = TileID.JungleGrass;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        else if (TileID.Sets.Stone[type] && type != TileID.Stone)
                        {
                            Main.tile[k, l].type = TileID.Stone;
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
