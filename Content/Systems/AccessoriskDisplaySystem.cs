using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RiskOfRain2.Content.Items.Accessories;
using Terraria;
using Terraria.GameContent;
using Terraria.UI;
using Terraria.ModLoader;
using Terraria.Chat;
using Terraria.UI.Chat;
//TODO remove and redo cleanly 
namespace RiskOfRain2.Content.Systems
{
    public class AccessoriskDisplaySystem : ModSystem
    {
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int index = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (index == -1)
            {
                return;
            }

            layers.Insert(index, new LegacyGameInterfaceLayer(
                "RiskOfRain2: Accessorisk Display",
                delegate
                {
                    DrawAccessoriskDisplay(Main.spriteBatch);
                    return true;
                },
                InterfaceScaleType.UI)
            );
        }

        private static void DrawAccessoriskDisplay(SpriteBatch spriteBatch)
        {
            if (Main.gamePaused || !Main.hasFocus || Main.dedServ)
            {
                return;
            }

            Player player = Main.LocalPlayer;
            if (player == null || !player.active)
            {
                return;
            }

            TempInv tempInv = player.GetModPlayer<TempInv>();
            if (tempInv == null || tempInv.inv == null || tempInv.inv.Count == 0)
            {
                return;
            }

            List<string> lines = new List<string>
            {
                "Accessorisk"
            };

            foreach (KeyValuePair<string, Accessorisk> pair in tempInv.inv)
            {
                lines.Add($"{pair.Key} x{pair.Value.stack}");
            }

            float lineHeight = FontAssets.MouseText.Value.MeasureString("M").Y;
            float maxWidth = 0f;
            foreach (string line in lines)
            {
                maxWidth = MathHelper.Max(maxWidth, FontAssets.MouseText.Value.MeasureString(line).X);
            }

            Vector2 position = new Vector2(14f, 14f);
            Rectangle background = new Rectangle(
                (int)position.X - 6,
                (int)position.Y - 6,
                (int)(maxWidth + 12f),
                (int)(lineHeight * lines.Count + 12f));

            spriteBatch.Draw(TextureAssets.MagicPixel.Value, background, Color.Black * 0.65f);

            for (int i = 0; i < lines.Count; i++)
            {
                Vector2 linePosition = position + new Vector2(0f, i * lineHeight);
                ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, lines[i], linePosition, Color.White, 0f, Vector2.Zero, Vector2.One * 0.85f);
            }
        }
    }
}
