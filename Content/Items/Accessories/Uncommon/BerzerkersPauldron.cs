using Humanizer;
using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Uncommon
{
    public class BerzerkersPauldron : AccessoriskCombat
    {
        //Killing 4 enemies within 1 second sends you into a frenzy for 6s (+4s per stack). Increases movement speed by 50% and attack speed by 100%.
        public bool isInFrenzy=false;
        public override string Texture => "Terraria/Images/Item_235";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            if (isInFrenzy)
            {
                player.Player.moveSpeed*=1.50f;
                player.Player.GetAttackSpeed(DamageClass.Generic)*=2f;
                timeKeeper--;
                if(timeKeeper==0) isInFrenzy=false;
            }
            else
            {
                if (innerStack >= 4)
                {
                    innerStack=0;
                    isInFrenzy=true;
                    timeKeeper=120+4*60*stack;
                }
                else
                {
                    if(timeKeeper>0)timeKeeper--;
                    if(timeKeeper==0)innerStack=0;
                }
            }
        }
        public override void OnKillEffect(TempInv player, NPC npc)
        {   
            if(timeKeeper==0)timeKeeper=60;
            innerStack++;
        }
        public override void OnHitEffect(TempInv player, NPC npc){}
    }
}
