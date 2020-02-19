using System.Drawing;
using System.Windows.Forms;

namespace HomeWork4.Forms.ProfessionalColorTables
{

    internal sealed class MainMenuColorTable : ProfessionalColorTable
    {

        public override Color MenuBorder => Color.Black;

        public override Color MenuItemSelectedGradientBegin => Color.LightGray;

        public override Color MenuItemSelectedGradientEnd => Color.LightGray;

        public override Color MenuItemPressedGradientBegin => Color.Gray;

        public override Color MenuItemPressedGradientMiddle => Color.Gray;

        public override Color MenuItemPressedGradientEnd => Color.Gray;

        public override Color MenuItemBorder => Color.Black;

        public override Color ToolStripBorder => Color.Black;

        public override Color MenuItemSelected => Color.LightGray;

        public override Color MenuStripGradientBegin => Color.LightGray;

        public override Color MenuStripGradientEnd => SystemColors.Menu;

    }

}
