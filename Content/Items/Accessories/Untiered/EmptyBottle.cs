using RiskOfRain2.Content.Systems;
namespace RiskOfRain2.Content.Items.Accessories.Untiered
{
    //Does nothing
    public class EmptyBottle : Accessorisk
    {
        public override string Texture => "Terraria/Images/Item_189";
        public override void SetDefaults()
        {
            rarity = Rarity.Untiered;
        }
        public override void ApplyEffect(TempInv player){}
    }
}