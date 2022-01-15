using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class WaterCard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tsunami Card?");
			Tooltip.SetDefault("'Is this supposed to be here?'");
		}

		public override void SetDefaults()
		{
			item.damage = 72;
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
			item.shoot = ProjectileID.WaterBolt;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AquaScepter, 1);
			recipe.AddIngredient(ItemID.WaterBolt, 25);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}