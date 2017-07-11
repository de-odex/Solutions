using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.OreSpread
{
    public class DiamondSolution: OreSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            oreID = TileID.Diamond;
        }
    }
}
