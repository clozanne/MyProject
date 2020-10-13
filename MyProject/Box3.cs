using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Box3 : Cuboid
    {
        public Box3(int l, int w, int h) : base(l, w, h)
        {

            this.length = 61;
            this.width = 46;
            this.height = 45;
        }
    }
}
