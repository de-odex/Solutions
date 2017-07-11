using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class PurpleSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Purple Spray";
            maxTime = 134;
            dustType = 112;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            WorldGen.Convert(i, j, 1, size);
        }
    }
}
