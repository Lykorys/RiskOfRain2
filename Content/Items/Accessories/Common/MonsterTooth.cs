using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Killing an enemy spawns a healing orb that heals for 8 plus an additional 2% (+2% per stack) of maximum health.
    public class MonsterTooth : AccessoriskCombat
    {   
        public override string Texture => "Terraria/Images/Item_69";
        public override void ApplyEffect(TempInv player){}
        public override void OnKillEffect(TempInv player,NPC npc)
        {
            int itemIndex = Item.NewItem(
                npc.GetSource_Loot(), 
                npc.position, 
                npc.width, 
                npc.height, 
                ModContent.ItemType<MonsterToothOrb>()
            );
            if (Main.item[itemIndex].ModItem is MonsterToothOrb orb)
            {
                orb.stack = stack; 
            }
        }
        public override void OnHitEffect(TempInv player, NPC npc){}
    }
	public class MonsterToothOrb(int stacks) : ModItem
	{
		public int healAmount = 8;
        public int stack = stacks;
		public override LocalizedText Tooltip => LocalizedText.Empty;
        public override string Texture => "Terraria/Images/Item_184";

		public override void SetStaticDefaults() {
			ItemID.Sets.ItemsThatShouldNotBeInInventory[Type] = true;
			ItemID.Sets.IgnoresEncumberingStone[Type] = true;
			ItemID.Sets.IsAPickup[Type] = true;
		}

        public override bool OnPickup(Player player) {
			player.Heal(healAmount + (int)(player.statLifeMax2 * (0.02f * stack)));
			return false;
		}
    }

}