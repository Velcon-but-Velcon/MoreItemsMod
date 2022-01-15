using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemAdditions.Items.Arcana.Tools
{

    public class ArcanaPickaxe : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arcana Pix");
            Tooltip.SetDefault("'It seems to have taken the form of a pickaxe'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.scale = 2;
            item.value = Item.sellPrice(gold: 5, silver: 50);
            item.rare = ItemRarityID.Blue;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.autoReuse = true;
            item.pick = 130;
            item.axe = 15;
            item.melee = true;
            item.damage = 5;
            item.knockBack = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ArcanaBar", 15);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}