using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using RiskOfRain2.Content.Items.Accessories;
using Terraria;
using Terraria.ModLoader;
namespace RiskOfRain2.Content.Systems
{
    public class TempInv : ModPlayer
    {
        public Dictionary<string,Accessorisk> inv = new Dictionary<string, Accessorisk>();
        public int gold = 0;
        public float bossDamageMultiplier = 1f;
        public int inCombatTimer = 0;
        public bool isInCombat => inCombatTimer==0;
        public bool isEventOnGoing => Main.bloodMoon || Main.eclipse || Main.snowMoon || Main.pumpkinMoon;
        public void AddAccessorisk(Accessorisk access)
        {
            if(inv.ContainsKey(access.name)) inv[access.name].stack++;
            else inv.Add(access.name,access);
        }
        public void RemoveAccessorisk(Accessorisk access)
        {
            if (inv.ContainsKey(access.name))
            {
                if(inv[access.name].stack==1) inv.Remove(access.name);
                else inv[access.name].stack--;
            }
        }
        public override void ResetEffects()
        {
            bossDamageMultiplier = 1f;
        }
        public override void PostUpdateEquips()
        {
            if(inCombatTimer>0) inCombatTimer--;
            foreach(var acce in inv.Values)
            {
                acce.ApplyEffect(this);
            }
        }
        
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if(target != null && target.friendly || target.dontTakeDamage || target.immune[Player.whoAmI] > 0) inCombatTimer=300;
            if (target != null && target.boss)
            {
                modifiers.FinalDamage *= bossDamageMultiplier;
            }
        }
        public override void PostUpdate()
        {
            if (!isEventOnGoing)
            {
                inv = new Dictionary<string, Accessorisk>();
                gold = 0;
            }
            base.PostUpdate();
        }
    }
}