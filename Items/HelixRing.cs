using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class HelixRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Helix Ring");
			Tooltip.SetDefault("'The ring of a god. (Wait how did you get this?)'\nLife Regen +10\nDefense +8");
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
			player.statDefense += 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GuideVoodooDoll, 1);
			recipe.AddIngredient(ItemID.SoulofFlight, 25);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}