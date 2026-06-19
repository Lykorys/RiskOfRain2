using System.Security;
using RiskOfRain2.Content.Systems;
using Steamworks;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories
{
    public abstract class Accesorisk : ModItem
    {
        //TODO destroy item on pickup and add to the player TempInv
        public int stack = 0;
        public string name => GetType().Name;
        public override bool OnPickup(Player player)
        {
            TempInv inv = Main.LocalPlayer.GetModPlayer<TempInv>();
            inv.AddAccessorisk(this);
            return false;
        }
        public abstract void ApplyEffect(TempInv player);
    }
}