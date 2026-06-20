using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class CautiousSlug : Accessorisk
    {
        public override void ApplyEffect(TempInv player)
        {
            if (!player.isInCombat) player.Player.lifeRegen+= 3*stack;
        }
    }
}