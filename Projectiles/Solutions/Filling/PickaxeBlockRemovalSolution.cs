using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionsMod.Dusts.LightedDust;
using Terraria;
using Terraria.ModLoader;

namespace SolutionsMod.Projectiles.Solutions.Filling
{
    public class PickaxeBlockRemovalSolution : BaseSolution
    {

        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Removal Spray";
            maxTime = 133;
            //minDistance = 128;
            dustType = mod.DustType<RockDust>();
        }

        public override void Convert(int i, int j, int size = 4)
        {
            if (projectile.owner < 0 || projectile.owner > 254 || !Main.player[projectile.owner].active)
                return;
            int pickP = getPickaxePower(Main.player[projectile.owner]);
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        int type = Main.tile[k, l].type;
                        int wall = Main.tile[k, l].wall;
                        if (wall != 0)
                        {
                            Main.tile[k, l].wall = 0;
                            WorldGen.SquareWallFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                        if (canMineTile(k, l, pickP) && !hasChest(k, l)) { 
                                Main.tile[k, l].active(false);
                                WorldGen.SquareTileFrame(k, l, true);
                                NetMessage.SendTileSquare(-1, k, l, 1);
                        }
                    }
                }
            }
        }

        public static int getPickaxePower(Player p)
        {
            int ans = 0;
            for (int i = 0; i < 50; i++)
            {
                if (p.inventory[i].pick > ans)
                {
                    ans = p.inventory[i].pick;
                }
            }
            return ans;
        }

        public static bool canMineTile(int x, int y, int pickPower)
        {
            int dmg = 0;
            Tile tile = Main.tile[x, y];
            TileLoader.PickPowerCheck(tile, pickPower, ref dmg);
            if (dmg > 0) return true;
            if (Main.tileNoFail[(int)tile.type]) return true;
            if (tile.type == 211 && pickPower < 200) return false;
            if (tile.type == 37 && pickPower < 50) return false;
            if ((tile.type == 22 || tile.type == 204) && (double)y > Main.worldSurface && pickPower < 55) return false;
            if ((tile.type == 25 || tile.type == 56 || tile.type == 58 || tile.type == 203 ||
                tile.type == 117 || tile.type == 404 || Main.tileDungeon[(int)tile.type]) && pickPower < 65) return false;
            if ((tile.type == 107 || tile.type == 221) && pickPower < 100) return false;
            if ((tile.type == 108 || tile.type == 222) && pickPower < 110) return false;
            if ((tile.type == 111 || tile.type == 223) && pickPower < 150) return false;
            if ((tile.type == 226 || tile.type == 237) && pickPower < 210) return false;

            return true;
        }


    public static bool hasChest(int x, int y)
        {
            int chest = Chest.FindChest(x, y);
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y - 1);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x, y - 1);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x - 1, y - 2);
            }
            if (chest == -1)
            {
                chest = Chest.FindChest(x, y - 2);
            }
            return chest != -1;
        }

    }
}
