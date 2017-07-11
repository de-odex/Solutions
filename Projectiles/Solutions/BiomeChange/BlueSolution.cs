using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class BlueSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Blue Spray";
            maxTime = 134;
            dustType = 111;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            WorldGen.Convert(i, j, 2, size);
        }
    }
}
