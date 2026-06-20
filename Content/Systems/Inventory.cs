using System.Collections.Generic;
using System.Data;
using RiskOfRain2.Content.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Systems
{
    public class TempInv : ModPlayer
    {
        public Dictionary<string,Accesorisk> inv = new Dictionary<string, Accesorisk>();
        public int gold = 0;
        public bool isEventOnGoing => Main.bloodMoon || Main.eclipse || Main.snowMoon || Main.pumpkinMoon;
        public void AddAccessorisk(Accesorisk access)
        {
            if(inv.ContainsKey(access.name)) inv[access.name].stack++;
            else inv.Add(access.name,access);
        }

        public override void PostUpdateEquips()
        {
            foreach(var acce in inv.Values)
            {
                acce.ApplyEffect(this);
            }
        }
        
        public override void PostUpdate()
        {
            if (!isEventOnGoing)
            {
                inv = new Dictionary<string, Accesorisk>();
                gold = 0;
            }
            base.PostUpdate();
        }
    }
}