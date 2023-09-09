using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace BetterMaterialTooltip
{
    public class MaterialTooltipRevamp : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            TooltipLine line = tooltips.FirstOrDefault(x => x.Mod == "Terraria" && x.Name == "Material");

            if (line != null)
            {
                var textColor = (ModContent.GetInstance<TooltipColorConfig>().TextColor * (Main.mouseTextColor / 255f)).Hex3();

                // Use the version with the Item sprite if the bool is true; Only load the sprite if true too.
                if (ModContent.GetInstance<TooltipColorConfig>().UseItem)
                {
                    var itemText = ModContent.GetInstance<TooltipColorConfig>().TooltipItem.Type;
                    line.Text = Language.GetTextValue(Mod.GetLocalizationKey("CommonItemTooltip.MaterialPlus"), itemText, textColor);
                    return;
                }

                // Use the version without the item sprite if the config bool is false
                line.Text = Language.GetTextValue(Mod.GetLocalizationKey("CommonItemTooltip.MaterialColorOnly"), textColor);

            }
        }
    }
}
