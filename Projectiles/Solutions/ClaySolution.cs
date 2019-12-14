using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;
using Terraria.ID;


namespace SolutionsMod.Projectiles.Solutions
{
    public class ClaySolution : BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            //projectile.name = "Clay Spray";
            dustType = mod.DustType("ClayDust");
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
                        if (Main.tile[k, l].active() && (TileID.Sets.Conversion.Grass[type] ||type == TileID.Dirt)){

                            Main.tile[k, l].type = TileID.ClayBlock;
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                    }
                }
            }
        }
    }
}
