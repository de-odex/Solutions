using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class MudRemovalSolution : BlockRemovalSolution
    {
        public static bool[] mudWalls = WallID.Sets.Factory.CreateBoolSet(new int[] { WallID.MudUnsafe});
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<DirtDust>();
            blockID = TileID.Mud;
            wallSet = mudWalls;
        }
    }
}
