using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Deal an additional 20% damage (+20% per stack) to bosses.
    public class ArmorPiercingRound : Accessorisk
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            player.bossDamageMultiplier *= 1f + 0.20f * stack;
        }
    }
}