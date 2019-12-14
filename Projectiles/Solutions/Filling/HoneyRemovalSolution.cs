using System;
using Microsoft.Xna.Framework;
using SolutionsMod.Dusts.LightedDust;
using SolutionsMod.Projectiles.Solutions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public class HoneyRemovalSolution : BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Honey Spray";
            projectile.ignoreWater = true;
            dustType = mod.DustType("HoneyDust");
            maxTime = 64;
        }

		public override void Convert(int i, int j, int size = 4)
		{
			for (int k = i - size; k <= i + size; k++)
			{
				for (int l = j - size; l <= j + size; l++)
				{
					if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
					{
						int type = (int)Main.tile[k, l].type;
						if(Main.tile[k, l].liquid > 0 && Main.tile[k, l].honey()){
								Main.tile[k, l].liquid = 0;
								WorldGen.SquareTileFrame(k, l, true);
								NetMessage.SendTileSquare(-1, k, l, 1);
						}
					}
				}
			}
		}
	}
}
