using System;
using Microsoft.Xna.Framework;
using SolutionsMod.Dusts.LightedDust;
using SolutionsMod.Projectiles.Solutions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public class LavaSolution : BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Lava Spray";
            projectile.ignoreWater = true;
            dustType = mod.DustType<LavaDust>();
            maxTime = 64;
            minDistance = 128;
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
						
						if(Main.tile[k, l].liquid > 0){
							if(Main.tile[k, l].lava()){
								Main.tile[k, l].liquid = 255;
								WorldGen.SquareTileFrame(k, l, true);
								NetMessage.SendTileSquare(-1, k, l, 1);
							}
							else if (Main.tile[k, l].liquidType() == 0){
								Main.tile[k, l].lava(false);
								Main.tile[k, l].liquid = 0;
								Main.tile[k, l].type = 56;
								Main.tile[k, l].active(true);
								WorldGen.SquareTileFrame(k, l, true);
								NetMessage.SendTileSquare(-1, k, l, 1);
							}
							else if (Main.tile[k, l].honey()){
								Main.tile[k, l].honey(false);
								Main.tile[k, l].liquid = 0;
								Main.tile[k, l].type = 230;
								Main.tile[k, l].active(true);
								WorldGen.SquareTileFrame(k, l, true);
								NetMessage.SendTileSquare(-1, k, l, 1);
							}
							else{}
						}else{
							if(!Main.tile[k, l].active()){
								Main.tile[k, l].liquidType(1);
								Main.tile[k, l].liquid = 255;
								WorldGen.SquareTileFrame(k, l, true);
								NetMessage.SendTileSquare(-1, k, l, 1);
							}
						}					
						
					}
				}
			}
		}
	}
}
