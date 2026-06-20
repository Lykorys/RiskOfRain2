using System.Security.Cryptography.X509Certificates;
using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class BisonSteak : Accessorisk
    {
        public override void ApplyEffect(TempInv player)
        {
            player.Player.statLifeMax2+=25*stack;
        }
    }
}