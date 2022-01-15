using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ItemAdditions.Items
{
	public class HadesCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hades' Crown");
			Tooltip.SetDefault("'You're actually doing well.'\nMultiplies ALL damage by %170 and melee by %190");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.lifeRegen = 7;
			item.defense = 45;
			item.value = Item.sellPrice(platinum: 3);
			item.rare = ItemRarityID.Red;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += .7f;
			player.meleeDamageMult += .9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "StyxRing", 1);
			recipe.AddIngredient(null, "WarriorCrown", 1);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}