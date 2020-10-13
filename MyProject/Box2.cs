using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Box2 : Cuboid
    {
        public Box2(int l, int w, int h) : base(l, w, h)
        {

            this.length = 45;
            this.width = 35;
            this.height = 16;
        }
    }
}
