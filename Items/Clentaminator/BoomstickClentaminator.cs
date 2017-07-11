using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework; 

namespace SolutionsMod.Items.Clentaminator
{
	public class BoomstickClentaminator : ModItem
	{

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Boomstick Clentaminator");
        }

        public override void SetDefaults()
		{
			item.CloneDefaults(779);
			item.value = Item.buyPrice(5, 0, 0, 0);
			item.autoReuse = false;
			item.useTime = 12;
			item.useAnimation = 12;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack){
			
			double angle = Math.Atan2(speedY,speedX);
			double speed = Math.Sqrt(speedY*speedY + speedX*speedX);
			
			double spread = 20*(Math.PI/180);
			Projectile.NewProjectile(position.X, position.Y, (float)(speed*(Math.Cos(angle-spread))), (float)(speed*(Math.Sin(angle-spread))), /*item.shoot*/ type, damage, knockBack, player.whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, (float)(speed*(Math.Cos(angle+spread))), (float)(speed*(Math.Sin(angle+spread))), /*item.shoot*/ type, damage, knockBack, player.whoAmI, 0f, 0f);
			return true;
		}
	}
}
