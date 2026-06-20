using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Increase your attack speed by 10% (+3.5% per stack) for up to 3 (+1 per stack) enemies and allies within 20 meters.
    public class BolsteringLantern : Accessorisk
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            if (player.GetTotalEntitiesInRadius(20) > 2 + stack)
            {
                player.Player.GetAttackSpeed(DamageClass.Generic)*=1f+0.10f+0.35f*stack;
            }
        }
    }
}