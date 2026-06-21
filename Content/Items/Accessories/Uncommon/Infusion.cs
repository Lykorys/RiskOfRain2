using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Uncommon
{
    //Killing an enemy increases your health permanently by 1 (+1 per stack), up to a maximum of 100 (+100 per stack) health.
    public class Infusion: AccessoriskCombat
    {
        public override void SetDefaults()
        {
            innerStack=0;//use to represent the number of health gained 
        }
        public override void ApplyEffect(TempInv player){}
        public override void OnKillEffect(TempInv player, NPC npc){
            if(innerStack<stack*100)
            {
                player.Player.statLifeMax2+=stack;
                innerStack+=stack;
            }
        }
        public override void OnHitEffect(TempInv player, NPC npc){}
    }
}