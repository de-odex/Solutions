using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class DirtSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<DirtDust>();
            blockID = TileID.Dirt;
        }
    }
}
