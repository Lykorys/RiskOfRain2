using RiskOfRain2.Content.Items.Accessories.Untiered;
using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class DelicateWatch : Accessorisk
    {
        public override void ApplyEffect(TempInv player)
        {
            if (player.Player.statLife < 0.25 * player.Player.statLifeMax2)
            {
                player.RemoveAccessorisk(this);
                player.AddAccessorisk(new DelicateWatchBroken());
            }
            else
            {
                player.Player.GetDamage(DamageClass.Generic) *= 1f+0.2f*stack;
            }
        }
    }
}