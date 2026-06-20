using System.Security;
using RiskOfRain2.Content.Systems;
using Steamworks;
using Terraria;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories
{
    public abstract class Accessorisk : ModItem
    {
        //TODO destroy item on pickup and add to the player TempInv
        public int stack = 1;
        public int cooldown = 0;
        public string name => GetType().Name;
        public override bool OnPickup(Player player)
        {
            Main.NewText("PickedUp");
            TempInv inv = player.GetModPlayer<TempInv>();
            inv.AddAccessorisk(this);
            Main.NewText(inv.inv[name]);
            return false;
        }
        public abstract void ApplyEffect(TempInv player);
    }
}