using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public abstract class BlockFillingSolution : BaseSolution
    {

        public ushort blockID = 1;
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Filling Solution";
            maxTime = 134;
            minDistance = 128;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        if(Main.tile[k, l] == null)
                        {
                            Main.tile[k, l] = new Tile();
                        }
                        if (!Main.tile[k, l].active())
                        {
                            Main.tile[k, l].type = blockID;
                            Main.tile[k, l].liquid = 0;
                            Main.tile[k, l].active(true);
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                    }
                }
            }
        }

    }
}
