using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ModLoader;
using Terraria.ID;
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
    public class GoldMoney : ModSystem
    {
        public override void PostDrawInterface(SpriteBatch spriteBatch)
        {
            TempInv player = Main.LocalPlayer.GetModPlayer<TempInv>();

            string moneyText = $"{player.gold}";

            Terraria.Utils.DrawBorderStringFourWay(
                spriteBatch,
                FontAssets.MouseText.Value,
                moneyText,
                20f,
                Main.screenHeight * 0.95f,
                Color.Yellow,
                Color.Black,
                Vector2.Zero
            );
        }
    }
}