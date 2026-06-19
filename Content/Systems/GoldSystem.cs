using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Systems
{
    public class GoldSystem : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {
            if (!NPCID.Sets.Zombies[npc.type]) return;
            if (!npc.AnyInteractions()) return;

            Player player = Main.player[npc.lastInteraction];
            TempInv inv = player.GetModPlayer<TempInv>();
            inv.gold+=100;
            Main.NewText("You killed a zombie!", 50, 255, 50);
            base.OnKill(npc);//TODO
        }
    }
}