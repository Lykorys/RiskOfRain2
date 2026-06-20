using RiskOfRain2.Content.Systems;
using Terraria;

namespace RiskOfRain2.Content.Items.Accessories.Boss
{
    //Increases maximum health by 10% (+10% per stack).
    public class Pearl : Accessorisk
    {
        public override void ApplyEffect(TempInv player)
        {
            float multiplier = 1f + 0.10f * stack;
            player.Player.statLifeMax2 = (int)(player.Player.statLifeMax2 * multiplier);
        }
    }
}