// TODO: Implement item logic
using RiskOfRain2.Content.Systems;
using Terraria;

namespace RiskOfRain2.Content.Items.Accessories.Boss
{
    //Increments maximum health by 10% stack
    public class Pearl : Accesorisk
    {
        public override void ApplyEffect(TempInv player)
        {
            player.Player.statLifeMax2+=(int)(player.Player.statLifeMax2*0.10f);
        }
    }
}