using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class NightShort : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night's Shiv");
			Tooltip.SetDefault("'Never underestimate the shortswords.'");
		}

		public override void SetDefaults()
		{
			item.damage = 56;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.scale = 2;
			item.useTime = 5;
			item.useAnimation = 55;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.VenomBullet;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa, 1);
			recipe.AddIngredient(null, "JungleShort", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}