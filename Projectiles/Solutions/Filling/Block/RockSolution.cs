using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class RockSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<RockDust>();
            blockID = TileID.Stone;
        }
    }
}
