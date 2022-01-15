using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class Hallows : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallows Greatstaff");
			Tooltip.SetDefault("'The staff of the king, long ago.'");
		}

		public override void SetDefaults()
		{
			item.damage = 199;
			item.summon = true;
			item.width = 20;
			item.height = 20;
			item.scale = 2;
			item.useTime = 7;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.FlamingJack;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 25);
			recipe.AddIngredient(ItemID.SoulofFright, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}