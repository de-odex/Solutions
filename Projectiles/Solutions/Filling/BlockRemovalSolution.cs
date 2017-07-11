using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public abstract class BlockRemovalSolution : BaseSolution
    {

        public int blockID = -1;
        public bool[] blockSet = null;
        public bool[] wallSet = null;
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Removal Spray";
            maxTime = 133;
            //minDistance = 128;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        int type = Main.tile[k, l].type;
                        int wall = Main.tile[k, l].wall;
                        if (wallSet != null && wallSet[wall])
                        {
                            Main.tile[k, l].wall = 0;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        if ((blockSet != null && blockSet[type])|| (blockID >= 0 && type == blockID))
                        {
                            if (!hasChest(k, l))
                            {
                                Main.tile[k, l].active(false);
                                WorldGen.SquareTileFrame(k, l, true);
                                NetMessage.SendTileSquare(-1, k, l, 1);
                            }
                        }
                    }
                }
            }
        }


        public static bool hasChest(int x, int y)
        {
            int chest = Chest.FindChest(x, y);
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y - 1);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x, y - 1);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y - 2);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x, y - 2);
            }
            return chest != -1;
        }

    }
}
