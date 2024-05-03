using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Bridge
{
    public abstract class Renderer
    {
        public abstract void RenderCircle();
        public abstract void RenderSquare();
        public abstract void RenderTriangle();
    }
}
