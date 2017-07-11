using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class RedSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Red Spray";
            maxTime = 134;
            dustType = 114;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            WorldGen.Convert(i, j, 4, size);
        }
    }
}
