using System;
using SolutionsMod.Dusts.LightedDust;
using Terraria;
using Terraria.ID;


namespace SolutionsMod.Projectiles.Solutions
{
    public class MineralSolution : BaseSolution
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
           // projectile.name = "Mineral Spray";
            dustType = mod.DustType<MineralDust>();
        }

        public override void Convert(int i, int j, int size = 4)
        {
            for (int k = i - size; k <= i + size; k++)
            {
                for (int l = j - size; l <= j + size; l++)
                {
                    if (WorldGen.InWorld(k, l, 1) && Math.Abs(k - i) + Math.Abs(l - j) < Math.Sqrt(size * size + size * size))
                    {
                        if (Main.tile[k, l] == null)
                        {
                            Main.tile[k, l] = new Tile();
                        }
                        int type = (int)Main.tile[k, l].type;
                        if (type == 1 || type == 25 || type == 117 || type == 203)
                        {
                            int chance = Main.rand.Next(100);
                            if (chance < 20)
                            {
                                chance = Main.rand.Next(100);
                                if (chance < 50)
                                {
                                    if (Main.rand.Next(2) == 0)
                                    {
                                        Main.tile[k, l].type = 66;
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = 67;
                                    }
                                }
                                else if (chance < 90)
                                {
                                    switch (Main.rand.Next(3))
                                    {
                                        case 0:
                                            Main.tile[k, l].type = 63;
                                            break;
                                        case 1:
                                            Main.tile[k, l].type = 64;
                                            break;
                                        default:
                                            Main.tile[k, l].type = 65;
                                            break;
                                    }
                                }
                                else
                                {
                                    Main.tile[k, l].type = 68;
                                }
                            }
                            else if (chance >= 70 && Main.hardMode && WorldGen.oreTier1 != -1)
                            {
                                chance = Main.rand.Next(100);
                                if (chance >= 85 && WorldGen.oreTier3 != -1)
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.oreTier3 == 111) ? 223 : 111);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = (ushort)WorldGen.oreTier3;
                                    }
                                }
                                else if (chance < 35 && WorldGen.oreTier2 != -1)
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.oreTier2 == 108) ? 222 : 108);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = (ushort)WorldGen.oreTier2;
                                    }
                                }
                                else
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.oreTier1 == 107) ? 221 : 107);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = (ushort)WorldGen.oreTier1;
                                    }
                                }
                            }
                            else
                            {
                                chance = Main.rand.Next(100);
                                if (chance >= 85)
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.GoldTierOre == 8) ? 169 : 8);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = WorldGen.GoldTierOre;
                                    }
                                }
                                else if (chance >= 65)
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.SilverTierOre == 9) ? 168 : 9);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = WorldGen.SilverTierOre;
                                    }
                                }
                                else if (chance >= 40)
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.IronTierOre == 6) ? 167 : 6);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = WorldGen.IronTierOre;
                                    }
                                }
                                else
                                {
                                    if (Main.rand.Next(5) == 0)
                                    {
                                        Main.tile[k, l].type = (ushort)((WorldGen.CopperTierOre == 7) ? 166 : 7);
                                    }
                                    else
                                    {
                                        Main.tile[k, l].type = WorldGen.CopperTierOre;
                                    }
                                }
                            }
                            WorldGen.SquareTileFrame(k, l, true);
                            NetMessage.SendTileSquare(-1, k, l, 1);
                        }



                    }
                }
            }
        }
    }
}
