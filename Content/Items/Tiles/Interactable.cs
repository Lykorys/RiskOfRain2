using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Security.Permissions;
using Terraria.GameContent.ObjectInteractions;
using System.CodeDom.Compiler;
using RiskOfRain2.Content.Systems;
using System;

namespace RiskOfRain2.Content.Tiles
{
    public abstract class Interactable : ModTile
    {   
        public int price;
        public bool isDone;
        public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings) 
        {
            return true;
        }
        public override void MouseOver(int i, int j) {
            Player player = Main.LocalPlayer;
            player.noThrow = 2; 
        }
        public static bool generateItem(float nothingChance,float commonChance,float uncommonChance,float legendaryChance,float equipmentChance)
        {
            float rand = Main.rand.Next(1,101);
            float currentInterval = 0f;
            currentInterval += nothingChance;
            if (rand <= currentInterval){
                Main.NewText("Nothing");
                return false; 
            }
            currentInterval += commonChance;
            if (rand <= currentInterval) {
                Main.NewText("Common");
                return true;
            }
            currentInterval += uncommonChance;
            if (rand <= currentInterval) {
                Main.NewText("Uncommon");
                return true;
            }
            currentInterval += legendaryChance;
            if (rand <= currentInterval) {
                Main.NewText("Legendary");
                return true;
            }
            currentInterval += equipmentChance;
            if (rand <= currentInterval) {
                Main.NewText("Equipment");
                return true;
            }
            return false;
        }
    }
}