using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using RiskOfRain2.Content.NPCs.Bosses;

namespace RiskOfRain2.Content.Items.Consumables
{
	public class MithrixSummonItem : ModItem
	{
        public override string Texture =>  "Terraria/Images/Item_" + ItemID.Acorn;
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 3;
			ItemID.Sets.SortingPriorityBossSpawns[Type] = 12;
		}

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 20;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 30;
			Item.useTime = 30;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = false;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup) {
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.BossSpawners;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips) {
            tooltips.Add(new TooltipLine(Mod,"test","There seems to be a risk of rain")
            {
                OverrideColor = new Color(90, 223, 230)
            });
		}
		public override bool? UseItem(Player player) {
			if (player.whoAmI == Main.myPlayer) {
				SoundEngine.PlaySound(SoundID.Roar, player.position);

				int type = ModContent.NPCType<Mithrix>();

				if (Main.netMode != NetmodeID.MultiplayerClient) {
					NPC.NewNPC(NPC.GetSource_NaturalSpawn(), (int)player.Center.X-600, (int)player.Center.Y -150, type);
				}
				else {
					NetMessage.SendData(MessageID.SpawnBossUseLicenseStartEvent, number: player.whoAmI, number2: type);
				}
			}
			return true;
		}
	}
}
