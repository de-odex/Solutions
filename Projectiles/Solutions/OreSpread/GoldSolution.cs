using Terraria.ID;

namespace SolutionsMod.Projectiles.Solutions.OreSpread
{
    public class GoldSolution: OreSpreadSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            oreID = TileID.Gold;
        }
    }
}
