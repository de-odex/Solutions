using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.GrassSpread
{
    public class MushroomGrassSpreadSolution : BaseGrassSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = 113;
            dirtID = TileID.Mud;
            grassID = TileID.MushroomGrass;
            wallSet = null;
        }
    }
}
