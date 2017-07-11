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
    public class BaseGrassSpreadSolution : BaseSolution
    {
        public ushort grassID = TileID.Grass;
        public ushort dirtID = 0;
        public bool[] wallSet = DirtRemovalSolution.dirtWalls;
        public ushort wallID = WallID.GrassUnsafe;

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
                        if (wallSet != null && wallSet[wall])
                        {
                            Main.tile[k, l].wall = wallID;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        if (Main.tile[k, l].active() && type == dirtID)
                        {
                            bool onEdge = !(WorldGen.InWorld(k - 1, l, 1) && WorldGen.InWorld(k + 1, l, 1) && WorldGen.InWorld(k, l - 1, 1) && WorldGen.InWorld(k, l + 1, 1));
                            if (onEdge)
                            {
                                Main.tile[k, l].type = grassID;
                                WorldGen.SquareTileFrame(k, l, true);
                                NetMessage.SendTileSquare(-1, k, l, 1);
                            }else
                            {
                                bool surroundNull = Main.tile[k - 1, l] == null || Main.tile[k + 1, l] == null || Main.tile[k, l - 1] == null || Main.tile[k, l + 1] == null;
                                if (surroundNull)
                                {
                                    Main.tile[k, l].type = grassID;
                                    WorldGen.SquareTileFrame(k, l, true);
                                    NetMessage.SendTileSquare(-1, k, l, 1);
                                }
                                else
                                {
                                    bool surroundInActive = !(Main.tile[k - 1, l].active() && Main.tile[k + 1, l].active() && Main.tile[k, l - 1].active() && Main.tile[k, l + 1].active());
                                    if (surroundInActive)
                                    {
                                        Main.tile[k, l].type = grassID;
                                        WorldGen.SquareTileFrame(k, l, true);
                                        NetMessage.SendTileSquare(-1, k, l, 1);
                                    }else
                                    {
                                        bool surroundPlatforms = TileID.Sets.Platforms[Main.tile[k - 1, l].type] || TileID.Sets.Platforms[Main.tile[k + 1, l].type] || TileID.Sets.Platforms[Main.tile[k, l - 1].type] || TileID.Sets.Platforms[Main.tile[k, l + 1].type];
                                        if (surroundPlatforms)
                                        {
                                            Main.tile[k, l].type = grassID;
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
        }
    }
}
