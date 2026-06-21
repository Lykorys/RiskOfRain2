using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class FocusCrystal : AccessoriskCombat
    {
        public override string Texture => "Terraria/Images/Item_3828";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player){}
        public override void OnKillEffect(TempInv player,NPC npc){}
        
        public override void OnHitEffect(TempInv player,NPC npc)
        {
            if (player.FindDistance(npc) < 13)
            {
                
            }
        }
    }
}