using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Items.Accessories.Boss
{
    /*Increases ALL stats by 10% (+10% per stack).*/
    public class IrradiantPearl : Accesorisk
    {
        public override void ApplyEffect(TempInv inv)
        {
            Player player = inv.Player;
            float modifier = 1f + (0.10f * stack);
            player.GetDamage(DamageClass.Generic) *= modifier;
            int critBonus = 10 * stack;
            player.GetCritChance(DamageClass.Generic) += critBonus;
            player.statDefense += 10 * stack;
            player.statLifeMax2 = (int)(player.statLifeMax2 * modifier);
            player.statManaMax2 = (int)(player.statManaMax2 * modifier);
            player.moveSpeed *= modifier;
            player.pickSpeed *= 1f - 0.10f * stack; 
            player.tileSpeed *= modifier;
        }
    }
}