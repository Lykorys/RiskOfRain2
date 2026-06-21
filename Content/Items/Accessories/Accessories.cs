using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Items.Accessories
{
    public enum Rarity
    {
        White,
        Green,
        Red,
        Yellow,
        Blue,
        Purple,
        Orange,
        Untiered
    }
    public abstract class Accessorisk : ModItem
    {
        public Rarity rarity;
        public int stack = 1;
        public int innerStack;
        public int timeKeeper = 0;
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
    public abstract class AccessoriskCombat : Accessorisk
    {
        public abstract void OnKillEffect(TempInv player,NPC npc);
        public abstract void OnHitEffect(TempInv player,NPC npc);
    }
    public abstract class Scrap : Accessorisk{}
}