using Humanizer;
using RiskOfRain2.Content.Items.Accessories.Untiered;
using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories.Common
{
    public class PowerElixir : Accessorisk
    {
        public override string Texture => "Terraria/Images/Item_188";
        public override void SetDefaults()
        {
            rarity=Rarity.White;
        }
        public override void ApplyEffect(TempInv player)
        {
            
            if (player.Player.statLife < 0.25 * player.Player.statLifeMax2)
            {
                player.RemoveAccessorisk(this);
                player.Player.statLife+=(int)(player.Player.statLifeMax2*0.75f);
            }
        }
    }
}