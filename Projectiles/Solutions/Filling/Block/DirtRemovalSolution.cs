using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class DirtRemovalSolution : BlockRemovalSolution
    {
        public static bool[] dirtWalls = WallID.Sets.Factory.CreateBoolSet(new int[] { WallID.Dirt, WallID.DirtUnsafe, WallID.DirtUnsafe2, WallID.DirtUnsafe3, WallID.DirtUnsafe4 });
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<DirtDust>();
            blockID = TileID.Dirt;
            wallSet = dirtWalls;
        }
    }
}
