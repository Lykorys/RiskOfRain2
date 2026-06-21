using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Increases attack speed by 7.5% (+7.5 per stack) and movement speed by 7% (+7% per stack).
    public class Mocha : Accessorisk
    {
        public override string Texture => "Terraria/Images/Item_5042";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            player.Player.GetAttackSpeed(DamageClass.Generic) *= 1f + 0.075f * stack;
            player.Player.moveSpeed*=1f+0.075f*stack;
        }
    }
}