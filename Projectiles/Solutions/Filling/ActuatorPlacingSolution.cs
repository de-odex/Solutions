using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public class ActuatorPlacingSolution : BaseSolution
    {

        public override void SetDefaults()
        {
            base.SetDefaults();
            // projectile.name = "Removal Spray";
            maxTime = 133;
            //minDistance = 128;
            dustType = 114;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        if (Main.tile[k, l].wire() || Main.tile[k, l].wire2() || Main.tile[k, l].wire3() || Main.tile[k, l].wire4())
                        {
                            if (Main.tile[k, l].active() && ActuatingSolution.canPlaceActuator(Main.tile[k, l].type))
                            {
                                Main.tile[k, l].actuator(true);
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
