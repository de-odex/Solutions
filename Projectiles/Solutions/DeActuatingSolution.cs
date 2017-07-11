using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace SolutionsMod.Projectiles.Solutions
{
    public class DeActuatingSolution : BaseSolution
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
                        if (Main.tile[k,l].inActive()){ 
                                Wiring.ReActive(k,l);       
                        }
                    }
                }
            }
        }
    }

}

