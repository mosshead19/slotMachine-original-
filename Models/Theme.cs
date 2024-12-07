using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slotMachine.Models
{
    public abstract class Theme
    {
        public abstract Image[] Symbols { get; }
        public abstract Font ReelFont { get; }
        public abstract Color ReelColor { get; }
    }


}
