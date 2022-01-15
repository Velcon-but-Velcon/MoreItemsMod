using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class StarShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Fragment");
			Tooltip.SetDefault("'A mysterious fragment of an object unknown.'");
		}

		public override void SetDefaults()
        {
			item.width = 20;
			item.height = 20;
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(gold: 5);
			item.maxStack = 999;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}