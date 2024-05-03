using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Bridge
{
    public class Circle : Shape
    {
        public Circle(Renderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.RenderCircle();
        }
    }
}
