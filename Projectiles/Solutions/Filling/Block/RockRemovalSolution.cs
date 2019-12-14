using SolutionsMod.Dusts.LightedDust;
using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.Filling.Block
{
    public class RockRemovalSolution : BlockRemovalSolution
    {
        public static bool[] stoneBlocks = TileID.Sets.Conversion.Stone;

        public static bool[] stoneWalls = WallID.Sets.Factory.CreateBoolSet(new int[] {
            WallID.Stone,
            WallID.CaveUnsafe,
           WallID.Cave2Unsafe,
           WallID.Cave3Unsafe,
           WallID.Cave4Unsafe,
           WallID.Cave5Unsafe,
           WallID.Cave6Unsafe,
           WallID.Cave7Unsafe,
           WallID.Cave8Unsafe,
           WallID.CaveWall,
           WallID.CaveWall2
                    });
        public override void SetDefaults()
        {
            base.SetDefaults();
            dustType = mod.DustType("HoneyDust");
            blockSet = stoneBlocks;
            wallSet = stoneWalls;
        }
    }
}
