using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class Casey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Castastrophe");
			Tooltip.SetDefault("'The one weapon that kills all.'");
		}

		public override void SetDefaults()
		{
			item.damage = 3021;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.scale = 2;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.rare = ItemRarityID.Red;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.LunarFlare;
			item.shootSpeed = 20f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Short", 1);
			recipe.AddIngredient(null, "StarShard", 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}