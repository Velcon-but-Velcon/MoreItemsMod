using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class StyxRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ring of the River Styx");
			Tooltip.SetDefault("'A ring found inside the River Styx.'\nMultiplies melee damage by %150");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = Item.sellPrice(silver: 90);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamageMult += .5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}