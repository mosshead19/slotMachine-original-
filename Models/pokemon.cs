using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slotMachine.Models
{
    public  class pokemon:Theme
    {
        public override Image[] Symbols => new Image[] { Properties.Resources.pokemon1, Properties.Resources.pokemon2, Properties.Resources.pokemon3, Properties.Resources.pokemon4, Properties.Resources.pokemon5, Properties.Resources.pokemon6 };
        public override Font ReelFont => new Font("Segoe UI", 30, FontStyle.Italic);
        public override Color ReelColor => Color.Brown;
    }
}
