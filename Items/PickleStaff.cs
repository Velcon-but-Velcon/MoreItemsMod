using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class PickleStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pickle Staff");
			Tooltip.SetDefault("'Why is this a thing.'");
		}

		public override void SetDefaults()
		{
			item.magic = true;
			item.damage = 78;
			item.mana = 3;
			item.noMelee = true;
			item.useTime = 3;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item43;
			item.scale = 2;

			item.shoot = ProjectileID.ChlorophyteBullet;
			item.shootSpeed = 10f;
			item.autoReuse = true;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}