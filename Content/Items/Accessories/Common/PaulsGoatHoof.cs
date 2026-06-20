using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Increases movement speed by 14% (+14% per stack).
    public class PaulsGoatHoof : Accessorisk
    {
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv inv)
        {
            Player player = inv.Player;
            float modifier = 1f + (0.14f * stack);
            player.moveSpeed *= modifier;
        }
    }
}