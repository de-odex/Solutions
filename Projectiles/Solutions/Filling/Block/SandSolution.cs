using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class SandSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType("HoneyDust");
            blockID = TileID.Sand;
        }
    }
}
