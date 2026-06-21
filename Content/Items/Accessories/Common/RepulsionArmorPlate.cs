using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
//TODO
namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class RepulsionArmorPlate : Accessorisk
    {
        public override string Texture => "Terraria/Images/Item_938";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            
        }
    }
}