using System.Diagnostics;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class PickleGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A literal Pickle Gun");
			Tooltip.SetDefault("'Too much pickles'");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = 1;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 20f;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item11;
			item.useTime = 1;
			item.useAnimation = 10;
			item.autoReuse = true;
			item.scale = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CursedFlame, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}