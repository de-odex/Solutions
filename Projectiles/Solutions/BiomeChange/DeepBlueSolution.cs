using Terraria;

namespace SolutionsMod.Projectiles.Solutions.BiomeChange
{
    public class DeepBlueSolution: BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Deep Blue Spray";
            maxTime = 134;
            dustType = 113;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            WorldGen.Convert(i, j, 3, size);
        }
    }
}
