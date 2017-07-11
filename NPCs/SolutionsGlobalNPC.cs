using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SolutionsMod.NPCs
{
    public class SolutionsGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (Main.rand.Next(5000) == 0)
                {
                    Item.NewItem(npc.Center, Vector2.Zero, mod.ItemType("InfiniteLuminiteSoluion"));
                } else if (Main.rand.Next(5) == 0)
                {
                    Item.NewItem(npc.Center, Vector2.Zero, mod.ItemType("LuminiteSoluion"));
                }
            }
        }

    }
}
