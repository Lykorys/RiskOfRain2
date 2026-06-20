using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class ChronicExpansion : AccessoriskCombat
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void OnHitEffect(TempInv player,NPC npc)
        {
            if(innerStack>0)timeKeeper=420;
        }
        public override void OnKillEffect(TempInv player)
        {
            if(innerStack<5+5*stack)innerStack++;//5 is base value because stack starts at 1
            timeKeeper=420;
        }
        public override void ApplyEffect(TempInv player)
        {
            if(timeKeeper==0)innerStack=0;
            if (timeKeeper > 0)
            {
                timeKeeper--;
                player.Player.GetDamage(DamageClass.Generic)*= 1.035f+0.01f*stack;
            }
        }
    }
}