using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class GreenSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Green Spray";
            maxTime = 134;
            dustType = 110;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            WorldGen.Convert(i, j, 0, size);
        }
    }
}
