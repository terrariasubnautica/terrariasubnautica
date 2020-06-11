using Terraria;
using Terraria.ModLoader;

namespace SubnauticMod {
	public class SubnauticModPlayer : ModPlayer {
		public bool OxygenTank = false;
		public bool OxygenTank2 = false;
		public bool OxygenTank3 = false;
		public bool OxygenTank4 = false;
		public bool Fins = false;

		public override void ResetEffects() {
			OxygenTank = false;
			OxygenTank2 = false;
			OxygenTank3 = false;
			OxygenTank4 = false;
			Fins = false;
		}

		public override void PostUpdateRunSpeeds() {
			if(player.HeldItem.type == ModContent.ItemType<Content.Items.SeaGlide>()) {
				if(player.wet) {
					player.runAcceleration *= 3;
					player.maxRunSpeed *= 3;
				}
			}
		}
	}
}