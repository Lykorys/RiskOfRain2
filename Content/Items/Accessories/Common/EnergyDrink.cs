using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Sprint speed is improved by 25% (+25% per stack).
    //Modified to Maximum speed is increased by 10% (+10% per stack)
    public class EnergyDrink : Accessorisk
    {
        public override void ApplyEffect(TempInv inv)
        {
            Player player = inv.Player;
            float modifier = 1f + (0.10f * stack);
            player.maxRunSpeed *= modifier;
        }
    }
}