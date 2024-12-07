using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slotMachine.Models
{
    public class AnimalsTheme : Theme
    {
        public override Image[] Symbols => new Image[] { Properties.Resources.animal1, Properties.Resources.animal2, Properties.Resources.animal3, Properties.Resources.animal4, Properties.Resources.animal5, Properties.Resources.animal6 };
        public override Font ReelFont => new Font("Segoe UI", 30, FontStyle.Italic);
        public override Color ReelColor => Color.Brown;
    }
}
