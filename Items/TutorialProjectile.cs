using Terraria.ID;
using Terraria.ModLoader;

namespace BasicMod.Items
{
	public class TutorialProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Mod Projectile");
		}

		public override void SetDefaults()
		{
			//projectile.arrow = false;
			//projectile.width = 10;
			//projectile.height = 10;
			//projectile.aiStyle = 118;
			projectile.CloneDefaults(ProjectileID.LastPrism);
			//projectile.friendly = true;
			//projectile.ranged = true;
			aiType = ProjectileID.LastPrism;
		}

		// Additional hooks/methods here.
	}
}