using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class WarriorCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Warrior's Crown");
			Tooltip.SetDefault("'Hmm, I guess you killed something.'\nMultiplies melee damage by %170");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = Item.sellPrice(gold: 50);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamageMult += .7f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DestroyerEmblem, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}