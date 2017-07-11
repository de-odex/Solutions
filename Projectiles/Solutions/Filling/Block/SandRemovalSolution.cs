using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class SandRemovalSolution : BlockRemovalSolution
    {
        public static bool[] sandBlocks = TileID.Sets.Factory.CreateBoolSet(new int[] {
                    53,
                    112,
                    116,
                    234,
                    397,
                    398,
                    402,
                    399,
                    396,
                    400,
                    403,
                    401
        });

        public static bool[] sandWalls = WallID.Sets.Factory.CreateBoolSet(new int[] {
                    187,
                    220,
                    222,
                    221,
                    216,
                    217,
                    219,
                    218});
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType<HoneyDust>();
            blockSet = sandBlocks;
            wallSet = sandWalls;
        }
    }
}
