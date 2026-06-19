using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace RiskOfRain2.Content.Config
{
    public class BossConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Header("BossAIAttackFP")]
        [DefaultValue(0)]
        [Range(0, 4)]
        public int ForcedAttackHandFP;
        [Header("BossAIAttackSP")]
        [DefaultValue(0)]
        [Range(0, 5)]
        public int ForcedAttackHandSP;

        [Header("BossAIStartPhase")]
        [DefaultValue(0)]
        [Range(0, 2)]
        public int forcedPhaseHand;


        [Header("MithrixAISettings")]
        [DefaultValue(0)]
        [Range(0, 2)] //0 = Random 1 = Dash 2 = Slam
        public int ForcedAttackMithrix;
        [Header("MithrixAIStartPhase")]
        [DefaultValue(0)]
        [Range(0, 2)]
        public int forcedPhaseMithrix;
        [Header("projspeed")]
        [Range(0f, 15f)]
        [Increment(0.25f)]
        [DefaultValue(5f)] 
        public float projspeed;
        
        
        [Header("hue")]
        [Range(0f, 1f)] 
        [Increment(0.05f)] 
        [DefaultValue(0f)]
        public float hue;


    }
}