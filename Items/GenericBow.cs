using System.Diagnostics;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class GenericBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bow of Terra");
			Tooltip.SetDefault("'The bow made of Earth's soil.'");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.noMelee = true;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 7.5f;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item5;
			item.useTime = 15;
			item.useAnimation = 25;
			item.autoReuse = true;
			item.scale = .5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 35);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}