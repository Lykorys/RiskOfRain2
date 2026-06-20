using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
// TODO: Implement item logic
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class WhiteScrap : Scrap
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player){}
    }
}