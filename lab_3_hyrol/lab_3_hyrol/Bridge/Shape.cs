using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Bridge
{
    public abstract class Shape
    {
        protected Renderer renderer;

        protected Shape(Renderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
}
