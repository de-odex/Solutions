using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.OreSpread
{
    public class ChlorophyteSolution : OreSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            oreID = TileID.Chlorophyte;
            replacingTiles = TileID.Sets.Mud;
        }
    }
}
