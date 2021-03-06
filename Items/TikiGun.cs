using System.Diagnostics;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class TikiGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tiki Gun");
			Tooltip.SetDefault("'A post Plantera gun, probably viable.'");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.noMelee = true;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = 2;
			item.useAmmo = AmmoID.StyngerBolt;
			item.shootSpeed = 9f;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item11;
			item.useTime = 5;
			item.useAnimation = 10;
			item.autoReuse = true;
			item.scale = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PygmyStaff, 1);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}