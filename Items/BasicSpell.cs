using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace BasicMod.Items
{
	public class BasicSpell : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("BasicSpell"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A spell that is, in fact, basic");
		}

		public override void SetDefaults()
		{
			item.damage = 120;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 2;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BasicProjectile");
			item.shootSpeed = 8f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			position = new Vector2(Main.mouseX, Main.mouseY) + Main.screenPosition;
			Vector2 heading =  player.Center- position;
			heading.Normalize();
			speedX = heading.X;
			speedY = heading.Y;
			return true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}