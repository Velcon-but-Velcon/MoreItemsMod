using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class SkyCard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aether's Card?");
			Tooltip.SetDefault("'Is this supposed to be here?'");
		}

		public override void SetDefaults()
		{
			item.damage = 81;
			item.magic = true;
			item.mana = 0;
			item.width = 20;
			item.height = 20;
			item.scale = 1;
			item.useTime = 4;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.HallowStar;
			item.shootSpeed = 50f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}