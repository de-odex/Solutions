using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace SolutionsMod.Projectiles.Solutions
{
    public class ActuatingSolution : BaseSolution
    { 

        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Removal Spray";
            maxTime = 133;
            //minDistance = 128;
            dustType = 114;
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        if (canActuate(k,l)){ 
                                Wiring.DeActive(k,l);       
                        }
                    }
                }
            }
        }

        public static bool canPlaceActuator(int tile)
        {
            if (tile == 323 || tile == 5 || tile == 314 || (tile > 385 && tile < 390))
                return false;
           return Main.tileSolid[tile] && !TileID.Sets.NotReallySolid[tile];       
        }

        public static bool canActuate(int x, int y)
        {
            if (!WorldGen.InWorld(x, y, 1) || !canPlaceActuator(Main.tile[x, y].type)) return false;
            if (!WorldGen.InWorld(x, y - 1, 1) || !Main.tile[x, y - 1].active()) return true;
            int topType = Main.tile[x, y - 1].type;
            if (topType == TileID.Trees || topType == TileID.PalmTree || topType == TileID.MushroomTrees ||
                TileID.Sets.BasicChest[topType] || topType == TileID.Dressers || topType == TileID.DemonAltar || topType == TileID.Hellforge)
                return false;
            ModTile tt = TileLoader.GetTile(topType);
            if (tt != null && (tt.adjTiles.Contains(TileID.Dressers) || tt.adjTiles.Contains(TileID.Containers) || tt.adjTiles.Contains(TileID.Containers2)))
                return false;
            return true;
        }

    }

}
