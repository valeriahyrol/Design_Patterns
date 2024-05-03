﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_hyrol.Bridge
{
    public class Square : Shape
    {
        public Square(Renderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.RenderSquare();
        }
    }
}
