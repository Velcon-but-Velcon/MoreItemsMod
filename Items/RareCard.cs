using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
namespace ItemAdditions.Items
{
	public class RareCard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fusion Card?");
			Tooltip.SetDefault("'A quite rare card!'");
		}

		public override void SetDefaults()
		{
			item.damage = 142;
			item.magic = true;
			item.noMelee = true;
			item.mana = 1;
			item.width = 20;
			item.height = 20;
			item.scale = 1;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 4;
			item.value = 10000;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.Typhoon;
			item.shootSpeed = 25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SkyCard");
			recipe.AddIngredient(null, "EarthCard");
			recipe.AddIngredient(null, "FireCard");
			recipe.AddIngredient(null, "DemonCard");
			recipe.AddIngredient(null, "WaterCard");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}