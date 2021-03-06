using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
namespace ItemAdditions.Items
{
	public class GenericWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Wand");
			Tooltip.SetDefault("'A great easy mode wand.'");
		}

		public override void SetDefaults()
		{
			item.magic = true;
			item.damage = 24;
			item.mana = 5;
			item.noMelee = true;
			item.useTime = 15;
			item.useAnimation = 34;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item43;
			item.scale = 1;

			item.shoot = ProjectileID.EnchantedBeam;
			item.shootSpeed = 10f;
			item.autoReuse = true;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddIngredient(ItemID.ManaCrystal, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}