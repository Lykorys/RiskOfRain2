using RiskOfRain2.Content.Systems;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RiskOfRain2.Content.Tiles
{
    public class SmallChest : Interactable
    {
        public override string Texture => "Terraria/Images/Tiles_26"; 

        
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            TileID.Sets.DisableSmartCursor[Type] = true;
            price = 17;
        }
        
        public override bool RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            TempInv modPlayer = player.GetModPlayer<TempInv>();
            if (modPlayer.gold >= price && !isDone)
            {
                modPlayer.gold -= price;
                isDone=true;
                generateItem(0f,79.2f, 19.8f, 1f, 0f);
            }
            return false;
        }
    }

    public class SmallChestItem : ModItem
    {
        public override string Texture => "Terraria/Images/Item_" + ItemID.GoldChest;

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.maxStack = 99;
            
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;

            Item.value = Item.buyPrice(silver: 10);
            Item.rare = ItemRarityID.Green; 

            Item.createTile = ModContent.TileType<SmallChest>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}