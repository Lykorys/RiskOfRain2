using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //2 seconds after getting hurt, heal for 20 plus an additional 5% (+5% per stack) of maximum health.
    public class MedKit : AccessoriskCombat
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void OnHitEffect(TempInv player,NPC npc)
        {
            timeKeeper=120;
        }
        public override void OnKillEffect(TempInv player){}
        public override void ApplyEffect(TempInv player)
        {
            if (timeKeeper == 0)
            {
                player.Player.statLife+= (int)(20 +0.05f*player.Player.statLifeMax2*stack);
                timeKeeper=-1;
            }
            

            if (timeKeeper > 0)timeKeeper--;
        }
    }
}