using Terraria.ID;
using Terraria.ModLoader;

namespace BasicMod.Items
{
	public class BasicProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("English Display Basic Projectile");
		}

		public override void SetDefaults()
		{
			//projectile.arrow = false;
			//projectile.width = 10;
			//projectile.height = 10;
			//projectile.aiStyle = 118;
			projectile.CloneDefaults(ProjectileID.AmethystBolt);
			//projectile.friendly = true;
			//projectile.ranged = true;
			aiType = ProjectileID.AmethystBolt;
		}

		// Additional hooks/methods here.
	}
}