using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
namespace ItemAdditions.Items
{
	public class PickleSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sharpened Pickle");
			Tooltip.SetDefault("'Sharpened Pickle.'");
		}

		public override void SetDefaults()
		{
			item.damage = 135;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.scale = 2;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.CursedBullet;
			item.shootSpeed = 7f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 50);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}