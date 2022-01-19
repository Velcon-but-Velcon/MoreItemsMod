using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items.Dragonscale
{
	public class Dragonscale : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragon Scale");
			Tooltip.SetDefault("'The scale of a dragon, created long ago.'");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(gold: 25);
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellstone, 15);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
