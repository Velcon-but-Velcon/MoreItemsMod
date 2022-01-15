using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items.Arcana.Weapons
{
	public class ArcanaSpellstaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcana Spellstaff");
			Tooltip.SetDefault("'It seems to have taken the form of a staff.'");
		}

		public override void SetDefaults()
		{
			item.damage = 65;
			item.magic = true;
			item.mana = 1;
			item.width = 32;
			item.height = 32;
			item.scale = 2;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.FallingStar;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ArcanaBar", 7);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}