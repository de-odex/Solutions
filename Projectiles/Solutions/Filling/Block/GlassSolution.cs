using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class GlassSolution : BlockFillingSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType("IceSpreadDust");
            blockID = TileID.Glass;
        }
    }
}
