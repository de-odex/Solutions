using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.GrassSpread
{
    public class CorruptGrassSpreadSolution : BaseGrassSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = 112;
            grassID = TileID.CorruptGrass;
            wallID = WallID.CorruptGrassUnsafe;
        }
    }
}
