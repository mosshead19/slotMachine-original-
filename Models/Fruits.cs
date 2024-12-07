using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slotMachine.Models
{
    public class FruitsTheme : Theme
    {
        public override Image[] Symbols => new Image[] {Properties.Resources.fruit1, Properties.Resources.fruit6 , Properties.Resources.fruit2 , Properties.Resources.fruit3 , Properties.Resources.fruit4 , Properties.Resources.fruit5 };
        public override Font ReelFont => new Font("Segoe UI Emoji", 30, FontStyle.Bold);
        public override Color ReelColor => Color.Black;
    }
}
