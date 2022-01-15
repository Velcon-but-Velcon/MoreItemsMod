using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class TrueBeeScythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hornet Scythe");
			Tooltip.SetDefault("'A pretty viable weapon.'");
		}

		public override void SetDefaults()
		{
			item.damage = 128;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.scale = 1;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.InfluxWaver;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScytheBee", 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(null, "StyxRing", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}