using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace CraftManager
{
    public class CMSettings : SettingsBase
    {
        public CMSettings()
        {
            Enable = false;

            quality = false;
            scrap = new RangeNode<int>(0, 0, 5000);
            stone = new RangeNode<int>(0, 0, 5000);
            bauble = new RangeNode<int>(0, 0, 5000);

            AdvanceCrafting = false;
            Trans = new RangeNode<int>(0, 0, 5000);
            Alt = new RangeNode<int>(0, 0, 5000);
            Aug = new RangeNode<int>(0, 0, 5000);
            Regal = new RangeNode<int>(0, 0, 5000);
            AScouring = new RangeNode<int>(0, 0, 5000);

            RareCrafting = false;
            Alch = new RangeNode<int>(0, 0, 5000);
            Chaos = new RangeNode<int>(0, 0, 5000);
            RScouring = new RangeNode<int>(0, 0, 5000);

            ChanceCrafting = false;
            Chance = new RangeNode<int>(0, 0, 5000);
            CScouring = new RangeNode<int>(0, 0, 5000);

            SocketCrafting = false;

            IncSocket = false;
            Jewel = new RangeNode<int>(0, 0, 5000);
            minSocket = new RangeNode<int>(0, 0, 6);

            LinkSocket = false;
            Fuse = new RangeNode<int>(0, 0, 5000);
            minLinks = new RangeNode<int>(0, 0, 6);

            ColorSocket = false;
            Chrom = new RangeNode<int>(0, 0, 5000);
            redSocket = new RangeNode<int>(0, 0, 6);
            blueSocket = new RangeNode<int>(0, 0, 6);
            greenSocket = new RangeNode<int>(0, 0, 6);

            alterModCrafting = false;
            Blessed = new RangeNode<int>(0, 0, 5000);
            Divine = new RangeNode<int>(0, 0, 5000);
        }
        #region Improve Quality
    [Menu("Improve Quality", 1)]
        public ToggleNode quality { get; set; }
        [Menu("Armourer's Scrap", 2, 1)]
        public RangeNode<int> scrap { get; set; }
        [Menu("Blacksmith's Whetstone", 3, 1)]
        public RangeNode<int> stone { get; set; }
        [Menu("Glassblower's Bauble", 4, 1)]
        public RangeNode<int> bauble { get; set; }
        #endregion

        #region Advance Crafting
        [Menu("Advance Crafting", 10)]
        public ToggleNode AdvanceCrafting { get; set; }
        [Menu("Orb of Transmutation", 11, 10)]
        public RangeNode<int> Trans { get; set; }
        [Menu("Orb of Alteration", 12, 10)]
        public RangeNode<int> Alt { get; set; }
        [Menu("Orb of Augmentation", 13, 10)]
        public RangeNode<int> Aug { get; set; }
        [Menu("Regal Orb", 14, 10)]
        public RangeNode<int> Regal { get; set; }
        [Menu("Orb of Scouring", 15, 10)]
        public RangeNode<int> AScouring { get; set; }
        #endregion

        #region Rare Crafting
        [Menu("Rare Crafting", 20)]
        public ToggleNode RareCrafting { get; set; }
        [Menu("Orb of Alchemy", 21, 20)]
        public RangeNode<int> Alch { get; set; }
        [Menu("Chaos Orb", 22, 20)]
        public RangeNode<int> Chaos { get; set; }
        [Menu("Orb of Scouring", 23, 20)]
        public RangeNode<int> RScouring { get; set; }
        #endregion

        #region Chance Crafting
        [Menu("Chance Crafting", 30)]
        public ToggleNode ChanceCrafting { get; set; }
        [Menu("Orb of Chance", 31, 30)]
        public RangeNode<int> Chance { get; set; }
        [Menu("Orb of Scouring", 32, 30)]
        public RangeNode<int> CScouring { get; set; }
        #endregion

        #region Socket Crafting
        [Menu("Socket Crafting", 40)]
        public ToggleNode SocketCrafting { get; set; }

        [Menu("Increase Sockets", 41, 40)]
        public ToggleNode IncSocket { get; set; }
        [Menu("Jeweller's Orb", 42, 41)]
        public RangeNode<int> Jewel { get; set; }
        [Menu("Minimum Socket", 43, 41)]
        public RangeNode<int> minSocket { get; set; }

        [Menu("Link Sockets", 44, 40)]
        public ToggleNode LinkSocket { get; set; }
        [Menu("Orb of Fusing", 45, 44)]
        public RangeNode<int> Fuse { get; set; }
        [Menu("Minimum Links", 46, 44)]
        public RangeNode<int> minLinks { get; set; }

        [Menu("Color Sockets", 47, 40)]
        public ToggleNode ColorSocket { get; set; }
        [Menu("Chromatic Orb", 48, 47)]
        public RangeNode<int> Chrom { get; set; }
        [Menu("Red Color", 49, 47)]
        public RangeNode<int> redSocket { get; set; }
        [Menu("Blue Color", 50, 47)]
        public RangeNode<int> blueSocket { get; set; }
        [Menu("Green Color", 51, 47)]
        public RangeNode<int> greenSocket { get; set; }
        #endregion

        #region Alter Mod Value
        [Menu("Alter Mod Value", 60)]
        public ToggleNode alterModCrafting { get; set; }
        [Menu("Blessed Orb", 61, 60)]
        public RangeNode<int> Blessed { get; set; }
        [Menu("Divine Orb", 62, 60)]
        public RangeNode<int> Divine { get; set; }
        #endregion

    }
}
