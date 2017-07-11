using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.GrassSpread
{
    public class CrimsonGrassSpreadSolution : BaseGrassSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = 114;
            grassID = TileID.FleshGrass;
            wallID = WallID.CrimsonGrassUnsafe;
        }
    }
}
