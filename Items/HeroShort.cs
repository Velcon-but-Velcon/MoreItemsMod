using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class HeroShort : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hero's Shortsword");
			Tooltip.SetDefault("'Never underestimate the shortswords.'");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.scale = 2;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = 10000;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = ProjectileID.MagicMissile;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(null, "GenericShortsword");
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}