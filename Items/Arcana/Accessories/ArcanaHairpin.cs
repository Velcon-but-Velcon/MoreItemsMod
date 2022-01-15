using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items.Arcana.Accessories
{
	public class ArcanaHairpin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arcana Hairpin");
			Tooltip.SetDefault("'Who're you, magic man?'\nLife Regen +10\nMana Regen +10");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = Item.sellPrice(gold: 50);
			item.rare = ItemRarityID.Red;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeRegen += 10;
			player.manaRegen += 10;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ArcanaBar", 4);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}