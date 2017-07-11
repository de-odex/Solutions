using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class GlassRemovalSolution : BlockRemovalSolution
    {
        public static bool[] glassWalls = WallID.Sets.Factory.CreateBoolSet(new int[] { WallID.Glass, WallID.BlueStainedGlass, WallID.GreenStainedGlass, WallID.PurpleStainedGlass, WallID.RedStainedGlass, WallID.RainbowStainedGlass, WallID.YellowStainedGlass});
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<IceRemoveDust>();
            blockID = TileID.Glass;
            wallSet = glassWalls;
        }
    }
}
