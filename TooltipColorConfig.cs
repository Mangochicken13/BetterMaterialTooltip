using Microsoft.Xna.Framework;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace BetterMaterialTooltip
{
    public class TooltipColorConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(true)]
        public bool UseItem;

        [DisallowNull]
        public ItemDefinition TooltipItem = new ItemDefinition(ItemID.WorkBench);

        [DefaultValue(typeof(Color), "237, 191, 64, 255")]
        public Color TextColor;
    }
}
