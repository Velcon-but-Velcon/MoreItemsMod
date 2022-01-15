using System.Diagnostics;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class LazerBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lazer");
			Tooltip.SetDefault("'A bow made from space stones.'");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.noMelee = true;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 3f;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item5;
			item.useTime = 4;
			item.useAnimation = 25;
			item.autoReuse = true;
			item.scale = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}