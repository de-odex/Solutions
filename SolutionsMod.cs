using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;


namespace SolutionsMod
{
	public class SolutionsMod : Mod
	{
		public SolutionsMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true
			};
		}
		
		public override void AddRecipes()
		{
		/*
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(ItemID.Clentaminator,1);
			recipe.AddRecipe();*/
		}
		
	}
}