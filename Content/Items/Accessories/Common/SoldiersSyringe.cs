using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories.Common
{
    //Increases attack speed by 15% (+15% per stack).
    public class SoldiersSyringe : Accessorisk
    {
        public override string Texture => "Terraria/Images/Item_3009";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            player.Player.GetAttackSpeed(DamageClass.Generic) *= 1f + 0.15f * stack;
        }
    }
}