using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.OreSpread
{
    public class JungleBrickSolution : OreSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            oreID = TileID.LihzahrdBrick;
            replacingTiles = TileID.Sets.Mud;
        }
    }
}
