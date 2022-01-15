using System.Diagnostics;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class ObsidianBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obsidian Bow");
			Tooltip.SetDefault("'A great easy mode bow.'");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.ranged = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = 2;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 9f;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item5;
			item.useTime = 13;
			item.useAnimation = 25;
			item.autoReuse = true;
			item.scale = .7f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}